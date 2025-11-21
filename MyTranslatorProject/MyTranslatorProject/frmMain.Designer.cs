namespace MyTranslatorProject
{
    partial class MyTranslator
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MyTranslator));
            this.tbxApiKey = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnApiKeySave = new System.Windows.Forms.Button();
            this.btnApiKeyEdit = new System.Windows.Forms.Button();
            this.tbxTargetLanguage = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnTargetLangSave = new System.Windows.Forms.Button();
            this.btnTargetLangEdit = new System.Windows.Forms.Button();
            this.btnSourceLangSave = new System.Windows.Forms.Button();
            this.btnSourceLangEdit = new System.Windows.Forms.Button();
            this.dgvSourceLanguage = new System.Windows.Forms.DataGridView();
            this.tbxSourceLanguage = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.dgvTargetLanguage = new System.Windows.Forms.DataGridView();
            this.btnSettings = new System.Windows.Forms.Button();
            this.btnShowTranslationHistory = new System.Windows.Forms.Button();
            this.btnHowToUse = new System.Windows.Forms.Button();
            this.ntBiengTranslated = new System.Windows.Forms.NotifyIcon(this.components);
            this.ntTextTranslated = new System.Windows.Forms.NotifyIcon(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dgvSourceLanguage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTargetLanguage)).BeginInit();
            this.SuspendLayout();
            // 
            // tbxApiKey
            // 
            this.tbxApiKey.Location = new System.Drawing.Point(104, 25);
            this.tbxApiKey.Name = "tbxApiKey";
            this.tbxApiKey.Size = new System.Drawing.Size(282, 20);
            this.tbxApiKey.TabIndex = 1;
            this.tbxApiKey.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tbxApiKey_KeyDown);
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(22, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 23);
            this.label1.TabIndex = 1;
            this.label1.Text = "API Key :";
            // 
            // btnApiKeySave
            // 
            this.btnApiKeySave.Location = new System.Drawing.Point(104, 51);
            this.btnApiKeySave.Name = "btnApiKeySave";
            this.btnApiKeySave.Size = new System.Drawing.Size(75, 23);
            this.btnApiKeySave.TabIndex = 2;
            this.btnApiKeySave.Text = "Save";
            this.btnApiKeySave.UseVisualStyleBackColor = true;
            this.btnApiKeySave.Click += new System.EventHandler(this.btnApiKeySave_Click);
            // 
            // btnApiKeyEdit
            // 
            this.btnApiKeyEdit.Enabled = false;
            this.btnApiKeyEdit.Location = new System.Drawing.Point(185, 51);
            this.btnApiKeyEdit.Name = "btnApiKeyEdit";
            this.btnApiKeyEdit.Size = new System.Drawing.Size(75, 23);
            this.btnApiKeyEdit.TabIndex = 3;
            this.btnApiKeyEdit.Text = "Edit";
            this.btnApiKeyEdit.UseVisualStyleBackColor = true;
            this.btnApiKeyEdit.Click += new System.EventHandler(this.btnApiKeyEdit_Click);
            // 
            // tbxTargetLanguage
            // 
            this.tbxTargetLanguage.Location = new System.Drawing.Point(209, 133);
            this.tbxTargetLanguage.Name = "tbxTargetLanguage";
            this.tbxTargetLanguage.Size = new System.Drawing.Size(177, 20);
            this.tbxTargetLanguage.TabIndex = 7;
            this.tbxTargetLanguage.Text = "Search...";
            this.tbxTargetLanguage.TextChanged += new System.EventHandler(this.tbxTargetLanguage_TextChanged);
            this.tbxTargetLanguage.Enter += new System.EventHandler(this.tbxSourceLanguage_Enter);
            this.tbxTargetLanguage.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tbxTargetLanguage_KeyDown);
            this.tbxTargetLanguage.Leave += new System.EventHandler(this.tbxSourceLanguage_Leave);
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(205, 107);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(181, 23);
            this.label3.TabIndex = 1;
            this.label3.Text = "Target Language";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnTargetLangSave
            // 
            this.btnTargetLangSave.Location = new System.Drawing.Point(209, 410);
            this.btnTargetLangSave.Name = "btnTargetLangSave";
            this.btnTargetLangSave.Size = new System.Drawing.Size(85, 23);
            this.btnTargetLangSave.TabIndex = 8;
            this.btnTargetLangSave.Text = "Save";
            this.btnTargetLangSave.UseVisualStyleBackColor = true;
            this.btnTargetLangSave.Click += new System.EventHandler(this.btnTargetLangSave_Click);
            // 
            // btnTargetLangEdit
            // 
            this.btnTargetLangEdit.Enabled = false;
            this.btnTargetLangEdit.Location = new System.Drawing.Point(300, 410);
            this.btnTargetLangEdit.Name = "btnTargetLangEdit";
            this.btnTargetLangEdit.Size = new System.Drawing.Size(86, 23);
            this.btnTargetLangEdit.TabIndex = 9;
            this.btnTargetLangEdit.Text = "Edit";
            this.btnTargetLangEdit.UseVisualStyleBackColor = true;
            this.btnTargetLangEdit.Click += new System.EventHandler(this.btnTargetLangEdit_Click);
            // 
            // btnSourceLangSave
            // 
            this.btnSourceLangSave.Location = new System.Drawing.Point(26, 410);
            this.btnSourceLangSave.Name = "btnSourceLangSave";
            this.btnSourceLangSave.Size = new System.Drawing.Size(86, 23);
            this.btnSourceLangSave.TabIndex = 5;
            this.btnSourceLangSave.Text = "Save";
            this.btnSourceLangSave.UseVisualStyleBackColor = true;
            this.btnSourceLangSave.Click += new System.EventHandler(this.btnSourceLangSave_Click);
            // 
            // btnSourceLangEdit
            // 
            this.btnSourceLangEdit.Enabled = false;
            this.btnSourceLangEdit.Location = new System.Drawing.Point(118, 410);
            this.btnSourceLangEdit.Name = "btnSourceLangEdit";
            this.btnSourceLangEdit.Size = new System.Drawing.Size(85, 23);
            this.btnSourceLangEdit.TabIndex = 6;
            this.btnSourceLangEdit.Text = "Edit";
            this.btnSourceLangEdit.UseVisualStyleBackColor = true;
            this.btnSourceLangEdit.Click += new System.EventHandler(this.btnSourceLangEdit_Click);
            // 
            // dgvSourceLanguage
            // 
            this.dgvSourceLanguage.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvSourceLanguage.Location = new System.Drawing.Point(26, 159);
            this.dgvSourceLanguage.MultiSelect = false;
            this.dgvSourceLanguage.Name = "dgvSourceLanguage";
            this.dgvSourceLanguage.ReadOnly = true;
            this.dgvSourceLanguage.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.Black;
            this.dgvSourceLanguage.RowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvSourceLanguage.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvSourceLanguage.Size = new System.Drawing.Size(177, 245);
            this.dgvSourceLanguage.TabIndex = 12;
            this.dgvSourceLanguage.TabStop = false;
            this.dgvSourceLanguage.KeyDown += new System.Windows.Forms.KeyEventHandler(this.dgvSourceLanguage_KeyDown);
            // 
            // tbxSourceLanguage
            // 
            this.tbxSourceLanguage.Location = new System.Drawing.Point(26, 133);
            this.tbxSourceLanguage.Name = "tbxSourceLanguage";
            this.tbxSourceLanguage.Size = new System.Drawing.Size(177, 20);
            this.tbxSourceLanguage.TabIndex = 4;
            this.tbxSourceLanguage.Text = "Search...";
            this.tbxSourceLanguage.TextChanged += new System.EventHandler(this.tbxSourceLanguage_TextChanged);
            this.tbxSourceLanguage.Enter += new System.EventHandler(this.tbxSourceLanguage_Enter);
            this.tbxSourceLanguage.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tbxSourceLanguage_KeyDown);
            this.tbxSourceLanguage.Leave += new System.EventHandler(this.tbxSourceLanguage_Leave);
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(22, 107);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(181, 23);
            this.label2.TabIndex = 1;
            this.label2.Text = "Source Language";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // dgvTargetLanguage
            // 
            this.dgvTargetLanguage.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvTargetLanguage.Location = new System.Drawing.Point(209, 159);
            this.dgvTargetLanguage.MultiSelect = false;
            this.dgvTargetLanguage.Name = "dgvTargetLanguage";
            this.dgvTargetLanguage.ReadOnly = true;
            this.dgvTargetLanguage.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.Black;
            this.dgvTargetLanguage.RowsDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvTargetLanguage.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvTargetLanguage.Size = new System.Drawing.Size(177, 245);
            this.dgvTargetLanguage.TabIndex = 13;
            this.dgvTargetLanguage.TabStop = false;
            this.dgvTargetLanguage.KeyDown += new System.Windows.Forms.KeyEventHandler(this.dgvTargetLanguage_KeyDown);
            // 
            // btnSettings
            // 
            this.btnSettings.Location = new System.Drawing.Point(209, 449);
            this.btnSettings.Name = "btnSettings";
            this.btnSettings.Size = new System.Drawing.Size(177, 23);
            this.btnSettings.TabIndex = 10;
            this.btnSettings.Text = "Settings";
            this.btnSettings.UseVisualStyleBackColor = true;
            this.btnSettings.Click += new System.EventHandler(this.btnSettings_Click);
            // 
            // btnShowTranslationHistory
            // 
            this.btnShowTranslationHistory.Location = new System.Drawing.Point(26, 478);
            this.btnShowTranslationHistory.Name = "btnShowTranslationHistory";
            this.btnShowTranslationHistory.Size = new System.Drawing.Size(360, 23);
            this.btnShowTranslationHistory.TabIndex = 11;
            this.btnShowTranslationHistory.Text = "Show Translation History";
            this.btnShowTranslationHistory.UseVisualStyleBackColor = true;
            this.btnShowTranslationHistory.Click += new System.EventHandler(this.btnShowTranslationHistory_Click);
            // 
            // btnHowToUse
            // 
            this.btnHowToUse.Location = new System.Drawing.Point(26, 449);
            this.btnHowToUse.Name = "btnHowToUse";
            this.btnHowToUse.Size = new System.Drawing.Size(177, 23);
            this.btnHowToUse.TabIndex = 0;
            this.btnHowToUse.Text = "How To Use My Translator";
            this.btnHowToUse.UseVisualStyleBackColor = true;
            this.btnHowToUse.Click += new System.EventHandler(this.btnHowToUse_Click);
            // 
            // ntBiengTranslated
            // 
            this.ntBiengTranslated.BalloonTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            this.ntBiengTranslated.BalloonTipTitle = "Text is being translated ⌛";
            this.ntBiengTranslated.Visible = true;
            // 
            // ntTextTranslated
            // 
            this.ntTextTranslated.BalloonTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            this.ntTextTranslated.BalloonTipTitle = "Text Translated ✅";
            this.ntTextTranslated.Visible = true;
            // 
            // MyTranslator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(412, 524);
            this.Controls.Add(this.dgvTargetLanguage);
            this.Controls.Add(this.dgvSourceLanguage);
            this.Controls.Add(this.tbxTargetLanguage);
            this.Controls.Add(this.tbxSourceLanguage);
            this.Controls.Add(this.btnShowTranslationHistory);
            this.Controls.Add(this.btnHowToUse);
            this.Controls.Add(this.btnSettings);
            this.Controls.Add(this.btnTargetLangEdit);
            this.Controls.Add(this.btnTargetLangSave);
            this.Controls.Add(this.btnSourceLangEdit);
            this.Controls.Add(this.btnSourceLangSave);
            this.Controls.Add(this.btnApiKeyEdit);
            this.Controls.Add(this.btnApiKeySave);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbxApiKey);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "MyTranslator";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "My Translator";
            this.Load += new System.EventHandler(this.MyTranslator_Load);
            this.Shown += new System.EventHandler(this.MyTranslator_Shown);
            ((System.ComponentModel.ISupportInitialize)(this.dgvSourceLanguage)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTargetLanguage)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbxApiKey;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnApiKeySave;
        private System.Windows.Forms.Button btnApiKeyEdit;
        private System.Windows.Forms.TextBox tbxTargetLanguage;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnTargetLangSave;
        private System.Windows.Forms.Button btnTargetLangEdit;
        private System.Windows.Forms.Button btnSourceLangSave;
        private System.Windows.Forms.Button btnSourceLangEdit;
        private System.Windows.Forms.DataGridView dgvSourceLanguage;
        private System.Windows.Forms.TextBox tbxSourceLanguage;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dgvTargetLanguage;
        private System.Windows.Forms.Button btnSettings;
        private System.Windows.Forms.Button btnShowTranslationHistory;
        private System.Windows.Forms.Button btnHowToUse;
        private System.Windows.Forms.NotifyIcon ntBiengTranslated;
        private System.Windows.Forms.NotifyIcon ntTextTranslated;
    }
}

