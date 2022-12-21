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
        bool action = false;//insert
        HoaMaiEntities4 data = new HoaMaiEntities4();
        public frmThoikhoabieu1()
        {
            InitializeComponent();
        }
        private int autoMa()
        {
            int numberma = data.BAIHOCs
                .Select(x => x.MABAIHOC)
               .Count();

            return  numberma + 1;

        }
        private void btnSave_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(txtSTT.Text.Trim()))
            {
                // insert
                var t = new THOIKHOABIEU
                {
                    MABAIHOC = lkMabaihoc.EditValue.ToString(),
                    MALOP = lkMalop.EditValue.ToString(),
                    THU = dateeditNgay.DateTime.DayOfWeek.ToString(),
                    SOTHUTUTIET = autoMa(),
            
                    NGAY = dateeditNgay.DateTime
                   
                };
                data.THOIKHOABIEUx.Add(t);
                data.SaveChanges();
                getData();
                MessageBox.Show("Thêm dữ liệu THỜI KHÓA BIỂU thành công");
            }
            else
            {
                //update
                var t = int.Parse(txtSTT.Text.Trim());
                var tkb = data.THOIKHOABIEUx
                    .Where(x => x.SOTHUTUTIET == t)
                    .FirstOrDefault();
                
                tkb.MABAIHOC = lkMabaihoc.EditValue.ToString();
                tkb.MALOP = lkMalop.EditValue.ToString();
                txtSTT.ReadOnly = true;
                tkb.NGAY = dateeditNgay.DateTime;
                tkb.THU = dateeditNgay.DateTime.DayOfWeek.ToString();


                data.SaveChanges();
                getData();
                var s = data.THOIKHOABIEUx
                       .Where(x => x.THU == txtThu.Text.Trim())
                       .FirstOrDefault();


                data.SaveChanges();
                getData();
                MessageBox.Show("Xóa thành công", "Thông báo");
                txtSTT.Clear();

            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            btnDelete.Enabled = false;
            action = false;
            dateeditNgay.DateTime = DateTime.Now;
            txtSTT.Clear();
        }

        private void frmThoikhoabieu1_Load(object sender, EventArgs e)
        {
            getData();
            init();
        }
        void init()
        {
            this.dateeditNgay.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.dateeditNgay.Properties.DisplayFormat.FormatString = "dd/MM/yyyy";
            this.dateeditNgay.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.dateeditNgay.Properties.EditFormat.FormatString = "dd/MM/yyyy";
            this.dateeditNgay.Properties.Mask.EditMask = "dd/MM/yyyy";
            this.dateeditNgay.DateTime = DateTime.Now;



            txtThu.ReadOnly = true;
            txtSTT.ReadOnly = true;


            List<BAIHOC> lst = data.BAIHOCs.ToList();
            var colbaihoc = from t in lst
                            select new
                            {
                                MABAIHOC = t.MABAIHOC,
                                TENBAIHOC = t.TENBAIHOC,
                                SOTIET = t.SOTIET

                            };
            lkMabaihoc.Properties.DataSource = colbaihoc.ToList();
            lkMabaihoc.Properties.DisplayMember = "TENBAIHOC";
            lkMabaihoc.Properties.ValueMember = "MABAIHOC";


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

            btnSave.Enabled = true;
            btnCancel.Enabled = true;
            btnDelete.Enabled = true;
        }


        void getData()
        {

            List<THOIKHOABIEU> lst = data.THOIKHOABIEUx.ToList();
            int i = 0;
            var v = from t in lst
                    select new
                    {
                       
                        MABAIHOC = t.BAIHOC.MABAIHOC,
                        MALOP = t.LOP.MALOP, //1
                        SOTHUTUTIET = t.SOTHUTUTIET,
                        NGAY = t.NGAY,//5
                        THU = t.THU//3
                        

                    };
            gcThoiKhoaBieu.DataSource = v.ToList();
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
            GridView v = sender as GridView;
            try
            {
                lkMabaihoc.EditValue = v.GetFocusedRowCellValue(colMaBaiHoc).ToString();
                lkMalop.EditValue = v.GetFocusedRowCellValue(colMaLop).ToString();
                txtThu.Text= v.GetFocusedRowCellValue(colThu).ToString();
                txtSTT.Text = v.GetFocusedRowCellValue(colSoThuTuTiet).ToString();
                dateeditNgay.EditValue = DateTime.Parse(v.GetFocusedRowCellValue(colNgay).ToString());

                btnSave.Enabled = true;
                btnDelete.Enabled = true;
                btnCancel.Enabled = true;
            }
            catch { }
        }

        private void dateeditNgay_DateTimeChanged(object sender, EventArgs e)
        {
            txtThu.Text = dateeditNgay.DateTime.DayOfWeek.ToString();
        }
    }
}