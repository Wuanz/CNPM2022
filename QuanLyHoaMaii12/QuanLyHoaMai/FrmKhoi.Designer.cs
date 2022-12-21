namespace QuanLyHoaMai
{
    partial class FrmKhoi
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
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dgKhoi = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtGhichu = new System.Windows.Forms.TextBox();
            this.txtMakhoi = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtTenkhoi = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.toolStrip2 = new System.Windows.Forms.ToolStrip();
            this.toolStripLabel1 = new System.Windows.Forms.ToolStripLabel();
            this.Delete_Click = new System.Windows.Forms.ToolStripButton();
            this.Cancelmenu = new System.Windows.Forms.ToolStripButton();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgKhoi)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.toolStrip2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Pink;
            this.label1.Dock = System.Windows.Forms.DockStyle.Top;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.IndianRed;
            this.label1.Location = new System.Drawing.Point(0, 27);
            this.label1.Name = "label1";
            this.label1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label1.Size = new System.Drawing.Size(212, 37);
            this.label1.TabIndex = 2;
            this.label1.Text = "Quản lý Khối";
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.groupBox2.BackgroundImage = global::QuanLyHoaMai.Properties.Resources.f;
            this.groupBox2.Controls.Add(this.dgKhoi);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.ForeColor = System.Drawing.Color.Crimson;
            this.groupBox2.Location = new System.Drawing.Point(0, 222);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(684, 239);
            this.groupBox2.TabIndex = 10;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Danh sách Khối";
            // 
            // dgKhoi
            // 
            this.dgKhoi.BackgroundColor = System.Drawing.Color.LavenderBlush;
            this.dgKhoi.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgKhoi.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgKhoi.Location = new System.Drawing.Point(3, 18);
            this.dgKhoi.Name = "dgKhoi";
            this.dgKhoi.RowHeadersWidth = 51;
            this.dgKhoi.Size = new System.Drawing.Size(678, 218);
            this.dgKhoi.TabIndex = 0;
            this.dgKhoi.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgKhoi_CellClick);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.MediumPurple;
            this.groupBox1.BackgroundImage = global::QuanLyHoaMai.Properties.Resources.f;
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txtGhichu);
            this.groupBox1.Controls.Add(this.txtMakhoi);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.txtTenkhoi);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.Color.Crimson;
            this.groupBox1.Location = new System.Drawing.Point(0, 69);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(684, 392);
            this.groupBox1.TabIndex = 9;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông tin Khối";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.LightGoldenrodYellow;
            this.label2.Font = new System.Drawing.Font("Palatino Linotype", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.PaleVioletRed;
            this.label2.Image = global::QuanLyHoaMai.Properties.Resources.f;
            this.label2.Location = new System.Drawing.Point(43, 28);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(87, 26);
            this.label2.TabIndex = 3;
            this.label2.Text = "Mã khối";
            // 
            // txtGhichu
            // 
            this.txtGhichu.Location = new System.Drawing.Point(186, 121);
            this.txtGhichu.Name = "txtGhichu";
            this.txtGhichu.Size = new System.Drawing.Size(199, 22);
            this.txtGhichu.TabIndex = 8;
            // 
            // txtMakhoi
            // 
            this.txtMakhoi.Location = new System.Drawing.Point(186, 33);
            this.txtMakhoi.Name = "txtMakhoi";
            this.txtMakhoi.Size = new System.Drawing.Size(199, 22);
            this.txtMakhoi.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.label4.Font = new System.Drawing.Font("Palatino Linotype", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.PaleVioletRed;
            this.label4.Image = global::QuanLyHoaMai.Properties.Resources.f;
            this.label4.Location = new System.Drawing.Point(43, 121);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(83, 26);
            this.label4.TabIndex = 5;
            this.label4.Text = "Ghi chú";
            // 
            // txtTenkhoi
            // 
            this.txtTenkhoi.Location = new System.Drawing.Point(186, 78);
            this.txtTenkhoi.Name = "txtTenkhoi";
            this.txtTenkhoi.Size = new System.Drawing.Size(199, 22);
            this.txtTenkhoi.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.label3.Font = new System.Drawing.Font("Palatino Linotype", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.PaleVioletRed;
            this.label3.Image = global::QuanLyHoaMai.Properties.Resources.f;
            this.label3.Location = new System.Drawing.Point(43, 72);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(92, 26);
            this.label3.TabIndex = 4;
            this.label3.Text = "Tên khối";
            // 
            // toolStrip2
            // 
            this.toolStrip2.BackColor = System.Drawing.Color.GhostWhite;
            this.toolStrip2.BackgroundImage = global::QuanLyHoaMai.Properties.Resources.f;
            this.toolStrip2.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.toolStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripLabel1,
            this.Delete_Click,
            this.Cancelmenu});
            this.toolStrip2.Location = new System.Drawing.Point(0, 0);
            this.toolStrip2.Name = "toolStrip2";
            this.toolStrip2.Size = new System.Drawing.Size(684, 27);
            this.toolStrip2.TabIndex = 1;
            this.toolStrip2.Text = "toolStrip2";
            // 
            // toolStripLabel1
            // 
            this.toolStripLabel1.Font = new System.Drawing.Font("MV Boli", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toolStripLabel1.ForeColor = System.Drawing.Color.MediumAquamarine;
            this.toolStripLabel1.Image = global::QuanLyHoaMai.Properties.Resources.saved;
            this.toolStripLabel1.Name = "toolStripLabel1";
            this.toolStripLabel1.Size = new System.Drawing.Size(63, 24);
            this.toolStripLabel1.Text = "Save";
            this.toolStripLabel1.Click += new System.EventHandler(this.menuSaveKhoi_Click);
            // 
            // Delete_Click
            // 
            this.Delete_Click.Font = new System.Drawing.Font("MV Boli", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Delete_Click.ForeColor = System.Drawing.Color.IndianRed;
            this.Delete_Click.Image = global::QuanLyHoaMai.Properties.Resources.delete__1_;
            this.Delete_Click.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.Delete_Click.Name = "Delete_Click";
            this.Delete_Click.Size = new System.Drawing.Size(82, 24);
            this.Delete_Click.Text = "Delete";
            this.Delete_Click.Click += new System.EventHandler(this.Delete_Click_Click);
            // 
            // Cancelmenu
            // 
            this.Cancelmenu.Font = new System.Drawing.Font("MV Boli", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Cancelmenu.ForeColor = System.Drawing.Color.OliveDrab;
            this.Cancelmenu.Image = global::QuanLyHoaMai.Properties.Resources._8184333;
            this.Cancelmenu.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.Cancelmenu.Name = "Cancelmenu";
            this.Cancelmenu.Size = new System.Drawing.Size(80, 24);
            this.Cancelmenu.Text = "Cancel";
            this.Cancelmenu.Click += new System.EventHandler(this.Cancelmenu_Click);
            // 
            // FrmKhoi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Pink;
            this.ClientSize = new System.Drawing.Size(684, 461);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.toolStrip2);
            this.Name = "FrmKhoi";
            this.Text = "FrmKhoi";
            this.Load += new System.EventHandler(this.FrmKhoi_Load);
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgKhoi)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.toolStrip2.ResumeLayout(false);
            this.toolStrip2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtTenkhoi;
        private System.Windows.Forms.TextBox txtMakhoi;
        private System.Windows.Forms.TextBox txtGhichu;
        private System.Windows.Forms.ToolStripLabel toolStripLabel1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView dgKhoi;
        private System.Windows.Forms.ToolStripButton Delete_Click;
        private System.Windows.Forms.ToolStripButton Cancelmenu;
    }
}