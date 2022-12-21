using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyHoaMai
{
    public partial class frmBaihoc : Form
    {
        bool action = false;//insert
        HoaMaiEntities4 data = new HoaMaiEntities4();
        public frmBaihoc()
        {
            InitializeComponent();
        }

        private void frmBaihoc_Load(object sender, EventArgs e)
        {

            getData();
            getBaihoc();
            init();
        }
        void getData()
        {
            List<BAIHOC> lst = data.BAIHOCs.ToList();
            int i = 0;
            var v = from t in lst
                    select new
                    {
                        No = ++i,
                        Tenbaihoc = t.TENBAIHOC,
                        Mabaihoc = t.MABAIHOC,
                        TenMon = t.MONHOC.TENMON,
                        Tenkhoi = t.KHOI.TENKHOI,
                        Makhoi = t.KHOI.MAKHOI,
                        Sotiet = t.SOTIET,
                        Dungcu = t.YEUCAUVEDUNGCU,
                        Mamon = t.MONHOC.MAMON
                    };
            dgDanhsachmonhoc.DataSource = v.ToList();
        }

        private void menuSave_Click_Click(object sender, EventArgs e)
        {
            if (action == false)
            {
                // insert
                var t = new BAIHOC
                {
                    TENBAIHOC = txtTenbaihoc.Text.Trim(),
                    MABAIHOC = txtMabaihoc.Text.Trim(),
                    MAKHOI = cbMakhoi.SelectedValue.ToString(),
                    SOTIET = int.Parse(txtSotiet.Text.Trim()),
                    YEUCAUVEDUNGCU = txtDungcu.Text.Trim(),
                    MAMON = cbMamon.SelectedValue.ToString()
                };
                data.BAIHOCs.Add(t);
                data.SaveChanges();
                getData();
            }
            else
            {
                //update
                var bh = data.BAIHOCs
                    .Where(x => x.MABAIHOC == txtMabaihoc.Text.Trim())
                    .FirstOrDefault();
                bh.TENBAIHOC = txtTenbaihoc.Text.Trim();
                bh.MABAIHOC = txtMabaihoc.Text.Trim();
                bh.MAKHOI = cbMakhoi.SelectedValue.ToString();
                bh.SOTIET = int.Parse(txtSotiet.Text.Trim());
                bh.YEUCAUVEDUNGCU = txtDungcu.Text.Trim();
                bh.MAMON = cbMamon.SelectedValue.ToString();
                data.SaveChanges();
                getData();
                var s = data.BAIHOCs
                       .Where(x => x.MABAIHOC == txtMabaihoc.Text.Trim())
                       .FirstOrDefault();

                
                data.SaveChanges();
                getData();

            }

        }
        void getBaihoc()
        {

            data = new HoaMaiEntities4();

            cbMakhoi.DataSource = data.KHOIs.ToList();
            cbMamon.DataSource = data.MONHOCs.ToList();



        }
        void init() {

            delete_Click.Enabled = false;
            cbMakhoi.DisplayMember = "Tenkhoi";
            cbMakhoi.ValueMember = "Makhoi";
            cbMamon.DisplayMember = "Tenmon";
            cbMamon.ValueMember = "Mamon";

        }

        private void dgDSMH_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if(e.RowIndex >= 0)
            {
                DataGridViewRow r = dgDanhsachmonhoc.Rows[e.RowIndex];
                txtTenbaihoc.Text = r.Cells[1].Value.ToString();
                txtMabaihoc.Text = r.Cells[2].Value.ToString();
                cbMakhoi.SelectedIndex = cbMakhoi.FindStringExact(r.Cells[5].Value.ToString());
                txtSotiet.Text = r.Cells[6].Value.ToString();
                txtDungcu.Text = r.Cells[7].Value.ToString();
                cbMamon.SelectedIndex = cbMamon.FindStringExact(r.Cells[8].Value.ToString());

                action = true;
                txtMabaihoc.ReadOnly = true;
                delete_Click.Enabled = true;

            }
        }

        private void delete_Click_Click(object sender, EventArgs e)
        {
            //data = new HoaMaiEntities4();
            if (MessageBox.Show("Are you sure?", "Message", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
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
                }
            }

        }

        private void Cancelmenu_Click(object sender, EventArgs e)
        {
            action = false;
            txtMabaihoc.ReadOnly = false;
            delete_Click.Enabled = false;
            txtMabaihoc.Clear();
            txtTenbaihoc.Clear();

            txtDungcu.Clear();
            txtSotiet.Clear();
        }

      
    }
}
