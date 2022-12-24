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
    public partial class frmBaihoc1 : DevExpress.XtraEditors.XtraForm
    {
        bool action;

        HoaMaiEntities4 data = new HoaMaiEntities4();

        public frmBaihoc1()
        {
            InitializeComponent();
        }

        private void frmBaihoc1_Load(object sender, EventArgs e)
        {
            init();
            getData();
        }

        void init()
        {
            action = false; //insert

            txtMabaihoc.Text = "";
            txtMabaihoc.ReadOnly = true;

            txtTenbaihoc.Text = "";

            List<string> sotiet = new List<string>();
            sotiet.Add("1");
            sotiet.Add("2");
            sotiet.Add("3");
            sotiet.Add("4");
            sotiet.Add("5");
            sotiet.Add("6");
            cbSoTiet.Properties.Items.AddRange(sotiet);
            cbSoTiet.SelectedIndex = 0;

            txtDungcu.Text = "";

            List<KHOI> lstKHOI = data.KHOIs.ToList();
            var colkhoi = from t in lstKHOI
                          select new
                          {
                              MAKHOI = t.MAKHOI,
                              TENKHOI = t.TENKHOI,
                              GHICHU = t.GHICHU
                          };
            lkMakhoi.Properties.DataSource = colkhoi.ToList();
            lkMakhoi.Properties.DisplayMember = "TENKHOI";
            lkMakhoi.Properties.ValueMember = "MAKHOI";
            lkMakhoi.EditValue = "K1";


            List<MONHOC> lstMONHOC = data.MONHOCs.ToList();
            var colmonhoc = from t in lstMONHOC
                            select new
                            {
                                MAMON = t.MAMON,
                                TENMON = t.TENMON
                            };
            lkMamon.Properties.DataSource = colmonhoc.ToList();
            lkMamon.Properties.DisplayMember = "TENMON";
            lkMamon.Properties.ValueMember = "MAMON";
            lkMamon.EditValue = "M1";

            btnSave.Enabled = true;
            btnCancel.Enabled = true;
            btnDelete.Enabled = false;
        }

        void getData()
        {
            List<BAIHOC> lst = data.BAIHOCs.ToList();
            int i = 0;
            var v = from t in lst
                    select new
                    {
                        No = ++i,
                        TENBAIHOC = t.TENBAIHOC,
                        MABAIHOC = t.MABAIHOC,
                        TENMON = t.MONHOC.TENMON,
                        TENKHOI = t.KHOI.TENKHOI,
                        MAKHOI = t.KHOI.MAKHOI,
                        SOTIET = t.SOTIET,
                        DUNGCU = t.YEUCAUVEDUNGCU,
                        MAMON = t.MONHOC.MAMON
                    };
            gcBaiHoc.DataSource = v.ToList();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(txtMabaihoc.Text.Trim()))
            { //insert

                var baihoc = new BAIHOC
                {
                    MABAIHOC = autoMa(),
                    TENBAIHOC = txtTenbaihoc.Text.Trim(),
                    SOTIET = int.Parse(cbSoTiet.Text),
                    YEUCAUVEDUNGCU = txtDungcu.Text.Trim(),
                    MAKHOI = lkMakhoi.EditValue.ToString(),
                    MAMON = lkMamon.EditValue.ToString()
                };
                data.BAIHOCs.Add(baihoc);
                data.SaveChanges();
                getData();

                MessageBox.Show("Thêm dữ liệu BÀI HỌC thành công");
            }
            else
            { //update
                var baihoc = data.BAIHOCs
                    .Where(x => x.MABAIHOC == txtMabaihoc.Text.Trim())
                    .FirstOrDefault();

                baihoc.TENBAIHOC = txtTenbaihoc.Text.Trim();
                baihoc.SOTIET = int.Parse(cbSoTiet.Text);
                baihoc.YEUCAUVEDUNGCU = txtDungcu.Text.Trim();
                baihoc.MAKHOI = lkMakhoi.EditValue.ToString();
                baihoc.MAMON = lkMamon.EditValue.ToString();

                data.SaveChanges();
                getData();

                MessageBox.Show("Sửa thành công");
            }
        }

        private string autoMa()
        {
            int numberofRows = data.BAIHOCs.Count();

            if (numberofRows > 0)
            {
                string maBAIHOCLastRow = data.BAIHOCs
                    .OrderByDescending(x => x.MABAIHOC)
                    .Select(y => y.MABAIHOC)
                    .FirstOrDefault();

                char[] MABAIHOCLastRow = maBAIHOCLastRow.ToArray(); //ex {'B','0','0','1'}

                if (int.Parse(MABAIHOCLastRow[1].ToString()) == 0)
                {
                    if (int.Parse(MABAIHOCLastRow[2].ToString()) == 0)
                    {
                        if (int.Parse(MABAIHOCLastRow[3].ToString()) == 9)
                        {
                            return "B010";
                        }
                        else if (int.Parse(MABAIHOCLastRow[3].ToString()) <= 8)
                        {
                            string index3 = MABAIHOCLastRow[3].ToString();
                            string MABAIHOC = "B00" + (int.Parse(index3) + 1);
                            return MABAIHOC;
                        }
                    }
                    else if (int.Parse(MABAIHOCLastRow[2].ToString()) > 0)
                    {
                        string idex2 = MABAIHOCLastRow[2].ToString();
                        string idex3 = MABAIHOCLastRow[3].ToString();
                        string index23 = idex2 + idex3;

                        string MABAIHOC = "B0" + (int.Parse(index23) + 1);
                        return MABAIHOC;
                    }
                }
                else if (int.Parse(MABAIHOCLastRow[1].ToString()) > 0)
                {
                    string index1 = MABAIHOCLastRow[1].ToString();
                    string index2 = MABAIHOCLastRow[2].ToString();
                    string index3 = MABAIHOCLastRow[3].ToString();
                    string index123 = index1 + index2 + index3;

                    string MABAIHOC = "B" + (int.Parse(index123) + 1);
                    return MABAIHOC;
                }
            }
            return "B001";
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có thực sự muốn xóa" + txtMabaihoc.Text, "thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {

                var baihoc_thoikhoabieu = data.THOIKHOABIEUx.FirstOrDefault(x => x.MABAIHOC.Contains(txtMabaihoc.Text.Trim()));
                if (baihoc_thoikhoabieu != null)
                {
                    MessageBox.Show("Bài học này đã có liên kết THỜI KHÓA BIỂU nên không thể xóa");
                }
                else
                {
                    var baihoc = data.BAIHOCs.FirstOrDefault(x => x.MABAIHOC.Contains(txtMabaihoc.Text.Trim()));

                    data.BAIHOCs.Remove(baihoc);
                    data.SaveChanges();
                    getData();

                    MessageBox.Show("Xóa thành công" + txtMabaihoc.Text, "Thông báo");

                    action = true;

                    txtMabaihoc.Clear();
                    txtTenbaihoc.Clear();
                    cbSoTiet.SelectedIndex = 0;
                    txtDungcu.Clear();

                    lkMakhoi.EditValue = "K1";
                    lkMamon.EditValue = "M1";
                }
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            action = false;
            btnDelete.Enabled = false;

            txtMabaihoc.Clear();
            txtTenbaihoc.Clear();
            cbSoTiet.SelectedIndex = 0;
            txtDungcu.Clear();
            lkMakhoi.EditValue = "K1";
            lkMamon.EditValue = "M1";
        }

        private void gvBaihoc_KeyUp(object sender, KeyEventArgs e)
        {
            backDatatoBaihoc(sender);
        }

        private void gvBaihoc_KeyDown(object sender, KeyEventArgs e)
        {
            backDatatoBaihoc(sender);
        }

        private void gvBaihoc_RowCellClick(object sender, DevExpress.XtraGrid.Views.Grid.RowCellClickEventArgs e)
        {
            backDatatoBaihoc(sender);
        }

        private void gvBaihoc_RowClick(object sender, DevExpress.XtraGrid.Views.Grid.RowClickEventArgs e)
        {
            backDatatoBaihoc(sender);
        }

        private void backDatatoBaihoc(object sender)
        {
            GridView v = sender as GridView;
            try
            {
                txtMabaihoc.Text = v.GetFocusedRowCellValue(colMaBaiHoc).ToString();
                txtTenbaihoc.Text = v.GetFocusedRowCellValue(colTenBaiHoc).ToString();
                cbSoTiet.SelectedText = v.GetFocusedRowCellValue(colSoTiet).ToString();
                txtDungcu.Text = v.GetFocusedRowCellValue(colDungCu).ToString();
                lkMakhoi.EditValue = v.GetFocusedRowCellValue(colMaKhoi).ToString();
                lkMamon.EditValue = v.GetFocusedRowCellValue(colMaMon).ToString();

                btnSave.Enabled = true;
                btnDelete.Enabled = true;
                btnCancel.Enabled = true;
            }
            catch { }
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void txtTenbaihoc_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtMabaihoc_TextChanged(object sender, EventArgs e)
        {

        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }
    }
}