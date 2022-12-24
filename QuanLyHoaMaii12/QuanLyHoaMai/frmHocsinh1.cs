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
    public partial class frmHocsinh1 : DevExpress.XtraEditors.XtraForm
    {
        bool action;

        HoaMaiEntities4 data = new HoaMaiEntities4();

        public frmHocsinh1()
        {
            InitializeComponent();
        }

        private void frmHocsinh1_Load(object sender, EventArgs e)
        {
            init();
            getData();
        }

        void init()
        {
            action = false;

            txtMahocsinh1.Text = "";
            txtMahocsinh1.ReadOnly = true;

            txtTenhocsinh1.Text = "";

            List<string> diem = new List<string>();
            diem.Add("1");
            diem.Add("2");
            diem.Add("3");
            diem.Add("4");
            diem.Add("5");
            diem.Add("6");
            diem.Add("7");
            diem.Add("8");
            diem.Add("9");
            diem.Add("10");
            cbDiem.Properties.Items.AddRange(diem);
            cbDiem.SelectedIndex = 0;

            gvHocsinh.Columns[0].Caption = "Mã học sinh";
            gvHocsinh.Columns[1].Caption = "Tên học sinh";
            gvHocsinh.Columns[2].Caption = "Điểm";

            btnSave.Enabled = true;
            btnCancel.Enabled = true;
            btnDelete.Enabled = false;
        }

        void getData()
        {
            List<HOCSINH> lstHOCSINH = data.HOCSINHs.ToList();
            //int i = 0;
            var v = from t in lstHOCSINH
                    select new
                    {
                       //No = ++i,
                        MAHOCSINH = t.MAHOCSINH,
                        TENHOCSINH = t.TENHOCSINH,
                        DIEM = t.DIEM
                    };
            gcHocsinh.DataSource = v.ToList();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(txtMahocsinh1.Text.Trim()))
            { //insert
                var hocsinh = new HOCSINH
                {
                    MAHOCSINH = autoMa(),
                    TENHOCSINH = txtTenhocsinh1.Text.Trim(),
                    DIEM = int.Parse(cbDiem.Text),
                };
                data.HOCSINHs.Add(hocsinh);
                data.SaveChanges();
                getData();
                MessageBox.Show("Thêm dữ liệu HỌC SINH thành công");
            }
            else
            { //update

                var hocsinh = data.HOCSINHs
                    .Where(x => x.MAHOCSINH == txtMahocsinh1.Text.Trim())
                    .FirstOrDefault();
                hocsinh.TENHOCSINH = txtTenhocsinh1.Text.Trim();
                hocsinh.DIEM = int.Parse(cbDiem.Text);
                data.SaveChanges();
                getData();

                MessageBox.Show("Sửa thành công");
            }
        }

        private string autoMa()
        {
            int numberofRows = data.HOCSINHs.Count();

            if (numberofRows > 0)
            {
                string maHOCSINHLastRow = data.HOCSINHs
                    .OrderByDescending(x => x.MAHOCSINH)
                    .Select(y => y.MAHOCSINH)
                    .FirstOrDefault();

                char[] MAHOCSINHLastRow = maHOCSINHLastRow.ToArray(); //ex {'H','0','0','1'}

                if (int.Parse(MAHOCSINHLastRow[1].ToString()) == 0)
                {
                    if (int.Parse(MAHOCSINHLastRow[2].ToString()) == 0)
                    {
                        if (int.Parse(MAHOCSINHLastRow[3].ToString()) == 9)
                        {
                            return "H010";
                        }
                        else if (int.Parse(MAHOCSINHLastRow[3].ToString()) <= 8)
                        {
                            string index3 = MAHOCSINHLastRow[3].ToString();
                            string MABAIHOC = "H00" + (int.Parse(index3) + 1);
                            return MABAIHOC;
                        }
                    }
                    else if (int.Parse(MAHOCSINHLastRow[2].ToString()) > 0)
                    {
                        string idex2 = MAHOCSINHLastRow[2].ToString();
                        string idex3 = MAHOCSINHLastRow[3].ToString();
                        string index23 = idex2 + idex3;

                        string MAHOCSINH = "H0" + (int.Parse(index23) + 1);
                        return MAHOCSINH;
                    }
                }
                else if (int.Parse(MAHOCSINHLastRow[1].ToString()) > 0)
                {
                    string index1 = MAHOCSINHLastRow[1].ToString();
                    string index2 = MAHOCSINHLastRow[2].ToString();
                    string index3 = MAHOCSINHLastRow[3].ToString();
                    string index123 = index1 + index2 + index3;

                    string MAHOCSINH = "H" + (int.Parse(index123) + 1);
                    return MAHOCSINH;
                }
            }
            return "H001";
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có thực sự muốn xóa" + txtMahocsinh1.Text, "thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                var hocsinh = data.HOCSINHs.FirstOrDefault(x => x.MAHOCSINH.Contains(txtMahocsinh1.Text.Trim()));
                data.HOCSINHs.Remove(hocsinh);
                data.SaveChanges();
                getData();

                MessageBox.Show("Xóa thành công" + txtMahocsinh1.Text, "Thông báo");

                action = true;

                txtMahocsinh1.Clear();
                txtTenhocsinh1.Clear();
                cbDiem.SelectedIndex = 0;
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            action = false;
            btnDelete.Enabled = false;

            txtMahocsinh1.Clear();
            txtTenhocsinh1.Clear();
            cbDiem.SelectedIndex = 0;
        }

        private void gvHocsinh_RowClick(object sender, DevExpress.XtraGrid.Views.Grid.RowClickEventArgs e)
        {
            backDatatoHocsinh(sender);
        }

        private void gvHocsinh_RowCellClick(object sender, DevExpress.XtraGrid.Views.Grid.RowCellClickEventArgs e)
        {
            backDatatoHocsinh(sender);
        }

        private void gvHocsinh_KeyUp(object sender, KeyEventArgs e)
        {
            backDatatoHocsinh(sender);
        }

        private void gvHocsinh_KeyDown(object sender, KeyEventArgs e)
        {
            backDatatoHocsinh(sender);
        }

        private void backDatatoHocsinh(object sender)
        {
            GridView v = sender as GridView;
            try
            {
                txtMahocsinh1.Text = v.GetFocusedRowCellValue(colMAHOCSINH).ToString();
                txtTenhocsinh1.Text = v.GetFocusedRowCellValue(colTENHOCSINH).ToString();
                cbDiem.SelectedIndex = findIndex(v.GetFocusedRowCellValue(colDIEM).ToString());

                btnSave.Enabled = true;
                btnDelete.Enabled = true;
                btnCancel.Enabled = true;
            }
            catch { }
        }

        private int findIndex(string diem)
        {
            return (int.Parse(diem) - 1);
        }
    }
}