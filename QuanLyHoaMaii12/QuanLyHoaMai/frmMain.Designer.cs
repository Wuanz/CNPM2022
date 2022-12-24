
namespace QuanLyHoaMai
{
    partial class frmMain
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.menuStrip2 = new System.Windows.Forms.MenuStrip();
            this.tìmKiếmToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuKhoi_Click = new System.Windows.Forms.ToolStripMenuItem();
            this.lớpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.monhoc = new System.Windows.Forms.ToolStripMenuItem();
            this.baihoc = new System.Windows.Forms.ToolStripMenuItem();
            this.thờiKhóaBiểuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.inẤnToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exportImportToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.backUpRestoreToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.thôngTinPhầnMềmToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip2.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Location = new System.Drawing.Point(0, 33);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(5, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(1067, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // menuStrip2
            // 
            this.menuStrip2.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tìmKiếmToolStripMenuItem,
            this.inẤnToolStripMenuItem,
            this.exportImportToolStripMenuItem,
            this.backUpRestoreToolStripMenuItem,
            this.thôngTinPhầnMềmToolStripMenuItem});
            this.menuStrip2.Location = new System.Drawing.Point(0, 0);
            this.menuStrip2.Name = "menuStrip2";
            this.menuStrip2.Padding = new System.Windows.Forms.Padding(5, 2, 0, 2);
            this.menuStrip2.Size = new System.Drawing.Size(1067, 33);
            this.menuStrip2.TabIndex = 1;
            this.menuStrip2.Text = "menuStrip2";
            // 
            // tìmKiếmToolStripMenuItem
            // 
            this.tìmKiếmToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuKhoi_Click,
            this.lớpToolStripMenuItem,
            this.monhoc,
            this.baihoc,
            this.thờiKhóaBiểuToolStripMenuItem});
            this.tìmKiếmToolStripMenuItem.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tìmKiếmToolStripMenuItem.Image = global::QuanLyHoaMai.Properties.Resources.search;
            this.tìmKiếmToolStripMenuItem.Name = "tìmKiếmToolStripMenuItem";
            this.tìmKiếmToolStripMenuItem.Size = new System.Drawing.Size(133, 29);
            this.tìmKiếmToolStripMenuItem.Text = "Tìm kiếm";
            // 
            // menuKhoi_Click
            // 
            this.menuKhoi_Click.Image = global::QuanLyHoaMai.Properties.Resources.group_class;
            this.menuKhoi_Click.Name = "menuKhoi_Click";
            this.menuKhoi_Click.Size = new System.Drawing.Size(241, 30);
            this.menuKhoi_Click.Text = "Khối";
            this.menuKhoi_Click.Click += new System.EventHandler(this.menuKhoi_Click_Click);
            // 
            // lớpToolStripMenuItem
            // 
            this.lớpToolStripMenuItem.Image = global::QuanLyHoaMai.Properties.Resources.teaching;
            this.lớpToolStripMenuItem.Name = "lớpToolStripMenuItem";
            this.lớpToolStripMenuItem.Size = new System.Drawing.Size(241, 30);
            this.lớpToolStripMenuItem.Text = "Lớp";
            this.lớpToolStripMenuItem.Click += new System.EventHandler(this.menuLop_Click);
            // 
            // monhoc
            // 
            this.monhoc.Image = global::QuanLyHoaMai.Properties.Resources.library;
            this.monhoc.Name = "monhoc";
            this.monhoc.Size = new System.Drawing.Size(241, 30);
            this.monhoc.Text = "Môn học";
            this.monhoc.Click += new System.EventHandler(this.menuMonhoc_Click);
            // 
            // baihoc
            // 
            this.baihoc.Image = global::QuanLyHoaMai.Properties.Resources.video_lesson;
            this.baihoc.Name = "baihoc";
            this.baihoc.Size = new System.Drawing.Size(241, 30);
            this.baihoc.Text = "Bài học";
            this.baihoc.Click += new System.EventHandler(this.baihoc_Click);
            // 
            // thờiKhóaBiểuToolStripMenuItem
            // 
            this.thờiKhóaBiểuToolStripMenuItem.Image = global::QuanLyHoaMai.Properties.Resources.schedule;
            this.thờiKhóaBiểuToolStripMenuItem.Name = "thờiKhóaBiểuToolStripMenuItem";
            this.thờiKhóaBiểuToolStripMenuItem.Size = new System.Drawing.Size(241, 30);
            this.thờiKhóaBiểuToolStripMenuItem.Text = "Thời khóa biểu";
            this.thờiKhóaBiểuToolStripMenuItem.Click += new System.EventHandler(this.thờiKhóaBiểuToolStripMenuItem_Click);
            // 
            // inẤnToolStripMenuItem
            // 
            this.inẤnToolStripMenuItem.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.inẤnToolStripMenuItem.Image = global::QuanLyHoaMai.Properties.Resources.copy;
            this.inẤnToolStripMenuItem.Name = "inẤnToolStripMenuItem";
            this.inẤnToolStripMenuItem.Size = new System.Drawing.Size(107, 29);
            this.inẤnToolStripMenuItem.Text = "In / ấn";
            // 
            // exportImportToolStripMenuItem
            // 
            this.exportImportToolStripMenuItem.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.exportImportToolStripMenuItem.Image = global::QuanLyHoaMai.Properties.Resources.data__1_;
            this.exportImportToolStripMenuItem.Name = "exportImportToolStripMenuItem";
            this.exportImportToolStripMenuItem.Size = new System.Drawing.Size(181, 29);
            this.exportImportToolStripMenuItem.Text = "Export/ Import";
            // 
            // backUpRestoreToolStripMenuItem
            // 
            this.backUpRestoreToolStripMenuItem.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.backUpRestoreToolStripMenuItem.Image = global::QuanLyHoaMai.Properties.Resources.data;
            this.backUpRestoreToolStripMenuItem.Name = "backUpRestoreToolStripMenuItem";
            this.backUpRestoreToolStripMenuItem.Size = new System.Drawing.Size(211, 29);
            this.backUpRestoreToolStripMenuItem.Text = "Back up/ Restore";
            // 
            // thôngTinPhầnMềmToolStripMenuItem
            // 
            this.thôngTinPhầnMềmToolStripMenuItem.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.thôngTinPhầnMềmToolStripMenuItem.Image = global::QuanLyHoaMai.Properties.Resources.information;
            this.thôngTinPhầnMềmToolStripMenuItem.Name = "thôngTinPhầnMềmToolStripMenuItem";
            this.thôngTinPhầnMềmToolStripMenuItem.Size = new System.Drawing.Size(243, 29);
            this.thôngTinPhầnMềmToolStripMenuItem.Text = "Thông tin phần mềm";
            this.thôngTinPhầnMềmToolStripMenuItem.Click += new System.EventHandler(this.thôngTinPhầnMềmToolStripMenuItem_Click);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 554);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.menuStrip2);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "frmMain";
            this.Text = "Quan Ly Hoa Mai";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.menuStrip2.ResumeLayout(false);
            this.menuStrip2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.MenuStrip menuStrip2;
        private System.Windows.Forms.ToolStripMenuItem tìmKiếmToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem menuKhoi_Click;
        private System.Windows.Forms.ToolStripMenuItem lớpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem monhoc;
        private System.Windows.Forms.ToolStripMenuItem inẤnToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exportImportToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem backUpRestoreToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem thôngTinPhầnMềmToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem baihoc;
        private System.Windows.Forms.ToolStripMenuItem thờiKhóaBiểuToolStripMenuItem;
    }
}