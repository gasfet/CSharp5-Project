namespace mook_TextEdit
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
            this.plGroup = new System.Windows.Forms.Panel();
            this.lvFile = new System.Windows.Forms.ListView();
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.imgFile = new System.Windows.Forms.ImageList(this.components);
            this.tvDive = new System.Windows.Forms.TreeView();
            this.imgDisk = new System.Windows.Forms.ImageList(this.components);
            this.lvFolder = new System.Windows.Forms.ListView();
            this.ColumnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.tsBar = new System.Windows.Forms.ToolStrip();
            this.tsbNew = new System.Windows.Forms.ToolStripButton();
            this.tsbSave = new System.Windows.Forms.ToolStripButton();
            this.tsbPrvious = new System.Windows.Forms.ToolStripButton();
            this.tsbNext = new System.Windows.Forms.ToolStripButton();
            this.tsbNormal = new System.Windows.Forms.ToolStripButton();
            this.tsbCenter = new System.Windows.Forms.ToolStripButton();
            this.tsbRight = new System.Windows.Forms.ToolStripButton();
            this.msBar = new System.Windows.Forms.MenuStrip();
            this.파일ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.새로만들기ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.저장하기ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.다른이름으로저장ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.끝내기ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.편집ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.되돌리기ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.복사ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.자르기ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.모두선택ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.왼쪽ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.가운데ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.오른쪽ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.보기ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.편집상자ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.파일보기ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sfdFile = new System.Windows.Forms.SaveFileDialog();
            this.plGroup.SuspendLayout();
            this.tsBar.SuspendLayout();
            this.msBar.SuspendLayout();
            this.SuspendLayout();
            // 
            // plGroup
            // 
            this.plGroup.Controls.Add(this.lvFile);
            this.plGroup.Controls.Add(this.tvDive);
            this.plGroup.Controls.Add(this.lvFolder);
            this.plGroup.Dock = System.Windows.Forms.DockStyle.Left;
            this.plGroup.Location = new System.Drawing.Point(0, 49);
            this.plGroup.Name = "plGroup";
            this.plGroup.Size = new System.Drawing.Size(188, 425);
            this.plGroup.TabIndex = 16;
            // 
            // lvFile
            // 
            this.lvFile.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.lvFile.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader2});
            this.lvFile.Location = new System.Drawing.Point(3, 228);
            this.lvFile.MultiSelect = false;
            this.lvFile.Name = "lvFile";
            this.lvFile.Size = new System.Drawing.Size(182, 196);
            this.lvFile.SmallImageList = this.imgFile;
            this.lvFile.TabIndex = 4;
            this.lvFile.UseCompatibleStateImageBehavior = false;
            this.lvFile.View = System.Windows.Forms.View.Details;
            this.lvFile.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.lvFile_MouseDoubleClick);
            this.lvFile.MouseMove += new System.Windows.Forms.MouseEventHandler(this.lvFile_MouseMove);
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "파일 이름";
            this.columnHeader2.Width = 150;
            // 
            // imgFile
            // 
            this.imgFile.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imgFile.ImageStream")));
            this.imgFile.TransparentColor = System.Drawing.Color.Transparent;
            this.imgFile.Images.SetKeyName(0, "exe.bmp");
            this.imgFile.Images.SetKeyName(1, "com.bmp");
            this.imgFile.Images.SetKeyName(2, "txt.bmp");
            this.imgFile.Images.SetKeyName(3, "bmp.bmp");
            this.imgFile.Images.SetKeyName(4, "doc.bmp");
            this.imgFile.Images.SetKeyName(5, "gif.bmp");
            this.imgFile.Images.SetKeyName(6, "htm.bmp");
            this.imgFile.Images.SetKeyName(7, "html.bmp");
            this.imgFile.Images.SetKeyName(8, "hwp.bmp");
            this.imgFile.Images.SetKeyName(9, "jpg.bmp");
            this.imgFile.Images.SetKeyName(10, "mp3.bmp");
            this.imgFile.Images.SetKeyName(11, "mpg.bmp");
            this.imgFile.Images.SetKeyName(12, "ra.bmp");
            this.imgFile.Images.SetKeyName(13, "rar.bmp");
            this.imgFile.Images.SetKeyName(14, "zip.bmp");
            this.imgFile.Images.SetKeyName(15, "etc.bmp");
            this.imgFile.Images.SetKeyName(16, "Folder.bmp");
            // 
            // tvDive
            // 
            this.tvDive.ImageIndex = 0;
            this.tvDive.ImageList = this.imgDisk;
            this.tvDive.Location = new System.Drawing.Point(3, 3);
            this.tvDive.Name = "tvDive";
            this.tvDive.SelectedImageIndex = 0;
            this.tvDive.Size = new System.Drawing.Size(182, 80);
            this.tvDive.TabIndex = 2;
            this.tvDive.TabStop = false;
            this.tvDive.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.tvDive_AfterSelect);
            // 
            // imgDisk
            // 
            this.imgDisk.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imgDisk.ImageStream")));
            this.imgDisk.TransparentColor = System.Drawing.Color.Transparent;
            this.imgDisk.Images.SetKeyName(0, "0.JPG");
            this.imgDisk.Images.SetKeyName(1, "1.JPG");
            this.imgDisk.Images.SetKeyName(2, "2.JPG");
            this.imgDisk.Images.SetKeyName(3, "3.JPG");
            this.imgDisk.Images.SetKeyName(4, "4.JPG");
            this.imgDisk.Images.SetKeyName(5, "5.JPG");
            // 
            // lvFolder
            // 
            this.lvFolder.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.ColumnHeader1});
            this.lvFolder.Location = new System.Drawing.Point(3, 85);
            this.lvFolder.Name = "lvFolder";
            this.lvFolder.Size = new System.Drawing.Size(182, 140);
            this.lvFolder.SmallImageList = this.imgFile;
            this.lvFolder.TabIndex = 3;
            this.lvFolder.UseCompatibleStateImageBehavior = false;
            this.lvFolder.View = System.Windows.Forms.View.Details;
            this.lvFolder.DoubleClick += new System.EventHandler(this.lvFolder_DoubleClick);
            // 
            // ColumnHeader1
            // 
            this.ColumnHeader1.Text = "폴더이름";
            this.ColumnHeader1.Width = 150;
            // 
            // tsBar
            // 
            this.tsBar.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsbNew,
            this.tsbSave,
            this.tsbPrvious,
            this.tsbNext,
            this.tsbNormal,
            this.tsbCenter,
            this.tsbRight});
            this.tsBar.Location = new System.Drawing.Point(0, 24);
            this.tsBar.Name = "tsBar";
            this.tsBar.Size = new System.Drawing.Size(909, 25);
            this.tsBar.TabIndex = 15;
            this.tsBar.Text = "ToolStrip1";
            // 
            // tsbNew
            // 
            this.tsbNew.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbNew.Image = global::mook_TextEdit.Properties.Resources.tsbNew;
            this.tsbNew.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbNew.Name = "tsbNew";
            this.tsbNew.Size = new System.Drawing.Size(23, 22);
            this.tsbNew.Text = "새로만들기";
            this.tsbNew.ToolTipText = "새로만들기";
            this.tsbNew.Click += new System.EventHandler(this.tsbNew_Click);
            // 
            // tsbSave
            // 
            this.tsbSave.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbSave.Image = global::mook_TextEdit.Properties.Resources.tsbSave_Image;
            this.tsbSave.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbSave.Name = "tsbSave";
            this.tsbSave.Size = new System.Drawing.Size(23, 22);
            this.tsbSave.Text = "저장하기";
            this.tsbSave.Click += new System.EventHandler(this.tsbSave_Click);
            // 
            // tsbPrvious
            // 
            this.tsbPrvious.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbPrvious.Image = global::mook_TextEdit.Properties.Resources.tsbPrvious_Image;
            this.tsbPrvious.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbPrvious.Name = "tsbPrvious";
            this.tsbPrvious.Size = new System.Drawing.Size(23, 22);
            this.tsbPrvious.Text = "뒤로";
            this.tsbPrvious.Click += new System.EventHandler(this.tsbPrvious_Click);
            // 
            // tsbNext
            // 
            this.tsbNext.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbNext.Image = global::mook_TextEdit.Properties.Resources.tsbNext_Image;
            this.tsbNext.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbNext.Name = "tsbNext";
            this.tsbNext.Size = new System.Drawing.Size(23, 22);
            this.tsbNext.Text = "앞으로";
            this.tsbNext.Click += new System.EventHandler(this.tsbNext_Click);
            // 
            // tsbNormal
            // 
            this.tsbNormal.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbNormal.Image = global::mook_TextEdit.Properties.Resources.tsbNormal_Image;
            this.tsbNormal.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbNormal.Name = "tsbNormal";
            this.tsbNormal.Size = new System.Drawing.Size(23, 22);
            this.tsbNormal.Text = "왼쪽정렬";
            this.tsbNormal.Click += new System.EventHandler(this.tsbNormal_Click);
            // 
            // tsbCenter
            // 
            this.tsbCenter.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbCenter.Image = global::mook_TextEdit.Properties.Resources.tsbCenter_Image;
            this.tsbCenter.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbCenter.Name = "tsbCenter";
            this.tsbCenter.Size = new System.Drawing.Size(23, 22);
            this.tsbCenter.Text = "가운데정렬";
            this.tsbCenter.Click += new System.EventHandler(this.tsbCenter_Click);
            // 
            // tsbRight
            // 
            this.tsbRight.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbRight.Image = global::mook_TextEdit.Properties.Resources.tsbRight_Image;
            this.tsbRight.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbRight.Name = "tsbRight";
            this.tsbRight.Size = new System.Drawing.Size(23, 22);
            this.tsbRight.Text = "오른쪽정렬";
            this.tsbRight.Click += new System.EventHandler(this.tsbRight_Click);
            // 
            // msBar
            // 
            this.msBar.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.파일ToolStripMenuItem,
            this.편집ToolStripMenuItem,
            this.보기ToolStripMenuItem});
            this.msBar.Location = new System.Drawing.Point(0, 0);
            this.msBar.Name = "msBar";
            this.msBar.Size = new System.Drawing.Size(909, 24);
            this.msBar.TabIndex = 14;
            this.msBar.Text = "MenuStrip1";
            // 
            // 파일ToolStripMenuItem
            // 
            this.파일ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.새로만들기ToolStripMenuItem,
            this.저장하기ToolStripMenuItem,
            this.다른이름으로저장ToolStripMenuItem,
            this.ToolStripSeparator1,
            this.끝내기ToolStripMenuItem});
            this.파일ToolStripMenuItem.Name = "파일ToolStripMenuItem";
            this.파일ToolStripMenuItem.Size = new System.Drawing.Size(43, 20);
            this.파일ToolStripMenuItem.Text = "파일";
            // 
            // 새로만들기ToolStripMenuItem
            // 
            this.새로만들기ToolStripMenuItem.Name = "새로만들기ToolStripMenuItem";
            this.새로만들기ToolStripMenuItem.Size = new System.Drawing.Size(174, 22);
            this.새로만들기ToolStripMenuItem.Text = "새로만들기";
            this.새로만들기ToolStripMenuItem.Click += new System.EventHandler(this.새로만들기ToolStripMenuItem_Click);
            // 
            // 저장하기ToolStripMenuItem
            // 
            this.저장하기ToolStripMenuItem.Name = "저장하기ToolStripMenuItem";
            this.저장하기ToolStripMenuItem.Size = new System.Drawing.Size(174, 22);
            this.저장하기ToolStripMenuItem.Text = "저장하기";
            this.저장하기ToolStripMenuItem.Click += new System.EventHandler(this.저장하기ToolStripMenuItem_Click);
            // 
            // 다른이름으로저장ToolStripMenuItem
            // 
            this.다른이름으로저장ToolStripMenuItem.Name = "다른이름으로저장ToolStripMenuItem";
            this.다른이름으로저장ToolStripMenuItem.Size = new System.Drawing.Size(174, 22);
            this.다른이름으로저장ToolStripMenuItem.Text = "다른이름으로 저장";
            this.다른이름으로저장ToolStripMenuItem.Click += new System.EventHandler(this.다른이름으로저장ToolStripMenuItem_Click);
            // 
            // ToolStripSeparator1
            // 
            this.ToolStripSeparator1.Name = "ToolStripSeparator1";
            this.ToolStripSeparator1.Size = new System.Drawing.Size(171, 6);
            // 
            // 끝내기ToolStripMenuItem
            // 
            this.끝내기ToolStripMenuItem.Name = "끝내기ToolStripMenuItem";
            this.끝내기ToolStripMenuItem.Size = new System.Drawing.Size(174, 22);
            this.끝내기ToolStripMenuItem.Text = "끝내기";
            this.끝내기ToolStripMenuItem.Click += new System.EventHandler(this.끝내기ToolStripMenuItem_Click);
            // 
            // 편집ToolStripMenuItem
            // 
            this.편집ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.되돌리기ToolStripMenuItem,
            this.ToolStripSeparator2,
            this.복사ToolStripMenuItem,
            this.자르기ToolStripMenuItem,
            this.ToolStripSeparator3,
            this.모두선택ToolStripMenuItem,
            this.toolStripSeparator4,
            this.왼쪽ToolStripMenuItem,
            this.가운데ToolStripMenuItem,
            this.오른쪽ToolStripMenuItem});
            this.편집ToolStripMenuItem.Name = "편집ToolStripMenuItem";
            this.편집ToolStripMenuItem.Size = new System.Drawing.Size(43, 20);
            this.편집ToolStripMenuItem.Text = "편집";
            // 
            // 되돌리기ToolStripMenuItem
            // 
            this.되돌리기ToolStripMenuItem.Name = "되돌리기ToolStripMenuItem";
            this.되돌리기ToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.되돌리기ToolStripMenuItem.Text = "되돌리기";
            this.되돌리기ToolStripMenuItem.Click += new System.EventHandler(this.되돌리기ToolStripMenuItem_Click);
            // 
            // ToolStripSeparator2
            // 
            this.ToolStripSeparator2.Name = "ToolStripSeparator2";
            this.ToolStripSeparator2.Size = new System.Drawing.Size(149, 6);
            // 
            // 복사ToolStripMenuItem
            // 
            this.복사ToolStripMenuItem.Name = "복사ToolStripMenuItem";
            this.복사ToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.복사ToolStripMenuItem.Text = "복사";
            this.복사ToolStripMenuItem.Click += new System.EventHandler(this.복사ToolStripMenuItem_Click);
            // 
            // 자르기ToolStripMenuItem
            // 
            this.자르기ToolStripMenuItem.Name = "자르기ToolStripMenuItem";
            this.자르기ToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.자르기ToolStripMenuItem.Text = "자르기";
            this.자르기ToolStripMenuItem.Click += new System.EventHandler(this.자르기ToolStripMenuItem_Click);
            // 
            // ToolStripSeparator3
            // 
            this.ToolStripSeparator3.Name = "ToolStripSeparator3";
            this.ToolStripSeparator3.Size = new System.Drawing.Size(149, 6);
            // 
            // 모두선택ToolStripMenuItem
            // 
            this.모두선택ToolStripMenuItem.Name = "모두선택ToolStripMenuItem";
            this.모두선택ToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.모두선택ToolStripMenuItem.Text = "모두선택";
            this.모두선택ToolStripMenuItem.Click += new System.EventHandler(this.모두선택ToolStripMenuItem_Click);
            // 
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            this.toolStripSeparator4.Size = new System.Drawing.Size(149, 6);
            // 
            // 왼쪽ToolStripMenuItem
            // 
            this.왼쪽ToolStripMenuItem.Name = "왼쪽ToolStripMenuItem";
            this.왼쪽ToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.왼쪽ToolStripMenuItem.Text = "왼   쪽";
            this.왼쪽ToolStripMenuItem.Click += new System.EventHandler(this.왼쪽ToolStripMenuItem_Click);
            // 
            // 가운데ToolStripMenuItem
            // 
            this.가운데ToolStripMenuItem.Name = "가운데ToolStripMenuItem";
            this.가운데ToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.가운데ToolStripMenuItem.Text = "가운데";
            this.가운데ToolStripMenuItem.Click += new System.EventHandler(this.가운데ToolStripMenuItem_Click);
            // 
            // 오른쪽ToolStripMenuItem
            // 
            this.오른쪽ToolStripMenuItem.Name = "오른쪽ToolStripMenuItem";
            this.오른쪽ToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.오른쪽ToolStripMenuItem.Text = "오른쪽";
            this.오른쪽ToolStripMenuItem.Click += new System.EventHandler(this.오른쪽ToolStripMenuItem_Click);
            // 
            // 보기ToolStripMenuItem
            // 
            this.보기ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.편집상자ToolStripMenuItem,
            this.파일보기ToolStripMenuItem});
            this.보기ToolStripMenuItem.Name = "보기ToolStripMenuItem";
            this.보기ToolStripMenuItem.Size = new System.Drawing.Size(43, 20);
            this.보기ToolStripMenuItem.Text = "보기";
            // 
            // 편집상자ToolStripMenuItem
            // 
            this.편집상자ToolStripMenuItem.Checked = true;
            this.편집상자ToolStripMenuItem.CheckState = System.Windows.Forms.CheckState.Checked;
            this.편집상자ToolStripMenuItem.Name = "편집상자ToolStripMenuItem";
            this.편집상자ToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.편집상자ToolStripMenuItem.Text = "편집 상자";
            this.편집상자ToolStripMenuItem.Click += new System.EventHandler(this.편집상자ToolStripMenuItem_Click);
            // 
            // 파일보기ToolStripMenuItem
            // 
            this.파일보기ToolStripMenuItem.Checked = true;
            this.파일보기ToolStripMenuItem.CheckState = System.Windows.Forms.CheckState.Checked;
            this.파일보기ToolStripMenuItem.Name = "파일보기ToolStripMenuItem";
            this.파일보기ToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.파일보기ToolStripMenuItem.Text = "파일 보기";
            this.파일보기ToolStripMenuItem.Click += new System.EventHandler(this.파일보기ToolStripMenuItem_Click);
            // 
            // sfdFile
            // 
            this.sfdFile.FileName = "doc1";
            this.sfdFile.Filter = "서식파일(*.rtf)|*.rtf|텍스트 파일(*.txt)|*.txt|모든 파일(*.*)|*.*";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(909, 474);
            this.Controls.Add(this.plGroup);
            this.Controls.Add(this.tsBar);
            this.Controls.Add(this.msBar);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.msBar;
            this.Name = "Form1";
            this.Text = "텍스트 편집기";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.lvFile_MouseMove);
            this.plGroup.ResumeLayout(false);
            this.tsBar.ResumeLayout(false);
            this.tsBar.PerformLayout();
            this.msBar.ResumeLayout(false);
            this.msBar.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        internal System.Windows.Forms.Panel plGroup;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        internal System.Windows.Forms.ColumnHeader ColumnHeader1;
        private System.Windows.Forms.ToolStrip tsBar;
        internal System.Windows.Forms.ToolStripButton tsbNew;
        internal System.Windows.Forms.ToolStripButton tsbSave;
        internal System.Windows.Forms.ToolStripButton tsbPrvious;
        internal System.Windows.Forms.ToolStripButton tsbNext;
        internal System.Windows.Forms.ToolStripButton tsbNormal;
        internal System.Windows.Forms.ToolStripButton tsbCenter;
        internal System.Windows.Forms.ToolStripButton tsbRight;
        private System.Windows.Forms.MenuStrip msBar;
        internal System.Windows.Forms.ToolStripMenuItem 파일ToolStripMenuItem;
        internal System.Windows.Forms.ToolStripMenuItem 새로만들기ToolStripMenuItem;
        internal System.Windows.Forms.ToolStripMenuItem 저장하기ToolStripMenuItem;
        internal System.Windows.Forms.ToolStripMenuItem 다른이름으로저장ToolStripMenuItem;
        internal System.Windows.Forms.ToolStripSeparator ToolStripSeparator1;
        internal System.Windows.Forms.ToolStripMenuItem 끝내기ToolStripMenuItem;
        internal System.Windows.Forms.ToolStripMenuItem 편집ToolStripMenuItem;
        internal System.Windows.Forms.ToolStripMenuItem 되돌리기ToolStripMenuItem;
        internal System.Windows.Forms.ToolStripSeparator ToolStripSeparator2;
        internal System.Windows.Forms.ToolStripMenuItem 복사ToolStripMenuItem;
        internal System.Windows.Forms.ToolStripMenuItem 자르기ToolStripMenuItem;
        internal System.Windows.Forms.ToolStripSeparator ToolStripSeparator3;
        internal System.Windows.Forms.ToolStripMenuItem 모두선택ToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
        private System.Windows.Forms.ToolStripMenuItem 왼쪽ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 가운데ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 오른쪽ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 보기ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 편집상자ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 파일보기ToolStripMenuItem;
        private System.Windows.Forms.ListView lvFile;
        private System.Windows.Forms.TreeView tvDive;
        private System.Windows.Forms.ListView lvFolder;
        private System.Windows.Forms.SaveFileDialog sfdFile;
        private System.Windows.Forms.ImageList imgDisk;
        private System.Windows.Forms.ImageList imgFile;
    }
}

