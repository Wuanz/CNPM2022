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
        bool action = false;//insert
        HoaMaiEntities4 data = new HoaMaiEntities4();
        public frmMonhoc1()
        {
            InitializeComponent();
        }
        private string autoMa()
        {
            int numberofRows = data.MONHOCs.Count();

            if (numberofRows > 0)
            {
                string maMONLastRow = data.MONHOCs
                    .OrderByDescending(x => x.MAMON)
                    .Select(y => y.MAMON)
                    .FirstOrDefault();

                char[] MAMONLastRow = maMONLastRow.ToArray(); //ex {'M','0','0','1'}

                if (int.Parse(MAMONLastRow[1].ToString()) == 0)
                {
                    if (int.Parse(MAMONLastRow[2].ToString()) == 0)
                    {
                        if (int.Parse(MAMONLastRow[3].ToString()) == 9)
                        {
                            return "M010";
                        }
                        else if (int.Parse(MAMONLastRow[3].ToString()) <= 8)
                        {
                            string index3 = MAMONLastRow[3].ToString();
                            string MAMON = "M00" + (int.Parse(index3) + 1);
                            return MAMON;
                        }
                    }
                    else if (int.Parse(MAMONLastRow[2].ToString()) > 0)
                    {
                        string idex2 = MAMONLastRow[2].ToString();
                        string idex3 = MAMONLastRow[3].ToString();
                        string index23 = idex2 + idex3;

                        string MAMON = "M0" + (int.Parse(index23) + 1);
                        return MAMON;
                    }
                }
                else if (int.Parse(MAMONLastRow[1].ToString()) > 0)
                {
                    string index1 = MAMONLastRow[1].ToString();
                    string index2 = MAMONLastRow[2].ToString();
                    string index3 = MAMONLastRow[3].ToString();
                    string index123 = index1 + index2 + index3;

                    string MAMON = "M" + (int.Parse(index123) + 1);
                    return MAMON;
                }
            }
            return "M001";
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(txtMamon.Text.Trim()))
            {
                var g = new MONHOC
                {
                    MAMON = autoMa(),
                    TENMON = txtTenmon.Text.Trim()

                };
                data.MONHOCs.Add(g);
                data.SaveChanges();
                getData();
                MessageBox.Show("Thêm dữ liệu Môn thành công");
            }
            else
            {
                var mh = data.MONHOCs
               .Where(x => x.MAMON == txtMamon.Text.Trim())
               .FirstOrDefault();

                txtMamon.ReadOnly = true;
                mh.TENMON = txtTenmon.Text.Trim();

                var s = data.MONHOCs
                       .Where(x => x.MAMON == txtMamon.Text.Trim())
                       .FirstOrDefault();
                data.SaveChanges();
                getData();
                MessageBox.Show("Sửa thành công");

            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có thực sự muốn xóa" + txtMamon.Text, "thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {

                var kh = data.BAIHOCs.FirstOrDefault(x => x.MAMON.Contains(txtMamon.Text.Trim()));
                if (kh != null)
                {
                    MessageBox.Show("Dữ liệu này có liên kết với bài học nên không thể xóa");
                }
                else
                {
                    var s = data.MONHOCs.FirstOrDefault(x => x.MAMON.Contains(txtMamon.Text.Trim()));

                    data.MONHOCs.Remove(s);
                    data.SaveChanges();
                    getData();
                    MessageBox.Show("Xóa thành công" + txtMamon.Text, "Thông báo");
                    txtMamon.Clear();
                    txtTenmon.Clear();
                }
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            txtMamon.ReadOnly = false;
            btnDelete.Enabled = false;
            action = false;
            txtMamon.Clear();
            txtTenmon.Clear();

        
        }
        void init()
        {
            txtMamon.Text = "";
            txtTenmon.Text = "";
            txtMamon.ReadOnly = true;
  
            btnDelete.Enabled = false;
        }

        private void frmMonhoc1_Load(object sender, EventArgs e)
        {
            getData();
            init();
        }
        void getData()
        {

            List<MONHOC> lst = data.MONHOCs.ToList();
            int i = 0;
            var v = from t in lst
                    select new
                    {
                        No = ++i,
                        MAMON = t.MAMON,
                        TENMON = t.TENMON
                    };
            gcMonHoc.DataSource = v.ToList();
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