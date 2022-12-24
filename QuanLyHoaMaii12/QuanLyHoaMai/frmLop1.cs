using DevExpress.XtraEditors;
using DevExpress.XtraGrid.Views.Grid;
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
    public partial class frmLop1 : DevExpress.XtraEditors.XtraForm
    {
        bool action;

        HoaMaiEntities4 data = new HoaMaiEntities4();

        public frmLop1()
        {
            InitializeComponent();
        }

        private void frmLop1_Load(object sender, EventArgs e)
        {
            init();
            getData();
        }

        void init()
        {
            action = false; //insert

            txtMalop.Text = "";
            txtMalop.ReadOnly = true;

            txtTenlop.Text = "";

            txtGiaovienphutrach.Text = "";

            btnDelete.Enabled = false;
        }

        void getData()
        {
            data = new HoaMaiEntities4();

            List<LOP> lstLOP = data.LOPs.ToList();
            int i = 0;
            var v = from t in lstLOP
                    select new
                    {
                        No = ++i,
                        MALOP = t.MALOP,
                        TENLOP = t.TENLOP,
                        GIAOVIENPHUTRACH = t.GIAOVIENPHUTRACH
                    };
            gcLop.DataSource = v.ToList();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(txtMalop.Text.Trim()))
            { // insert
                var lop = new LOP
                {
                    MALOP = autoMa(),
                    TENLOP = txtTenlop.Text.Trim(),
                    GIAOVIENPHUTRACH = txtGiaovienphutrach.Text.Trim()

                };
                data.LOPs.Add(lop);
                data.SaveChanges();
                getData();
                MessageBox.Show("Thêm dữ liệu Lớp thành công");
            }
            else
            { // update
                var lop = data.LOPs
                    .Where(x => x.MALOP == txtMalop.Text.Trim())
                    .FirstOrDefault();
                lop.TENLOP = txtTenlop.Text.Trim();
                lop.GIAOVIENPHUTRACH = txtGiaovienphutrach.Text.Trim();
                data.SaveChanges();
                getData();

                MessageBox.Show("Sửa thành công");
            }
        }

        private string autoMa()
        {
            int numberofRows = data.LOPs.Count();

            if (numberofRows > 0)
            {
                string maLOPLastRow = data.LOPs
                    .OrderByDescending(x => x.MALOP)
                    .Select(y => y.MALOP)
                    .FirstOrDefault();

                char[] MALOPLastRow = maLOPLastRow.ToArray(); //ex {'L','0','0','1'}

                if (int.Parse(MALOPLastRow[1].ToString()) == 0)
                {
                    if (int.Parse(MALOPLastRow[2].ToString()) == 0)
                    {
                        if (int.Parse(MALOPLastRow[3].ToString()) == 9)
                        {
                            return "L010";
                        }
                        else if (int.Parse(MALOPLastRow[3].ToString()) <= 8)
                        {
                            string index3 = MALOPLastRow[3].ToString();
                            string MALOP = "L00" + (int.Parse(index3) + 1);
                            return MALOP;
                        }
                    }
                    else if (int.Parse(MALOPLastRow[2].ToString()) > 0)
                    {
                        string idex2 = MALOPLastRow[2].ToString();
                        string idex3 = MALOPLastRow[3].ToString();
                        string index23 = idex2 + idex3;

                        string MALOP = "L0" + (int.Parse(index23) + 1);
                        return MALOP;
                    }
                }
                else if (int.Parse(MALOPLastRow[1].ToString()) > 0)
                {
                    string index1 = MALOPLastRow[1].ToString();
                    string index2 = MALOPLastRow[2].ToString();
                    string index3 = MALOPLastRow[3].ToString();
                    string index123 = index1 + index2 + index3;

                    string MALOP = "L" + (int.Parse(index123) + 1);
                    return MALOP;
                }
            }
            return "L001";
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có thực sự muốn xóa" + txtMalop.Text, "thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {

                var lop_thoikhoabieu = data.THOIKHOABIEUx.FirstOrDefault(x => x.MALOP.Contains(txtMalop.Text.Trim()));
                if (lop_thoikhoabieu != null)
                {
                    MessageBox.Show("Dữ liệu Lớp này có liên kết với TKB nên không thể xóa");
                    return;
                }
                else
                {
                    var lop = data.LOPs.FirstOrDefault(x => x.MALOP.Contains(txtMalop.Text.Trim()));
                    data.LOPs.Remove(lop);
                    data.SaveChanges();
                    getData();

                    MessageBox.Show("Xóa thành công" + txtMalop.Text, "Thông báo");

                    action = true;
                    txtMalop.Clear();
                    txtTenlop.Clear();
                    txtGiaovienphutrach.Clear();
                }
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            action = false;
            btnDelete.Enabled = false;

            txtMalop.Clear();
            txtTenlop.Clear();
            txtGiaovienphutrach.Clear();
        }

        private void gvLop_KeyDown(object sender, KeyEventArgs e)
        {
            backDatatoLop(sender);
        }

        private void gvLop_KeyUp(object sender, KeyEventArgs e)
        {
            backDatatoLop(sender);
        }

        private void gvLop_RowCellClick(object sender, DevExpress.XtraGrid.Views.Grid.RowCellClickEventArgs e)
        {
            backDatatoLop(sender);
        }

        private void gvLop_RowClick(object sender, DevExpress.XtraGrid.Views.Grid.RowClickEventArgs e)
        {
            backDatatoLop(sender);
        }

        private void backDatatoLop(object sender)
        {
            GridView v = sender as GridView;
            try
            {
                txtMalop.Text = v.GetFocusedRowCellValue(colMaLop).ToString();
                txtTenlop.Text = v.GetFocusedRowCellValue(colTenLop).ToString();
                txtGiaovienphutrach.Text = v.GetFocusedRowCellValue(colGVPT).ToString();

                btnSave.Enabled = true;
                btnDelete.Enabled = true;
                btnCancel.Enabled = true;
            }
            catch { }
        }
    }
}