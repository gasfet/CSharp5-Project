namespace mook_ImageViewer
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
            this.tsMenu = new System.Windows.Forms.ToolStrip();
            this.tsbtnOpen = new System.Windows.Forms.ToolStripButton();
            this.tsbtnRefresh = new System.Windows.Forms.ToolStripButton();
            this.tsbtnImg = new System.Windows.Forms.ToolStripButton();
            this.tsbtnUp = new System.Windows.Forms.ToolStripButton();
            this.tsddbtnView = new System.Windows.Forms.ToolStripDropDownButton();
            this.큰아이콘ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.작은아이콘ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.간단히ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.리스트ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ofdFile = new System.Windows.Forms.OpenFileDialog();
            this.Splitter = new System.Windows.Forms.Splitter();
            this.treeDisk = new System.Windows.Forms.TreeView();
            this.DriveList = new System.Windows.Forms.ImageList(this.components);
            this.chName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chSize = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chFolder = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chDate = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.lvFile = new System.Windows.Forms.ListView();
            this.FileList = new System.Windows.Forms.ImageList(this.components);
            this.tsMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // tsMenu
            // 
            this.tsMenu.ImageScalingSize = new System.Drawing.Size(32, 32);
            this.tsMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsbtnOpen,
            this.tsbtnRefresh,
            this.tsbtnImg,
            this.tsbtnUp,
            this.tsddbtnView});
            this.tsMenu.Location = new System.Drawing.Point(0, 0);
            this.tsMenu.Name = "tsMenu";
            this.tsMenu.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
            this.tsMenu.Size = new System.Drawing.Size(684, 39);
            this.tsMenu.TabIndex = 0;
            this.tsMenu.Text = "열기";
            // 
            // tsbtnOpen
            // 
            this.tsbtnOpen.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbtnOpen.Image = global::mook_ImageViewer.Properties.Resources._1;
            this.tsbtnOpen.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbtnOpen.Name = "tsbtnOpen";
            this.tsbtnOpen.Size = new System.Drawing.Size(36, 36);
            this.tsbtnOpen.Text = "열기";
            this.tsbtnOpen.Click += new System.EventHandler(this.tsbtnOpen_Click);
            // 
            // tsbtnRefresh
            // 
            this.tsbtnRefresh.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbtnRefresh.Image = global::mook_ImageViewer.Properties.Resources._2;
            this.tsbtnRefresh.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbtnRefresh.Name = "tsbtnRefresh";
            this.tsbtnRefresh.Size = new System.Drawing.Size(36, 36);
            this.tsbtnRefresh.Text = "새로고침";
            this.tsbtnRefresh.Click += new System.EventHandler(this.tsbtnRefresh_Click);
            // 
            // tsbtnImg
            // 
            this.tsbtnImg.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbtnImg.Enabled = false;
            this.tsbtnImg.Image = global::mook_ImageViewer.Properties.Resources._3;
            this.tsbtnImg.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbtnImg.Name = "tsbtnImg";
            this.tsbtnImg.Size = new System.Drawing.Size(36, 36);
            this.tsbtnImg.Text = "이미지보기";
            this.tsbtnImg.Click += new System.EventHandler(this.tsbtnImg_Click);
            // 
            // tsbtnUp
            // 
            this.tsbtnUp.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbtnUp.Enabled = false;
            this.tsbtnUp.Image = global::mook_ImageViewer.Properties.Resources._4;
            this.tsbtnUp.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbtnUp.Name = "tsbtnUp";
            this.tsbtnUp.Size = new System.Drawing.Size(36, 36);
            this.tsbtnUp.Text = "상위폴더";
            this.tsbtnUp.Click += new System.EventHandler(this.tsbtnUp_Click);
            // 
            // tsddbtnView
            // 
            this.tsddbtnView.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsddbtnView.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.큰아이콘ToolStripMenuItem,
            this.작은아이콘ToolStripMenuItem,
            this.간단히ToolStripMenuItem,
            this.리스트ToolStripMenuItem});
            this.tsddbtnView.Image = global::mook_ImageViewer.Properties.Resources._5;
            this.tsddbtnView.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsddbtnView.Name = "tsddbtnView";
            this.tsddbtnView.Size = new System.Drawing.Size(45, 36);
            this.tsddbtnView.Text = "보기";
            // 
            // 큰아이콘ToolStripMenuItem
            // 
            this.큰아이콘ToolStripMenuItem.Name = "큰아이콘ToolStripMenuItem";
            this.큰아이콘ToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.큰아이콘ToolStripMenuItem.Text = "큰 아이콘";
            this.큰아이콘ToolStripMenuItem.Click += new System.EventHandler(this.큰아이콘ToolStripMenuItem_Click);
            // 
            // 작은아이콘ToolStripMenuItem
            // 
            this.작은아이콘ToolStripMenuItem.Name = "작은아이콘ToolStripMenuItem";
            this.작은아이콘ToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.작은아이콘ToolStripMenuItem.Text = "작은 아이콘";
            this.작은아이콘ToolStripMenuItem.Click += new System.EventHandler(this.작은아이콘ToolStripMenuItem_Click);
            // 
            // 간단히ToolStripMenuItem
            // 
            this.간단히ToolStripMenuItem.Name = "간단히ToolStripMenuItem";
            this.간단히ToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.간단히ToolStripMenuItem.Text = "간단히";
            this.간단히ToolStripMenuItem.Click += new System.EventHandler(this.간단히ToolStripMenuItem_Click);
            // 
            // 리스트ToolStripMenuItem
            // 
            this.리스트ToolStripMenuItem.Name = "리스트ToolStripMenuItem";
            this.리스트ToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.리스트ToolStripMenuItem.Text = "리스트";
            this.리스트ToolStripMenuItem.Click += new System.EventHandler(this.리스트ToolStripMenuItem_Click);
            // 
            // ofdFile
            // 
            this.ofdFile.FileName = "제목없음";
            this.ofdFile.Filter = "JPEG Images(*.jpg,*.jpeg)|*.jpg;*.jpeg|GIF Image(*.gif)|*.gif|Bitmap(*.bmp)|*.bmp" +
    "|All Image Format|*.jpg;*.jpeg;*.gif*.bmp";
            // 
            // Splitter
            // 
            this.Splitter.Location = new System.Drawing.Point(162, 39);
            this.Splitter.Name = "Splitter";
            this.Splitter.Size = new System.Drawing.Size(1, 434);
            this.Splitter.TabIndex = 6;
            this.Splitter.TabStop = false;
            // 
            // treeDisk
            // 
            this.treeDisk.Dock = System.Windows.Forms.DockStyle.Left;
            this.treeDisk.ImageIndex = 0;
            this.treeDisk.ImageList = this.DriveList;
            this.treeDisk.Location = new System.Drawing.Point(0, 39);
            this.treeDisk.Name = "treeDisk";
            this.treeDisk.SelectedImageIndex = 0;
            this.treeDisk.Size = new System.Drawing.Size(162, 434);
            this.treeDisk.TabIndex = 5;
            this.treeDisk.TabStop = false;
            this.treeDisk.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.treeDisk_AfterSelect);
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
            // chName
            // 
            this.chName.Text = "파일 이름";
            this.chName.Width = 140;
            // 
            // chSize
            // 
            this.chSize.Text = "크기";
            this.chSize.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.chSize.Width = 80;
            // 
            // chFolder
            // 
            this.chFolder.Text = "파일 폴더";
            this.chFolder.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.chFolder.Width = 110;
            // 
            // chDate
            // 
            this.chDate.Text = "최근 수정 날짜";
            this.chDate.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.chDate.Width = 170;
            // 
            // lvFile
            // 
            this.lvFile.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.chName,
            this.chSize,
            this.chFolder,
            this.chDate});
            this.lvFile.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lvFile.FullRowSelect = true;
            this.lvFile.LargeImageList = this.FileList;
            this.lvFile.Location = new System.Drawing.Point(163, 39);
            this.lvFile.Name = "lvFile";
            this.lvFile.Size = new System.Drawing.Size(521, 434);
            this.lvFile.SmallImageList = this.FileList;
            this.lvFile.StateImageList = this.FileList;
            this.lvFile.TabIndex = 7;
            this.lvFile.TabStop = false;
            this.lvFile.UseCompatibleStateImageBehavior = false;
            this.lvFile.View = System.Windows.Forms.View.Details;
            this.lvFile.Click += new System.EventHandler(this.lvFile_Click);
            this.lvFile.DoubleClick += new System.EventHandler(this.lvFile_DoubleClick);
            // 
            // FileList
            // 
            this.FileList.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("FileList.ImageStream")));
            this.FileList.TransparentColor = System.Drawing.Color.Transparent;
            this.FileList.Images.SetKeyName(0, "exe.bmp");
            this.FileList.Images.SetKeyName(1, "com.bmp");
            this.FileList.Images.SetKeyName(2, "txt.bmp");
            this.FileList.Images.SetKeyName(3, "bmp.bmp");
            this.FileList.Images.SetKeyName(4, "doc.bmp");
            this.FileList.Images.SetKeyName(5, "gif.bmp");
            this.FileList.Images.SetKeyName(6, "htm.bmp");
            this.FileList.Images.SetKeyName(7, "html.bmp");
            this.FileList.Images.SetKeyName(8, "hwp.bmp");
            this.FileList.Images.SetKeyName(9, "jpg.bmp");
            this.FileList.Images.SetKeyName(10, "mp3.bmp");
            this.FileList.Images.SetKeyName(11, "mpg.bmp");
            this.FileList.Images.SetKeyName(12, "ra.bmp");
            this.FileList.Images.SetKeyName(13, "rar.bmp");
            this.FileList.Images.SetKeyName(14, "zip.bmp");
            this.FileList.Images.SetKeyName(15, "etc.bmp");
            this.FileList.Images.SetKeyName(16, "Folder.bmp");
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(684, 473);
            this.Controls.Add(this.lvFile);
            this.Controls.Add(this.Splitter);
            this.Controls.Add(this.treeDisk);
            this.Controls.Add(this.tsMenu);
            this.Name = "Form1";
            this.Text = "이미지 뷰어";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tsMenu.ResumeLayout(false);
            this.tsMenu.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip tsMenu;
        private System.Windows.Forms.Splitter Splitter;
        private System.Windows.Forms.TreeView treeDisk;
        private System.Windows.Forms.ImageList DriveList;
        private System.Windows.Forms.ToolStripButton tsbtnOpen;
        private System.Windows.Forms.ToolStripButton tsbtnRefresh;
        private System.Windows.Forms.ToolStripButton tsbtnImg;
        private System.Windows.Forms.ToolStripButton tsbtnUp;
        private System.Windows.Forms.ToolStripDropDownButton tsddbtnView;
        private System.Windows.Forms.ToolStripMenuItem 큰아이콘ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 작은아이콘ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 간단히ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 리스트ToolStripMenuItem;
        private System.Windows.Forms.OpenFileDialog ofdFile;
        private System.Windows.Forms.ColumnHeader chName;
        private System.Windows.Forms.ColumnHeader chSize;
        private System.Windows.Forms.ColumnHeader chFolder;
        private System.Windows.Forms.ColumnHeader chDate;
        private System.Windows.Forms.ListView lvFile;
        private System.Windows.Forms.ImageList FileList;
    }
}

