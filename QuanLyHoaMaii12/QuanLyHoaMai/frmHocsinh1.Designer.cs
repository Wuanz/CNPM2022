namespace QuanLyHoaMai
{
    partial class frmHocsinh1
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
            this.components = new System.ComponentModel.Container();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.btnSave = new System.Windows.Forms.ToolStripButton();
            this.btnDelete = new System.Windows.Forms.ToolStripButton();
            this.btnCancel = new System.Windows.Forms.ToolStripButton();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.gcHocsinh = new DevExpress.XtraGrid.GridControl();
            this.hOCSINHBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gvHocsinh = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colMAHOCSINH = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTENHOCSINH = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDIEM = new DevExpress.XtraGrid.Columns.GridColumn();
            this.cbDiem = new DevExpress.XtraEditors.ComboBoxEdit();
            this.txtTenhocsinh = new System.Windows.Forms.Label();
            this.txtTenhocsinh1 = new System.Windows.Forms.TextBox();
            this.txtMahocsinh1 = new System.Windows.Forms.TextBox();
            this.txtMahocsinh = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.toolStrip1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gcHocsinh)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hOCSINHBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvHocsinh)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbDiem.Properties)).BeginInit();
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
            this.toolStrip1.Size = new System.Drawing.Size(83, 621);
            this.toolStrip1.TabIndex = 15;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // btnSave
            // 
            this.btnSave.Font = new System.Drawing.Font("Palatino Linotype", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnSave.Image = global::QuanLyHoaMai.Properties.Resources.saved;
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(80, 25);
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
            this.label1.Size = new System.Drawing.Size(272, 37);
            this.label1.TabIndex = 16;
            this.label1.Text = "Quản lý học sinh";
            // 
            // groupBox2
            // 
            this.groupBox2.BackgroundImage = global::QuanLyHoaMai.Properties.Resources.teacher_backtoschool;
            this.groupBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.groupBox2.Controls.Add(this.groupBox1);
            this.groupBox2.Controls.Add(this.cbDiem);
            this.groupBox2.Controls.Add(this.txtTenhocsinh);
            this.groupBox2.Controls.Add(this.txtTenhocsinh1);
            this.groupBox2.Controls.Add(this.txtMahocsinh1);
            this.groupBox2.Controls.Add(this.txtMahocsinh);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.groupBox2.Location = new System.Drawing.Point(83, 37);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox2.Size = new System.Drawing.Size(1396, 584);
            this.groupBox2.TabIndex = 17;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Thông tin Bài học";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.gcHocsinh);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.groupBox1.Location = new System.Drawing.Point(3, 389);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Size = new System.Drawing.Size(1390, 193);
            this.groupBox1.TabIndex = 19;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Quản lý thông tin";
            // 
            // gcHocsinh
            // 
            this.gcHocsinh.DataSource = this.hOCSINHBindingSource;
            this.gcHocsinh.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gcHocsinh.EmbeddedNavigator.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gcHocsinh.Location = new System.Drawing.Point(3, 16);
            this.gcHocsinh.MainView = this.gvHocsinh;
            this.gcHocsinh.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gcHocsinh.Name = "gcHocsinh";
            this.gcHocsinh.Size = new System.Drawing.Size(1384, 175);
            this.gcHocsinh.TabIndex = 0;
            this.gcHocsinh.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvHocsinh});
            // 
            // hOCSINHBindingSource
            // 
            this.hOCSINHBindingSource.DataSource = typeof(QuanLyHoaMai.HOCSINH);
            // 
            // gvHocsinh
            // 
            this.gvHocsinh.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colMAHOCSINH,
            this.colTENHOCSINH,
            this.colDIEM});
            this.gvHocsinh.DetailHeight = 284;
            this.gvHocsinh.GridControl = this.gcHocsinh;
            this.gvHocsinh.Name = "gvHocsinh";
            this.gvHocsinh.RowClick += new DevExpress.XtraGrid.Views.Grid.RowClickEventHandler(this.gvHocsinh_RowClick);
            this.gvHocsinh.RowCellClick += new DevExpress.XtraGrid.Views.Grid.RowCellClickEventHandler(this.gvHocsinh_RowCellClick);
            this.gvHocsinh.KeyDown += new System.Windows.Forms.KeyEventHandler(this.gvHocsinh_KeyDown);
            this.gvHocsinh.KeyUp += new System.Windows.Forms.KeyEventHandler(this.gvHocsinh_KeyUp);
            // 
            // colMAHOCSINH
            // 
            this.colMAHOCSINH.FieldName = "MAHOCSINH";
            this.colMAHOCSINH.MinWidth = 21;
            this.colMAHOCSINH.Name = "colMAHOCSINH";
            this.colMAHOCSINH.Visible = true;
            this.colMAHOCSINH.VisibleIndex = 0;
            this.colMAHOCSINH.Width = 81;
            // 
            // colTENHOCSINH
            // 
            this.colTENHOCSINH.FieldName = "TENHOCSINH";
            this.colTENHOCSINH.MinWidth = 21;
            this.colTENHOCSINH.Name = "colTENHOCSINH";
            this.colTENHOCSINH.Visible = true;
            this.colTENHOCSINH.VisibleIndex = 1;
            this.colTENHOCSINH.Width = 81;
            // 
            // colDIEM
            // 
            this.colDIEM.FieldName = "DIEM";
            this.colDIEM.MinWidth = 21;
            this.colDIEM.Name = "colDIEM";
            this.colDIEM.Visible = true;
            this.colDIEM.VisibleIndex = 2;
            this.colDIEM.Width = 81;
            // 
            // cbDiem
            // 
            this.cbDiem.Location = new System.Drawing.Point(883, 325);
            this.cbDiem.Name = "cbDiem";
            this.cbDiem.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbDiem.Properties.Appearance.Options.UseFont = true;
            this.cbDiem.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cbDiem.Size = new System.Drawing.Size(100, 26);
            this.cbDiem.TabIndex = 17;
            // 
            // txtTenhocsinh
            // 
            this.txtTenhocsinh.AutoSize = true;
            this.txtTenhocsinh.BackColor = System.Drawing.Color.Transparent;
            this.txtTenhocsinh.Font = new System.Drawing.Font("Palatino Linotype", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTenhocsinh.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.txtTenhocsinh.Location = new System.Drawing.Point(710, 282);
            this.txtTenhocsinh.Name = "txtTenhocsinh";
            this.txtTenhocsinh.Size = new System.Drawing.Size(125, 26);
            this.txtTenhocsinh.TabIndex = 13;
            this.txtTenhocsinh.Text = "Tên học sinh";
            // 
            // txtTenhocsinh1
            // 
            this.txtTenhocsinh1.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTenhocsinh1.Location = new System.Drawing.Point(883, 282);
            this.txtTenhocsinh1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtTenhocsinh1.Name = "txtTenhocsinh1";
            this.txtTenhocsinh1.Size = new System.Drawing.Size(104, 27);
            this.txtTenhocsinh1.TabIndex = 12;
            // 
            // txtMahocsinh1
            // 
            this.txtMahocsinh1.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMahocsinh1.Location = new System.Drawing.Point(883, 240);
            this.txtMahocsinh1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtMahocsinh1.Name = "txtMahocsinh1";
            this.txtMahocsinh1.Size = new System.Drawing.Size(104, 27);
            this.txtMahocsinh1.TabIndex = 11;
            // 
            // txtMahocsinh
            // 
            this.txtMahocsinh.AutoSize = true;
            this.txtMahocsinh.BackColor = System.Drawing.Color.Transparent;
            this.txtMahocsinh.Font = new System.Drawing.Font("Palatino Linotype", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMahocsinh.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.txtMahocsinh.Location = new System.Drawing.Point(710, 244);
            this.txtMahocsinh.Name = "txtMahocsinh";
            this.txtMahocsinh.Size = new System.Drawing.Size(120, 26);
            this.txtMahocsinh.TabIndex = 1;
            this.txtMahocsinh.Text = "Mã học sinh";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Palatino Linotype", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label4.Location = new System.Drawing.Point(727, 324);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(62, 26);
            this.label4.TabIndex = 3;
            this.label4.Text = "Điểm";
            // 
            // frmHocsinh1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1479, 621);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.toolStrip1);
            this.Name = "frmHocsinh1";
            this.Text = "frmHocsinh1";
            this.Load += new System.EventHandler(this.frmHocsinh1_Load);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gcHocsinh)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hOCSINHBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvHocsinh)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbDiem.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton btnDelete;
        private System.Windows.Forms.ToolStripButton btnCancel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label txtTenhocsinh;
        private System.Windows.Forms.TextBox txtTenhocsinh1;
        private System.Windows.Forms.TextBox txtMahocsinh1;
        private System.Windows.Forms.Label txtMahocsinh;
        private System.Windows.Forms.Label label4;
        private DevExpress.XtraEditors.ComboBoxEdit cbDiem;
        private System.Windows.Forms.GroupBox groupBox1;
        private DevExpress.XtraGrid.GridControl gcHocsinh;
        private DevExpress.XtraGrid.Views.Grid.GridView gvHocsinh;
        private System.Windows.Forms.ToolStripButton btnSave;
        private System.Windows.Forms.BindingSource hOCSINHBindingSource;
        private DevExpress.XtraGrid.Columns.GridColumn colMAHOCSINH;
        private DevExpress.XtraGrid.Columns.GridColumn colTENHOCSINH;
        private DevExpress.XtraGrid.Columns.GridColumn colDIEM;
    }
}