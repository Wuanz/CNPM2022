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
    public partial class frmKhoi1 : DevExpress.XtraEditors.XtraForm
    {
        bool action = false;//insert
        HoaMaiEntities4 data = new HoaMaiEntities4();
        public frmKhoi1()
        {
            InitializeComponent();
        }
        private string autoMa()
        {
            int numberofRows = data.MONHOCs.Count();

            if (numberofRows > 0)
            {
                string maKHOILastRow = data.KHOIs
                    .OrderByDescending(x => x.MAKHOI)
                    .Select(y => y.MAKHOI)
                    .FirstOrDefault();

                char[] MAKHOILastRow = maKHOILastRow.ToArray(); //ex {'M','0','0','1'}

                if (int.Parse(MAKHOILastRow[1].ToString()) == 0)
                {
                    if (int.Parse(MAKHOILastRow[2].ToString()) == 0)
                    {
                        if (int.Parse(MAKHOILastRow[3].ToString()) == 9)
                        {
                            return "M010";
                        }
                        else if (int.Parse(MAKHOILastRow[3].ToString()) <= 8)
                        {
                            string index3 = MAKHOILastRow[3].ToString();
                            string MAKHOI = "M00" + (int.Parse(index3) + 1);
                            return MAKHOI;
                        }
                    }
                    else if (int.Parse(MAKHOILastRow[2].ToString()) > 0)
                    {
                        string idex2 = MAKHOILastRow[2].ToString();
                        string idex3 = MAKHOILastRow[3].ToString();
                        string index23 = idex2 + idex3;

                        string MAKHOI = "M0" + (int.Parse(index23) + 1);
                        return MAKHOI;
                    }
                }
                else if (int.Parse(MAKHOILastRow[1].ToString()) > 0)
                {
                    string index1 = MAKHOILastRow[1].ToString();
                    string index2 = MAKHOILastRow[2].ToString();
                    string index3 = MAKHOILastRow[3].ToString();
                    string index123 = index1 + index2 + index3;

                    string MAKHOI = "K" + (int.Parse(index123) + 1);
                    return MAKHOI;
                }
            }
            return "K001";
        }
        
        private void menuSaveKhoi_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(txtMakhoi.Text.Trim()))
            {
                var t = new KHOI
                {

                    MAKHOI = autoMa(),
                    TENKHOI = txtTenkhoi.Text.Trim(),
                    GHICHU = txtGhichu.Text.Trim()
                };
                data.KHOIs.Add(t);
                data.SaveChanges();
                getData();

                MessageBox.Show("Thêm dữ liệu Khối thành công");
            }
            else
            {
                //update
                var kh = data.KHOIs
                    .Where(x => x.MAKHOI == txtMakhoi.Text.Trim())
                    .FirstOrDefault();

                txtMakhoi.ReadOnly = true;
                kh.TENKHOI = txtTenkhoi.Text.Trim();
                kh.GHICHU = txtGhichu.Text.Trim();

                data.SaveChanges();
                getData();
                MessageBox.Show("Sửa thành công");
            }
        }

        private void Delete_Click_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có thực sự muốn xóa" + txtMakhoi.Text, "thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                //var s = data.BAIHOCs
                //         .Where(x => x.MABAIHOC == txtMabaihoc.Text.Trim())
                //         .FirstOrDefault();
                var kh = data.BAIHOCs.FirstOrDefault(x => x.MAKHOI.Contains(txtMakhoi.Text.Trim()));
                if (kh != null)
                {
                    MessageBox.Show("Môn học này đã có dữ liệu bên Bài học không xóa được");
                    return;
                }

                else
                {
                    var s = data.KHOIs.FirstOrDefault(x => x.MAKHOI.Contains(txtMakhoi.Text.Trim()));

                    data.KHOIs.Remove(s);
                    data.SaveChanges();
                    getData();
                    MessageBox.Show("Xóa thành công" , "Thông báo");
                    txtMakhoi.Clear();
                    txtTenkhoi.Clear();
                    txtGhichu.Clear();
                }
            }
        }

        private void Cancelmenu_Click(object sender, EventArgs e)
        {
            txtMakhoi.ReadOnly = false;
            btnDelete.Enabled = false;
            action = false;
            txtMakhoi.Clear();
            txtTenkhoi.Clear();
            txtGhichu.Clear();
        }

        private void frmKhoi1_Load(object sender, EventArgs e)
        {
            getData();
            init();

        }
        void init()
        {
            txtTenkhoi.Text = "";
            txtMakhoi.Text = "";
            txtMakhoi.ReadOnly = true;
            txtGhichu.Text = "";
            btnDelete.Enabled = false;

        }
        void getData()
        {
            data = new HoaMaiEntities4();
            List<KHOI> lst = data.KHOIs.ToList();

            int i = 0;
            var v = from t in lst
                    select new
                    {
                        No = ++i,
                        MAKHOI = t.MAKHOI,
                        TENKHOI = t.TENKHOI,
                        GHICHU = t.GHICHU
                    };
            gcKhoi.DataSource = v.ToList();
        }

        private void gvKhoi_RowCellClick(object sender, DevExpress.XtraGrid.Views.Grid.RowCellClickEventArgs e)
        {
            backDatatoKhoi(sender);
        }

        private void gvKhoi_RowClick(object sender, DevExpress.XtraGrid.Views.Grid.RowClickEventArgs e)
        {
            backDatatoKhoi(sender);
        }

        private void gvKhoi_KeyDown(object sender, KeyEventArgs e)
        {
            backDatatoKhoi(sender);
        }

        private void gvKhoi_KeyUp(object sender, KeyEventArgs e)
        {
            backDatatoKhoi(sender);
        }
        private void backDatatoKhoi(object sender)
        {
            GridView v = sender as GridView;
            try
            {
                txtMakhoi.Text = v.GetFocusedRowCellValue(colMaKhoi).ToString();
                txtTenkhoi.Text = v.GetFocusedRowCellValue(colTenKhoi).ToString();
                txtGhichu.Text = v.GetFocusedRowCellValue(colGhiChu).ToString();

                btnSave.Enabled = true;
                btnDelete.Enabled = true;
                btnCancel.Enabled = true;
            }
            catch { }
        }
    }
}