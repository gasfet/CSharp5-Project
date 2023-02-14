namespace mook_Painting
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
            this.tsLeftBar = new System.Windows.Forms.ToolStrip();
            this.tsbtnLine01 = new System.Windows.Forms.ToolStripButton();
            this.tsbtnLine02 = new System.Windows.Forms.ToolStripButton();
            this.tsbtnLine03 = new System.Windows.Forms.ToolStripButton();
            this.tsbtnLine04 = new System.Windows.Forms.ToolStripButton();
            this.cdColor = new System.Windows.Forms.ColorDialog();
            this.tsBar = new System.Windows.Forms.ToolStrip();
            this.tsbtnRefresh = new System.Windows.Forms.ToolStripButton();
            this.tsbtnBlack = new System.Windows.Forms.ToolStripButton();
            this.tsbtnRed = new System.Windows.Forms.ToolStripButton();
            this.tsbtnBlue = new System.Windows.Forms.ToolStripButton();
            this.tsbtnYellow = new System.Windows.Forms.ToolStripButton();
            this.msBar = new System.Windows.Forms.MenuStrip();
            this.파일ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.새로ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.끝내기ToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.모양ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.직선ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.곡선ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.원ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.사각형ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.편집ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.굵기ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripMenuItem3 = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripMenuItem4 = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripMenuItem5 = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripMenuItem6 = new System.Windows.Forms.ToolStripMenuItem();
            this.색ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.색편집ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tsLeftBar.SuspendLayout();
            this.tsBar.SuspendLayout();
            this.msBar.SuspendLayout();
            this.SuspendLayout();
            // 
            // tsLeftBar
            // 
            this.tsLeftBar.Dock = System.Windows.Forms.DockStyle.Left;
            this.tsLeftBar.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.tsLeftBar.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsbtnLine01,
            this.tsbtnLine02,
            this.tsbtnLine03,
            this.tsbtnLine04});
            this.tsLeftBar.Location = new System.Drawing.Point(0, 49);
            this.tsLeftBar.Name = "tsLeftBar";
            this.tsLeftBar.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
            this.tsLeftBar.Size = new System.Drawing.Size(24, 424);
            this.tsLeftBar.TabIndex = 7;
            // 
            // tsbtnLine01
            // 
            this.tsbtnLine01.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbtnLine01.Image = global::mook_Painting.Properties.Resources.tsbtnLine01;
            this.tsbtnLine01.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbtnLine01.Name = "tsbtnLine01";
            this.tsbtnLine01.Size = new System.Drawing.Size(21, 20);
            this.tsbtnLine01.Text = "toolStripButton1";
            this.tsbtnLine01.ToolTipText = "직선";
            this.tsbtnLine01.Click += new System.EventHandler(this.tsbtnLine01_Click);
            // 
            // tsbtnLine02
            // 
            this.tsbtnLine02.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbtnLine02.Image = global::mook_Painting.Properties.Resources.tsbtnLine02;
            this.tsbtnLine02.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbtnLine02.Name = "tsbtnLine02";
            this.tsbtnLine02.Size = new System.Drawing.Size(21, 20);
            this.tsbtnLine02.Text = "toolStripButton2";
            this.tsbtnLine02.ToolTipText = "곡선";
            this.tsbtnLine02.Click += new System.EventHandler(this.tsbtnLine02_Click);
            // 
            // tsbtnLine03
            // 
            this.tsbtnLine03.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbtnLine03.Image = global::mook_Painting.Properties.Resources.tsbtnLine03;
            this.tsbtnLine03.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbtnLine03.Name = "tsbtnLine03";
            this.tsbtnLine03.Size = new System.Drawing.Size(21, 20);
            this.tsbtnLine03.Text = "toolStripButton3";
            this.tsbtnLine03.ToolTipText = "원";
            this.tsbtnLine03.Click += new System.EventHandler(this.tsbtnLine03_Click);
            // 
            // tsbtnLine04
            // 
            this.tsbtnLine04.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbtnLine04.Image = global::mook_Painting.Properties.Resources.tsbtnLine04;
            this.tsbtnLine04.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbtnLine04.Name = "tsbtnLine04";
            this.tsbtnLine04.Size = new System.Drawing.Size(21, 20);
            this.tsbtnLine04.Text = "toolStripButton4";
            this.tsbtnLine04.ToolTipText = "사각형";
            this.tsbtnLine04.Click += new System.EventHandler(this.tsbtnLine04_Click);
            // 
            // tsBar
            // 
            this.tsBar.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.tsBar.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsbtnRefresh,
            this.tsbtnBlack,
            this.tsbtnRed,
            this.tsbtnBlue,
            this.tsbtnYellow});
            this.tsBar.Location = new System.Drawing.Point(0, 24);
            this.tsBar.Name = "tsBar";
            this.tsBar.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
            this.tsBar.Size = new System.Drawing.Size(492, 25);
            this.tsBar.TabIndex = 6;
            // 
            // tsbtnRefresh
            // 
            this.tsbtnRefresh.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbtnRefresh.Image = global::mook_Painting.Properties.Resources.Refresh;
            this.tsbtnRefresh.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbtnRefresh.Name = "tsbtnRefresh";
            this.tsbtnRefresh.Size = new System.Drawing.Size(23, 22);
            this.tsbtnRefresh.Text = "새로고침";
            this.tsbtnRefresh.Click += new System.EventHandler(this.tsbtnRefresh_Click);
            // 
            // tsbtnBlack
            // 
            this.tsbtnBlack.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbtnBlack.Image = global::mook_Painting.Properties.Resources.black;
            this.tsbtnBlack.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbtnBlack.Name = "tsbtnBlack";
            this.tsbtnBlack.Size = new System.Drawing.Size(23, 22);
            this.tsbtnBlack.Text = "깜장색";
            this.tsbtnBlack.Click += new System.EventHandler(this.tsbtnBlack_Click);
            // 
            // tsbtnRed
            // 
            this.tsbtnRed.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbtnRed.Image = global::mook_Painting.Properties.Resources.red;
            this.tsbtnRed.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbtnRed.Name = "tsbtnRed";
            this.tsbtnRed.Size = new System.Drawing.Size(23, 22);
            this.tsbtnRed.Text = "빨강색";
            this.tsbtnRed.Click += new System.EventHandler(this.tsbtnRed_Click);
            // 
            // tsbtnBlue
            // 
            this.tsbtnBlue.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbtnBlue.Image = global::mook_Painting.Properties.Resources.blue;
            this.tsbtnBlue.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbtnBlue.Name = "tsbtnBlue";
            this.tsbtnBlue.Size = new System.Drawing.Size(23, 22);
            this.tsbtnBlue.Text = "파랑색";
            this.tsbtnBlue.Click += new System.EventHandler(this.tsbtnBlue_Click);
            // 
            // tsbtnYellow
            // 
            this.tsbtnYellow.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbtnYellow.Image = global::mook_Painting.Properties.Resources.yellow;
            this.tsbtnYellow.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbtnYellow.Name = "tsbtnYellow";
            this.tsbtnYellow.Size = new System.Drawing.Size(23, 22);
            this.tsbtnYellow.Text = "노란색";
            this.tsbtnYellow.Click += new System.EventHandler(this.tsbtnYellow_Click);
            // 
            // msBar
            // 
            this.msBar.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.파일ToolStripMenuItem,
            this.모양ToolStripMenuItem,
            this.편집ToolStripMenuItem,
            this.색ToolStripMenuItem});
            this.msBar.Location = new System.Drawing.Point(0, 0);
            this.msBar.Name = "msBar";
            this.msBar.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
            this.msBar.Size = new System.Drawing.Size(492, 24);
            this.msBar.TabIndex = 5;
            this.msBar.Text = "MenuStrip1";
            // 
            // 파일ToolStripMenuItem
            // 
            this.파일ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.새로ToolStripMenuItem,
            this.ToolStripSeparator1,
            this.끝내기ToolStripMenuItem1});
            this.파일ToolStripMenuItem.Name = "파일ToolStripMenuItem";
            this.파일ToolStripMenuItem.Size = new System.Drawing.Size(43, 20);
            this.파일ToolStripMenuItem.Text = "편집";
            // 
            // 새로ToolStripMenuItem
            // 
            this.새로ToolStripMenuItem.Name = "새로ToolStripMenuItem";
            this.새로ToolStripMenuItem.Size = new System.Drawing.Size(138, 22);
            this.새로ToolStripMenuItem.Text = "새로 만들기";
            this.새로ToolStripMenuItem.Click += new System.EventHandler(this.새로ToolStripMenuItem_Click);
            // 
            // ToolStripSeparator1
            // 
            this.ToolStripSeparator1.Name = "ToolStripSeparator1";
            this.ToolStripSeparator1.Size = new System.Drawing.Size(135, 6);
            // 
            // 끝내기ToolStripMenuItem1
            // 
            this.끝내기ToolStripMenuItem1.Name = "끝내기ToolStripMenuItem1";
            this.끝내기ToolStripMenuItem1.Size = new System.Drawing.Size(138, 22);
            this.끝내기ToolStripMenuItem1.Text = "끝내기";
            this.끝내기ToolStripMenuItem1.Click += new System.EventHandler(this.끝내기ToolStripMenuItem1_Click);
            // 
            // 모양ToolStripMenuItem
            // 
            this.모양ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.직선ToolStripMenuItem,
            this.곡선ToolStripMenuItem,
            this.원ToolStripMenuItem,
            this.사각형ToolStripMenuItem});
            this.모양ToolStripMenuItem.Name = "모양ToolStripMenuItem";
            this.모양ToolStripMenuItem.Size = new System.Drawing.Size(43, 20);
            this.모양ToolStripMenuItem.Text = "모양";
            // 
            // 직선ToolStripMenuItem
            // 
            this.직선ToolStripMenuItem.Name = "직선ToolStripMenuItem";
            this.직선ToolStripMenuItem.Size = new System.Drawing.Size(110, 22);
            this.직선ToolStripMenuItem.Text = "직선";
            this.직선ToolStripMenuItem.Click += new System.EventHandler(this.직선ToolStripMenuItem_Click);
            // 
            // 곡선ToolStripMenuItem
            // 
            this.곡선ToolStripMenuItem.Name = "곡선ToolStripMenuItem";
            this.곡선ToolStripMenuItem.Size = new System.Drawing.Size(110, 22);
            this.곡선ToolStripMenuItem.Text = "곡선";
            this.곡선ToolStripMenuItem.Click += new System.EventHandler(this.곡선ToolStripMenuItem_Click);
            // 
            // 원ToolStripMenuItem
            // 
            this.원ToolStripMenuItem.Name = "원ToolStripMenuItem";
            this.원ToolStripMenuItem.Size = new System.Drawing.Size(110, 22);
            this.원ToolStripMenuItem.Text = "원";
            this.원ToolStripMenuItem.Click += new System.EventHandler(this.원ToolStripMenuItem_Click);
            // 
            // 사각형ToolStripMenuItem
            // 
            this.사각형ToolStripMenuItem.Name = "사각형ToolStripMenuItem";
            this.사각형ToolStripMenuItem.Size = new System.Drawing.Size(110, 22);
            this.사각형ToolStripMenuItem.Text = "사각형";
            this.사각형ToolStripMenuItem.Click += new System.EventHandler(this.사각형ToolStripMenuItem_Click);
            // 
            // 편집ToolStripMenuItem
            // 
            this.편집ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.굵기ToolStripMenuItem});
            this.편집ToolStripMenuItem.Name = "편집ToolStripMenuItem";
            this.편집ToolStripMenuItem.Size = new System.Drawing.Size(43, 20);
            this.편집ToolStripMenuItem.Text = "편집";
            // 
            // 굵기ToolStripMenuItem
            // 
            this.굵기ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ToolStripMenuItem2,
            this.ToolStripMenuItem3,
            this.ToolStripMenuItem4,
            this.ToolStripMenuItem5,
            this.ToolStripMenuItem6});
            this.굵기ToolStripMenuItem.Name = "굵기ToolStripMenuItem";
            this.굵기ToolStripMenuItem.Size = new System.Drawing.Size(98, 22);
            this.굵기ToolStripMenuItem.Text = "굵기";
            // 
            // ToolStripMenuItem2
            // 
            this.ToolStripMenuItem2.Name = "ToolStripMenuItem2";
            this.ToolStripMenuItem2.Size = new System.Drawing.Size(81, 22);
            this.ToolStripMenuItem2.Text = "1";
            this.ToolStripMenuItem2.Click += new System.EventHandler(this.ToolStripMenuItem2_Click);
            // 
            // ToolStripMenuItem3
            // 
            this.ToolStripMenuItem3.Name = "ToolStripMenuItem3";
            this.ToolStripMenuItem3.Size = new System.Drawing.Size(81, 22);
            this.ToolStripMenuItem3.Text = "2";
            this.ToolStripMenuItem3.Click += new System.EventHandler(this.ToolStripMenuItem3_Click);
            // 
            // ToolStripMenuItem4
            // 
            this.ToolStripMenuItem4.Name = "ToolStripMenuItem4";
            this.ToolStripMenuItem4.Size = new System.Drawing.Size(81, 22);
            this.ToolStripMenuItem4.Text = "3";
            this.ToolStripMenuItem4.Click += new System.EventHandler(this.ToolStripMenuItem4_Click);
            // 
            // ToolStripMenuItem5
            // 
            this.ToolStripMenuItem5.Name = "ToolStripMenuItem5";
            this.ToolStripMenuItem5.Size = new System.Drawing.Size(81, 22);
            this.ToolStripMenuItem5.Text = "4";
            this.ToolStripMenuItem5.Click += new System.EventHandler(this.ToolStripMenuItem5_Click);
            // 
            // ToolStripMenuItem6
            // 
            this.ToolStripMenuItem6.Name = "ToolStripMenuItem6";
            this.ToolStripMenuItem6.Size = new System.Drawing.Size(81, 22);
            this.ToolStripMenuItem6.Text = "5";
            this.ToolStripMenuItem6.Click += new System.EventHandler(this.ToolStripMenuItem6_Click);
            // 
            // 색ToolStripMenuItem
            // 
            this.색ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.색편집ToolStripMenuItem});
            this.색ToolStripMenuItem.Name = "색ToolStripMenuItem";
            this.색ToolStripMenuItem.Size = new System.Drawing.Size(43, 20);
            this.색ToolStripMenuItem.Text = "색상";
            // 
            // 색편집ToolStripMenuItem
            // 
            this.색편집ToolStripMenuItem.Name = "색편집ToolStripMenuItem";
            this.색편집ToolStripMenuItem.Size = new System.Drawing.Size(114, 22);
            this.색편집ToolStripMenuItem.Text = "색 편집";
            this.색편집ToolStripMenuItem.Click += new System.EventHandler(this.색편집ToolStripMenuItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(492, 473);
            this.Controls.Add(this.tsLeftBar);
            this.Controls.Add(this.tsBar);
            this.Controls.Add(this.msBar);
            this.Name = "Form1";
            this.Text = "그림판";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseMove);
            this.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseUp);
            this.Resize += new System.EventHandler(this.Form1_Resize);
            this.tsLeftBar.ResumeLayout(false);
            this.tsLeftBar.PerformLayout();
            this.tsBar.ResumeLayout(false);
            this.tsBar.PerformLayout();
            this.msBar.ResumeLayout(false);
            this.msBar.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip tsLeftBar;
        private System.Windows.Forms.ToolStripButton tsbtnLine01;
        private System.Windows.Forms.ToolStripButton tsbtnLine02;
        private System.Windows.Forms.ToolStripButton tsbtnLine03;
        private System.Windows.Forms.ToolStripButton tsbtnLine04;
        internal System.Windows.Forms.ColorDialog cdColor;
        internal System.Windows.Forms.ToolStripButton tsbtnRefresh;
        internal System.Windows.Forms.ToolStripButton tsbtnBlack;
        internal System.Windows.Forms.ToolStripButton tsbtnRed;
        internal System.Windows.Forms.ToolStripButton tsbtnBlue;
        internal System.Windows.Forms.ToolStripButton tsbtnYellow;
        internal System.Windows.Forms.ToolStripMenuItem 파일ToolStripMenuItem;
        internal System.Windows.Forms.ToolStripMenuItem 새로ToolStripMenuItem;
        internal System.Windows.Forms.ToolStripSeparator ToolStripSeparator1;
        internal System.Windows.Forms.ToolStripMenuItem 끝내기ToolStripMenuItem1;
        internal System.Windows.Forms.ToolStripMenuItem 모양ToolStripMenuItem;
        internal System.Windows.Forms.ToolStripMenuItem 직선ToolStripMenuItem;
        internal System.Windows.Forms.ToolStripMenuItem 곡선ToolStripMenuItem;
        internal System.Windows.Forms.ToolStripMenuItem 원ToolStripMenuItem;
        internal System.Windows.Forms.ToolStripMenuItem 사각형ToolStripMenuItem;
        internal System.Windows.Forms.ToolStripMenuItem 편집ToolStripMenuItem;
        internal System.Windows.Forms.ToolStripMenuItem 굵기ToolStripMenuItem;
        internal System.Windows.Forms.ToolStripMenuItem ToolStripMenuItem2;
        internal System.Windows.Forms.ToolStripMenuItem ToolStripMenuItem3;
        internal System.Windows.Forms.ToolStripMenuItem ToolStripMenuItem4;
        internal System.Windows.Forms.ToolStripMenuItem ToolStripMenuItem5;
        internal System.Windows.Forms.ToolStripMenuItem ToolStripMenuItem6;
        internal System.Windows.Forms.ToolStripMenuItem 색ToolStripMenuItem;
        internal System.Windows.Forms.ToolStripMenuItem 색편집ToolStripMenuItem;
        private System.Windows.Forms.ToolStrip tsBar;
        private System.Windows.Forms.MenuStrip msBar;
    }
}
