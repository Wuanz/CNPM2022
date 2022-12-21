using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraBars;

namespace QuanLyHoaMai
{
    public partial class frmRB : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        public frmRB()
        {
            InitializeComponent();
        }

        private void menuKhoi_Click_ItemClick(object sender, ItemClickEventArgs e)
        {
            frmKhoi1 f = new frmKhoi1();
            f.MdiParent = this;
            f.Show();
        }

        private void menuLop_Click_ItemClick(object sender, ItemClickEventArgs e)
        {
            frmLop1 f = new frmLop1();
            f.MdiParent = this;
            f.Show();
        }

        private void menuMonhoc_Click_ItemClick(object sender, ItemClickEventArgs e)
        {
            frmMonhoc1 f = new frmMonhoc1();
            f.MdiParent = this;
            f.Show();
        }

        private void menuBaihocClick_ItemClick(object sender, ItemClickEventArgs e)
        {
            frmBaihoc1 f = new frmBaihoc1();
            f.MdiParent = this;
            f.Show();
        }

        private void menuTkb_Click_ItemClick(object sender, ItemClickEventArgs e)
        {
            frmThoikhoabieu1 f = new frmThoikhoabieu1();
            f.MdiParent = this;
            f.Show();
        }

        private void barButtonItem1_ItemClick(object sender, ItemClickEventArgs e)
        {
            ReportDev f = new ReportDev();
            f.MdiParent = this;
            f.Show();
        }
    }
}