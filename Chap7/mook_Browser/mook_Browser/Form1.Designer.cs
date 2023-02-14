namespace mook_Browser
{
    partial class Form1
    {
        /// <summary>
        /// 필수 디자이너 변수입니다.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 사용 중인 모든 리소스를 정리합니다.
        /// </summary>
        /// <param name="disposing">관리되는 리소스를 삭제해야 하면 true이고, 그렇지 않으면 false입니다.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 디자이너에서 생성한 코드

        /// <summary>
        /// 디자이너 지원에 필요한 메서드입니다.
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마십시오.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.plFvFind = new System.Windows.Forms.Panel();
            this.lvFvView = new System.Windows.Forms.TreeView();
            this.ImgFvList = new System.Windows.Forms.ImageList(this.components);
            this.tsFvMenu = new System.Windows.Forms.ToolStrip();
            this.tsbClose = new System.Windows.Forms.ToolStripButton();
            this.tsMenu = new System.Windows.Forms.ToolStrip();
            this.tsbtnRight = new System.Windows.Forms.ToolStripButton();
            this.tscbbAddress = new System.Windows.Forms.ToolStripComboBox();
            this.tsbtnRefresh = new System.Windows.Forms.ToolStripButton();
            this.tsbtnStop = new System.Windows.Forms.ToolStripButton();
            this.tsbtnHome = new System.Windows.Forms.ToolStripButton();
            this.msMenu = new System.Windows.Forms.MenuStrip();
            this.파일FToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.열기OToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.닫기XToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.도구TToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.인터넷옵션OToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.즐겨찾기AToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.즐겨찾ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.webBrowser = new System.Windows.Forms.WebBrowser();
            this.plView = new System.Windows.Forms.Panel();
            this.plTop = new System.Windows.Forms.Panel();
            this.SubImgList = new System.Windows.Forms.ImageList(this.components);
            this.splitter = new System.Windows.Forms.Splitter();
            this.tsbtnLeft = new System.Windows.Forms.ToolStripButton();
            this.plFvFind.SuspendLayout();
            this.tsFvMenu.SuspendLayout();
            this.tsMenu.SuspendLayout();
            this.msMenu.SuspendLayout();
            this.plView.SuspendLayout();
            this.plTop.SuspendLayout();
            this.SuspendLayout();
            // 
            // plFvFind
            // 
            this.plFvFind.BackColor = System.Drawing.Color.White;
            this.plFvFind.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.plFvFind.Controls.Add(this.lvFvView);
            this.plFvFind.Controls.Add(this.tsFvMenu);
            this.plFvFind.Dock = System.Windows.Forms.DockStyle.Left;
            this.plFvFind.Location = new System.Drawing.Point(0, 49);
            this.plFvFind.Name = "plFvFind";
            this.plFvFind.Size = new System.Drawing.Size(183, 269);
            this.plFvFind.TabIndex = 5;
            // 
            // lvFvView
            // 
            this.lvFvView.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lvFvView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lvFvView.FullRowSelect = true;
            this.lvFvView.ImageIndex = 0;
            this.lvFvView.ImageList = this.ImgFvList;
            this.lvFvView.Location = new System.Drawing.Point(0, 25);
            this.lvFvView.Name = "lvFvView";
            this.lvFvView.SelectedImageIndex = 0;
            this.lvFvView.Size = new System.Drawing.Size(179, 240);
            this.lvFvView.TabIndex = 4;
            this.lvFvView.DoubleClick += new System.EventHandler(this.lvFvView_DoubleClick);
            // 
            // ImgFvList
            // 
            this.ImgFvList.ColorDepth = System.Windows.Forms.ColorDepth.Depth16Bit;
            this.ImgFvList.ImageSize = new System.Drawing.Size(16, 16);
            this.ImgFvList.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // tsFvMenu
            // 
            this.tsFvMenu.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.tsFvMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsbClose});
            this.tsFvMenu.Location = new System.Drawing.Point(0, 0);
            this.tsFvMenu.Name = "tsFvMenu";
            this.tsFvMenu.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
            this.tsFvMenu.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.tsFvMenu.Size = new System.Drawing.Size(179, 25);
            this.tsFvMenu.TabIndex = 4;
            this.tsFvMenu.Text = "즐겨찾기";
            // 
            // tsbClose
            // 
            this.tsbClose.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbClose.Image = global::mook_Browser.Properties.Resources.close;
            this.tsbClose.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbClose.Name = "tsbClose";
            this.tsbClose.Size = new System.Drawing.Size(23, 22);
            this.tsbClose.Text = "닫기";
            this.tsbClose.Click += new System.EventHandler(this.tsbClose_Click);
            // 
            // tsMenu
            // 
            this.tsMenu.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.tsMenu.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.tsMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsbtnLeft,
            this.tsbtnRight,
            this.tscbbAddress,
            this.tsbtnRefresh,
            this.tsbtnStop,
            this.tsbtnHome});
            this.tsMenu.Location = new System.Drawing.Point(0, 24);
            this.tsMenu.Name = "tsMenu";
            this.tsMenu.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
            this.tsMenu.Size = new System.Drawing.Size(740, 25);
            this.tsMenu.TabIndex = 0;
            // 
            // tsbtnRight
            // 
            this.tsbtnRight.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbtnRight.Image = global::mook_Browser.Properties.Resources.R_on_1;
            this.tsbtnRight.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbtnRight.Name = "tsbtnRight";
            this.tsbtnRight.Size = new System.Drawing.Size(23, 22);
            this.tsbtnRight.Text = "앞으로";
            this.tsbtnRight.ToolTipText = "앞으로";
            this.tsbtnRight.Click += new System.EventHandler(this.tsbtnRight_Click);
            // 
            // tscbbAddress
            // 
            this.tscbbAddress.AutoSize = false;
            this.tscbbAddress.DropDownWidth = 300;
            this.tscbbAddress.Name = "tscbbAddress";
            this.tscbbAddress.Size = new System.Drawing.Size(600, 23);
            this.tscbbAddress.SelectedIndexChanged += new System.EventHandler(this.tscbbAddress_SelectedIndexChanged);
            this.tscbbAddress.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tscbbAddress_KeyPress);
            // 
            // tsbtnRefresh
            // 
            this.tsbtnRefresh.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbtnRefresh.Image = global::mook_Browser.Properties.Resources.refresh_1;
            this.tsbtnRefresh.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbtnRefresh.Name = "tsbtnRefresh";
            this.tsbtnRefresh.Size = new System.Drawing.Size(23, 22);
            this.tsbtnRefresh.Text = "새로고침";
            this.tsbtnRefresh.ToolTipText = "새로고침";
            this.tsbtnRefresh.Click += new System.EventHandler(this.tsbtnRefresh_Click);
            // 
            // tsbtnStop
            // 
            this.tsbtnStop.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbtnStop.Image = global::mook_Browser.Properties.Resources.Stop_1;
            this.tsbtnStop.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbtnStop.Name = "tsbtnStop";
            this.tsbtnStop.Size = new System.Drawing.Size(23, 22);
            this.tsbtnStop.Text = "정지";
            this.tsbtnStop.ToolTipText = "중지";
            this.tsbtnStop.Click += new System.EventHandler(this.tsbtnStop_Click);
            // 
            // tsbtnHome
            // 
            this.tsbtnHome.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbtnHome.Image = global::mook_Browser.Properties.Resources.Home_1;
            this.tsbtnHome.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbtnHome.Name = "tsbtnHome";
            this.tsbtnHome.Size = new System.Drawing.Size(23, 22);
            this.tsbtnHome.Text = "홈으로";
            this.tsbtnHome.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.tsbtnHome.ToolTipText = "홈으로";
            this.tsbtnHome.Click += new System.EventHandler(this.tsbtnHome_Click);
            // 
            // msMenu
            // 
            this.msMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.파일FToolStripMenuItem,
            this.도구TToolStripMenuItem,
            this.즐겨찾기AToolStripMenuItem});
            this.msMenu.Location = new System.Drawing.Point(0, 0);
            this.msMenu.Name = "msMenu";
            this.msMenu.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
            this.msMenu.Size = new System.Drawing.Size(740, 24);
            this.msMenu.TabIndex = 1;
            this.msMenu.Text = "menuStrip1";
            // 
            // 파일FToolStripMenuItem
            // 
            this.파일FToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.열기OToolStripMenuItem,
            this.toolStripSeparator1,
            this.닫기XToolStripMenuItem});
            this.파일FToolStripMenuItem.Name = "파일FToolStripMenuItem";
            this.파일FToolStripMenuItem.Size = new System.Drawing.Size(57, 20);
            this.파일FToolStripMenuItem.Text = "파일(&F)";
            // 
            // 열기OToolStripMenuItem
            // 
            this.열기OToolStripMenuItem.Name = "열기OToolStripMenuItem";
            this.열기OToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.O)));
            this.열기OToolStripMenuItem.Size = new System.Drawing.Size(158, 22);
            this.열기OToolStripMenuItem.Text = "열기(&O)";
            this.열기OToolStripMenuItem.Click += new System.EventHandler(this.열기OToolStripMenuItem_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(155, 6);
            // 
            // 닫기XToolStripMenuItem
            // 
            this.닫기XToolStripMenuItem.Name = "닫기XToolStripMenuItem";
            this.닫기XToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.X)));
            this.닫기XToolStripMenuItem.Size = new System.Drawing.Size(158, 22);
            this.닫기XToolStripMenuItem.Text = "닫기(&X)";
            this.닫기XToolStripMenuItem.Click += new System.EventHandler(this.닫기XToolStripMenuItem_Click);
            // 
            // 도구TToolStripMenuItem
            // 
            this.도구TToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.인터넷옵션OToolStripMenuItem});
            this.도구TToolStripMenuItem.Name = "도구TToolStripMenuItem";
            this.도구TToolStripMenuItem.Size = new System.Drawing.Size(57, 20);
            this.도구TToolStripMenuItem.Text = "도구(&T)";
            // 
            // 인터넷옵션OToolStripMenuItem
            // 
            this.인터넷옵션OToolStripMenuItem.Name = "인터넷옵션OToolStripMenuItem";
            this.인터넷옵션OToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.O)));
            this.인터넷옵션OToolStripMenuItem.Size = new System.Drawing.Size(198, 22);
            this.인터넷옵션OToolStripMenuItem.Text = "인터넷 옵션(&O)";
            this.인터넷옵션OToolStripMenuItem.Click += new System.EventHandler(this.인터넷옵션OToolStripMenuItem_Click);
            // 
            // 즐겨찾기AToolStripMenuItem
            // 
            this.즐겨찾기AToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.즐겨찾ToolStripMenuItem});
            this.즐겨찾기AToolStripMenuItem.Name = "즐겨찾기AToolStripMenuItem";
            this.즐겨찾기AToolStripMenuItem.Size = new System.Drawing.Size(83, 20);
            this.즐겨찾기AToolStripMenuItem.Text = "즐겨찾기(&A)";
            // 
            // 즐겨찾ToolStripMenuItem
            // 
            this.즐겨찾ToolStripMenuItem.Checked = true;
            this.즐겨찾ToolStripMenuItem.CheckState = System.Windows.Forms.CheckState.Checked;
            this.즐겨찾ToolStripMenuItem.Name = "즐겨찾ToolStripMenuItem";
            this.즐겨찾ToolStripMenuItem.Size = new System.Drawing.Size(122, 22);
            this.즐겨찾ToolStripMenuItem.Text = "즐겨찾기";
            this.즐겨찾ToolStripMenuItem.Click += new System.EventHandler(this.즐겨찾ToolStripMenuItem_Click);
            // 
            // webBrowser
            // 
            this.webBrowser.Dock = System.Windows.Forms.DockStyle.Fill;
            this.webBrowser.Location = new System.Drawing.Point(0, 0);
            this.webBrowser.MinimumSize = new System.Drawing.Size(20, 20);
            this.webBrowser.Name = "webBrowser";
            this.webBrowser.Size = new System.Drawing.Size(553, 265);
            this.webBrowser.TabIndex = 3;
            // 
            // plView
            // 
            this.plView.BackColor = System.Drawing.Color.White;
            this.plView.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.plView.Controls.Add(this.webBrowser);
            this.plView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.plView.Location = new System.Drawing.Point(183, 49);
            this.plView.Name = "plView";
            this.plView.Size = new System.Drawing.Size(557, 269);
            this.plView.TabIndex = 6;
            // 
            // plTop
            // 
            this.plTop.BackColor = System.Drawing.Color.White;
            this.plTop.Controls.Add(this.tsMenu);
            this.plTop.Controls.Add(this.msMenu);
            this.plTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.plTop.Location = new System.Drawing.Point(0, 0);
            this.plTop.Name = "plTop";
            this.plTop.Size = new System.Drawing.Size(740, 49);
            this.plTop.TabIndex = 7;
            // 
            // SubImgList
            // 
            this.SubImgList.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
            this.SubImgList.ImageSize = new System.Drawing.Size(16, 16);
            this.SubImgList.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // splitter
            // 
            this.splitter.Location = new System.Drawing.Point(183, 49);
            this.splitter.Name = "splitter";
            this.splitter.Size = new System.Drawing.Size(3, 269);
            this.splitter.TabIndex = 8;
            this.splitter.TabStop = false;
            // 
            // tsbtnLeft
            // 
            this.tsbtnLeft.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbtnLeft.Image = global::mook_Browser.Properties.Resources.L_on_1;
            this.tsbtnLeft.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbtnLeft.Name = "tsbtnLeft";
            this.tsbtnLeft.Size = new System.Drawing.Size(23, 22);
            this.tsbtnLeft.Text = "뒤로";
            this.tsbtnLeft.ToolTipText = "뒤로";
            this.tsbtnLeft.Click += new System.EventHandler(this.tsbtnLeft_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(740, 318);
            this.Controls.Add(this.splitter);
            this.Controls.Add(this.plView);
            this.Controls.Add(this.plFvFind);
            this.Controls.Add(this.plTop);
            this.MainMenuStrip = this.msMenu;
            this.Name = "Form1";
            this.Text = "웹 브라우저";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.plFvFind.ResumeLayout(false);
            this.plFvFind.PerformLayout();
            this.tsFvMenu.ResumeLayout(false);
            this.tsFvMenu.PerformLayout();
            this.tsMenu.ResumeLayout(false);
            this.tsMenu.PerformLayout();
            this.msMenu.ResumeLayout(false);
            this.msMenu.PerformLayout();
            this.plView.ResumeLayout(false);
            this.plTop.ResumeLayout(false);
            this.plTop.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ToolStripButton tsbtnLeft;
        private System.Windows.Forms.ToolStripButton tsbtnRight;
        private System.Windows.Forms.ToolStripButton tsbtnRefresh;
        private System.Windows.Forms.ToolStripButton tsbtnStop;
        private System.Windows.Forms.MenuStrip msMenu;
        private System.Windows.Forms.ToolStripMenuItem 파일FToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 열기OToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem 닫기XToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 도구TToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 인터넷옵션OToolStripMenuItem;
        private System.Windows.Forms.ToolStripButton tsbtnHome;
        private System.Windows.Forms.ToolStrip tsMenu;
        private System.Windows.Forms.ToolStripComboBox tscbbAddress;
        private System.Windows.Forms.ToolStripMenuItem 즐겨찾기AToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 즐겨찾ToolStripMenuItem;
        private System.Windows.Forms.ToolStrip tsFvMenu;
        private System.Windows.Forms.Panel plFvFind;
        internal System.Windows.Forms.WebBrowser webBrowser;
        private System.Windows.Forms.ToolStripButton tsbClose;
        private System.Windows.Forms.Panel plView;
        private System.Windows.Forms.Panel plTop;
        private System.Windows.Forms.TreeView lvFvView;
        private System.Windows.Forms.ImageList ImgFvList;
        private System.Windows.Forms.ImageList SubImgList;
        private System.Windows.Forms.Splitter splitter;
    }
}
