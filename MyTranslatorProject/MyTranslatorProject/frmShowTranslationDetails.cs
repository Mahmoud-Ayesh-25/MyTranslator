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
    public partial class frmShowTranslationDetails : Form
    {
        public frmShowTranslationDetails(string From, string To, DateTime Date)
        {
            InitializeComponent();

            lblDate.Text = $"Date : {Date.ToString()}";
            rtbxFrom.Text = From;
            rtbxTo.Text = To;
        }

        private void cbxFromRTL_CheckedChanged(object sender, EventArgs e)
        {
            if (cbxFromRTL.Checked)
            {
                rtbxFrom.RightToLeft = RightToLeft.Yes;
            }
            else
            {
                rtbxFrom.RightToLeft = RightToLeft.No;
            }
        }

        private void cbxToRTL_CheckedChanged(object sender, EventArgs e)
        {
            if (cbxToRTL.Checked)
            {
                rtbxTo.RightToLeft = RightToLeft.Yes;
            }
            else
            {
                rtbxTo.RightToLeft = RightToLeft.No;
            }
        }
    }
}
