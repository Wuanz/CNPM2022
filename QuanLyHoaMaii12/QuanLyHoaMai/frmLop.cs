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
    
    public partial class frmLop : Form
    {
        bool action = false;//insert
        HoaMaiEntities4 data = new HoaMaiEntities4();
        public frmLop()
        {
            InitializeComponent();
        }

       

        private void menuSaveLop_Click(object sender, EventArgs e)
        {
            if (action == false)
            {
                var g = new LOP
                {
                    MALOP = txtMalop.Text.Trim(),
                    TENLOP = txtTenlop.Text.Trim(),
                    GIAOVIENPHUTRACH = txtGiaovienphutrach.Text.Trim()

                };
                data.LOPs.Add(g);
                data.SaveChanges();
                getData();
            } 
            else
            {
                var lp = data.LOPs
               .Where(x => x.MALOP == txtMalop.Text.Trim())
               .FirstOrDefault();

                lp.MALOP = txtMalop.Text.Trim();
                lp.TENLOP = txtTenlop.Text.Trim();
                lp.GIAOVIENPHUTRACH = txtGiaovienphutrach.Text.Trim();

                var s = data.LOPs
                       .Where(x => x.MALOP == txtMalop.Text.Trim())
                       .FirstOrDefault();
                data.SaveChanges();
                getData();

            }
            }
      
        

        private void frmLop_Load(object sender, EventArgs e)
        {
            getData();
            init();



        }

        void init()
        {
            Delete_Click.Enabled = false;
        }

        void getData()
        {
            List<LOP> lst = data.LOPs.ToList();
            int i = 0;
            var v = from t in lst
                    select new
                    {
                        No = ++i,
                        Malop = t.MALOP,
                        Tenlop = t.TENLOP,
                        Giaovienphutrach = t.GIAOVIENPHUTRACH
                    };
            dgLop.DataSource = v.ToList();
        }

        private void dgLop_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow r = dgLop.Rows[e.RowIndex];
                txtMalop.Text = r.Cells[1].Value.ToString();
                txtTenlop.Text = r.Cells[2].Value.ToString();
                txtGiaovienphutrach.Text = r.Cells[3].Value.ToString();

                action = true;
                txtMalop.ReadOnly = true;
                Delete_Click.Enabled = true;

            }
        }

        private void Delete_Click_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure?", "Message", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {

                var kh = data.THOIKHOABIEUx.FirstOrDefault(x => x.MALOP.Contains(txtMalop.Text.Trim()));
                if (kh != null)
                {
                    MessageBox.Show("Dữ liệu này có liên kết với TKB nên không thể xóa");
                }
                else
                {
                    var s = data.LOPs.FirstOrDefault(x => x.MALOP.Contains(txtMalop.Text.Trim()));

                    data.LOPs.Remove(s);
                    data.SaveChanges();
                    getData();
                }
            }
        }

        private void Cancelmenu_Click(object sender, EventArgs e)
        {
            txtMalop.ReadOnly = false;
            Delete_Click.Enabled = false;
            action = false;
            txtMalop.Clear();
            txtTenlop.Clear();
            txtGiaovienphutrach.Clear();
        }
    }
}
