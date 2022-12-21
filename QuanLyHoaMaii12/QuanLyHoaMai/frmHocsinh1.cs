using DevExpress.XtraEditors;
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
        bool action = false;//insert
        HoaMaiEntities4 data = new HoaMaiEntities4();
        public frmHocsinh1()
        {
            InitializeComponent();
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

                char[] MAHOCSINHLastRow = maHOCSINHLastRow.ToArray(); //ex {'M','0','0','1'}

                if (int.Parse(MAHOCSINHLastRow[1].ToString()) == 0)
                {
                    if (int.Parse(MAHOCSINHLastRow[2].ToString()) == 0)
                    {
                        if (int.Parse(MAHOCSINHLastRow[3].ToString()) == 9)
                        {
                            return "M010";
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

                        string MAHOCSINH = "M0" + (int.Parse(index23) + 1);
                        return MAHOCSINH;
                    }
                }
                else if (int.Parse(MAHOCSINHLastRow[1].ToString()) > 0)
                {
                    string index1 = MAHOCSINHLastRow[1].ToString();
                    string index2 = MAHOCSINHLastRow[2].ToString();
                    string index3 = MAHOCSINHLastRow[3].ToString();
                    string index123 = index1 + index2 + index3;

                    string MAHOCSINH = "B" + (int.Parse(index123) + 1);
                    return MAHOCSINH;
                }
            }
            return "H001";
        }
        //private void btnDelete_Click(object sender, EventArgs e)
        //{
        //    if (MessageBox.Show("Bạn có thực sự muốn xóa" + txtMahocsinh1.Text, "thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
        //    {

        //        var kh = data.HOCSINHs.FirstOrDefault(x => x.MAMON.Contains(txtMamon.Text.Trim()));
        //        if (kh != null)
        //        {
        //            MessageBox.Show("Dữ liệu này có liên kết với bài học nên không thể xóa");
        //        }
        //        else
        //        {
        //            var s = data.MONHOCs.FirstOrDefault(x => x.MAMON.Contains(txtMamon.Text.Trim()));

        //            data.MONHOCs.Remove(s);
        //            data.SaveChanges();
        //            getData();
        //            MessageBox.Show("Xóa thành công" + txtMamon.Text, "Thông báo");
        //            txtMamon.Clear();
        //            txtTenmon.Clear();
        //        }
        //    }
        //}
        private void btnSave_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(txtTenhocsinh1.Text.Trim()))
            {

                // insert
                var t = new HOCSINH
                {

                    TENHOCSINH = txtMahocsinh1.Text.Trim(),
                    MAHOCSINH = autoMa(),

                   
                    DIEM = int.Parse(cbDiem.Text),
                    
                };
                data.HOCSINHs.Add(t);
                data.SaveChanges();
                getData();
                MessageBox.Show("Thêm dữ liệu HỌC SINH thành công");
            }
            else
            {
                //update
                var bh = data.HOCSINHs
                    .Where(x => x.MAHOCSINH == txtMahocsinh1.Text.Trim())
                    .FirstOrDefault();
                bh.TENHOCSINH = txtTenhocsinh1.Text.Trim();
                txtMahocsinh1.ReadOnly = true;
               
                bh.DIEM = int.Parse(cbDiem.Text);
                
                data.SaveChanges();
                getData();
                var s = data.BAIHOCs
                       .Where(x => x.MABAIHOC == txtTenhocsinh1.Text.Trim())
                       .FirstOrDefault();


                data.SaveChanges();
                getData();
                MessageBox.Show("Sửa thành công");
            }
        }
        private void btnCancel_Click(object sender, EventArgs e)
        {
            txtMahocsinh1.ReadOnly = false;
            btnDelete.Enabled = false;
            action = false;
            txtTenhocsinh1.Clear();
            cbDiem.SelectedIndex = 0;


        }
         void init()
        {
            txtMahocsinh1.Text = "";
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

    
            btnSave.Enabled = true;
            btnCancel.Enabled = true;
            btnDelete.Enabled = true;
        }
        void getData()
        {

            List<HOCSINH> lst = data.HOCSINHs.ToList();
            int i = 0;
            var v = from t in lst
                    select new
                    {
                        No = ++i,
                        MAHOCSINH = t.MAHOCSINH,
                        TENHOCSINH = t.TENHOCSINH,
                        DIEM = t.DIEM
                    };
            //gcHocsinh.DataSource = v.ToList();
        }
        private void frmHocsinh1_Load(object sender, EventArgs e)
        {
            getData();
            init();
        }

    }
}