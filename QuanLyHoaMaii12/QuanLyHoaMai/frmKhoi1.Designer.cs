namespace QuanLyHoaMai
{
    partial class frmKhoi1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmKhoi1));
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.btnSave = new System.Windows.Forms.ToolStripButton();
            this.btnCancel = new System.Windows.Forms.ToolStripButton();
            this.btnDelete = new System.Windows.Forms.ToolStripButton();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtGhichu = new System.Windows.Forms.TextBox();
            this.txtMakhoi = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtTenkhoi = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.gcKhoi = new DevExpress.XtraGrid.GridControl();
            this.gvKhoi = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colMaKhoi = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTenKhoi = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colGhiChu = new DevExpress.XtraGrid.Columns.GridColumn();
            this.toolStrip1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gcKhoi)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvKhoi)).BeginInit();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.Dock = System.Windows.Forms.DockStyle.Left;
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnSave,
            this.btnCancel,
            this.btnDelete});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(68, 427);
            this.toolStrip1.TabIndex = 0;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // btnSave
            // 
            this.btnSave.Image = global::QuanLyHoaMai.Properties.Resources.saved;
            this.btnSave.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(65, 24);
            this.btnSave.Text = "Save";
            this.btnSave.Click += new System.EventHandler(this.menuSaveKhoi_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Image = ((System.Drawing.Image)(resources.GetObject("btnCancel.Image")));
            this.btnCancel.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(65, 24);
            this.btnCancel.Text = "Cancel";
            this.btnCancel.Click += new System.EventHandler(this.Cancelmenu_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Image = ((System.Drawing.Image)(resources.GetObject("btnDelete.Image")));
            this.btnDelete.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(65, 24);
            this.btnDelete.Text = "Delete";
            this.btnDelete.Click += new System.EventHandler(this.Delete_Click_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Dock = System.Windows.Forms.DockStyle.Top;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(68, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(177, 35);
            this.label1.TabIndex = 1;
            this.label1.Text = "Quản lý khối";
            // 
            // groupBox1
            // 
            this.groupBox1.BackgroundImage = global::QuanLyHoaMai.Properties.Resources.abstract_green_background_with_fern_leaves_101125_2408;
            this.groupBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txtGhichu);
            this.groupBox1.Controls.Add(this.txtMakhoi);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.txtTenkhoi);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.Location = new System.Drawing.Point(68, 35);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Size = new System.Drawing.Size(765, 392);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Quản lý khối";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Palatino Linotype", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.LavenderBlush;
            this.label2.Location = new System.Drawing.Point(48, 24);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(87, 26);
            this.label2.TabIndex = 9;
            this.label2.Text = "Mã khối";
            // 
            // txtGhichu
            // 
            this.txtGhichu.Location = new System.Drawing.Point(212, 117);
            this.txtGhichu.Name = "txtGhichu";
            this.txtGhichu.Size = new System.Drawing.Size(227, 21);
            this.txtGhichu.TabIndex = 14;
            // 
            // txtMakhoi
            // 
            this.txtMakhoi.Location = new System.Drawing.Point(212, 29);
            this.txtMakhoi.Name = "txtMakhoi";
            this.txtMakhoi.Size = new System.Drawing.Size(227, 21);
            this.txtMakhoi.TabIndex = 13;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Palatino Linotype", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.LavenderBlush;
            this.label4.Location = new System.Drawing.Point(48, 117);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(83, 26);
            this.label4.TabIndex = 11;
            this.label4.Text = "Ghi chú";
            // 
            // txtTenkhoi
            // 
            this.txtTenkhoi.Location = new System.Drawing.Point(212, 74);
            this.txtTenkhoi.Name = "txtTenkhoi";
            this.txtTenkhoi.Size = new System.Drawing.Size(227, 21);
            this.txtTenkhoi.TabIndex = 12;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Palatino Linotype", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.LavenderBlush;
            this.label3.Location = new System.Drawing.Point(48, 68);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(92, 26);
            this.label3.TabIndex = 10;
            this.label3.Text = "Tên khối";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.gcKhoi);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.groupBox2.Location = new System.Drawing.Point(68, 208);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox2.Size = new System.Drawing.Size(765, 219);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "groupBox2";
            // 
            // gcKhoi
            // 
            this.gcKhoi.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gcKhoi.Location = new System.Drawing.Point(3, 16);
            this.gcKhoi.MainView = this.gvKhoi;
            this.gcKhoi.Name = "gcKhoi";
            this.gcKhoi.Size = new System.Drawing.Size(759, 201);
            this.gcKhoi.TabIndex = 0;
            this.gcKhoi.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvKhoi});
            // 
            // gvKhoi
            // 
            this.gvKhoi.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colMaKhoi,
            this.colTenKhoi,
            this.colGhiChu});
            this.gvKhoi.GridControl = this.gcKhoi;
            this.gvKhoi.Name = "gvKhoi";
            this.gvKhoi.RowClick += new DevExpress.XtraGrid.Views.Grid.RowClickEventHandler(this.gvKhoi_RowClick);
            this.gvKhoi.RowCellClick += new DevExpress.XtraGrid.Views.Grid.RowCellClickEventHandler(this.gvKhoi_RowCellClick);
            this.gvKhoi.KeyDown += new System.Windows.Forms.KeyEventHandler(this.gvKhoi_KeyDown);
            this.gvKhoi.KeyUp += new System.Windows.Forms.KeyEventHandler(this.gvKhoi_KeyUp);
            // 
            // colMaKhoi
            // 
            this.colMaKhoi.Caption = "Mã Khối";
            this.colMaKhoi.FieldName = "MAKHOI";
            this.colMaKhoi.Name = "colMaKhoi";
            this.colMaKhoi.Visible = true;
            this.colMaKhoi.VisibleIndex = 0;
            // 
            // colTenKhoi
            // 
            this.colTenKhoi.Caption = "Tên Khối";
            this.colTenKhoi.FieldName = "TENKHOI";
            this.colTenKhoi.Name = "colTenKhoi";
            this.colTenKhoi.Visible = true;
            this.colTenKhoi.VisibleIndex = 1;
            // 
            // colGhiChu
            // 
            this.colGhiChu.Caption = "Ghi chú";
            this.colGhiChu.FieldName = "GHICHU";
            this.colGhiChu.Name = "colGhiChu";
            this.colGhiChu.Visible = true;
            this.colGhiChu.VisibleIndex = 2;
            // 
            // frmKhoi1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(833, 427);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.toolStrip1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "frmKhoi1";
            this.Text = "frmKhoi1";
            this.Load += new System.EventHandler(this.frmKhoi1_Load);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gcKhoi)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvKhoi)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton btnSave;
        private System.Windows.Forms.ToolStripButton btnCancel;
        private System.Windows.Forms.ToolStripButton btnDelete;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtGhichu;
        private System.Windows.Forms.TextBox txtMakhoi;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtTenkhoi;
        private System.Windows.Forms.Label label3;
        private DevExpress.XtraGrid.GridControl gcKhoi;
        private DevExpress.XtraGrid.Views.Grid.GridView gvKhoi;
        private DevExpress.XtraGrid.Columns.GridColumn colMaKhoi;
        private DevExpress.XtraGrid.Columns.GridColumn colTenKhoi;
        private DevExpress.XtraGrid.Columns.GridColumn colGhiChu;
    }
}