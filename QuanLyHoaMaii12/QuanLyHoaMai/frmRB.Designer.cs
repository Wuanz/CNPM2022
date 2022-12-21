namespace QuanLyHoaMai
{
    partial class frmRB
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
            DevExpress.Utils.Animation.PushTransition pushTransition1 = new DevExpress.Utils.Animation.PushTransition();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmRB));
            this.repositoryItemImageEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemImageEdit();
            this.repositoryItemPictureEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemPictureEdit();
            this.ribbon = new DevExpress.XtraBars.Ribbon.RibbonControl();
            this.barLinkContainerItem1 = new DevExpress.XtraBars.BarLinkContainerItem();
            this.barListItem1 = new DevExpress.XtraBars.BarListItem();
            this.barWorkspaceMenuItem1 = new DevExpress.XtraBars.BarWorkspaceMenuItem();
            this.workspaceManager1 = new DevExpress.Utils.WorkspaceManager(this.components);
            this.menuKhoi_Click = new DevExpress.XtraBars.BarButtonItem();
            this.menuLop_Click = new DevExpress.XtraBars.BarButtonItem();
            this.menuMonhoc_Click = new DevExpress.XtraBars.BarButtonItem();
            this.menuBaihocClick = new DevExpress.XtraBars.BarButtonItem();
            this.menuTkb_Click = new DevExpress.XtraBars.BarButtonItem();
            this.menuReport_Click = new DevExpress.XtraBars.BarButtonItem();
            this.barStaticItem1 = new DevExpress.XtraBars.BarStaticItem();
            this.ribbonPage1 = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroup1 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPageGroup2 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonStatusBar = new DevExpress.XtraBars.Ribbon.RibbonStatusBar();
            this.documentManager1 = new DevExpress.XtraBars.Docking2010.DocumentManager(this.components);
            this.tabbedView1 = new DevExpress.XtraBars.Docking2010.Views.Tabbed.TabbedView(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemImageEdit1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemPictureEdit1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ribbon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.documentManager1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tabbedView1)).BeginInit();
            this.SuspendLayout();
            // 
            // repositoryItemImageEdit1
            // 
            this.repositoryItemImageEdit1.AutoHeight = false;
            this.repositoryItemImageEdit1.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repositoryItemImageEdit1.Name = "repositoryItemImageEdit1";
            // 
            // repositoryItemPictureEdit1
            // 
            this.repositoryItemPictureEdit1.Name = "repositoryItemPictureEdit1";
            // 
            // ribbon
            // 
            this.ribbon.EmptyAreaImageOptions.ImagePadding = new System.Windows.Forms.Padding(26, 24, 26, 24);
            this.ribbon.ExpandCollapseItem.Id = 0;
            this.ribbon.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.ribbon.ExpandCollapseItem,
            this.ribbon.SearchEditItem,
            this.barLinkContainerItem1,
            this.barListItem1,
            this.barWorkspaceMenuItem1,
            this.menuKhoi_Click,
            this.menuLop_Click,
            this.menuMonhoc_Click,
            this.menuBaihocClick,
            this.menuTkb_Click,
            this.menuReport_Click,
            this.barStaticItem1});
            this.ribbon.Location = new System.Drawing.Point(0, 0);
            this.ribbon.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ribbon.MaxItemId = 19;
            this.ribbon.Name = "ribbon";
            this.ribbon.OptionsMenuMinWidth = 283;
            this.ribbon.Pages.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPage[] {
            this.ribbonPage1});
            this.ribbon.Size = new System.Drawing.Size(913, 158);
            this.ribbon.StatusBar = this.ribbonStatusBar;
            // 
            // barLinkContainerItem1
            // 
            this.barLinkContainerItem1.Caption = "barLinkContainerItem1";
            this.barLinkContainerItem1.Id = 5;
            this.barLinkContainerItem1.Name = "barLinkContainerItem1";
            // 
            // barListItem1
            // 
            this.barListItem1.Caption = "Khoi";
            this.barListItem1.Id = 6;
            this.barListItem1.Name = "barListItem1";
            // 
            // barWorkspaceMenuItem1
            // 
            this.barWorkspaceMenuItem1.Caption = "khoi";
            this.barWorkspaceMenuItem1.Id = 7;
            this.barWorkspaceMenuItem1.Name = "barWorkspaceMenuItem1";
            this.barWorkspaceMenuItem1.WorkspaceManager = this.workspaceManager1;
            // 
            // workspaceManager1
            // 
            this.workspaceManager1.TargetControl = this;
            this.workspaceManager1.TransitionType = pushTransition1;
            // 
            // menuKhoi_Click
            // 
            this.menuKhoi_Click.Caption = "Khối";
            this.menuKhoi_Click.Id = 8;
            this.menuKhoi_Click.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("menuKhoi_Click.ImageOptions.SvgImage")));
            this.menuKhoi_Click.Name = "menuKhoi_Click";
            this.menuKhoi_Click.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.menuKhoi_Click_ItemClick);
            // 
            // menuLop_Click
            // 
            this.menuLop_Click.Caption = "Lớp";
            this.menuLop_Click.Id = 9;
            this.menuLop_Click.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("menuLop_Click.ImageOptions.SvgImage")));
            this.menuLop_Click.Name = "menuLop_Click";
            this.menuLop_Click.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.menuLop_Click_ItemClick);
            // 
            // menuMonhoc_Click
            // 
            this.menuMonhoc_Click.Caption = "Môn học";
            this.menuMonhoc_Click.Id = 10;
            this.menuMonhoc_Click.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("menuMonhoc_Click.ImageOptions.SvgImage")));
            this.menuMonhoc_Click.Name = "menuMonhoc_Click";
            this.menuMonhoc_Click.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.menuMonhoc_Click_ItemClick);
            // 
            // menuBaihocClick
            // 
            this.menuBaihocClick.Caption = "Bài học";
            this.menuBaihocClick.Id = 11;
            this.menuBaihocClick.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("menuBaihocClick.ImageOptions.SvgImage")));
            this.menuBaihocClick.Name = "menuBaihocClick";
            this.menuBaihocClick.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.menuBaihocClick_ItemClick);
            // 
            // menuTkb_Click
            // 
            this.menuTkb_Click.Caption = "Thời khóa biểu";
            this.menuTkb_Click.Id = 12;
            this.menuTkb_Click.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("menuTkb_Click.ImageOptions.SvgImage")));
            this.menuTkb_Click.Name = "menuTkb_Click";
            this.menuTkb_Click.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.menuTkb_Click_ItemClick);
            // 
            // menuReport_Click
            // 
            this.menuReport_Click.Caption = "Report Khối";
            this.menuReport_Click.Id = 13;
            this.menuReport_Click.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("menuReport_Click.ImageOptions.SvgImage")));
            this.menuReport_Click.Name = "menuReport_Click";
            this.menuReport_Click.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barButtonItem1_ItemClick);
            // 
            // barStaticItem1
            // 
            this.barStaticItem1.Caption = "Report Lớp";
            this.barStaticItem1.Id = 17;
            this.barStaticItem1.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("barStaticItem1.ImageOptions.SvgImage")));
            this.barStaticItem1.Name = "barStaticItem1";
            this.barStaticItem1.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph;
            // 
            // ribbonPage1
            // 
            this.ribbonPage1.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.ribbonPageGroup1,
            this.ribbonPageGroup2});
            this.ribbonPage1.Name = "ribbonPage1";
            this.ribbonPage1.Text = "Danh mục";
            // 
            // ribbonPageGroup1
            // 
            this.ribbonPageGroup1.ItemLinks.Add(this.menuKhoi_Click, true);
            this.ribbonPageGroup1.ItemLinks.Add(this.menuLop_Click, true);
            this.ribbonPageGroup1.ItemLinks.Add(this.menuMonhoc_Click, true);
            this.ribbonPageGroup1.ItemLinks.Add(this.menuBaihocClick, true);
            this.ribbonPageGroup1.ItemLinks.Add(this.menuTkb_Click, true);
            this.ribbonPageGroup1.Name = "ribbonPageGroup1";
            this.ribbonPageGroup1.Text = "Danh mục dùng chung";
            // 
            // ribbonPageGroup2
            // 
            this.ribbonPageGroup2.ItemLinks.Add(this.menuReport_Click);
            this.ribbonPageGroup2.ItemLinks.Add(this.barStaticItem1);
            this.ribbonPageGroup2.Name = "ribbonPageGroup2";
            this.ribbonPageGroup2.Text = "Report";
            // 
            // ribbonStatusBar
            // 
            this.ribbonStatusBar.Location = new System.Drawing.Point(0, 426);
            this.ribbonStatusBar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ribbonStatusBar.Name = "ribbonStatusBar";
            this.ribbonStatusBar.Ribbon = this.ribbon;
            this.ribbonStatusBar.Size = new System.Drawing.Size(913, 22);
            // 
            // documentManager1
            // 
            this.documentManager1.MdiParent = this;
            this.documentManager1.MenuManager = this.ribbon;
            this.documentManager1.View = this.tabbedView1;
            this.documentManager1.ViewCollection.AddRange(new DevExpress.XtraBars.Docking2010.Views.BaseView[] {
            this.tabbedView1});
            // 
            // frmRB
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(913, 448);
            this.Controls.Add(this.ribbonStatusBar);
            this.Controls.Add(this.ribbon);
            this.IsMdiContainer = true;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "frmRB";
            this.Ribbon = this.ribbon;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.StatusBar = this.ribbonStatusBar;
            this.Text = "Quản lý trường Hoa Mai";
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemImageEdit1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemPictureEdit1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ribbon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.documentManager1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tabbedView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraBars.Ribbon.RibbonControl ribbon;
        private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPage1;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup1;
        private DevExpress.XtraBars.Ribbon.RibbonStatusBar ribbonStatusBar;
        private DevExpress.XtraBars.BarListItem barListItem1;
        private DevExpress.XtraBars.BarWorkspaceMenuItem barWorkspaceMenuItem1;
        private DevExpress.Utils.WorkspaceManager workspaceManager1;
        private DevExpress.XtraBars.BarLinkContainerItem barLinkContainerItem1;
        private DevExpress.XtraBars.BarButtonItem menuKhoi_Click;
        private DevExpress.XtraBars.BarButtonItem menuLop_Click;
        private DevExpress.XtraBars.BarButtonItem menuMonhoc_Click;
        private DevExpress.XtraBars.BarButtonItem menuBaihocClick;
        private DevExpress.XtraBars.BarButtonItem menuTkb_Click;
        private DevExpress.XtraBars.Docking2010.DocumentManager documentManager1;
        private DevExpress.XtraBars.Docking2010.Views.Tabbed.TabbedView tabbedView1;
        private DevExpress.XtraBars.BarButtonItem menuReport_Click;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup2;
        private DevExpress.XtraEditors.Repository.RepositoryItemImageEdit repositoryItemImageEdit1;
        private DevExpress.XtraEditors.Repository.RepositoryItemPictureEdit repositoryItemPictureEdit1;
        private DevExpress.XtraBars.BarStaticItem barStaticItem1;
    }
}