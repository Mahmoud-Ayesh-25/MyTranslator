using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyTranslatorProject
{
    public partial class frmSettings : Form
    {
        void DisableShortcut()
        {
            cbFrstShortcut.Enabled = false;
            cbScndShortcut.Enabled = false;
            tbxShortcut.Enabled = false;
            btnShortcutEdit.Enabled = true;
            btnShortcutSave.Enabled = false;
        }

        void EnableShortcut()
        {
            cbFrstShortcut.Enabled = true;
            cbScndShortcut.Enabled = true;
            tbxShortcut.Enabled = true;
            btnShortcutEdit.Enabled = false;
            btnShortcutSave.Enabled = true;
        }

        int stMOD_To_Index(string stMOD)
        {
            switch (stMOD)
            {
                case "MOD_ALT":
                    return 0;
                case "MOD_CONTROL":
                    return 1;
                case "MOD_SHIFT":
                    return 2;
                default: return 0;
            }
        }

        string Index_To_stMOD(int index)
        {
            switch (index)
            {
                case 0:
                    return "MOD_ALT";
                case 1:
                    return "MOD_CONTROL";
                case 2:
                    return "MOD_SHIFT";
                default: return "MOD_ALT";
            }
        }

        void SetShortcutControls(string firstShortcutButton, string secondShortcutButton, string key)
        {
            tbxShortcut.Text = key;

            cbFrstShortcut.SelectedIndex = stMOD_To_Index(firstShortcutButton);
            cbScndShortcut.SelectedIndex = stMOD_To_Index(secondShortcutButton);
        }

        void GetShortcut()
        {
            if (!File.Exists("Shortcut"))
            {
                File.WriteAllText("Shortcut", "MOD_CONTROL|MOD_SHIFT|T");
            }

            DisableShortcut();

            string shortcut = File.ReadAllText("Shortcut");

            string[] shortcutButtons = shortcut.Split('|');

            SetShortcutControls(shortcutButtons[0], shortcutButtons[1], shortcutButtons[2]);
        }

        void SaveShortcut()
        {
            string stFirstShortcutButton = Index_To_stMOD(cbFrstShortcut.SelectedIndex);
            string stSecondShortcutButton = Index_To_stMOD(cbScndShortcut.SelectedIndex);
            string stKey = tbxShortcut.Text.ToUpper();

            int firstShortcutButton = clsSettings.ExtractMOD(stFirstShortcutButton);
            int secondShortcutButton = clsSettings.ExtractMOD(stSecondShortcutButton);
            Keys key = clsSettings.ExtractKey(stKey);

            int fsModifires = (firstShortcutButton | secondShortcutButton);

            clsSettings.MainForm.SetShortcut(fsModifires, key);

            File.WriteAllText("Shortcut", $"{stFirstShortcutButton}|{stSecondShortcutButton}|{stKey}");

            DisableShortcut();
        }

        bool IsCBCanSave()
        {
            if (cbFrstShortcut.Text == cbScndShortcut.Text)
                return false;

            return true;
        }

        public frmSettings()
        {
            InitializeComponent();
            GetShortcut();
            chbAutoRun.Checked = clsAutoRunSettings.IsStartupEnabled("My Translator");
        }

        private void btnShortcutSave_Click(object sender, EventArgs e)
        {
            if (IsCBCanSave())
                SaveShortcut();
            else
                MessageBox.Show("Cannot save this shortcut, keys must be different.", "Shortcut Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void btnShortcutEdit_Click(object sender, EventArgs e)
        {
            EnableShortcut();
        }

        private void tbxShortcut_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar))
            {
                if (!((Keys)e.KeyChar == Keys.Back))
                {
                    e.Handled = true;
                }
            }
        }

        private void chbAutoRun_CheckedChanged(object sender, EventArgs e)
        {
            if (chbAutoRun.Checked)
            {
                clsAutoRunSettings.EnableStartup("My Translator");
                File.WriteAllText("AutoRun", "1");
            }
            else if (chbAutoRun.Checked == false)
            {
                clsAutoRunSettings.DisableStartup("My Translator");
                File.WriteAllText("AutoRun", "0");
            }
        }
    }
}
