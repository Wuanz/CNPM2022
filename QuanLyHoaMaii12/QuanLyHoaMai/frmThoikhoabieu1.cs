using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using DevExpress.XtraGrid.Views.Grid;

namespace QuanLyHoaMai
{
    public partial class frmThoikhoabieu1 : DevExpress.XtraEditors.XtraForm
    {
        bool action;

        HoaMaiEntities4 data = new HoaMaiEntities4();

        public frmThoikhoabieu1()
        {
            InitializeComponent();
        }

        private void frmThoikhoabieu1_Load(object sender, EventArgs e)
        {
            init();
            getData();
        }

        void init()
        {
            List<LOP> lstLOP = data.LOPs.ToList();
            var collop = from t in lstLOP
                         select new
                         {
                             MALOP = t.MALOP,
                             TENLOP = t.TENLOP,
                             GIAOVIENPHUTRACH = t.GIAOVIENPHUTRACH

                         };
            lkMalop.Properties.DataSource = collop.ToList();
            lkMalop.Properties.DisplayMember = "TENLOP";
            lkMalop.Properties.ValueMember = "MALOP";

            txtSTT.Text = "";

            List<BAIHOC> lstBAIHOC = data.BAIHOCs.ToList();
            var colbaihoc = from t in lstBAIHOC
                            select new
                            {
                                MABAIHOC = t.MABAIHOC,
                                TENBAIHOC = t.TENBAIHOC,
                                SOTIET = t.SOTIET

                            };
            lkMabaihoc.Properties.DataSource = colbaihoc.ToList();
            lkMabaihoc.Properties.DisplayMember = "TENBAIHOC";
            lkMabaihoc.Properties.ValueMember = "MABAIHOC";

            txtThu.Text = "";

            this.dateeditNgay.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.dateeditNgay.Properties.DisplayFormat.FormatString = "dd/MM/yyyy";
            this.dateeditNgay.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.dateeditNgay.Properties.EditFormat.FormatString = "dd/MM/yyyy";
            this.dateeditNgay.Properties.Mask.EditMask = "dd/MM/yyyy";
            this.dateeditNgay.DateTime = DateTime.Now;

            Cancel();
        }

        void getData()
        {
            List<THOIKHOABIEU> lstTHOIKHOABIEU = data.THOIKHOABIEUx.ToList();
            //int i = 0;
            var v = from t in lstTHOIKHOABIEU
                    select new
                    {
                        //STT = ++i,
                        MABAIHOC = t.BAIHOC.MABAIHOC,
                        MALOP = t.LOP.MALOP,
                        SOTHUTUTIET = t.SOTHUTUTIET.ToString(),
                        NGAY = t.NGAY.ToString(),
                        THU = t.THU
                    };
            gcThoiKhoaBieu.DataSource = v.ToList();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (action == false)
            { //insert
                if (String.IsNullOrEmpty(txtSTT.Text.Trim())) {
                    MessageBox.Show("Số thứ tự tiết trống!");
                    return;
                }
                if (String.IsNullOrEmpty(txtThu.Text.Trim()))
                {
                    MessageBox.Show("Thứ trống!");
                    return;
                }

                var malop = lkMalop.EditValue.ToString();
                var sothututiet = int.Parse(txtSTT.Text.Trim());
                var mabaihoc = lkMabaihoc.EditValue.ToString();


                var thoikhoabieu = data.THOIKHOABIEUx
                    .Where(x => x.MALOP == malop
                    && x.SOTHUTUTIET == sothututiet
                    && x.MABAIHOC == mabaihoc)
                    .FirstOrDefault();

                if (thoikhoabieu != null) {
                    MessageBox.Show("Thời khóa biểu này đã tồn tại!");
                    return;
                }
                else
                {
                    var t = new THOIKHOABIEU
                    {
                        MALOP = lkMalop.EditValue.ToString(),
                        SOTHUTUTIET = int.Parse(txtSTT.Text.Trim()),
                        MABAIHOC = lkMabaihoc.EditValue.ToString(),
                        THU = txtThu.Text.Trim(),
                        NGAY = dateeditNgay.DateTime
                    };
                    data.THOIKHOABIEUx.Add(t);
                    data.SaveChanges();
                    getData();

                    MessageBox.Show("Thêm dữ liệu THỜI KHÓA BIỂU thành công");

                    Cancel();
                }
            }
            else
            { //update
                var malop = lkMalop.EditValue.ToString();
                var stttiet = int.Parse(txtSTT.Text.Trim());
                var mabaihoc = lkMabaihoc.EditValue.ToString();

                var tkb = data.THOIKHOABIEUx
                    .Where(x => x.MALOP == malop
                    && x.SOTHUTUTIET == stttiet
                    && x.MABAIHOC == mabaihoc)
                    .FirstOrDefault();

                tkb.THU = txtThu.Text.Trim();
                tkb.NGAY = dateeditNgay.DateTime;

                data.SaveChanges();
                getData();

                MessageBox.Show("Sửa thành công", "Thông báo");
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có thực sự muốn xóa", "thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                var malop = lkMalop.EditValue.ToString();
                var stttiet = int.Parse(txtSTT.Text.Trim());
                var mabaihoc = lkMabaihoc.EditValue.ToString();

                var tkb = data.THOIKHOABIEUx
                    .Where(x => x.MALOP == malop
                    && x.SOTHUTUTIET == stttiet
                    && x.MABAIHOC == mabaihoc)
                    .FirstOrDefault();

                data.THOIKHOABIEUx.Remove(tkb);
                data.SaveChanges();
                getData();

                MessageBox.Show("Xóa thành công", "Thông báo");

                Cancel();
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Cancel();
        }

        private void Cancel()
        {
            action = false;

            lkMalop.Enabled = true;
            
            txtSTT.Text = "";
            txtSTT.Enabled = true;
            
            lkMabaihoc.Enabled = true;

            txtThu.Text = "";
            dateeditNgay.DateTime = DateTime.Now;

            btnSave.Enabled = true;
            btnCancel.Enabled = true;
            btnDelete.Enabled = false;
        }

        private void gvThoikhoabieu_RowCellClick(object sender, DevExpress.XtraGrid.Views.Grid.RowCellClickEventArgs e)
        {
            backDatatoTKB(sender);
        }

        private void gvThoikhoabieu_KeyDown(object sender, KeyEventArgs e)
        {
            backDatatoTKB(sender);
        }

        private void gvThoikhoabieu_KeyUp(object sender, KeyEventArgs e)
        {
            backDatatoTKB(sender);
        }

        private void gvThoikhoabieu_RowClick(object sender, DevExpress.XtraGrid.Views.Grid.RowClickEventArgs e)
        {
            backDatatoTKB(sender);
        }

        private void backDatatoTKB(object sender)
        {
            action = true;

            lkMalop.Enabled = false;
            txtSTT.Enabled = false;
            lkMabaihoc.Enabled = false;

            GridView v = sender as GridView;
            try
            {
                lkMalop.EditValue = v.GetFocusedRowCellValue(colMaLop).ToString();
                txtSTT.Text = v.GetFocusedRowCellValue(colSoThuTuTiet).ToString();
                lkMabaihoc.EditValue = v.GetFocusedRowCellValue(colMaBaiHoc).ToString();

                txtThu.Text = v.GetFocusedRowCellValue(colThu).ToString();
                dateeditNgay.EditValue = DateTime.Parse(v.GetFocusedRowCellValue(colNgay).ToString());

                btnSave.Enabled = true;
                btnDelete.Enabled = true;
                btnCancel.Enabled = true;
            }
            catch { }
        }

        private void txtSTT_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }
    }
}