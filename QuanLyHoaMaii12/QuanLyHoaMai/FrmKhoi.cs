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

    public partial class FrmKhoi : Form
    {
        bool action = false;//insert
        HoaMaiEntities4 data = new HoaMaiEntities4();
        public FrmKhoi()
        {
            InitializeComponent();
        }


        private void menuSaveKhoi_Click(object sender, EventArgs e)
        {
            if (action == false)
            {
                var t = new KHOI
                {

                    MAKHOI = txtMakhoi.Text.Trim(),
                    TENKHOI = txtTenkhoi.Text.Trim(),
                    GHICHU = txtGhichu.Text.Trim()
                };
                data.KHOIs.Add(t);
                data.SaveChanges();
                getData();
            }
            else
            {
                //update
                var kh = data.KHOIs
                    .Where(x => x.MAKHOI == txtMakhoi.Text.Trim())
                    .FirstOrDefault();

                kh.MAKHOI = txtMakhoi.Text.Trim();
                kh.TENKHOI = txtTenkhoi.Text.Trim();
                kh.GHICHU = txtGhichu.Text.Trim();
                data.SaveChanges();
                getData();

                var s = data.KHOIs
                       .Where(x => x.MAKHOI == txtMakhoi.Text.Trim())
                       .FirstOrDefault();
                data.SaveChanges();
                getData();
            }
            }

        private void FrmKhoi_Load(object sender, EventArgs e)
        {
            getData();
            init();

            
        }
        void init() {
            Delete_Click.Enabled = false;
        }
        void getData()
        {
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
            dgKhoi.DataSource = v.ToList();
        }
        
        private void Delete_Click_Click(object sender, EventArgs e)
        {
            //data = new HoaMaiEntities4();
            //if (MessageBox.Show("Are you sure?", "Message", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes) {
            //    var s = (from t in data.KHOIs
            //             where t.MAKHOI == txtMakhoi.Text
            //             select t).SingleOrDefault();

            //    data.KHOIs.Remove(s);
            //    data.SaveChanges();
            //    getData();
            //}
            if (MessageBox.Show("Are you sure?", "Message", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                //var s = data.BAIHOCs
                //         .Where(x => x.MABAIHOC == txtMabaihoc.Text.Trim())
                //         .FirstOrDefault();
                var kh = data.BAIHOCs.FirstOrDefault(x => x.MAKHOI.Contains(txtMakhoi.Text.Trim()));
                if (kh != null)
                {
                    MessageBox.Show("Mon nay da co trong du  lieu");
                }
                else
                {
                    var s = data.KHOIs.FirstOrDefault(x => x.MAKHOI.Contains(txtMakhoi.Text.Trim()));

                    data.KHOIs.Remove(s);
                    data.SaveChanges();
                    getData();
                }
            }

        }

        private void dgKhoi_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if(e.RowIndex>= 0)
            {
                DataGridViewRow r = dgKhoi.Rows[e.RowIndex];
                txtMakhoi.Text = r.Cells[1].Value.ToString();
                txtTenkhoi.Text = r.Cells[2].Value.ToString();
                txtGhichu.Text = r.Cells[3].Value.ToString();

                action = true;
                txtMakhoi.ReadOnly = true;
                Delete_Click.Enabled = true;
              
            }
        }

        private void Cancelmenu_Click(object sender, EventArgs e)
        {
            txtMakhoi.ReadOnly = false;
            Delete_Click.Enabled = false;
            action = false;
            txtMakhoi.Clear();
            txtTenkhoi.Clear();
            txtGhichu.Clear();
        }
    }
}
