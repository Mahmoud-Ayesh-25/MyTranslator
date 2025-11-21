using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyTranslatorProject
{
    public partial class frmTextBox : Form
    {
        public void SetText(string text)
        {
            rtbxTrnaslateDisplayer.Text = text;
        }

        public frmTextBox()
        {
            InitializeComponent();

            this.StartPosition = FormStartPosition.Manual;
            this.Location = new Point(1000, 500);
            this.WindowState = FormWindowState.Minimized;
        }

        private void frmTextBox_SizeChanged(object sender, EventArgs e)
        {
            rtbxTrnaslateDisplayer.Height = this.Size.Height - 90;
            rtbxTrnaslateDisplayer.Width = this.Size.Width - 40;
            rtbxTrnaslateDisplayer.Location = new System.Drawing.Point(12, 40);
        }

        private void cbxRightToLeft_CheckedChanged(object sender, EventArgs e)
        {
            if (cbxRightToLeft.Checked)
            {
                rtbxTrnaslateDisplayer.RightToLeft = RightToLeft.Yes;
            }
            else
            {
                rtbxTrnaslateDisplayer.RightToLeft = RightToLeft.No;
            }
        }
    }
}
