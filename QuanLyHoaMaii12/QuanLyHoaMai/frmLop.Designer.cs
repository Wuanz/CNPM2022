namespace QuanLyHoaMai
{
    partial class frmLop
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
            this.label4 = new System.Windows.Forms.Label();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripLabel1 = new System.Windows.Forms.ToolStripLabel();
            this.Delete_Click = new System.Windows.Forms.ToolStripButton();
            this.Cancelmenu = new System.Windows.Forms.ToolStripButton();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dgLop = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtMalop = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtGiaovienphutrach = new System.Windows.Forms.TextBox();
            this.txtTenlop = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.toolStrip1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgLop)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Dock = System.Windows.Forms.DockStyle.Top;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Peru;
            this.label4.Location = new System.Drawing.Point(0, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(190, 37);
            this.label4.TabIndex = 6;
            this.label4.Text = "Quản lý lớp";
            // 
            // toolStrip1
            // 
            this.toolStrip1.BackColor = System.Drawing.Color.Bisque;
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripLabel1,
            this.Delete_Click,
            this.Cancelmenu});
            this.toolStrip1.Location = new System.Drawing.Point(0, 37);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(649, 27);
            this.toolStrip1.TabIndex = 8;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolStripLabel1
            // 
            this.toolStripLabel1.Font = new System.Drawing.Font("MV Boli", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toolStripLabel1.ForeColor = System.Drawing.Color.Peru;
            this.toolStripLabel1.Image = global::QuanLyHoaMai.Properties.Resources.floppy_disk;
            this.toolStripLabel1.Name = "toolStripLabel1";
            this.toolStripLabel1.Size = new System.Drawing.Size(63, 24);
            this.toolStripLabel1.Text = "Save";
            this.toolStripLabel1.Click += new System.EventHandler(this.menuSaveLop_Click);
            // 
            // Delete_Click
            // 
            this.Delete_Click.Font = new System.Drawing.Font("MV Boli", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Delete_Click.ForeColor = System.Drawing.Color.DarkOrange;
            this.Delete_Click.Image = global::QuanLyHoaMai.Properties.Resources.delete__3_;
            this.Delete_Click.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.Delete_Click.Name = "Delete_Click";
            this.Delete_Click.Size = new System.Drawing.Size(82, 24);
            this.Delete_Click.Text = "Delete";
            this.Delete_Click.Click += new System.EventHandler(this.Delete_Click_Click);
            // 
            // Cancelmenu
            // 
            this.Cancelmenu.Font = new System.Drawing.Font("MV Boli", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Cancelmenu.ForeColor = System.Drawing.Color.Orange;
            this.Cancelmenu.Image = global::QuanLyHoaMai.Properties.Resources.cancel;
            this.Cancelmenu.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.Cancelmenu.Name = "Cancelmenu";
            this.Cancelmenu.Size = new System.Drawing.Size(80, 24);
            this.Cancelmenu.Text = "Cancel";
            this.Cancelmenu.Click += new System.EventHandler(this.Cancelmenu_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.BackgroundImage = global::QuanLyHoaMai.Properties.Resources._46a0a3e2d70269dd703aa4ba8346d326;
            this.groupBox2.Controls.Add(this.dgLop);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.groupBox2.Location = new System.Drawing.Point(0, 207);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(649, 233);
            this.groupBox2.TabIndex = 10;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Danh sách Lớp";
            // 
            // dgLop
            // 
            this.dgLop.BackgroundColor = System.Drawing.Color.LightGoldenrodYellow;
            this.dgLop.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgLop.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgLop.Location = new System.Drawing.Point(3, 18);
            this.dgLop.Name = "dgLop";
            this.dgLop.RowHeadersWidth = 51;
            this.dgLop.Size = new System.Drawing.Size(643, 212);
            this.dgLop.TabIndex = 0;
            this.dgLop.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgLop_CellClick);
            // 
            // groupBox1
            // 
            this.groupBox1.BackgroundImage = global::QuanLyHoaMai.Properties.Resources._46a0a3e2d70269dd703aa4ba8346d326;
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txtMalop);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.txtGiaovienphutrach);
            this.groupBox1.Controls.Add(this.txtTenlop);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.Color.Black;
            this.groupBox1.Location = new System.Drawing.Point(0, 64);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(649, 376);
            this.groupBox1.TabIndex = 9;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông tin Lớp";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.SystemColors.Control;
            this.label2.Font = new System.Drawing.Font("Palatino Linotype", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label2.Image = global::QuanLyHoaMai.Properties.Resources._46a0a3e2d70269dd703aa4ba8346d326;
            this.label2.Location = new System.Drawing.Point(39, 30);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(75, 26);
            this.label2.TabIndex = 1;
            this.label2.Text = "Mã lớp";
            // 
            // txtMalop
            // 
            this.txtMalop.Location = new System.Drawing.Point(254, 34);
            this.txtMalop.Name = "txtMalop";
            this.txtMalop.Size = new System.Drawing.Size(94, 22);
            this.txtMalop.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.BlanchedAlmond;
            this.label1.Font = new System.Drawing.Font("Palatino Linotype", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Image = global::QuanLyHoaMai.Properties.Resources._46a0a3e2d70269dd703aa4ba8346d326;
            this.label1.Location = new System.Drawing.Point(39, 64);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 26);
            this.label1.TabIndex = 0;
            this.label1.Text = "Tên lớp";
            // 
            // txtGiaovienphutrach
            // 
            this.txtGiaovienphutrach.Location = new System.Drawing.Point(254, 105);
            this.txtGiaovienphutrach.Name = "txtGiaovienphutrach";
            this.txtGiaovienphutrach.Size = new System.Drawing.Size(192, 22);
            this.txtGiaovienphutrach.TabIndex = 3;
            // 
            // txtTenlop
            // 
            this.txtTenlop.Location = new System.Drawing.Point(254, 68);
            this.txtTenlop.Name = "txtTenlop";
            this.txtTenlop.Size = new System.Drawing.Size(192, 22);
            this.txtTenlop.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Palatino Linotype", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label3.Image = global::QuanLyHoaMai.Properties.Resources._46a0a3e2d70269dd703aa4ba8346d326;
            this.label3.Location = new System.Drawing.Point(39, 101);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(190, 26);
            this.label3.TabIndex = 2;
            this.label3.Text = "Giáo viên phụ trách";
            // 
            // frmLop
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PeachPuff;
            this.ClientSize = new System.Drawing.Size(649, 440);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.label4);
            this.Name = "frmLop";
            this.Text = "frmLop";
            this.Load += new System.EventHandler(this.frmLop_Load);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgLop)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtGiaovienphutrach;
        private System.Windows.Forms.TextBox txtTenlop;
        private System.Windows.Forms.TextBox txtMalop;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripLabel toolStripLabel1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView dgLop;
        private System.Windows.Forms.ToolStripButton Delete_Click;
        private System.Windows.Forms.ToolStripButton Cancelmenu;
    }
}