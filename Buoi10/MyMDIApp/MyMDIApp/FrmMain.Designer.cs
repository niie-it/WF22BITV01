namespace MyMDIApp
{
    partial class FrmMain
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmMain));
            menuStrip1 = new MenuStrip();
            hệThốngToolStripMenuItem = new ToolStripMenuItem();
            mnuDangNhap = new ToolStripMenuItem();
            ngườiDùngToolStripMenuItem = new ToolStripMenuItem();
            mnuQuanLyNhanVien = new ToolStripMenuItem();
            toolStripSeparator1 = new ToolStripSeparator();
            đóngTấtCảFormConToolStripMenuItem = new ToolStripMenuItem();
            mnuDangXuat = new ToolStripMenuItem();
            thoátToolStripMenuItem = new ToolStripMenuItem();
            windoToolStripMenuItem = new ToolStripMenuItem();
            sắpXếpToolStripMenuItem = new ToolStripMenuItem();
            cascadeToolStripMenuItem = new ToolStripMenuItem();
            tileHorizontalToolStripMenuItem = new ToolStripMenuItem();
            tileVerticalToolStripMenuItem = new ToolStripMenuItem();
            arrangeIconToolStripMenuItem = new ToolStripMenuItem();
            toolStrip1 = new ToolStrip();
            toolStripButton1 = new ToolStripButton();
            toolStripButton2 = new ToolStripButton();
            statusStrip1 = new StatusStrip();
            lblThongTin = new ToolStripStatusLabel();
            menuStrip1.SuspendLayout();
            toolStrip1.SuspendLayout();
            statusStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(40, 40);
            menuStrip1.Items.AddRange(new ToolStripItem[] { hệThốngToolStripMenuItem, windoToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(984, 49);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // hệThốngToolStripMenuItem
            // 
            hệThốngToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { mnuDangNhap, ngườiDùngToolStripMenuItem, mnuQuanLyNhanVien, toolStripSeparator1, đóngTấtCảFormConToolStripMenuItem, mnuDangXuat, thoátToolStripMenuItem });
            hệThốngToolStripMenuItem.Name = "hệThốngToolStripMenuItem";
            hệThốngToolStripMenuItem.Size = new Size(167, 45);
            hệThốngToolStripMenuItem.Text = "Hệ thống";
            // 
            // mnuDangNhap
            // 
            mnuDangNhap.Name = "mnuDangNhap";
            mnuDangNhap.Size = new Size(466, 54);
            mnuDangNhap.Text = "Đăng nhập";
            mnuDangNhap.Click += đăngNhậpToolStripMenuItem_Click;
            // 
            // ngườiDùngToolStripMenuItem
            // 
            ngườiDùngToolStripMenuItem.Name = "ngườiDùngToolStripMenuItem";
            ngườiDùngToolStripMenuItem.Size = new Size(466, 54);
            ngườiDùngToolStripMenuItem.Text = "Người dùng";
            // 
            // mnuQuanLyNhanVien
            // 
            mnuQuanLyNhanVien.Name = "mnuQuanLyNhanVien";
            mnuQuanLyNhanVien.Size = new Size(466, 54);
            mnuQuanLyNhanVien.Text = "Quản lý Nhân viên";
            mnuQuanLyNhanVien.Click += quảnLýNhânViênToolStripMenuItem_Click;
            // 
            // toolStripSeparator1
            // 
            toolStripSeparator1.Name = "toolStripSeparator1";
            toolStripSeparator1.Size = new Size(463, 6);
            // 
            // đóngTấtCảFormConToolStripMenuItem
            // 
            đóngTấtCảFormConToolStripMenuItem.Name = "đóngTấtCảFormConToolStripMenuItem";
            đóngTấtCảFormConToolStripMenuItem.Size = new Size(466, 54);
            đóngTấtCảFormConToolStripMenuItem.Text = "Đóng tất cả form con";
            đóngTấtCảFormConToolStripMenuItem.Click += đóngTấtCảFormConToolStripMenuItem_Click;
            // 
            // mnuDangXuat
            // 
            mnuDangXuat.Name = "mnuDangXuat";
            mnuDangXuat.Size = new Size(466, 54);
            mnuDangXuat.Text = "Đăng xuất";
            // 
            // thoátToolStripMenuItem
            // 
            thoátToolStripMenuItem.Name = "thoátToolStripMenuItem";
            thoátToolStripMenuItem.Size = new Size(466, 54);
            thoátToolStripMenuItem.Text = "Đóng chương trình";
            // 
            // windoToolStripMenuItem
            // 
            windoToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { sắpXếpToolStripMenuItem });
            windoToolStripMenuItem.Name = "windoToolStripMenuItem";
            windoToolStripMenuItem.Size = new Size(144, 45);
            windoToolStripMenuItem.Text = "Tiện ích";
            // 
            // sắpXếpToolStripMenuItem
            // 
            sắpXếpToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { cascadeToolStripMenuItem, tileHorizontalToolStripMenuItem, tileVerticalToolStripMenuItem, arrangeIconToolStripMenuItem });
            sắpXếpToolStripMenuItem.Name = "sắpXếpToolStripMenuItem";
            sắpXếpToolStripMenuItem.Size = new Size(289, 54);
            sắpXếpToolStripMenuItem.Text = "Sắp xếp";
            // 
            // cascadeToolStripMenuItem
            // 
            cascadeToolStripMenuItem.Name = "cascadeToolStripMenuItem";
            cascadeToolStripMenuItem.Size = new Size(383, 54);
            cascadeToolStripMenuItem.Text = "Cascade";
            cascadeToolStripMenuItem.Click += cascadeToolStripMenuItem_Click;
            // 
            // tileHorizontalToolStripMenuItem
            // 
            tileHorizontalToolStripMenuItem.Name = "tileHorizontalToolStripMenuItem";
            tileHorizontalToolStripMenuItem.Size = new Size(383, 54);
            tileHorizontalToolStripMenuItem.Text = "Tile  Horizontal";
            tileHorizontalToolStripMenuItem.Click += tileHorizontalToolStripMenuItem_Click;
            // 
            // tileVerticalToolStripMenuItem
            // 
            tileVerticalToolStripMenuItem.Name = "tileVerticalToolStripMenuItem";
            tileVerticalToolStripMenuItem.Size = new Size(383, 54);
            tileVerticalToolStripMenuItem.Text = "Tile Vertical";
            tileVerticalToolStripMenuItem.Click += tileVerticalToolStripMenuItem_Click;
            // 
            // arrangeIconToolStripMenuItem
            // 
            arrangeIconToolStripMenuItem.Name = "arrangeIconToolStripMenuItem";
            arrangeIconToolStripMenuItem.Size = new Size(383, 54);
            arrangeIconToolStripMenuItem.Text = "Arrange  Icon";
            arrangeIconToolStripMenuItem.Click += arrangeIconToolStripMenuItem_Click;
            // 
            // toolStrip1
            // 
            toolStrip1.ImageScalingSize = new Size(40, 40);
            toolStrip1.Items.AddRange(new ToolStripItem[] { toolStripButton1, toolStripButton2 });
            toolStrip1.Location = new Point(0, 49);
            toolStrip1.Name = "toolStrip1";
            toolStrip1.Size = new Size(984, 51);
            toolStrip1.TabIndex = 1;
            toolStrip1.Text = "toolStrip1";
            // 
            // toolStripButton1
            // 
            toolStripButton1.DisplayStyle = ToolStripItemDisplayStyle.Image;
            toolStripButton1.Image = (Image)resources.GetObject("toolStripButton1.Image");
            toolStripButton1.ImageTransparentColor = Color.Magenta;
            toolStripButton1.Name = "toolStripButton1";
            toolStripButton1.Size = new Size(58, 44);
            toolStripButton1.Text = "toolStripButton1";
            // 
            // toolStripButton2
            // 
            toolStripButton2.DisplayStyle = ToolStripItemDisplayStyle.Image;
            toolStripButton2.Image = (Image)resources.GetObject("toolStripButton2.Image");
            toolStripButton2.ImageTransparentColor = Color.Magenta;
            toolStripButton2.Name = "toolStripButton2";
            toolStripButton2.Size = new Size(58, 44);
            toolStripButton2.Text = "toolStripButton2";
            // 
            // statusStrip1
            // 
            statusStrip1.ImageScalingSize = new Size(40, 40);
            statusStrip1.Items.AddRange(new ToolStripItem[] { lblThongTin });
            statusStrip1.Location = new Point(0, 574);
            statusStrip1.Name = "statusStrip1";
            statusStrip1.Size = new Size(984, 54);
            statusStrip1.TabIndex = 3;
            statusStrip1.Text = "statusStrip1";
            // 
            // lblThongTin
            // 
            lblThongTin.Name = "lblThongTin";
            lblThongTin.Size = new Size(290, 41);
            lblThongTin.Text = "Bạn chưa đăng nhập";
            // 
            // FrmMain
            // 
            AutoScaleDimensions = new SizeF(17F, 41F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(984, 628);
            Controls.Add(statusStrip1);
            Controls.Add(toolStrip1);
            Controls.Add(menuStrip1);
            IsMdiContainer = true;
            MainMenuStrip = menuStrip1;
            Name = "FrmMain";
            Text = "Form MAIN";
            Load += FrmMain_Load;
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            toolStrip1.ResumeLayout(false);
            toolStrip1.PerformLayout();
            statusStrip1.ResumeLayout(false);
            statusStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem hệThốngToolStripMenuItem;
        private ToolStrip toolStrip1;
        private ToolStripButton toolStripButton1;
        private ToolStripButton toolStripButton2;
        private ToolStripMenuItem mnuDangNhap;
        private ToolStripMenuItem ngườiDùngToolStripMenuItem;
        private ToolStripMenuItem mnuQuanLyNhanVien;
        private ToolStripSeparator toolStripSeparator1;
        private ToolStripMenuItem đóngTấtCảFormConToolStripMenuItem;
        private ToolStripMenuItem thoátToolStripMenuItem;
        private ToolStripMenuItem windoToolStripMenuItem;
        private ToolStripMenuItem sắpXếpToolStripMenuItem;
        private ToolStripMenuItem cascadeToolStripMenuItem;
        private ToolStripMenuItem tileHorizontalToolStripMenuItem;
        private ToolStripMenuItem tileVerticalToolStripMenuItem;
        private ToolStripMenuItem arrangeIconToolStripMenuItem;
        private ToolStripMenuItem mnuDangXuat;
        private StatusStrip statusStrip1;
        private ToolStripStatusLabel lblThongTin;
    }
}
