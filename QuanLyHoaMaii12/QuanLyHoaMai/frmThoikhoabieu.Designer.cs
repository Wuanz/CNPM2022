namespace QuanLyHoaMai
{
    partial class frmThoikhoabieu
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
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.Delete_Click = new System.Windows.Forms.ToolStripLabel();
            this.toolStripButton2 = new System.Windows.Forms.ToolStripButton();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtThu = new System.Windows.Forms.TextBox();
            this.cbMalop = new System.Windows.Forms.ComboBox();
            this.cbMabaihoc = new System.Windows.Forms.ComboBox();
            this.txtNgay = new System.Windows.Forms.DateTimePicker();
            this.txtSTT = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dgThoikhoabieu = new System.Windows.Forms.DataGridView();
            this.toolStrip1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgThoikhoabieu)).BeginInit();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButton1,
            this.Delete_Click,
            this.toolStripButton2});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(800, 31);
            this.toolStrip1.TabIndex = 0;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolStripButton1
            // 
            this.toolStripButton1.Image = global::QuanLyHoaMai.Properties.Resources.saved;
            this.toolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton1.Name = "toolStripButton1";
            this.toolStripButton1.Size = new System.Drawing.Size(64, 24);
            this.toolStripButton1.Text = "Save";
            this.toolStripButton1.Click += new System.EventHandler(this.menuSaveTKB_Click);
            // 
            // Delete_Click
            // 
            this.Delete_Click.Image = global::QuanLyHoaMai.Properties.Resources.delete__1_;
            this.Delete_Click.Name = "Delete_Click";
            this.Delete_Click.Size = new System.Drawing.Size(73, 24);
            this.Delete_Click.Text = "Delete";
            this.Delete_Click.Click += new System.EventHandler(this.menuDeleteTKB_Click);
            // 
            // toolStripButton2
            // 
            this.toolStripButton2.Image = global::QuanLyHoaMai.Properties.Resources.close1;
            this.toolStripButton2.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton2.Name = "toolStripButton2";
            this.toolStripButton2.Size = new System.Drawing.Size(77, 24);
            this.toolStripButton2.Text = "Cancel";
            this.toolStripButton2.Click += new System.EventHandler(this.menuCancelTKB_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Dock = System.Windows.Forms.DockStyle.Top;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(0, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(312, 36);
            this.label1.TabIndex = 1;
            this.label1.Text = "Quản lý thời khóa biểu";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(51, 58);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 16);
            this.label2.TabIndex = 2;
            this.label2.Text = "Mã bài học";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(400, 58);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(77, 16);
            this.label3.TabIndex = 3;
            this.label3.Text = "Số thứ tự tiết";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(553, 110);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(44, 16);
            this.label4.TabIndex = 4;
            this.label4.Text = "label4";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(51, 110);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(48, 16);
            this.label5.TabIndex = 5;
            this.label5.Text = "Mã lớp";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtThu);
            this.groupBox1.Controls.Add(this.cbMalop);
            this.groupBox1.Controls.Add(this.cbMabaihoc);
            this.groupBox1.Controls.Add(this.txtNgay);
            this.groupBox1.Controls.Add(this.txtSTT);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.Location = new System.Drawing.Point(0, 67);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Size = new System.Drawing.Size(800, 383);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "groupBox1";
            // 
            // txtThu
            // 
            this.txtThu.Location = new System.Drawing.Point(509, 137);
            this.txtThu.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtThu.Name = "txtThu";
            this.txtThu.Size = new System.Drawing.Size(100, 22);
            this.txtThu.TabIndex = 12;
            // 
            // cbMalop
            // 
            this.cbMalop.FormattingEnabled = true;
            this.cbMalop.Location = new System.Drawing.Point(144, 110);
            this.cbMalop.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbMalop.Name = "cbMalop";
            this.cbMalop.Size = new System.Drawing.Size(121, 24);
            this.cbMalop.TabIndex = 11;
            // 
            // cbMabaihoc
            // 
            this.cbMabaihoc.FormattingEnabled = true;
            this.cbMabaihoc.Location = new System.Drawing.Point(144, 53);
            this.cbMabaihoc.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbMabaihoc.Name = "cbMabaihoc";
            this.cbMabaihoc.Size = new System.Drawing.Size(121, 24);
            this.cbMabaihoc.TabIndex = 10;
            // 
            // txtNgay
            // 
            this.txtNgay.Location = new System.Drawing.Point(509, 95);
            this.txtNgay.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtNgay.Name = "txtNgay";
            this.txtNgay.Size = new System.Drawing.Size(200, 22);
            this.txtNgay.TabIndex = 9;
            // 
            // txtSTT
            // 
            this.txtSTT.Location = new System.Drawing.Point(509, 55);
            this.txtSTT.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtSTT.Name = "txtSTT";
            this.txtSTT.Size = new System.Drawing.Size(100, 22);
            this.txtSTT.TabIndex = 8;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(400, 143);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(30, 16);
            this.label7.TabIndex = 7;
            this.label7.Text = "Thứ";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(400, 102);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(40, 16);
            this.label6.TabIndex = 6;
            this.label6.Text = "Ngày";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dgThoikhoabieu);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.groupBox2.Location = new System.Drawing.Point(0, 236);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox2.Size = new System.Drawing.Size(800, 214);
            this.groupBox2.TabIndex = 7;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "groupBox2";
            // 
            // dgThoikhoabieu
            // 
            this.dgThoikhoabieu.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgThoikhoabieu.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgThoikhoabieu.Location = new System.Drawing.Point(3, 17);
            this.dgThoikhoabieu.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgThoikhoabieu.Name = "dgThoikhoabieu";
            this.dgThoikhoabieu.RowHeadersWidth = 51;
            this.dgThoikhoabieu.RowTemplate.Height = 24;
            this.dgThoikhoabieu.Size = new System.Drawing.Size(794, 195);
            this.dgThoikhoabieu.TabIndex = 0;
            this.dgThoikhoabieu.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgThoikhoabieu_CellClick);
            // 
            // frmThoikhoabieu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.toolStrip1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "frmThoikhoabieu";
            this.Text = "frmThoikhoabieu";
            this.Load += new System.EventHandler(this.frmThoikhoabieu_Load);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgThoikhoabieu)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton toolStripButton1;
        private System.Windows.Forms.ToolStripLabel Delete_Click;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ToolStripButton toolStripButton2;
        private System.Windows.Forms.ComboBox cbMalop;
        private System.Windows.Forms.ComboBox cbMabaihoc;
        private System.Windows.Forms.DateTimePicker txtNgay;
        private System.Windows.Forms.TextBox txtSTT;
        private System.Windows.Forms.DataGridView dgThoikhoabieu;
        private System.Windows.Forms.TextBox txtThu;
    }
}