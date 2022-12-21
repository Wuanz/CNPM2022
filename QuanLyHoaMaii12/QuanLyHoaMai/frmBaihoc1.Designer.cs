namespace QuanLyHoaMai
{
    partial class frmBaihoc1
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
            this.btnSave = new System.Windows.Forms.ToolStripLabel();
            this.btnDelete = new System.Windows.Forms.ToolStripButton();
            this.btnCancel = new System.Windows.Forms.ToolStripButton();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.gcBaiHoc = new DevExpress.XtraGrid.GridControl();
            this.gvBaihoc = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colTenBaiHoc = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMaBaiHoc = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMaKhoi = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMaMon = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSoTiet = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDungCu = new DevExpress.XtraGrid.Columns.GridColumn();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.cbSoTiet = new DevExpress.XtraEditors.ComboBoxEdit();
            this.lkMakhoi = new DevExpress.XtraEditors.LookUpEdit();
            this.lkMamon = new DevExpress.XtraEditors.LookUpEdit();
            this.label7 = new System.Windows.Forms.Label();
            this.txtMabaihoc = new System.Windows.Forms.TextBox();
            this.txtTenbaihoc = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtDungcu = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.toolStrip1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gcBaiHoc)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvBaihoc)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cbSoTiet.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lkMakhoi.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lkMamon.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.BackColor = System.Drawing.Color.Transparent;
            this.toolStrip1.Dock = System.Windows.Forms.DockStyle.Left;
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnSave,
            this.btnDelete,
            this.btnCancel});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(83, 537);
            this.toolStrip1.TabIndex = 14;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // btnSave
            // 
            this.btnSave.Font = new System.Drawing.Font("Palatino Linotype", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnSave.Image = global::QuanLyHoaMai.Properties.Resources.saved;
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(80, 21);
            this.btnSave.Text = "Save";
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Font = new System.Drawing.Font("Palatino Linotype", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnDelete.Image = global::QuanLyHoaMai.Properties.Resources.delete__1_;
            this.btnDelete.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(80, 25);
            this.btnDelete.Text = "Delete";
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnCancel.Font = new System.Drawing.Font("Palatino Linotype", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancel.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnCancel.Image = global::QuanLyHoaMai.Properties.Resources.cross_button;
            this.btnCancel.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(80, 25);
            this.btnCancel.Text = "Cancel";
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Dock = System.Windows.Forms.DockStyle.Top;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(83, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(255, 37);
            this.label1.TabIndex = 15;
            this.label1.Text = "Quản lý bài học";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.gcBaiHoc);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.groupBox1.Location = new System.Drawing.Point(83, 293);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Size = new System.Drawing.Size(960, 244);
            this.groupBox1.TabIndex = 17;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "groupBox1";
            // 
            // gcBaiHoc
            // 
            this.gcBaiHoc.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.gcBaiHoc.EmbeddedNavigator.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gcBaiHoc.Location = new System.Drawing.Point(3, 47);
            this.gcBaiHoc.MainView = this.gvBaihoc;
            this.gcBaiHoc.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gcBaiHoc.Name = "gcBaiHoc";
            this.gcBaiHoc.Size = new System.Drawing.Size(954, 195);
            this.gcBaiHoc.TabIndex = 0;
            this.gcBaiHoc.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvBaihoc});
            // 
            // gvBaihoc
            // 
            this.gvBaihoc.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colTenBaiHoc,
            this.colMaBaiHoc,
            this.colMaKhoi,
            this.colMaMon,
            this.colSoTiet,
            this.colDungCu});
            this.gvBaihoc.DetailHeight = 284;
            this.gvBaihoc.GridControl = this.gcBaiHoc;
            this.gvBaihoc.Name = "gvBaihoc";
            this.gvBaihoc.RowClick += new DevExpress.XtraGrid.Views.Grid.RowClickEventHandler(this.gvBaihoc_RowClick);
            this.gvBaihoc.RowCellClick += new DevExpress.XtraGrid.Views.Grid.RowCellClickEventHandler(this.gvBaihoc_RowCellClick);
            this.gvBaihoc.KeyDown += new System.Windows.Forms.KeyEventHandler(this.gvBaihoc_KeyDown);
            this.gvBaihoc.KeyUp += new System.Windows.Forms.KeyEventHandler(this.gvBaihoc_KeyUp);
            // 
            // colTenBaiHoc
            // 
            this.colTenBaiHoc.Caption = "Tên bài học";
            this.colTenBaiHoc.FieldName = "TENBAIHOC";
            this.colTenBaiHoc.Name = "colTenBaiHoc";
            this.colTenBaiHoc.Visible = true;
            this.colTenBaiHoc.VisibleIndex = 0;
            this.colTenBaiHoc.Width = 64;
            // 
            // colMaBaiHoc
            // 
            this.colMaBaiHoc.Caption = "Mã bài học";
            this.colMaBaiHoc.FieldName = "MABAIHOC";
            this.colMaBaiHoc.Name = "colMaBaiHoc";
            this.colMaBaiHoc.Visible = true;
            this.colMaBaiHoc.VisibleIndex = 1;
            this.colMaBaiHoc.Width = 64;
            // 
            // colMaKhoi
            // 
            this.colMaKhoi.Caption = "Mã khối";
            this.colMaKhoi.FieldName = "MAKHOI";
            this.colMaKhoi.Name = "colMaKhoi";
            this.colMaKhoi.Visible = true;
            this.colMaKhoi.VisibleIndex = 2;
            this.colMaKhoi.Width = 64;
            // 
            // colMaMon
            // 
            this.colMaMon.Caption = "Mã môn";
            this.colMaMon.FieldName = "MAMON";
            this.colMaMon.Name = "colMaMon";
            this.colMaMon.Visible = true;
            this.colMaMon.VisibleIndex = 3;
            this.colMaMon.Width = 64;
            // 
            // colSoTiet
            // 
            this.colSoTiet.Caption = "Số tiết";
            this.colSoTiet.FieldName = "SOTIET";
            this.colSoTiet.Name = "colSoTiet";
            this.colSoTiet.Visible = true;
            this.colSoTiet.VisibleIndex = 4;
            this.colSoTiet.Width = 64;
            // 
            // colDungCu
            // 
            this.colDungCu.Caption = "Dụng cụ";
            this.colDungCu.FieldName = "DUNGCU";
            this.colDungCu.Name = "colDungCu";
            this.colDungCu.Visible = true;
            this.colDungCu.VisibleIndex = 5;
            this.colDungCu.Width = 64;
            // 
            // groupBox2
            // 
            this.groupBox2.BackgroundImage = global::QuanLyHoaMai.Properties.Resources.pexels_ave_calvar_martinez_5038394;
            this.groupBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.groupBox2.Controls.Add(this.cbSoTiet);
            this.groupBox2.Controls.Add(this.lkMakhoi);
            this.groupBox2.Controls.Add(this.lkMamon);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.txtMabaihoc);
            this.groupBox2.Controls.Add(this.txtTenbaihoc);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.txtDungcu);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.groupBox2.Location = new System.Drawing.Point(83, 37);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox2.Size = new System.Drawing.Size(960, 500);
            this.groupBox2.TabIndex = 16;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Thông tin Bài học";
            this.groupBox2.Enter += new System.EventHandler(this.groupBox2_Enter);
            // 
            // cbSoTiet
            // 
            this.cbSoTiet.Location = new System.Drawing.Point(498, 64);
            this.cbSoTiet.Name = "cbSoTiet";
            this.cbSoTiet.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cbSoTiet.Size = new System.Drawing.Size(100, 20);
            this.cbSoTiet.TabIndex = 16;
            // 
            // lkMakhoi
            // 
            this.lkMakhoi.Location = new System.Drawing.Point(192, 107);
            this.lkMakhoi.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.lkMakhoi.Name = "lkMakhoi";
            this.lkMakhoi.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.lkMakhoi.Size = new System.Drawing.Size(107, 20);
            this.lkMakhoi.TabIndex = 15;
            // 
            // lkMamon
            // 
            this.lkMamon.Location = new System.Drawing.Point(495, 27);
            this.lkMamon.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.lkMamon.Name = "lkMamon";
            this.lkMamon.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.lkMamon.Size = new System.Drawing.Size(107, 20);
            this.lkMamon.TabIndex = 14;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Palatino Linotype", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label7.Location = new System.Drawing.Point(19, 65);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(110, 26);
            this.label7.TabIndex = 13;
            this.label7.Text = "Mã bài học";
            this.label7.Click += new System.EventHandler(this.label7_Click);
            // 
            // txtMabaihoc
            // 
            this.txtMabaihoc.Location = new System.Drawing.Point(192, 72);
            this.txtMabaihoc.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtMabaihoc.Name = "txtMabaihoc";
            this.txtMabaihoc.Size = new System.Drawing.Size(104, 21);
            this.txtMabaihoc.TabIndex = 12;
            this.txtMabaihoc.TextChanged += new System.EventHandler(this.txtMabaihoc_TextChanged);
            // 
            // txtTenbaihoc
            // 
            this.txtTenbaihoc.Location = new System.Drawing.Point(192, 27);
            this.txtTenbaihoc.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtTenbaihoc.Name = "txtTenbaihoc";
            this.txtTenbaihoc.Size = new System.Drawing.Size(131, 21);
            this.txtTenbaihoc.TabIndex = 11;
            this.txtTenbaihoc.TextChanged += new System.EventHandler(this.txtTenbaihoc_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Palatino Linotype", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label2.Location = new System.Drawing.Point(19, 27);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(115, 26);
            this.label2.TabIndex = 1;
            this.label2.Text = "Tên bài học";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Palatino Linotype", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label3.Location = new System.Drawing.Point(361, 99);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(88, 26);
            this.label3.TabIndex = 2;
            this.label3.Text = "Dụng cụ";
            // 
            // txtDungcu
            // 
            this.txtDungcu.Location = new System.Drawing.Point(498, 99);
            this.txtDungcu.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtDungcu.Name = "txtDungcu";
            this.txtDungcu.Size = new System.Drawing.Size(156, 21);
            this.txtDungcu.TabIndex = 10;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Palatino Linotype", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label4.Location = new System.Drawing.Point(362, 58);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(70, 26);
            this.label4.TabIndex = 3;
            this.label4.Text = "Số tiết";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Palatino Linotype", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label6.Location = new System.Drawing.Point(362, 21);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(87, 26);
            this.label6.TabIndex = 5;
            this.label6.Text = "Mã môn";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Palatino Linotype", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label5.Location = new System.Drawing.Point(19, 105);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(87, 26);
            this.label5.TabIndex = 4;
            this.label5.Text = "Mã khối";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // frmBaihoc1
            // 
            this.Appearance.BackColor = System.Drawing.Color.SeaShell;
            this.Appearance.Options.UseBackColor = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1043, 537);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.toolStrip1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "frmBaihoc1";
            this.Text = "frmBaihoc1";
            this.Load += new System.EventHandler(this.frmBaihoc1_Load);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gcBaiHoc)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvBaihoc)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cbSoTiet.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lkMakhoi.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lkMamon.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripLabel btnSave;
        private System.Windows.Forms.ToolStripButton btnDelete;
        private System.Windows.Forms.ToolStripButton btnCancel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtMabaihoc;
        private System.Windows.Forms.TextBox txtTenbaihoc;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtDungcu;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.GroupBox groupBox1;
        private DevExpress.XtraEditors.LookUpEdit lkMakhoi;
        private DevExpress.XtraEditors.LookUpEdit lkMamon;
        private DevExpress.XtraGrid.GridControl gcBaiHoc;
        private DevExpress.XtraGrid.Views.Grid.GridView gvBaihoc;
        private DevExpress.XtraGrid.Columns.GridColumn colTenBaiHoc;
        private DevExpress.XtraGrid.Columns.GridColumn colMaBaiHoc;
        private DevExpress.XtraGrid.Columns.GridColumn colMaKhoi;
        private DevExpress.XtraGrid.Columns.GridColumn colMaMon;
        private DevExpress.XtraGrid.Columns.GridColumn colSoTiet;
        private DevExpress.XtraGrid.Columns.GridColumn colDungCu;
        private DevExpress.XtraEditors.ComboBoxEdit cbSoTiet;
    }
}