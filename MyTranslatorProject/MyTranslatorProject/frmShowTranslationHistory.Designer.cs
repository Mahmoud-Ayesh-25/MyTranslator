namespace MyTranslatorProject
{
    partial class frmShowTranslationHistory
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmShowTranslationHistory));
            this.dgvTranslationsHistory = new System.Windows.Forms.DataGridView();
            this.cmsTranslationHistory = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.showDetailsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btnShowTranslationDetails = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.cbFilter = new System.Windows.Forms.ComboBox();
            this.tbxFilter = new System.Windows.Forms.TextBox();
            this.btnDeleteTranslation = new System.Windows.Forms.Button();
            this.btnClearTranslationHistory = new System.Windows.Forms.Button();
            this.lblRecords = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTranslationsHistory)).BeginInit();
            this.cmsTranslationHistory.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvTranslationsHistory
            // 
            this.dgvTranslationsHistory.AllowUserToAddRows = false;
            this.dgvTranslationsHistory.AllowUserToDeleteRows = false;
            this.dgvTranslationsHistory.AllowUserToResizeColumns = false;
            this.dgvTranslationsHistory.AllowUserToResizeRows = false;
            this.dgvTranslationsHistory.ColumnHeadersHeight = 25;
            this.dgvTranslationsHistory.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvTranslationsHistory.ContextMenuStrip = this.cmsTranslationHistory;
            this.dgvTranslationsHistory.Location = new System.Drawing.Point(12, 39);
            this.dgvTranslationsHistory.MultiSelect = false;
            this.dgvTranslationsHistory.Name = "dgvTranslationsHistory";
            this.dgvTranslationsHistory.ReadOnly = true;
            this.dgvTranslationsHistory.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.Black;
            this.dgvTranslationsHistory.RowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvTranslationsHistory.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvTranslationsHistory.Size = new System.Drawing.Size(768, 381);
            this.dgvTranslationsHistory.TabIndex = 0;
            this.dgvTranslationsHistory.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvTranslationsHistory_CellDoubleClick);
            this.dgvTranslationsHistory.DataBindingComplete += new System.Windows.Forms.DataGridViewBindingCompleteEventHandler(this.dgvTranslationsHistory_DataBindingComplete);
            this.dgvTranslationsHistory.KeyDown += new System.Windows.Forms.KeyEventHandler(this.dgvTranslationsHistory_KeyDown);
            // 
            // cmsTranslationHistory
            // 
            this.cmsTranslationHistory.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.showDetailsToolStripMenuItem,
            this.deleteToolStripMenuItem});
            this.cmsTranslationHistory.Name = "cmsTranslationHistory";
            this.cmsTranslationHistory.Size = new System.Drawing.Size(142, 48);
            // 
            // showDetailsToolStripMenuItem
            // 
            this.showDetailsToolStripMenuItem.Name = "showDetailsToolStripMenuItem";
            this.showDetailsToolStripMenuItem.Size = new System.Drawing.Size(141, 22);
            this.showDetailsToolStripMenuItem.Text = "Show Details";
            this.showDetailsToolStripMenuItem.Click += new System.EventHandler(this.showDetailsToolStripMenuItem_Click);
            // 
            // deleteToolStripMenuItem
            // 
            this.deleteToolStripMenuItem.Name = "deleteToolStripMenuItem";
            this.deleteToolStripMenuItem.Size = new System.Drawing.Size(141, 22);
            this.deleteToolStripMenuItem.Text = "Delete";
            this.deleteToolStripMenuItem.Click += new System.EventHandler(this.deleteToolStripMenuItem_Click);
            // 
            // btnShowTranslationDetails
            // 
            this.btnShowTranslationDetails.Location = new System.Drawing.Point(583, 426);
            this.btnShowTranslationDetails.Name = "btnShowTranslationDetails";
            this.btnShowTranslationDetails.Size = new System.Drawing.Size(197, 23);
            this.btnShowTranslationDetails.TabIndex = 3;
            this.btnShowTranslationDetails.Text = "Show Selected Translation Details";
            this.btnShowTranslationDetails.UseVisualStyleBackColor = true;
            this.btnShowTranslationDetails.Click += new System.EventHandler(this.btnShowTranslationDetails_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(9, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 15);
            this.label1.TabIndex = 3;
            this.label1.Text = "Filter By : ";
            // 
            // cbFilter
            // 
            this.cbFilter.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbFilter.FormattingEnabled = true;
            this.cbFilter.Items.AddRange(new object[] {
            "None",
            "From",
            "To"});
            this.cbFilter.Location = new System.Drawing.Point(65, 12);
            this.cbFilter.Name = "cbFilter";
            this.cbFilter.Size = new System.Drawing.Size(96, 21);
            this.cbFilter.TabIndex = 1;
            this.cbFilter.SelectedIndexChanged += new System.EventHandler(this.cbFilter_SelectedIndexChanged);
            // 
            // tbxFilter
            // 
            this.tbxFilter.Location = new System.Drawing.Point(167, 13);
            this.tbxFilter.Name = "tbxFilter";
            this.tbxFilter.Size = new System.Drawing.Size(182, 20);
            this.tbxFilter.TabIndex = 2;
            this.tbxFilter.TextChanged += new System.EventHandler(this.tbxFilter_TextChanged);
            // 
            // btnDeleteTranslation
            // 
            this.btnDeleteTranslation.Location = new System.Drawing.Point(413, 426);
            this.btnDeleteTranslation.Name = "btnDeleteTranslation";
            this.btnDeleteTranslation.Size = new System.Drawing.Size(164, 23);
            this.btnDeleteTranslation.TabIndex = 4;
            this.btnDeleteTranslation.Text = "Delete Selected Translation";
            this.btnDeleteTranslation.UseVisualStyleBackColor = true;
            this.btnDeleteTranslation.Click += new System.EventHandler(this.btnDeleteTranslation_Click);
            // 
            // btnClearTranslationHistory
            // 
            this.btnClearTranslationHistory.Location = new System.Drawing.Point(262, 426);
            this.btnClearTranslationHistory.Name = "btnClearTranslationHistory";
            this.btnClearTranslationHistory.Size = new System.Drawing.Size(145, 23);
            this.btnClearTranslationHistory.TabIndex = 5;
            this.btnClearTranslationHistory.Text = "Clear Translation History";
            this.btnClearTranslationHistory.UseVisualStyleBackColor = true;
            this.btnClearTranslationHistory.Click += new System.EventHandler(this.btnClearTranslationHistory_Click);
            // 
            // lblRecords
            // 
            this.lblRecords.AutoSize = true;
            this.lblRecords.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRecords.Location = new System.Drawing.Point(9, 426);
            this.lblRecords.Name = "lblRecords";
            this.lblRecords.Size = new System.Drawing.Size(69, 15);
            this.lblRecords.TabIndex = 6;
            this.lblRecords.Text = "Records : 0";
            // 
            // frmShowTranslationHistory
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(792, 461);
            this.Controls.Add(this.lblRecords);
            this.Controls.Add(this.btnClearTranslationHistory);
            this.Controls.Add(this.btnDeleteTranslation);
            this.Controls.Add(this.tbxFilter);
            this.Controls.Add(this.cbFilter);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnShowTranslationDetails);
            this.Controls.Add(this.dgvTranslationsHistory);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "frmShowTranslationHistory";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Show Translation History";
            this.Load += new System.EventHandler(this.frmShowTranslationHistory_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvTranslationsHistory)).EndInit();
            this.cmsTranslationHistory.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvTranslationsHistory;
        private System.Windows.Forms.Button btnShowTranslationDetails;
        private System.Windows.Forms.ContextMenuStrip cmsTranslationHistory;
        private System.Windows.Forms.ToolStripMenuItem showDetailsToolStripMenuItem;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbFilter;
        private System.Windows.Forms.TextBox tbxFilter;
        private System.Windows.Forms.Button btnDeleteTranslation;
        private System.Windows.Forms.ToolStripMenuItem deleteToolStripMenuItem;
        private System.Windows.Forms.Button btnClearTranslationHistory;
        private System.Windows.Forms.Label lblRecords;
    }
}