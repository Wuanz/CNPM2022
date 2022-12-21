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
        bool action = false;//insert
        HoaMaiEntities4 data = new HoaMaiEntities4();
        public frmBaihoc1()
        {
            InitializeComponent();
        }
        private string autoMa()
        {
            int numberofRows = data.MONHOCs.Count();

            if (numberofRows > 0)
            {
                string maBAIHOCLastRow = data.BAIHOCs
                    .OrderByDescending(x => x.MABAIHOC)
                    .Select(y => y.MABAIHOC)
                    .FirstOrDefault();

                char[] MABAIHOCLastRow = maBAIHOCLastRow.ToArray(); //ex {'M','0','0','1'}

                if (int.Parse(MABAIHOCLastRow[1].ToString()) == 0)
                {
                    if (int.Parse(MABAIHOCLastRow[2].ToString()) == 0)
                    {
                        if (int.Parse(MABAIHOCLastRow[3].ToString()) == 9)
                        {
                            return "M010";
                        }
                        else if (int.Parse(MABAIHOCLastRow[3].ToString()) <= 8)
                        {
                            string index3 = MABAIHOCLastRow[3].ToString();
                            string MABAIHOC = "M00" + (int.Parse(index3) + 1);
                            return MABAIHOC;
                        }
                    }
                    else if (int.Parse(MABAIHOCLastRow[2].ToString()) > 0)
                    {
                        string idex2 = MABAIHOCLastRow[2].ToString();
                        string idex3 = MABAIHOCLastRow[3].ToString();
                        string index23 = idex2 + idex3;

                        string MABAIHOC = "M0" + (int.Parse(index23) + 1);
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
        //private string autoMa()
        //{
        //    string mabandau = data.BAIHOCs.OrderByDescending(x => x.MABAIHOC)
        //        .Select(y => y.MABAIHOC)
        //        .FirstOrDefault();

        //    string so = mabandau.Substring(1, mabandau.Length - 1);
        //    int somoi = Int32.Parse(so) + 1;
        //    string mamoi = "B" + somoi;
        //    return mamoi;
       

        //}

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(txtMabaihoc.Text.Trim()))
            {
             
                // insert
                var t = new BAIHOC
                {
                    TENBAIHOC = txtTenbaihoc.Text.Trim(),
                    MABAIHOC = autoMa(),
                   
                    MAKHOI = lkMakhoi.EditValue.ToString(),
                    SOTIET = int.Parse(cbSoTiet.Text),
                    YEUCAUVEDUNGCU = txtDungcu.Text.Trim(),
                    MAMON = lkMamon.EditValue.ToString()
                };
                data.BAIHOCs.Add(t);
                data.SaveChanges();
                getData();
                MessageBox.Show("Thêm dữ liệu BÀI HỌC thành công");
            }
            else
            {
                //update
                var bh = data.BAIHOCs
                    .Where(x => x.MABAIHOC == txtMabaihoc.Text.Trim())
                    .FirstOrDefault();
                bh.TENBAIHOC = txtTenbaihoc.Text.Trim();
                txtMabaihoc.ReadOnly = true;
                bh.MAKHOI = lkMakhoi.EditValue.ToString();
                bh.SOTIET = int.Parse(cbSoTiet.Text);
                bh.YEUCAUVEDUNGCU = txtDungcu.Text.Trim();
                bh.MAMON = lkMamon.EditValue.ToString();
                data.SaveChanges();
                getData();
                var s = data.BAIHOCs
                       .Where(x => x.MABAIHOC == txtMabaihoc.Text.Trim())
                       .FirstOrDefault();


                data.SaveChanges();
                getData();
                MessageBox.Show("Sửa thành công");
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có thực sự muốn xóa"+ txtMabaihoc.Text, "thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {

                var kh = data.THOIKHOABIEUx.FirstOrDefault(x => x.MABAIHOC.Contains(txtMabaihoc.Text.Trim()));
                if (kh != null)
                {
                    MessageBox.Show("Dữ liệu này có liên kết TKB nên không thể xóa");
                }
                else
                {
                    var s = data.BAIHOCs.FirstOrDefault(x => x.MABAIHOC.Contains(txtMabaihoc.Text.Trim()));

                    data.BAIHOCs.Remove(s);
                    data.SaveChanges();
                    getData();
                    MessageBox.Show("Xóa thành công" + txtMabaihoc.Text, "Thông báo");
                    txtMabaihoc.Clear();
                    txtDungcu.Clear();
                    txtTenbaihoc.Clear();

                    cbSoTiet.SelectedIndex = 0;
                    lkMakhoi.EditValue = "K1";
                    lkMamon.EditValue = "M1";


                }
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            txtMabaihoc.ReadOnly = false;
            btnDelete.Enabled = false;
            action = false;
            txtMabaihoc.Clear();
            txtDungcu.Clear();
            txtTenbaihoc.Clear();
            cbSoTiet.SelectedIndex = 0;
            lkMakhoi.EditValue = "K1";
            lkMamon.EditValue = "M1";


        }

        private void frmBaihoc1_Load(object sender, EventArgs e)
        {
            getData();
            init();
        }

        void init()
        {
            txtMabaihoc.ReadOnly = true;

            List<string> sotiet = new List<string>();
            sotiet.Add("1");
            sotiet.Add("2");
            sotiet.Add("3");
            sotiet.Add("4");
            sotiet.Add("5");
            sotiet.Add("6");
            cbSoTiet.Properties.Items.AddRange(sotiet);
            cbSoTiet.SelectedIndex = 0;



            List<MONHOC> lst = data.MONHOCs.ToList();
            var colmonhoc = from t in lst
                            select new
                            {
                                MAMON = t.MAMON,
                                TENMON = t.TENMON
                               

                            };
            lkMamon.Properties.DataSource = colmonhoc.ToList();
            lkMamon.Properties.DisplayMember = "TENMON";
            lkMamon.Properties.ValueMember = "MAMON";

            


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
            
            cbSoTiet.SelectedIndex = 0;
            lkMakhoi.EditValue = "K1";
            lkMamon.EditValue = "M1";
            
            btnSave.Enabled = true;
            btnCancel.Enabled = true;
            btnDelete.Enabled = true;
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
                lkMakhoi.EditValue = v.GetFocusedRowCellValue(colMaKhoi).ToString();
                lkMamon.EditValue = v.GetFocusedRowCellValue(colMaMon).ToString();
                txtDungcu.Text = v.GetFocusedRowCellValue(colDungCu).ToString();
                cbSoTiet.SelectedText = v.GetFocusedRowCellValue(colSoTiet).ToString();
                txtMabaihoc.Text = v.GetFocusedRowCellValue(colMaBaiHoc).ToString();
                txtTenbaihoc.Text = v.GetFocusedRowCellValue(colTenBaiHoc).ToString();

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