using Microsoft.Win32;
using System;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using TranslatorBusinessLayer;
using TranslatorBusinessLayerCL;
using static System.Net.Mime.MediaTypeNames;

namespace MyTranslatorProject
{
    
    public partial class MyTranslator : Form
    {
        //Registry hot key code -------------------------
        [DllImport("user32.dll")]
        private static extern bool RegisterHotKey(IntPtr hWnd, int id, int fsModifiers, Keys vk);

        [DllImport("user32.dll")]
        private static extern bool UnregisterHotKey(IntPtr hWnd, int id);

        private const int MOD_ALT = 0x1;
        private const int MOD_CONTROL = 0x2;
        private const int MOD_SHIFT = 0x4;
        //-------------------------------------------------


        DataTable dt_SourceLanguages = new DataTable();
        DataTable dt_TargetLanguages = new DataTable();

        bool isSourceLangSetted = false, isTargetLangSetted = false, isLangsSetted = false;

        string SourceLanguageName = "", TargetLanguageName = "";

        string apiKey = "";

        frmTextBox translateDisplayer = new frmTextBox();


        [STAThread]
        async Task TranslateHandler()
        {
            clsSystemClipboard.SimulateCopy();
            await Task.Delay(150);

            if (Clipboard.ContainsText())
            {
                string textBeforeTranslate = Clipboard.GetText();
                SetAndShowBeingTranslatedNotify(textBeforeTranslate);

                string prompt = clsApiConnector.BuildPrompt(SourceLanguageName, TargetLanguageName, textBeforeTranslate);
                string translatedText = await clsApiConnector.ChatWithCohere(apiKey, prompt);

                Clipboard.Clear();
                Clipboard.SetText(translatedText, TextDataFormat.UnicodeText);
                System.Windows.Forms.Application.DoEvents();
                await Task.Delay(150);

                clsSystemClipboard.SimulatePaste();

                bool isOpen = System.Windows.Forms.Application.OpenForms.OfType<frmTextBox>().Any();
                if (!isOpen)
                {
                    translateDisplayer = new frmTextBox();
                    translateDisplayer.Show();
                }

                translateDisplayer.SetText(translatedText);
                await Task.Delay(150);
                SetAndShowTextTranslatedNotify(translatedText);
                AddNewTranslation(textBeforeTranslate, translatedText);

                Clipboard.Clear();
            }
        }

        void SetAutoRun()
        {
            if (File.Exists("AutoRun"))
            {
                string autoRunEnabled = File.ReadAllText("AutoRun");

                if (autoRunEnabled == "1")
                {
                    clsAutoRunSettings.EnableStartup("My Translator");
                }
                else if (autoRunEnabled == "0")
                {
                    clsAutoRunSettings.DisableStartup("My Translator");
                }
            }
            else
            {
                File.WriteAllText("AutoRun", "1");
                clsAutoRunSettings.EnableStartup("My Translator");
            }
        }

        void SetAndShowBeingTranslatedNotify(string text)
        {
            ntBiengTranslated.Visible = true;
            ntBiengTranslated.Icon = SystemIcons.Application;
            ntBiengTranslated.BalloonTipText = text;
            ntBiengTranslated.ShowBalloonTip(1000);
        }

        void SetAndShowTextTranslatedNotify(string text)
        {
            ntTextTranslated.Visible = true;
            ntTextTranslated.Icon = SystemIcons.Application;
            ntTextTranslated.BalloonTipText = text;
            ntTextTranslated.ShowBalloonTip(1000);
        }

        public void SetShortcut(int fsModifires = 0, Keys key = Keys.None)
        {
            if (fsModifires != 0 && key != Keys.None)
            {
                RegisterHotKey(this.Handle, 1, fsModifires, key);
                return;
            }

            if (File.Exists("Shortcut"))
            {
                string shortcut = File.ReadAllText("Shortcut");
                string[] shortcutButtons = shortcut.Split('|');

                int firstKey = clsSettings.ExtractMOD(shortcutButtons[0]);
                int secondKey = clsSettings.ExtractMOD(shortcutButtons[1]);

                fsModifires = (firstKey | secondKey);

                key = clsSettings.ExtractKey(shortcutButtons[2]);

                RegisterHotKey(this.Handle, 1, fsModifires, key);
            }
            else
            {
                RegisterHotKey(this.Handle, 1, MOD_ALT | MOD_SHIFT, Keys.D);
                File.WriteAllText("Shortcut", "MOD_ALT|MOD_SHIFT|D");
            }
        }

        void AddNewTranslation(string From, string To)
        {
            clsTranslationsHistoryBusiness newTranslation = new clsTranslationsHistoryBusiness();

            newTranslation.TranslateFrom = From;
            newTranslation.TranslateTo = To;
            newTranslation.TranslationDate = DateTime.Now;

            newTranslation.AddNewTransation();
        }

        void DisableApiKeyReader()
        {
            tbxApiKey.Enabled = false;
            btnApiKeySave.Enabled = false;
            btnApiKeyEdit.Enabled = true;
        }

        void EnableApiKeyReader()
        {
            tbxApiKey.Enabled = true;
            btnApiKeySave.Enabled = true;
            btnApiKeyEdit.Enabled = false;
        }

        void SaveApiKey()
        {
            if (tbxApiKey.Text == "")
            {
                MessageBox.Show("Cannot save now because the text box is empty. Please enter the API Key first.", "Save Not Allowed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            apiKey = tbxApiKey.Text;
            DisableApiKeyReader();
            SaveApiKeyToFile();
        }

        void SaveApiKeyToFile()
        {
            File.WriteAllText("API Key", apiKey);
        }

        void LoadApiKeyFromFile()
        {
            try
            {
                apiKey = File.ReadAllText("API Key");
                tbxApiKey.Text = apiKey;
                DisableApiKeyReader();
            }
            catch { return; }
        }

        void SaveLanguagesToFile()
        {
            string fileText = $"{SourceLanguageName}|{TargetLanguageName}";

            File.WriteAllText("LastUsedLanguages", fileText);
        }

        void LoadLanguagesFromFile()
        {
            string LangsSeprated = "";

            try { LangsSeprated = File.ReadAllText("LastUsedLanguages"); }
            catch { return; }

            string[] Langs = LangsSeprated.Split('|');

            if (Langs.Length == 2)
            {
                SourceLanguageName = Langs[0];
                TargetLanguageName = Langs[1];
            }
        }

        void SetLanguages()
        {
            LoadLanguagesFromFile();

            if (SourceLanguageName == "" || TargetLanguageName == "")
            {
                SetSelectedRowFor_dgv(dgvSourceLanguage, "Arabic");
                SourceLanguageName = "Arabic"; 

                SetSelectedRowFor_dgv(dgvTargetLanguage, "English");
                TargetLanguageName = "English";

                return;
            }

            isSourceLangSetted = true;
            if (!SetSelectedRowFor_dgv(dgvSourceLanguage, SourceLanguageName))
            { 
                SetSelectedRowFor_dgv(dgvSourceLanguage, "Arabic");
                SourceLanguageName = "Arabic";
                isSourceLangSetted = false;
            }

            isTargetLangSetted = true;
            if (!SetSelectedRowFor_dgv(dgvTargetLanguage, TargetLanguageName))
            {
                SetSelectedRowFor_dgv(dgvTargetLanguage, "English");
                TargetLanguageName = "English";
                isTargetLangSetted = false;
            }

            isLangsSetted = (isSourceLangSetted && isTargetLangSetted);
        }

        void LanguagesSettingsFor_dgv(DataGridView dgv, DataTable dataSource)
        {
            dgv.DataSource = dataSource;
            dgv.Columns["LangID"].Visible = false;
            dgv.ColumnHeadersVisible = false;
            dgv.RowHeadersVisible = false;
            dgv.AllowUserToAddRows = false;
            dgv.AllowUserToResizeRows = false;
            dgv.AllowUserToDeleteRows = false;
            dgv.AllowUserToResizeColumns = false;
        }

        bool SetSelectedRowFor_dgv(DataGridView dgv, string LangName)
        {
            dgv.ClearSelection();

            foreach (DataGridViewRow row in dgv.Rows)
            {
                if (row.Cells[0].Value != null && row.Cells[0].Value.ToString() == LangName)
                {
                    row.Selected = true;
                    dgv.CurrentCell = row.Cells[0];
                    dgv.FirstDisplayedScrollingRowIndex = dgv.CurrentRow.Index;
                    return true;
                }
            }

            return false;
        }

        void FilterApplied(TextBox sender, DataGridView dgv, DataTable dataSource)
        {
            if (string.IsNullOrEmpty(sender.Text))
            {
                dataSource = clsLanguageBusiness.GetAllLanguages();
                dgv.DataSource = dataSource;
                return;
            }

            DataView dataView = dataSource.DefaultView;
            dataView.RowFilter = $"LangName LIKE '{sender.Text}%' OR LangName LIKE '%{sender.Text}' OR LangName LIKE '%{sender.Text}%'";
            dgv.DataSource = dataView;
        }

        void DisableSourceLanguageSelector()
        {
            dgvSourceLanguage.Enabled = false;
            btnSourceLangEdit.Enabled = true;
            btnSourceLangSave.Enabled = false;
            tbxSourceLanguage.Enabled = false;
            isSourceLangSetted = true;
        }
        void EnableSourceLanguageSelector()
        {
            dgvSourceLanguage.Enabled = true;
            btnSourceLangEdit.Enabled = false;
            btnSourceLangSave.Enabled = true;
            tbxSourceLanguage.Enabled = true;
            isSourceLangSetted = false;
        }
        void DisableTargetLanguageSelector()
        {
            dgvTargetLanguage.Enabled = false;
            btnTargetLangEdit.Enabled = true;
            btnTargetLangSave.Enabled = false;
            tbxTargetLanguage.Enabled = false;
            isTargetLangSetted = true;
        }
        void EnableTargetLanguageSelector()
        {
            dgvTargetLanguage.Enabled = true;
            btnTargetLangEdit.Enabled = false;
            btnTargetLangSave.Enabled = true;
            tbxTargetLanguage.Enabled = true;
            isTargetLangSetted = false;
        }

        void SaveSelectedLanguage(DataGridView dgv, ref string var)
        {
            var = dgv.CurrentRow.Cells[0].Value.ToString();

            if (dgv.Name == "dgvSourceLanguage")
            {
                DisableSourceLanguageSelector();
            }
            else
            {
                DisableTargetLanguageSelector();
            }

            isLangsSetted = (isSourceLangSetted && isTargetLangSetted);
            if (isLangsSetted)
                SaveLanguagesToFile();
        }

        void MoveTheDB()
        {
            string Path_mdf = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData), "MyTranslator", "TranslatorDB.mdf");
            string Path_log = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData), "MyTranslator", "TranslatorDB_log.ldf");

            if (File.Exists(Path_mdf) && File.Exists(Path_log)) return;

            string dir = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData), "MyTranslator");

            if (File.Exists(@"DB\TranslatorDB.mdf") && File.Exists(@"DB\TranslatorDB_log.ldf"))
            {
                Directory.CreateDirectory(dir);
                File.Move(@"DB\TranslatorDB.mdf", Path_mdf);
                File.Move(@"DB\TranslatorDB_log.ldf", Path_log);
                Directory.Delete(@"DB");
            }
            else
            {
                MessageBox.Show(@"The database cannot be found. Make sure the database files exist in \Program Folder\DB.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.Close();
            }
        }
        public MyTranslator()
        {
            InitializeComponent();

            MoveTheDB();
            clsSettings.MainForm = this;
            SetAutoRun();
            dt_SourceLanguages = clsLanguageBusiness.GetAllLanguages();
            dt_TargetLanguages = clsLanguageBusiness.GetAllLanguages();
        }

        private void MyTranslator_Load(object sender, EventArgs e)
        {
            LanguagesSettingsFor_dgv(dgvSourceLanguage, dt_SourceLanguages);
            LanguagesSettingsFor_dgv(dgvTargetLanguage, dt_TargetLanguages);

            SetLanguages();

            if (isLangsSetted)
            {
                DisableSourceLanguageSelector();
                DisableTargetLanguageSelector();
            }

            LoadApiKeyFromFile();
        }

        private void tbxSourceLanguage_Enter(object sender, EventArgs e)
        {
            if (((TextBox)sender).Text == "Search...")
                ((TextBox)sender).Text = "";
        }

        private void tbxSourceLanguage_Leave(object sender, EventArgs e)
        {
            if (((TextBox)sender).Text == "")
                ((TextBox)sender).Text = "Search...";
        }

        private void tbxSourceLanguage_TextChanged(object sender, EventArgs e)
        {
            if (((TextBox)sender).Text != "" && ((TextBox)sender).Text != "Search...")
                FilterApplied(((TextBox)sender), dgvSourceLanguage, dt_SourceLanguages);
        }

        private void tbxTargetLanguage_TextChanged(object sender, EventArgs e)
        {
            if (((TextBox)sender).Text != "" && ((TextBox)sender).Text != "Search...")
                FilterApplied(((TextBox)sender), dgvTargetLanguage, dt_TargetLanguages);
        }

        private void btnTargetLangSave_Click(object sender, EventArgs e)
        {
            SaveSelectedLanguage(dgvTargetLanguage, ref TargetLanguageName);
        }

        private void btnSourceLangEdit_Click(object sender, EventArgs e)
        {
            EnableSourceLanguageSelector();
        }

        private void btnTargetLangEdit_Click(object sender, EventArgs e)
        {
            EnableTargetLanguageSelector();
        }

        private void dgvSourceLanguage_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                SaveSelectedLanguage(dgvSourceLanguage, ref SourceLanguageName);
                e.Handled = true;
            }
        }

        private void dgvTargetLanguage_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                SaveSelectedLanguage(dgvTargetLanguage, ref TargetLanguageName);
                e.Handled = true;
            }
        }

        private void btnApiKeySave_Click(object sender, EventArgs e)
        {
            SaveApiKey();
        }

        private void btnApiKeyEdit_Click(object sender, EventArgs e)
        {
            EnableApiKeyReader();
        }

        private void tbxApiKey_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                SaveApiKey();
                e.Handled = true;
            }
        }

        private void btnShowTranslationHistory_Click(object sender, EventArgs e)
        {
            Form translationsHistoryForm = new frmShowTranslationHistory();
            translationsHistoryForm.Show();
        }

        private void btnSourceLangSave_Click(object sender, EventArgs e)
        {
            SaveSelectedLanguage(dgvSourceLanguage, ref SourceLanguageName);
        }

        

        private void tbxSourceLanguage_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Up || e.KeyCode == Keys.Down || e.KeyCode == Keys.Enter)
            {
                dgvSourceLanguage.Focus();
            }
        }

        private void btnHowToUse_MouseHover(object sender, EventArgs e)
        {
            ((Button)sender).BackColor = Color.White;
            ((Button)sender).ForeColor = Color.Black;
        }

        private void btnHowToUse_MouseLeave(object sender, EventArgs e)
        {
            ((Button)sender).BackColor = Color.Black;
            ((Button)sender).ForeColor = Color.White;
        }

        private void btnHowToUse_MouseDown(object sender, MouseEventArgs e)
        {
            ((Button)sender).BackColor = Color.FromArgb(255, 240, 240, 240);
            ((Button)sender).ForeColor = Color.Black;
        }

        private void btnHowToUse_MouseUp(object sender, MouseEventArgs e)
        {
            ((Button)sender).BackColor = Color.White;
            ((Button)sender).ForeColor = Color.Black;
        }

        private void btnHowToUse_Click(object sender, EventArgs e)
        {
            frmHowToUserMyTranslator frmInstructions = new frmHowToUserMyTranslator();
            frmInstructions.Show();
        }

        private void btnSettings_Click(object sender, EventArgs e)
        {
            frmSettings settings = new frmSettings();
            settings.Show();
        }

        private void MyTranslator_Shown(object sender, EventArgs e)
        {
            SetShortcut();
        }

        private void tbxTargetLanguage_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Up || e.KeyCode == Keys.Down || e.KeyCode == Keys.Enter)
            {
                dgvTargetLanguage.Focus();
            }
        }

        protected override void WndProc(ref Message m)
        {
            const int WM_HOTKEY = 0x0312;

            if (m.Msg == WM_HOTKEY && m.WParam.ToInt32() == 1)
            {
                 _ = TranslateHandler();
                return;
            }

            base.WndProc(ref m);
        }

        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            UnregisterHotKey(this.Handle, 1);
            base.OnFormClosing(e);
        }
    }
}
