namespace QuanLyHoaMai
{
    partial class frmBaihoc
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.menuSave_Click = new System.Windows.Forms.ToolStripLabel();
            this.delete_Click = new System.Windows.Forms.ToolStripButton();
            this.Cancelmenu = new System.Windows.Forms.ToolStripButton();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtMabaihoc = new System.Windows.Forms.TextBox();
            this.txtTenbaihoc = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtSotiet = new System.Windows.Forms.TextBox();
            this.txtDungcu = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.cbMamon = new System.Windows.Forms.ComboBox();
            this.cbMakhoi = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dgDanhsachmonhoc = new System.Windows.Forms.DataGridView();
            this.toolStrip1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgDanhsachmonhoc)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Dock = System.Windows.Forms.DockStyle.Top;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Bisque;
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(255, 37);
            this.label1.TabIndex = 0;
            this.label1.Text = "Quản lý bài học";
            // 
            // toolStrip1
            // 
            this.toolStrip1.BackColor = System.Drawing.Color.DarkKhaki;
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuSave_Click,
            this.delete_Click,
            this.Cancelmenu});
            this.toolStrip1.Location = new System.Drawing.Point(0, 37);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(600, 27);
            this.toolStrip1.TabIndex = 13;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // menuSave_Click
            // 
            this.menuSave_Click.Font = new System.Drawing.Font("MV Boli", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuSave_Click.ForeColor = System.Drawing.Color.GreenYellow;
            this.menuSave_Click.Image = global::QuanLyHoaMai.Properties.Resources.diskette;
            this.menuSave_Click.Name = "menuSave_Click";
            this.menuSave_Click.Size = new System.Drawing.Size(63, 24);
            this.menuSave_Click.Text = "Save";
            this.menuSave_Click.Click += new System.EventHandler(this.menuSave_Click_Click);
            // 
            // delete_Click
            // 
            this.delete_Click.Font = new System.Drawing.Font("MV Boli", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.delete_Click.ForeColor = System.Drawing.Color.Chartreuse;
            this.delete_Click.Image = global::QuanLyHoaMai.Properties.Resources.delete__8_;
            this.delete_Click.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.delete_Click.Name = "delete_Click";
            this.delete_Click.Size = new System.Drawing.Size(82, 24);
            this.delete_Click.Text = "Delete";
            this.delete_Click.Click += new System.EventHandler(this.delete_Click_Click);
            // 
            // Cancelmenu
            // 
            this.Cancelmenu.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.Cancelmenu.Font = new System.Drawing.Font("MV Boli", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Cancelmenu.ForeColor = System.Drawing.Color.LawnGreen;
            this.Cancelmenu.Image = global::QuanLyHoaMai.Properties.Resources.close;
            this.Cancelmenu.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.Cancelmenu.Name = "Cancelmenu";
            this.Cancelmenu.Size = new System.Drawing.Size(80, 24);
            this.Cancelmenu.Text = "Cancel";
            this.Cancelmenu.Click += new System.EventHandler(this.Cancelmenu_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.BackgroundImage = global::QuanLyHoaMai.Properties.Resources._2b89a3d01b20ad792087ff68add31ffe;
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.txtMabaihoc);
            this.groupBox2.Controls.Add(this.txtTenbaihoc);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.txtSotiet);
            this.groupBox2.Controls.Add(this.txtDungcu);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.cbMamon);
            this.groupBox2.Controls.Add(this.cbMakhoi);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox2.Location = new System.Drawing.Point(0, 37);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox2.Size = new System.Drawing.Size(600, 169);
            this.groupBox2.TabIndex = 12;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Thông tin Bài học";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.LemonChiffon;
            this.label7.Font = new System.Drawing.Font("Palatino Linotype", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(12, 86);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(110, 26);
            this.label7.TabIndex = 13;
            this.label7.Text = "Mã bài học";
            // 
            // txtMabaihoc
            // 
            this.txtMabaihoc.Location = new System.Drawing.Point(163, 86);
            this.txtMabaihoc.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtMabaihoc.Name = "txtMabaihoc";
            this.txtMabaihoc.Size = new System.Drawing.Size(92, 20);
            this.txtMabaihoc.TabIndex = 12;
            // 
            // txtTenbaihoc
            // 
            this.txtTenbaihoc.Location = new System.Drawing.Point(163, 48);
            this.txtTenbaihoc.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtTenbaihoc.Name = "txtTenbaihoc";
            this.txtTenbaihoc.Size = new System.Drawing.Size(115, 20);
            this.txtTenbaihoc.TabIndex = 11;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.LemonChiffon;
            this.label2.Font = new System.Drawing.Font("Palatino Linotype", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.label2.Location = new System.Drawing.Point(12, 48);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(115, 26);
            this.label2.TabIndex = 1;
            this.label2.Text = "Tên bài học";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.LemonChiffon;
            this.label3.Font = new System.Drawing.Font("Palatino Linotype", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(311, 120);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(88, 26);
            this.label3.TabIndex = 2;
            this.label3.Text = "Dụng cụ";
            // 
            // txtSotiet
            // 
            this.txtSotiet.Location = new System.Drawing.Point(431, 80);
            this.txtSotiet.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtSotiet.Name = "txtSotiet";
            this.txtSotiet.Size = new System.Drawing.Size(92, 20);
            this.txtSotiet.TabIndex = 9;
            // 
            // txtDungcu
            // 
            this.txtDungcu.Location = new System.Drawing.Point(431, 120);
            this.txtDungcu.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtDungcu.Name = "txtDungcu";
            this.txtDungcu.Size = new System.Drawing.Size(137, 20);
            this.txtDungcu.TabIndex = 10;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.LemonChiffon;
            this.label4.Font = new System.Drawing.Font("Palatino Linotype", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(312, 80);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(70, 26);
            this.label4.TabIndex = 3;
            this.label4.Text = "Số tiết";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.LemonChiffon;
            this.label6.Font = new System.Drawing.Font("Palatino Linotype", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(312, 42);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(87, 26);
            this.label6.TabIndex = 5;
            this.label6.Text = "Mã môn";
            // 
            // cbMamon
            // 
            this.cbMamon.FormattingEnabled = true;
            this.cbMamon.Location = new System.Drawing.Point(431, 47);
            this.cbMamon.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cbMamon.Name = "cbMamon";
            this.cbMamon.Size = new System.Drawing.Size(92, 21);
            this.cbMamon.TabIndex = 7;
            // 
            // cbMakhoi
            // 
            this.cbMakhoi.FormattingEnabled = true;
            this.cbMakhoi.Location = new System.Drawing.Point(163, 126);
            this.cbMakhoi.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cbMakhoi.Name = "cbMakhoi";
            this.cbMakhoi.Size = new System.Drawing.Size(92, 21);
            this.cbMakhoi.TabIndex = 8;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.LemonChiffon;
            this.label5.Font = new System.Drawing.Font("Palatino Linotype", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(12, 126);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(87, 26);
            this.label5.TabIndex = 4;
            this.label5.Text = "Mã khối";
            // 
            // groupBox1
            // 
            this.groupBox1.BackgroundImage = global::QuanLyHoaMai.Properties.Resources._2b89a3d01b20ad792087ff68add31ffe;
            this.groupBox1.Controls.Add(this.dgDanhsachmonhoc);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(0, 206);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox1.Size = new System.Drawing.Size(600, 160);
            this.groupBox1.TabIndex = 11;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Danh sách bài học";
            // 
            // dgDanhsachmonhoc
            // 
            this.dgDanhsachmonhoc.BackgroundColor = System.Drawing.Color.DarkSeaGreen;
            this.dgDanhsachmonhoc.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgDanhsachmonhoc.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgDanhsachmonhoc.Location = new System.Drawing.Point(2, 16);
            this.dgDanhsachmonhoc.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dgDanhsachmonhoc.Name = "dgDanhsachmonhoc";
            this.dgDanhsachmonhoc.RowHeadersWidth = 51;
            this.dgDanhsachmonhoc.RowTemplate.Height = 24;
            this.dgDanhsachmonhoc.Size = new System.Drawing.Size(596, 142);
            this.dgDanhsachmonhoc.TabIndex = 0;
            this.dgDanhsachmonhoc.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgDSMH_CellClick);
            // 
            // frmBaihoc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.ClientSize = new System.Drawing.Size(600, 366);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "frmBaihoc";
            this.Text = "frmBaihoc";
            this.Load += new System.EventHandler(this.frmBaihoc_Load);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgDanhsachmonhoc)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cbMamon;
        private System.Windows.Forms.ComboBox cbMakhoi;
        private System.Windows.Forms.TextBox txtSotiet;
        private System.Windows.Forms.TextBox txtDungcu;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripLabel menuSave_Click;
        private System.Windows.Forms.DataGridView dgDanhsachmonhoc;
        private System.Windows.Forms.ToolStripButton delete_Click;
        private System.Windows.Forms.ToolStripButton Cancelmenu;
        private System.Windows.Forms.TextBox txtMabaihoc;
        private System.Windows.Forms.TextBox txtTenbaihoc;
        private System.Windows.Forms.Label label7;
    }
}