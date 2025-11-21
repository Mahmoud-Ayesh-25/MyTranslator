namespace MyTranslatorProject
{
    partial class frmShowTranslationDetails
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmShowTranslationDetails));
            this.lblDate = new System.Windows.Forms.Label();
            this.rtbxTo = new System.Windows.Forms.RichTextBox();
            this.rtbxFrom = new System.Windows.Forms.RichTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.cbxFromRTL = new System.Windows.Forms.CheckBox();
            this.cbxToRTL = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // lblDate
            // 
            this.lblDate.AutoSize = true;
            this.lblDate.Font = new System.Drawing.Font("Microsoft YaHei", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDate.Location = new System.Drawing.Point(7, 9);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(72, 25);
            this.lblDate.TabIndex = 0;
            this.lblDate.Text = "Date : ";
            // 
            // rtbxTo
            // 
            this.rtbxTo.Font = new System.Drawing.Font("Microsoft YaHei", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rtbxTo.Location = new System.Drawing.Point(12, 273);
            this.rtbxTo.Name = "rtbxTo";
            this.rtbxTo.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.Vertical;
            this.rtbxTo.Size = new System.Drawing.Size(639, 165);
            this.rtbxTo.TabIndex = 1;
            this.rtbxTo.Text = "";
            // 
            // rtbxFrom
            // 
            this.rtbxFrom.Font = new System.Drawing.Font("Microsoft YaHei", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rtbxFrom.Location = new System.Drawing.Point(12, 71);
            this.rtbxFrom.Name = "rtbxFrom";
            this.rtbxFrom.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.Vertical;
            this.rtbxFrom.Size = new System.Drawing.Size(639, 165);
            this.rtbxFrom.TabIndex = 1;
            this.rtbxFrom.Text = "";
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Microsoft YaHei", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 43);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(639, 25);
            this.label2.TabIndex = 0;
            this.label2.Text = "From";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Microsoft YaHei", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(12, 245);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(639, 25);
            this.label3.TabIndex = 0;
            this.label3.Text = "To";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // cbxFromRTL
            // 
            this.cbxFromRTL.AutoSize = true;
            this.cbxFromRTL.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbxFromRTL.Location = new System.Drawing.Point(8, 49);
            this.cbxFromRTL.Name = "cbxFromRTL";
            this.cbxFromRTL.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.cbxFromRTL.Size = new System.Drawing.Size(95, 19);
            this.cbxFromRTL.TabIndex = 2;
            this.cbxFromRTL.Text = "Right To Left";
            this.cbxFromRTL.UseVisualStyleBackColor = true;
            this.cbxFromRTL.CheckedChanged += new System.EventHandler(this.cbxFromRTL_CheckedChanged);
            // 
            // cbxToRTL
            // 
            this.cbxToRTL.AutoSize = true;
            this.cbxToRTL.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbxToRTL.Location = new System.Drawing.Point(8, 251);
            this.cbxToRTL.Name = "cbxToRTL";
            this.cbxToRTL.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.cbxToRTL.Size = new System.Drawing.Size(95, 19);
            this.cbxToRTL.TabIndex = 3;
            this.cbxToRTL.Text = "Right To Left";
            this.cbxToRTL.UseVisualStyleBackColor = true;
            this.cbxToRTL.CheckedChanged += new System.EventHandler(this.cbxToRTL_CheckedChanged);
            // 
            // frmShowTranslationDetails
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(663, 450);
            this.Controls.Add(this.cbxToRTL);
            this.Controls.Add(this.cbxFromRTL);
            this.Controls.Add(this.rtbxFrom);
            this.Controls.Add(this.rtbxTo);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblDate);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "frmShowTranslationDetails";
            this.Text = "Show Translation Details";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblDate;
        private System.Windows.Forms.RichTextBox rtbxTo;
        private System.Windows.Forms.RichTextBox rtbxFrom;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.CheckBox cbxFromRTL;
        private System.Windows.Forms.CheckBox cbxToRTL;
    }
}