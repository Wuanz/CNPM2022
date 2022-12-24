using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyHoaMai
{
    public partial class frmTTphanmem : Form
    {
        public frmTTphanmem()
        {
            InitializeComponent();
        }

      

        private void txt_ttpm_TextChanged(object sender, EventArgs e)
        {
            txt_ttpm.ReadOnly = true;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
