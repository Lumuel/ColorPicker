using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ColorPicker
{
    public partial class frmFarbauswahl : Form
    {
        public frmFarbauswahl()
        {
            InitializeComponent();
        }

        private void frmFarbauswahl_btnStart_Click(object sender, EventArgs e)
        {
            if (colorDialog.ShowDialog() == DialogResult.OK)
            {

                int rValue = colorDialog.Color.R;
                int gValue = colorDialog.Color.G;
                int bValue = colorDialog.Color.B;
            }
        }
    }
}
