using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TranslatorBusinessLayerCL;

namespace MyTranslatorProject
{
    public partial class frmShowTranslationHistory : Form
    {
        DataTable translations = new DataTable();

        void SetTranslationsHistory_dgv()
        {
            if (translations.Columns.Count == 0) return;

            dgvTranslationsHistory.RowTemplate.Height = 35;
            dgvTranslationsHistory.DataSource = translations;
            dgvTranslationsHistory.RowHeadersVisible = false;
            dgvTranslationsHistory.Columns["TranslationID"].Visible = false;
            dgvTranslationsHistory.Columns["TranslateFrom"].HeaderText = "From";
            dgvTranslationsHistory.Columns["TranslateTo"].HeaderText = "To";
            dgvTranslationsHistory.Columns["TranslateDate"].HeaderText = "Date";
            dgvTranslationsHistory.Columns["TranslateFrom"].Width = 315;
            dgvTranslationsHistory.Columns["TranslateTo"].Width = 315;
            dgvTranslationsHistory.Columns["TranslateDate"].Width = 118;
        }

        void FilterApplied()
        {
            if (translations.Columns.Count == 0) return;

            switch (cbFilter.SelectedIndex)
            {
                case 0:
                    {
                        dgvTranslationsHistory.DataSource = translations;
                        break;
                    }
                case 1:
                    {
                        DataView dataView = translations.DefaultView;
                        dataView.RowFilter = $"TranslateFrom LIKE '{tbxFilter.Text}%'";
                        dgvTranslationsHistory.DataSource = dataView;
                        break;
                    }
                case 2:
                    {
                        DataView dataView = translations.DefaultView;
                        dataView.RowFilter = $"TranslateTo LIKE '{tbxFilter.Text}%'";
                        dgvTranslationsHistory.DataSource = dataView;
                        break;
                    }
            }
        }

        void ShowTranslationDetails()
        {
            if (dgvTranslationsHistory.Rows.Count > 0)
            {
                DateTime date = DateTime.Parse(dgvTranslationsHistory.CurrentRow.Cells[3].Value.ToString());
                string from = dgvTranslationsHistory.CurrentRow.Cells[1].Value.ToString();
                string to = dgvTranslationsHistory.CurrentRow.Cells[2].Value.ToString();

                frmShowTranslationDetails translationDetails = new frmShowTranslationDetails(from, to, date);
                translationDetails.Show();
            }
        }

        void Refresh()
        {
            translations = clsTranslationsHistoryBusiness.GetAllTranslations();
            dgvTranslationsHistory.DataSource = translations;
            SetTranslationsHistory_dgv();
        }

        void DeleteTranslation()
        {
            if (dgvTranslationsHistory.Rows.Count > 0)
            {
                if (MessageBox.Show("Are you sure you want to delete this translation?", "Delete Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    if (clsTranslationsHistoryBusiness.DeleteTranslation(int.Parse(dgvTranslationsHistory.CurrentRow.Cells["TranslationID"].Value.ToString())))
                    {
                        MessageBox.Show("The translation has been successfully deleted.", "Translation Deleted", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        Refresh();
                    }
                    else
                    {
                        MessageBox.Show("The translation was not deleted due to an error", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    MessageBox.Show("The deletion of the translation has been canceled.", "Deletion canceled", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

        public frmShowTranslationHistory()
        {
            InitializeComponent();
            translations = clsTranslationsHistoryBusiness.GetAllTranslations();
            cbFilter.SelectedIndex = 0;
        }

        private void frmShowTranslationHistory_Load(object sender, EventArgs e)
        {
            SetTranslationsHistory_dgv();
        }

        private void dgvTranslationsHistory_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            ShowTranslationDetails();
        }

        private void btnShowTranslationDetails_Click(object sender, EventArgs e)
        {
            ShowTranslationDetails();
        }

        private void showDetailsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ShowTranslationDetails();
        }

        private void cbFilter_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbFilter.SelectedIndex == 0)
                tbxFilter.Enabled = false;
            else
                tbxFilter.Enabled = true;
        }

        private void tbxFilter_TextChanged(object sender, EventArgs e)
        {
            FilterApplied();
        }

        private void dgvTranslationsHistory_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                ShowTranslationDetails();
                e.Handled = true;
            }
        }

        private void dgvTranslationsHistory_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            lblRecords.Text = $"Records : {dgvTranslationsHistory.Rows.Count.ToString()}";
        }

        private void btnDeleteTranslation_Click(object sender, EventArgs e)
        {
            DeleteTranslation();
        }

        private void deleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DeleteTranslation();
        }

        private void btnClearTranslationHistory_Click(object sender, EventArgs e)
        {
            if (dgvTranslationsHistory.Rows.Count > 0)
            {
                if (MessageBox.Show("Are you sure you want to clear the translation history?", "Clear confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    clsTranslationsHistoryBusiness.ClearTranslationHistory();
                    MessageBox.Show("The translation history has been successfully cleared.", "Cleared successfully", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Refresh();
                }
                else
                {
                    MessageBox.Show("The clearance of the translation history has been canceled.", "Clearance canceled", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }
    }
}
