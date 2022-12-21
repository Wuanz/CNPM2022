
namespace QuanLyHoaMai
{
    partial class frmMonhoc
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
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dgMon = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtMamon = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtTenmon = new System.Windows.Forms.TextBox();
            this.toolStripLabel1 = new System.Windows.Forms.ToolStripLabel();
            this.Delete_Click = new System.Windows.Forms.ToolStripButton();
            this.Cancelmenu = new System.Windows.Forms.ToolStripButton();
            this.toolStrip1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgMon)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.BackColor = System.Drawing.Color.Teal;
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripLabel1,
            this.Delete_Click,
            this.Cancelmenu});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(654, 27);
            this.toolStrip1.TabIndex = 6;
            this.toolStrip1.Text = "save";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Dock = System.Windows.Forms.DockStyle.Top;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.LightSeaGreen;
            this.label1.Location = new System.Drawing.Point(0, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(210, 37);
            this.label1.TabIndex = 6;
            this.label1.Text = "Quản lý môn";
            // 
            // groupBox2
            // 
            this.groupBox2.BackgroundImage = global::QuanLyHoaMai.Properties.Resources._5b8a009f28621b0f2b610a093fd91652;
            this.groupBox2.Controls.Add(this.dgMon);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.ForeColor = System.Drawing.Color.Black;
            this.groupBox2.Location = new System.Drawing.Point(0, 205);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(654, 267);
            this.groupBox2.TabIndex = 5;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Danh sách môn";
            // 
            // dgMon
            // 
            this.dgMon.BackgroundColor = System.Drawing.Color.PowderBlue;
            this.dgMon.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgMon.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgMon.Location = new System.Drawing.Point(3, 18);
            this.dgMon.Name = "dgMon";
            this.dgMon.RowHeadersWidth = 51;
            this.dgMon.Size = new System.Drawing.Size(648, 246);
            this.dgMon.TabIndex = 6;
            this.dgMon.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgMon_CellClick);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.groupBox1.BackgroundImage = global::QuanLyHoaMai.Properties.Resources.Feather_Blue_Bird_Pattern_ipad;
            this.groupBox1.Controls.Add(this.txtMamon);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.txtTenmon);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.Color.Black;
            this.groupBox1.Location = new System.Drawing.Point(0, 69);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(868, 152);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông tin môn";
            // 
            // txtMamon
            // 
            this.txtMamon.BackColor = System.Drawing.SystemColors.Window;
            this.txtMamon.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.txtMamon.Location = new System.Drawing.Point(161, 43);
            this.txtMamon.Name = "txtMamon";
            this.txtMamon.Size = new System.Drawing.Size(83, 22);
            this.txtMamon.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Palatino Linotype", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.PaleTurquoise;
            this.label2.Image = global::QuanLyHoaMai.Properties.Resources.Feather_Blue_Bird_Pattern_ipad;
            this.label2.Location = new System.Drawing.Point(45, 43);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(87, 26);
            this.label2.TabIndex = 1;
            this.label2.Text = "Mã môn";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Palatino Linotype", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.PaleTurquoise;
            this.label3.Image = global::QuanLyHoaMai.Properties.Resources.Feather_Blue_Bird_Pattern_ipad;
            this.label3.Location = new System.Drawing.Point(45, 75);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(92, 26);
            this.label3.TabIndex = 2;
            this.label3.Text = "Tên môn";
            // 
            // txtTenmon
            // 
            this.txtTenmon.Location = new System.Drawing.Point(161, 79);
            this.txtTenmon.Name = "txtTenmon";
            this.txtTenmon.Size = new System.Drawing.Size(165, 22);
            this.txtTenmon.TabIndex = 3;
            // 
            // toolStripLabel1
            // 
            this.toolStripLabel1.BackColor = System.Drawing.Color.MediumSpringGreen;
            this.toolStripLabel1.Font = new System.Drawing.Font("MV Boli", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toolStripLabel1.ForeColor = System.Drawing.Color.Cyan;
            this.toolStripLabel1.Image = global::QuanLyHoaMai.Properties.Resources.save_file;
            this.toolStripLabel1.Name = "toolStripLabel1";
            this.toolStripLabel1.Size = new System.Drawing.Size(63, 24);
            this.toolStripLabel1.Text = "Save";
            this.toolStripLabel1.Click += new System.EventHandler(this.menuSave_Click);
            // 
            // Delete_Click
            // 
            this.Delete_Click.Font = new System.Drawing.Font("MV Boli", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Delete_Click.ForeColor = System.Drawing.Color.Cyan;
            this.Delete_Click.Image = global::QuanLyHoaMai.Properties.Resources.delete__4_;
            this.Delete_Click.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.Delete_Click.Name = "Delete_Click";
            this.Delete_Click.Size = new System.Drawing.Size(82, 24);
            this.Delete_Click.Text = "Delete";
            this.Delete_Click.Click += new System.EventHandler(this.Delete_Click_Click);
            // 
            // Cancelmenu
            // 
            this.Cancelmenu.Font = new System.Drawing.Font("MV Boli", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Cancelmenu.ForeColor = System.Drawing.Color.Aquamarine;
            this.Cancelmenu.Image = global::QuanLyHoaMai.Properties.Resources.cancel__1_;
            this.Cancelmenu.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.Cancelmenu.Name = "Cancelmenu";
            this.Cancelmenu.Size = new System.Drawing.Size(80, 24);
            this.Cancelmenu.Text = "Cancel";
            this.Cancelmenu.Click += new System.EventHandler(this.Cancelmenu_Click);
            // 
            // frmMonhoc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightCyan;
            this.ClientSize = new System.Drawing.Size(654, 472);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.toolStrip1);
            this.Name = "frmMonhoc";
            this.Text = "frmMonhoc";
            this.Load += new System.EventHandler(this.frmMonhoc_Load);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgMon)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtTenmon;
        private System.Windows.Forms.TextBox txtMamon;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripLabel toolStripLabel1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgMon;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ToolStripButton Delete_Click;
        private System.Windows.Forms.ToolStripButton Cancelmenu;
    }
}