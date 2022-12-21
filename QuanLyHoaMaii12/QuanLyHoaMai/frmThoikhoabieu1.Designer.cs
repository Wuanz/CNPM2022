namespace QuanLyHoaMai
{
    partial class frmThoikhoabieu1
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
            this.btnSave = new System.Windows.Forms.ToolStripButton();
            this.btnDelete = new System.Windows.Forms.ToolStripLabel();
            this.btnCancel = new System.Windows.Forms.ToolStripButton();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtThu = new DevExpress.XtraEditors.TextEdit();
            this.dateeditNgay = new DevExpress.XtraEditors.DateEdit();
            this.lkMalop = new DevExpress.XtraEditors.LookUpEdit();
            this.lkMabaihoc = new DevExpress.XtraEditors.LookUpEdit();
            this.txtSTT = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.gcThoiKhoaBieu = new DevExpress.XtraGrid.GridControl();
            this.gvThoikhoabieu = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colMaBaiHoc = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMaLop = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSoThuTuTiet = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colNgay = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colThu = new DevExpress.XtraGrid.Columns.GridColumn();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.toolStrip1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtThu.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateeditNgay.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateeditNgay.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lkMalop.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lkMabaihoc.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcThoiKhoaBieu)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvThoikhoabieu)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.Dock = System.Windows.Forms.DockStyle.Left;
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnSave,
            this.btnDelete,
            this.btnCancel});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(68, 419);
            this.toolStrip1.TabIndex = 1;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // btnSave
            // 
            this.btnSave.Image = global::QuanLyHoaMai.Properties.Resources.saved;
            this.btnSave.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(65, 24);
            this.btnSave.Text = "Save";
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Image = global::QuanLyHoaMai.Properties.Resources.delete__1_;
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(65, 20);
            this.btnDelete.Text = "Delete";
            // 
            // btnCancel
            // 
            this.btnCancel.Image = global::QuanLyHoaMai.Properties.Resources._8184333;
            this.btnCancel.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(65, 24);
            this.btnCancel.Text = "Cancel";
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Dock = System.Windows.Forms.DockStyle.Top;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(68, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(250, 29);
            this.label1.TabIndex = 2;
            this.label1.Text = "Quản lý thời khóa biểu";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtThu);
            this.groupBox1.Controls.Add(this.dateeditNgay);
            this.groupBox1.Controls.Add(this.lkMalop);
            this.groupBox1.Controls.Add(this.lkMabaihoc);
            this.groupBox1.Controls.Add(this.txtSTT);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox1.Location = new System.Drawing.Point(68, 29);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Size = new System.Drawing.Size(887, 149);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "groupBox1";
            // 
            // txtThu
            // 
            this.txtThu.Location = new System.Drawing.Point(436, 108);
            this.txtThu.Name = "txtThu";
            this.txtThu.Size = new System.Drawing.Size(100, 20);
            this.txtThu.TabIndex = 17;
            // 
            // dateeditNgay
            // 
            this.dateeditNgay.EditValue = new System.DateTime(2022, 12, 16, 0, 0, 0, 0);
            this.dateeditNgay.Location = new System.Drawing.Point(436, 75);
            this.dateeditNgay.Name = "dateeditNgay";
            this.dateeditNgay.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dateeditNgay.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dateeditNgay.Size = new System.Drawing.Size(100, 20);
            this.dateeditNgay.TabIndex = 16;
            this.dateeditNgay.DateTimeChanged += new System.EventHandler(this.dateeditNgay_DateTimeChanged);
            // 
            // lkMalop
            // 
            this.lkMalop.Location = new System.Drawing.Point(141, 87);
            this.lkMalop.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.lkMalop.Name = "lkMalop";
            this.lkMalop.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.lkMalop.Size = new System.Drawing.Size(107, 20);
            this.lkMalop.TabIndex = 14;
            // 
            // lkMabaihoc
            // 
            this.lkMabaihoc.Location = new System.Drawing.Point(141, 46);
            this.lkMabaihoc.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.lkMabaihoc.Name = "lkMabaihoc";
            this.lkMabaihoc.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.lkMabaihoc.Size = new System.Drawing.Size(107, 20);
            this.lkMabaihoc.TabIndex = 13;
            // 
            // txtSTT
            // 
            this.txtSTT.Location = new System.Drawing.Point(436, 45);
            this.txtSTT.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtSTT.Name = "txtSTT";
            this.txtSTT.Size = new System.Drawing.Size(86, 21);
            this.txtSTT.TabIndex = 8;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(343, 116);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(26, 13);
            this.label7.TabIndex = 7;
            this.label7.Text = "Thứ";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(343, 83);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(32, 13);
            this.label6.TabIndex = 6;
            this.label6.Text = "Ngày";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(44, 47);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Mã bài học";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(343, 47);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(72, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Số thứ tự tiết";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(44, 89);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(38, 13);
            this.label5.TabIndex = 5;
            this.label5.Text = "Mã lớp";
            // 
            // gcThoiKhoaBieu
            // 
            this.gcThoiKhoaBieu.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gcThoiKhoaBieu.EmbeddedNavigator.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gcThoiKhoaBieu.Location = new System.Drawing.Point(3, 16);
            this.gcThoiKhoaBieu.MainView = this.gvThoikhoabieu;
            this.gcThoiKhoaBieu.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gcThoiKhoaBieu.Name = "gcThoiKhoaBieu";
            this.gcThoiKhoaBieu.Size = new System.Drawing.Size(881, 227);
            this.gcThoiKhoaBieu.TabIndex = 0;
            this.gcThoiKhoaBieu.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvThoikhoabieu});
            // 
            // gvThoikhoabieu
            // 
            this.gvThoikhoabieu.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colMaBaiHoc,
            this.colMaLop,
            this.colSoThuTuTiet,
            this.colNgay,
            this.colThu});
            this.gvThoikhoabieu.DetailHeight = 284;
            this.gvThoikhoabieu.GridControl = this.gcThoiKhoaBieu;
            this.gvThoikhoabieu.Name = "gvThoikhoabieu";
            this.gvThoikhoabieu.RowClick += new DevExpress.XtraGrid.Views.Grid.RowClickEventHandler(this.gvThoikhoabieu_RowClick);
            this.gvThoikhoabieu.RowCellClick += new DevExpress.XtraGrid.Views.Grid.RowCellClickEventHandler(this.gvThoikhoabieu_RowCellClick);
            this.gvThoikhoabieu.KeyDown += new System.Windows.Forms.KeyEventHandler(this.gvThoikhoabieu_KeyDown);
            this.gvThoikhoabieu.KeyUp += new System.Windows.Forms.KeyEventHandler(this.gvThoikhoabieu_KeyUp);
            // 
            // colMaBaiHoc
            // 
            this.colMaBaiHoc.Caption = "Mã Bài Học";
            this.colMaBaiHoc.FieldName = "MABAIHOC";
            this.colMaBaiHoc.Name = "colMaBaiHoc";
            this.colMaBaiHoc.Visible = true;
            this.colMaBaiHoc.VisibleIndex = 0;
            this.colMaBaiHoc.Width = 64;
            // 
            // colMaLop
            // 
            this.colMaLop.Caption = "Mã Lớp";
            this.colMaLop.FieldName = "MALOP";
            this.colMaLop.Name = "colMaLop";
            this.colMaLop.Visible = true;
            this.colMaLop.VisibleIndex = 1;
            this.colMaLop.Width = 64;
            // 
            // colSoThuTuTiet
            // 
            this.colSoThuTuTiet.Caption = "Số thứ thự tiết";
            this.colSoThuTuTiet.FieldName = "SOTHUTUTIET";
            this.colSoThuTuTiet.Name = "colSoThuTuTiet";
            this.colSoThuTuTiet.Visible = true;
            this.colSoThuTuTiet.VisibleIndex = 2;
            this.colSoThuTuTiet.Width = 64;
            // 
            // colNgay
            // 
            this.colNgay.Caption = "Ngày";
            this.colNgay.DisplayFormat.FormatString = "dd/MM/yyyy";
            this.colNgay.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.colNgay.FieldName = "NGAY";
            this.colNgay.Name = "colNgay";
            this.colNgay.Visible = true;
            this.colNgay.VisibleIndex = 3;
            this.colNgay.Width = 64;
            // 
            // colThu
            // 
            this.colThu.Caption = "Thứ";
            this.colThu.FieldName = "THU";
            this.colThu.Name = "colThu";
            this.colThu.Visible = true;
            this.colThu.VisibleIndex = 4;
            this.colThu.Width = 64;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.gcThoiKhoaBieu);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.groupBox2.Location = new System.Drawing.Point(68, 174);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox2.Size = new System.Drawing.Size(887, 245);
            this.groupBox2.TabIndex = 18;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "groupBox2";
            // 
            // frmThoikhoabieu1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(955, 419);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.toolStrip1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "frmThoikhoabieu1";
            this.Text = "frmThoikhoabieu1";
            this.Load += new System.EventHandler(this.frmThoikhoabieu1_Load);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtThu.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateeditNgay.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateeditNgay.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lkMalop.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lkMabaihoc.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcThoiKhoaBieu)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvThoikhoabieu)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton btnSave;
        private System.Windows.Forms.ToolStripLabel btnDelete;
        private System.Windows.Forms.ToolStripButton btnCancel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtSTT;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private DevExpress.XtraEditors.LookUpEdit lkMalop;
        private DevExpress.XtraEditors.LookUpEdit lkMabaihoc;
        private DevExpress.XtraGrid.GridControl gcThoiKhoaBieu;
        private DevExpress.XtraGrid.Views.Grid.GridView gvThoikhoabieu;
        private System.Windows.Forms.GroupBox groupBox2;
        private DevExpress.XtraGrid.Columns.GridColumn colMaBaiHoc;
        private DevExpress.XtraGrid.Columns.GridColumn colMaLop;
        private DevExpress.XtraGrid.Columns.GridColumn colSoThuTuTiet;
        private DevExpress.XtraGrid.Columns.GridColumn colNgay;
        private DevExpress.XtraGrid.Columns.GridColumn colThu;
        private DevExpress.XtraEditors.DateEdit dateeditNgay;
        private DevExpress.XtraEditors.TextEdit txtThu;
    }
}