namespace MyTranslatorProject
{
    partial class frmSettings
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmSettings));
            this.label1 = new System.Windows.Forms.Label();
            this.cbFrstShortcut = new System.Windows.Forms.ComboBox();
            this.cbScndShortcut = new System.Windows.Forms.ComboBox();
            this.tbxShortcut = new System.Windows.Forms.TextBox();
            this.btnShortcutSave = new System.Windows.Forms.Button();
            this.btnShortcutEdit = new System.Windows.Forms.Button();
            this.chbAutoRun = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(20, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(76, 18);
            this.label1.TabIndex = 0;
            this.label1.Text = "Shortcut : ";
            // 
            // cbFrstShortcut
            // 
            this.cbFrstShortcut.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbFrstShortcut.FormattingEnabled = true;
            this.cbFrstShortcut.Items.AddRange(new object[] {
            "ALT",
            "CONTROL",
            "SHIFT"});
            this.cbFrstShortcut.Location = new System.Drawing.Point(91, 21);
            this.cbFrstShortcut.Name = "cbFrstShortcut";
            this.cbFrstShortcut.Size = new System.Drawing.Size(73, 21);
            this.cbFrstShortcut.TabIndex = 0;
            // 
            // cbScndShortcut
            // 
            this.cbScndShortcut.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbScndShortcut.FormattingEnabled = true;
            this.cbScndShortcut.Items.AddRange(new object[] {
            "ALT",
            "CONTROL",
            "SHIFT"});
            this.cbScndShortcut.Location = new System.Drawing.Point(170, 21);
            this.cbScndShortcut.Name = "cbScndShortcut";
            this.cbScndShortcut.Size = new System.Drawing.Size(73, 21);
            this.cbScndShortcut.TabIndex = 1;
            // 
            // tbxShortcut
            // 
            this.tbxShortcut.Location = new System.Drawing.Point(249, 21);
            this.tbxShortcut.MaxLength = 1;
            this.tbxShortcut.Name = "tbxShortcut";
            this.tbxShortcut.Size = new System.Drawing.Size(21, 20);
            this.tbxShortcut.TabIndex = 2;
            this.tbxShortcut.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbxShortcut_KeyPress);
            // 
            // btnShortcutSave
            // 
            this.btnShortcutSave.Location = new System.Drawing.Point(276, 19);
            this.btnShortcutSave.Name = "btnShortcutSave";
            this.btnShortcutSave.Size = new System.Drawing.Size(75, 23);
            this.btnShortcutSave.TabIndex = 3;
            this.btnShortcutSave.Text = "Save";
            this.btnShortcutSave.UseVisualStyleBackColor = true;
            this.btnShortcutSave.Click += new System.EventHandler(this.btnShortcutSave_Click);
            // 
            // btnShortcutEdit
            // 
            this.btnShortcutEdit.Location = new System.Drawing.Point(357, 19);
            this.btnShortcutEdit.Name = "btnShortcutEdit";
            this.btnShortcutEdit.Size = new System.Drawing.Size(75, 23);
            this.btnShortcutEdit.TabIndex = 4;
            this.btnShortcutEdit.Text = "Edit";
            this.btnShortcutEdit.UseVisualStyleBackColor = true;
            this.btnShortcutEdit.Click += new System.EventHandler(this.btnShortcutEdit_Click);
            // 
            // chbAutoRun
            // 
            this.chbAutoRun.AutoSize = true;
            this.chbAutoRun.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chbAutoRun.Location = new System.Drawing.Point(20, 59);
            this.chbAutoRun.Name = "chbAutoRun";
            this.chbAutoRun.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.chbAutoRun.Size = new System.Drawing.Size(188, 22);
            this.chbAutoRun.TabIndex = 6;
            this.chbAutoRun.Text = "Auto Run With Windows";
            this.chbAutoRun.UseVisualStyleBackColor = true;
            this.chbAutoRun.CheckedChanged += new System.EventHandler(this.chbAutoRun_CheckedChanged);
            // 
            // frmSettings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(459, 98);
            this.Controls.Add(this.chbAutoRun);
            this.Controls.Add(this.btnShortcutEdit);
            this.Controls.Add(this.btnShortcutSave);
            this.Controls.Add(this.tbxShortcut);
            this.Controls.Add(this.cbScndShortcut);
            this.Controls.Add(this.cbFrstShortcut);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "frmSettings";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Settings";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbFrstShortcut;
        private System.Windows.Forms.ComboBox cbScndShortcut;
        private System.Windows.Forms.TextBox tbxShortcut;
        private System.Windows.Forms.Button btnShortcutSave;
        private System.Windows.Forms.Button btnShortcutEdit;
        private System.Windows.Forms.CheckBox chbAutoRun;
    }
}