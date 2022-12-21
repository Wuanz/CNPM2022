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
    public partial class frmThoikhoabieu : Form
    {
        bool action = false;//insert
        HoaMaiEntities4 data = new HoaMaiEntities4();
        public frmThoikhoabieu()
        {
            InitializeComponent();
        }

        private void menuSaveTKB_Click(object sender, EventArgs e)
        {
            if (action == false)
            {
                // insert
                var t = new THOIKHOABIEU
                {
                    MABAIHOC = cbMabaihoc.SelectedValue.ToString(),
                    MALOP = cbMalop.SelectedValue.ToString(),
                   
                    SOTHUTUTIET = int.Parse(txtSTT.Text.Trim()),
                    NGAY = DateTime.Parse(txtNgay.Value.ToString("dd/MM/yyyy")),
                    THU = txtThu.Text.Trim()
                };
                data.THOIKHOABIEUx.Add(t);
                data.SaveChanges();
                getData();
            }
            else
            {
                //update
                var tkb = data.THOIKHOABIEUx
                    .Where(x => x.THU == txtThu.Text.Trim())
                    .FirstOrDefault();
                tkb.MABAIHOC = cbMabaihoc.SelectedValue.ToString();
                tkb.MALOP = cbMalop.SelectedValue.ToString();
                tkb.SOTHUTUTIET = int.Parse(txtSTT.Text.Trim());
                tkb.NGAY = DateTime.Parse(txtNgay.Value.ToString("dd/MM/yyyy"));
                tkb.THU = txtThu.Text.Trim();


                data.SaveChanges();
                getData();
                var s = data.THOIKHOABIEUx
                       .Where(x => x.THU == txtThu.Text.Trim())
                       .FirstOrDefault();


                data.SaveChanges();
                getData();

            }

        
    }

        private void menuDeleteTKB_Click(object sender, EventArgs e)
        {

            if (MessageBox.Show("Are you sure?", "Message", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                var s = data.THOIKHOABIEUx
                     .Where(x => x.THU == txtThu.Text.Trim())
                     .FirstOrDefault();
                data.THOIKHOABIEUx.Remove(s);
                data.SaveChanges();
                getData();
                txtThu.Clear();
                // txtNgay.Clear();
                txtSTT.Clear();
            }
        }

        private void menuCancelTKB_Click(object sender, EventArgs e)
        {
            // txtMamon.ReadOnly = false;
            Delete_Click.Enabled = false;
            action = false;
            txtThu.Clear();
           // txtNgay.Clear();
            txtSTT.Clear();
        }

        private void frmThoikhoabieu_Load(object sender, EventArgs e)
        {

            getData();
            getThoikhoabieu();
            init();
        }
        void getData()
        {

            List<THOIKHOABIEU> lst = data.THOIKHOABIEUx.ToList();
            int i = 0;
            var v = from t in lst
                    select new
                    {
                        No = ++i,
                        cbMabaihoc = t.BAIHOC.MABAIHOC,
                        cbMalop = t.LOP.MALOP, //1
                        Sothututiet = t.SOTHUTUTIET,//4
                        Ngay = t.NGAY,//5
                        Thu = t.THU//3
                   

                    };
            dgThoikhoabieu.DataSource = v.ToList();
        }
        void getThoikhoabieu()
        {

            data = new HoaMaiEntities4();

            cbMabaihoc.DataSource = data.BAIHOCs.ToList();
            cbMalop.DataSource = data.LOPs.ToList();

        }
        void init()
        {
            Delete_Click.Enabled = false;
            txtNgay.Format = DateTimePickerFormat.Custom;
            txtNgay.CustomFormat = "dd/MM/yyyy";
            cbMabaihoc.DisplayMember = "Tenbaihoc";
            cbMabaihoc.ValueMember = "Mabaihoc";
            cbMalop.DisplayMember = "Tenlop";
            cbMalop.ValueMember = "Malop";

        }

        

      

        private void dgThoikhoabieu_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if(e.RowIndex >= 0)
            {
                DataGridViewRow r = dgThoikhoabieu.Rows[e.RowIndex];

                cbMabaihoc.SelectedIndex = cbMabaihoc.FindStringExact(r.Cells[1].Value.ToString());
                cbMalop.SelectedIndex = cbMalop.FindStringExact(r.Cells[2].Value.ToString());

                txtSTT.Text = r.Cells[3].Value.ToString();
                txtNgay.Text = DateTime.Parse(r.Cells[4].Value.ToString()).ToString();

                txtThu.Text = r.Cells[5].Value.ToString();

                action = true;
                Delete_Click.Enabled = true;

            }
        }
    }
}
