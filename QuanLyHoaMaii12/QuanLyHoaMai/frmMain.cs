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
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        private void menuKhoi_Click_Click(object sender, EventArgs e)
        {
            FrmKhoi f = new FrmKhoi();
            f.MdiParent = this;
            f.Show();
        }

        private void menuLop_Click(object sender, EventArgs e)
        {
            frmLop t = new frmLop();
            t.MdiParent = this;
            t.Show();
        }

        private void menuMonhoc_Click(object sender, EventArgs e)
        {
            frmMonhoc t = new frmMonhoc();
            t.MdiParent = this;
            t.Show();
        }

        private void baihoc_Click(object sender, EventArgs e)
        {
            frmBaihoc t = new frmBaihoc();
            t.MdiParent = this;
            t.Show();
        }

        private void thờiKhóaBiểuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmThoikhoabieu t = new frmThoikhoabieu();
            t.MdiParent = this;
            t.Show();
        }

        private void thôngTinPhầnMềmToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmTTphanmem t = new frmTTphanmem();
            t.MdiParent = this;
            t.Show();
        }
    }
}
