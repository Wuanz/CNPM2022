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
    public partial class frmMonhoc : Form
    {
        bool action = false;//insert
        HoaMaiEntities4 data = new HoaMaiEntities4();
        public frmMonhoc()
        {
            InitializeComponent();
        }

        void init()
        {
            Delete_Click.Enabled = false;
        }
        private void frmMonhoc_Load(object sender, EventArgs e)
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
                        Mamon = t.MAMON,
                        TenMon = t.TENMON
                    };
            dgMon.DataSource = v.ToList();
        }

        private void menuSave_Click(object sender, EventArgs e)
        {
            if (action == false)
            {
                var g = new MONHOC
                {
                    MAMON = txtMamon.Text.Trim(),
                    TENMON = txtTenmon.Text.Trim()

                };
                data.MONHOCs.Add(g);
                data.SaveChanges();
                getData();
            }
            else
            {
                var mh = data.MONHOCs
               .Where(x => x.MAMON == txtMamon.Text.Trim())
               .FirstOrDefault();

                mh.MAMON = txtMamon.Text.Trim();
                mh.TENMON = txtTenmon.Text.Trim();

                var s = data.MONHOCs
                       .Where(x => x.MAMON == txtMamon.Text.Trim())
                       .FirstOrDefault();
                data.SaveChanges();
                getData();

            }
       
        }

        private void dgMon_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow r = dgMon.Rows[e.RowIndex];
                txtMamon.Text = r.Cells[1].Value.ToString();
                txtTenmon.Text = r.Cells[2].Value.ToString();

                action = true;
                txtMamon.ReadOnly = true;
                Delete_Click.Enabled = true;

            }
        }

        private void Delete_Click_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure?", "Message", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
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
                }
            }
        }

        private void Cancelmenu_Click(object sender, EventArgs e)
        {
            txtMamon.ReadOnly = false;
            Delete_Click.Enabled = false;
            txtMamon.Clear();
            txtTenmon.Clear();
            
        }
    } 

}