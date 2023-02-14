namespace mook_Explorer
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.ToolMenu = new System.Windows.Forms.ToolStrip();
            this.toolStripSplitButton1 = new System.Windows.Forms.ToolStripSplitButton();
            this.큰아이콘ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.아이콘ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.자세히ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.DriveList = new System.Windows.Forms.ImageList(this.components);
            this.ImgListSmall = new System.Windows.Forms.ImageList(this.components);
            this.ImgListLarge = new System.Windows.Forms.ImageList(this.components);
            this.ImgListBig = new System.Windows.Forms.ImageList(this.components);
            this.treeDisk = new System.Windows.Forms.TreeView();
            this.Splitter = new System.Windows.Forms.Splitter();
            this.lvFile = new System.Windows.Forms.ListView();
            this.ColumnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ColumnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ColumnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ColumnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.plGroup = new System.Windows.Forms.Panel();
            this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.ToolMenu.SuspendLayout();
            this.plGroup.SuspendLayout();
            this.SuspendLayout();
            // 
            // ToolMenu
            // 
            this.ToolMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButton1,
            this.toolStripSplitButton1});
            this.ToolMenu.Location = new System.Drawing.Point(0, 0);
            this.ToolMenu.Name = "ToolMenu";
            this.ToolMenu.Size = new System.Drawing.Size(694, 25);
            this.ToolMenu.TabIndex = 6;
            this.ToolMenu.Text = "toolStrip1";
            // 
            // toolStripSplitButton1
            // 
            this.toolStripSplitButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripSplitButton1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.큰아이콘ToolStripMenuItem,
            this.아이콘ToolStripMenuItem,
            this.자세히ToolStripMenuItem});
            this.toolStripSplitButton1.Image = global::mook_Explorer.Properties.Resources.option;
            this.toolStripSplitButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripSplitButton1.Name = "toolStripSplitButton1";
            this.toolStripSplitButton1.Size = new System.Drawing.Size(32, 22);
            this.toolStripSplitButton1.Text = "보기";
            // 
            // 큰아이콘ToolStripMenuItem
            // 
            this.큰아이콘ToolStripMenuItem.Name = "큰아이콘ToolStripMenuItem";
            this.큰아이콘ToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.큰아이콘ToolStripMenuItem.Text = "큰 아이콘";
            this.큰아이콘ToolStripMenuItem.Click += new System.EventHandler(this.큰아이콘ToolStripMenuItem_Click);
            // 
            // 아이콘ToolStripMenuItem
            // 
            this.아이콘ToolStripMenuItem.Name = "아이콘ToolStripMenuItem";
            this.아이콘ToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.아이콘ToolStripMenuItem.Text = "아이콘";
            this.아이콘ToolStripMenuItem.Click += new System.EventHandler(this.아이콘ToolStripMenuItem_Click);
            // 
            // 자세히ToolStripMenuItem
            // 
            this.자세히ToolStripMenuItem.Name = "자세히ToolStripMenuItem";
            this.자세히ToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.자세히ToolStripMenuItem.Text = "자세히";
            this.자세히ToolStripMenuItem.Click += new System.EventHandler(this.자세히ToolStripMenuItem_Click);
            // 
            // DriveList
            // 
            this.DriveList.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("DriveList.ImageStream")));
            this.DriveList.TransparentColor = System.Drawing.Color.Transparent;
            this.DriveList.Images.SetKeyName(0, "0.JPG");
            this.DriveList.Images.SetKeyName(1, "1.JPG");
            this.DriveList.Images.SetKeyName(2, "2.JPG");
            this.DriveList.Images.SetKeyName(3, "3.JPG");
            this.DriveList.Images.SetKeyName(4, "4.JPG");
            this.DriveList.Images.SetKeyName(5, "5.JPG");
            // 
            // ImgListSmall
            // 
            this.ImgListSmall.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
            this.ImgListSmall.ImageSize = new System.Drawing.Size(16, 16);
            this.ImgListSmall.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // ImgListLarge
            // 
            this.ImgListLarge.ColorDepth = System.Windows.Forms.ColorDepth.Depth16Bit;
            this.ImgListLarge.ImageSize = new System.Drawing.Size(32, 32);
            this.ImgListLarge.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // ImgListBig
            // 
            this.ImgListBig.ColorDepth = System.Windows.Forms.ColorDepth.Depth16Bit;
            this.ImgListBig.ImageSize = new System.Drawing.Size(48, 48);
            this.ImgListBig.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // treeDisk
            // 
            this.treeDisk.Dock = System.Windows.Forms.DockStyle.Left;
            this.treeDisk.ImageIndex = 0;
            this.treeDisk.ImageList = this.DriveList;
            this.treeDisk.Location = new System.Drawing.Point(0, 0);
            this.treeDisk.Name = "treeDisk";
            this.treeDisk.SelectedImageIndex = 0;
            this.treeDisk.Size = new System.Drawing.Size(162, 349);
            this.treeDisk.TabIndex = 2;
            this.treeDisk.TabStop = false;
            this.treeDisk.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.treeDisk_AfterSelect);
            // 
            // Splitter
            // 
            this.Splitter.Location = new System.Drawing.Point(162, 0);
            this.Splitter.Name = "Splitter";
            this.Splitter.Size = new System.Drawing.Size(1, 349);
            this.Splitter.TabIndex = 3;
            this.Splitter.TabStop = false;
            // 
            // lvFile
            // 
            this.lvFile.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.ColumnHeader1,
            this.ColumnHeader2,
            this.ColumnHeader3,
            this.ColumnHeader4});
            this.lvFile.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lvFile.FullRowSelect = true;
            this.lvFile.Location = new System.Drawing.Point(163, 0);
            this.lvFile.Name = "lvFile";
            this.lvFile.Size = new System.Drawing.Size(531, 349);
            this.lvFile.SmallImageList = this.ImgListLarge;
            this.lvFile.TabIndex = 4;
            this.lvFile.TabStop = false;
            this.lvFile.UseCompatibleStateImageBehavior = false;
            this.lvFile.View = System.Windows.Forms.View.SmallIcon;
            this.lvFile.DoubleClick += new System.EventHandler(this.lvFile_DoubleClick);
            // 
            // ColumnHeader1
            // 
            this.ColumnHeader1.Text = "파일 이름";
            this.ColumnHeader1.Width = 140;
            // 
            // ColumnHeader2
            // 
            this.ColumnHeader2.Text = "크기";
            this.ColumnHeader2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.ColumnHeader2.Width = 80;
            // 
            // ColumnHeader3
            // 
            this.ColumnHeader3.Text = "파일 폴더";
            this.ColumnHeader3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.ColumnHeader3.Width = 110;
            // 
            // ColumnHeader4
            // 
            this.ColumnHeader4.Text = "최근 수정 날짜";
            this.ColumnHeader4.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.ColumnHeader4.Width = 170;
            // 
            // plGroup
            // 
            this.plGroup.Controls.Add(this.lvFile);
            this.plGroup.Controls.Add(this.Splitter);
            this.plGroup.Controls.Add(this.treeDisk);
            this.plGroup.Dock = System.Windows.Forms.DockStyle.Fill;
            this.plGroup.Location = new System.Drawing.Point(0, 25);
            this.plGroup.Name = "plGroup";
            this.plGroup.Size = new System.Drawing.Size(694, 349);
            this.plGroup.TabIndex = 4;
            // 
            // toolStripButton1
            // 
            this.toolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton1.Image = global::mook_Explorer.Properties.Resources.up;
            this.toolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton1.Name = "toolStripButton1";
            this.toolStripButton1.Size = new System.Drawing.Size(23, 22);
            this.toolStripButton1.Text = "상위 폴더";
            this.toolStripButton1.Click += new System.EventHandler(this.toolStripButton1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(694, 374);
            this.Controls.Add(this.plGroup);
            this.Controls.Add(this.ToolMenu);
            this.Name = "Form1";
            this.Text = "윈도우 탐색기";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ToolMenu.ResumeLayout(false);
            this.ToolMenu.PerformLayout();
            this.plGroup.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ImageList DriveList;
        private System.Windows.Forms.ImageList ImgListSmall;
        private System.Windows.Forms.ImageList ImgListLarge;
        private System.Windows.Forms.ImageList ImgListBig;
        private System.Windows.Forms.TreeView treeDisk;
        private System.Windows.Forms.Splitter Splitter;
        private System.Windows.Forms.ListView lvFile;
        internal System.Windows.Forms.ColumnHeader ColumnHeader1;
        internal System.Windows.Forms.ColumnHeader ColumnHeader2;
        internal System.Windows.Forms.ColumnHeader ColumnHeader3;
        internal System.Windows.Forms.ColumnHeader ColumnHeader4;
        private System.Windows.Forms.Panel plGroup;
        private System.Windows.Forms.ToolStrip ToolMenu;
        private System.Windows.Forms.ToolStripButton toolStripButton1;
        private System.Windows.Forms.ToolStripSplitButton toolStripSplitButton1;
        private System.Windows.Forms.ToolStripMenuItem 큰아이콘ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 아이콘ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 자세히ToolStripMenuItem;
    }
}

