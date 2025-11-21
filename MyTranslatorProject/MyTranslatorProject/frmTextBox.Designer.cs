namespace MyTranslatorProject
{
    partial class frmTextBox
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmTextBox));
            this.rtbxTrnaslateDisplayer = new System.Windows.Forms.RichTextBox();
            this.cbxRightToLeft = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // rtbxTrnaslateDisplayer
            // 
            this.rtbxTrnaslateDisplayer.Font = new System.Drawing.Font("Microsoft YaHei", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rtbxTrnaslateDisplayer.Location = new System.Drawing.Point(12, 37);
            this.rtbxTrnaslateDisplayer.Name = "rtbxTrnaslateDisplayer";
            this.rtbxTrnaslateDisplayer.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.Vertical;
            this.rtbxTrnaslateDisplayer.Size = new System.Drawing.Size(776, 401);
            this.rtbxTrnaslateDisplayer.TabIndex = 0;
            this.rtbxTrnaslateDisplayer.Text = "";
            // 
            // cbxRightToLeft
            // 
            this.cbxRightToLeft.AutoSize = true;
            this.cbxRightToLeft.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbxRightToLeft.Location = new System.Drawing.Point(8, 12);
            this.cbxRightToLeft.Name = "cbxRightToLeft";
            this.cbxRightToLeft.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.cbxRightToLeft.Size = new System.Drawing.Size(95, 19);
            this.cbxRightToLeft.TabIndex = 1;
            this.cbxRightToLeft.Text = "Right To Left";
            this.cbxRightToLeft.UseVisualStyleBackColor = true;
            this.cbxRightToLeft.CheckedChanged += new System.EventHandler(this.cbxRightToLeft_CheckedChanged);
            // 
            // frmTextBox
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.cbxRightToLeft);
            this.Controls.Add(this.rtbxTrnaslateDisplayer);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmTextBox";
            this.Text = "Translation Viewer";
            this.SizeChanged += new System.EventHandler(this.frmTextBox_SizeChanged);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox rtbxTrnaslateDisplayer;
        private System.Windows.Forms.CheckBox cbxRightToLeft;
    }
}