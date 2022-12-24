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
    public partial class frmMonhoc1 : DevExpress.XtraEditors.XtraForm
    {
        bool action;

        HoaMaiEntities4 data = new HoaMaiEntities4();

        public frmMonhoc1()
        {
            InitializeComponent();
        }


        private void frmMonhoc1_Load(object sender, EventArgs e)
        {
            init();
            getData();
        }

        void init()
        {
            action = false; //insert 

            txtMamon.Text = "";
            txtMamon.ReadOnly = true;

            txtTenmon.Text = "";

            btnDelete.Enabled = false;
        }

        void getData()
        {

            List<MONHOC> lstMONHOC = data.MONHOCs.ToList();
            int i = 0;
            var v = from t in lstMONHOC
                    select new
                    {
                        No = ++i,
                        MAMON = t.MAMON,
                        TENMON = t.TENMON
                    };
            gcMonHoc.DataSource = v.ToList();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(txtMamon.Text.Trim()))
            {
                var monhoc = new MONHOC
                {
                    MAMON = autoMa(),
                    TENMON = txtTenmon.Text.Trim()
                };
                data.MONHOCs.Add(monhoc);
                data.SaveChanges();
                getData();

                MessageBox.Show("Thêm dữ liệu Môn thành công");

                action = false;

                txtTenmon.Clear();
            }
            else
            {
                var monhoc = data.MONHOCs
                    .Where(x => x.MAMON == txtMamon.Text.Trim())
                    .FirstOrDefault();

                monhoc.TENMON = txtTenmon.Text.Trim();

                data.SaveChanges();
                getData();

                MessageBox.Show("Sửa thành công");
            }
        }

        private string autoMa()
        {
            int numberofRows = data.MONHOCs.Count();

            if (numberofRows > 0)
            {
                string maMONHOCLastRow = data.MONHOCs
                    .OrderByDescending(x => x.MAMON)
                    .Select(y => y.MAMON)
                    .FirstOrDefault();

                char[] MAMONHOCLastRow = maMONHOCLastRow.ToArray(); //ex {'M','0','0','1'}

                if (int.Parse(MAMONHOCLastRow[1].ToString()) == 0)
                {
                    if (int.Parse(MAMONHOCLastRow[2].ToString()) == 0)
                    {
                        if (int.Parse(MAMONHOCLastRow[3].ToString()) == 9)
                        {
                            return "M010";
                        }
                        else if (int.Parse(MAMONHOCLastRow[3].ToString()) <= 8)
                        {
                            string index3 = MAMONHOCLastRow[3].ToString();
                            string MAMON = "M00" + (int.Parse(index3) + 1);
                            return MAMON;
                        }
                    }
                    else if (int.Parse(MAMONHOCLastRow[2].ToString()) > 0)
                    {
                        string idex2 = MAMONHOCLastRow[2].ToString();
                        string idex3 = MAMONHOCLastRow[3].ToString();
                        string index23 = idex2 + idex3;

                        string MAMON = "M0" + (int.Parse(index23) + 1);
                        return MAMON;
                    }
                }
                else if (int.Parse(MAMONHOCLastRow[1].ToString()) > 0)
                {
                    string index1 = MAMONHOCLastRow[1].ToString();
                    string index2 = MAMONHOCLastRow[2].ToString();
                    string index3 = MAMONHOCLastRow[3].ToString();
                    string index123 = index1 + index2 + index3;

                    string MAMON = "M" + (int.Parse(index123) + 1);
                    return MAMON;
                }
            }
            return "M001";
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có thực sự muốn xóa" + txtMamon.Text, "thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                var monhoc_baihoc = data.BAIHOCs.FirstOrDefault(x => x.MAMON.Contains(txtMamon.Text.Trim()));
                if (monhoc_baihoc != null)
                {
                    MessageBox.Show("Môn học này có liên kết với bài học nên không thể xóa");
                }
                else
                {
                    var s = data.MONHOCs.FirstOrDefault(x => x.MAMON.Contains(txtMamon.Text.Trim()));

                    data.MONHOCs.Remove(s);
                    data.SaveChanges();
                    getData();

                    MessageBox.Show("Xóa thành công" + txtMamon.Text, "Thông báo");

                    action = false;
                    txtMamon.Clear();
                    txtTenmon.Clear();
                }
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            action = false;

            btnDelete.Enabled = false;

            txtMamon.Clear();
            txtTenmon.Clear();
        }

        private void gvMonhoc_KeyUp(object sender, KeyEventArgs e)
        {
            backDatatoMonhoc(sender);
        }

        private void gvMonhoc_KeyDown(object sender, KeyEventArgs e)
        {
            backDatatoMonhoc(sender);
        }

        private void gvMonhoc_RowCellClick(object sender, DevExpress.XtraGrid.Views.Grid.RowCellClickEventArgs e)
        {
            backDatatoMonhoc(sender);
        }

        private void gvMonhoc_RowClick(object sender, DevExpress.XtraGrid.Views.Grid.RowClickEventArgs e)
        {
            backDatatoMonhoc(sender);
        }

        private void backDatatoMonhoc(object sender)
        {
            GridView v = sender as GridView;
            try
            {
                txtMamon.Text = v.GetFocusedRowCellValue(colMaMon).ToString();
                txtTenmon.Text = v.GetFocusedRowCellValue(colTenMon).ToString();

                btnSave.Enabled = true;
                btnDelete.Enabled = true;
                btnCancel.Enabled = true;
            }
            catch { }
        }
    }
}