namespace mook_FormSkin
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
            this.picFileOpen = new System.Windows.Forms.PictureBox();
            this.picStop = new System.Windows.Forms.PictureBox();
            this.picPause = new System.Windows.Forms.PictureBox();
            this.picPlay = new System.Windows.Forms.PictureBox();
            this.picMinimize = new System.Windows.Forms.PictureBox();
            this.picClose = new System.Windows.Forms.PictureBox();
            this.picSpeakerTrack = new System.Windows.Forms.PictureBox();
            this.picSpeaker = new System.Windows.Forms.PictureBox();
            this.lvList = new System.Windows.Forms.ListView();
            this.chNum = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chTitle = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chTime = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.lblVolume = new System.Windows.Forms.Label();
            this.cmsMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.스킨ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.표준ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.가벼운ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.picFileOpen)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picStop)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picPause)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picPlay)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picMinimize)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picClose)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picSpeakerTrack)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picSpeaker)).BeginInit();
            this.cmsMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // picFileOpen
            // 
            this.picFileOpen.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.picFileOpen.Location = new System.Drawing.Point(79, 121);
            this.picFileOpen.Name = "picFileOpen";
            this.picFileOpen.Size = new System.Drawing.Size(21, 20);
            this.picFileOpen.TabIndex = 42;
            this.picFileOpen.TabStop = false;
            this.picFileOpen.MouseDown += new System.Windows.Forms.MouseEventHandler(this.picFileOpen_MouseDown);
            this.picFileOpen.MouseLeave += new System.EventHandler(this.picFileOpen_MouseLeave);
            this.picFileOpen.MouseMove += new System.Windows.Forms.MouseEventHandler(this.picFileOpen_MouseMove);
            // 
            // picStop
            // 
            this.picStop.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.picStop.Location = new System.Drawing.Point(57, 121);
            this.picStop.Name = "picStop";
            this.picStop.Size = new System.Drawing.Size(20, 20);
            this.picStop.TabIndex = 41;
            this.picStop.TabStop = false;
            this.picStop.MouseDown += new System.Windows.Forms.MouseEventHandler(this.picStop_MouseDown);
            this.picStop.MouseLeave += new System.EventHandler(this.picStop_MouseLeave);
            this.picStop.MouseMove += new System.Windows.Forms.MouseEventHandler(this.picStop_MouseMove);
            // 
            // picPause
            // 
            this.picPause.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.picPause.Location = new System.Drawing.Point(35, 121);
            this.picPause.Name = "picPause";
            this.picPause.Size = new System.Drawing.Size(22, 20);
            this.picPause.TabIndex = 40;
            this.picPause.TabStop = false;
            this.picPause.MouseDown += new System.Windows.Forms.MouseEventHandler(this.picPause_MouseDown);
            this.picPause.MouseLeave += new System.EventHandler(this.picPause_MouseLeave);
            this.picPause.MouseMove += new System.Windows.Forms.MouseEventHandler(this.picPause_MouseMove);
            // 
            // picPlay
            // 
            this.picPlay.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.picPlay.Location = new System.Drawing.Point(13, 121);
            this.picPlay.Name = "picPlay";
            this.picPlay.Size = new System.Drawing.Size(21, 20);
            this.picPlay.TabIndex = 39;
            this.picPlay.TabStop = false;
            this.picPlay.MouseDown += new System.Windows.Forms.MouseEventHandler(this.picPlay_MouseDown);
            this.picPlay.MouseLeave += new System.EventHandler(this.picPlay_MouseLeave);
            this.picPlay.MouseMove += new System.Windows.Forms.MouseEventHandler(this.picPlay_MouseMove);
            // 
            // picMinimize
            // 
            this.picMinimize.Location = new System.Drawing.Point(279, 0);
            this.picMinimize.Name = "picMinimize";
            this.picMinimize.Size = new System.Drawing.Size(17, 17);
            this.picMinimize.TabIndex = 48;
            this.picMinimize.TabStop = false;
            this.picMinimize.Click += new System.EventHandler(this.picMinimize_Click);
            this.picMinimize.MouseDown += new System.Windows.Forms.MouseEventHandler(this.picMinimize_MouseDown);
            this.picMinimize.MouseLeave += new System.EventHandler(this.picMinimize_MouseLeave);
            this.picMinimize.MouseMove += new System.Windows.Forms.MouseEventHandler(this.picMinimize_MouseMove);
            // 
            // picClose
            // 
            this.picClose.Location = new System.Drawing.Point(299, 0);
            this.picClose.Name = "picClose";
            this.picClose.Size = new System.Drawing.Size(17, 17);
            this.picClose.TabIndex = 47;
            this.picClose.TabStop = false;
            this.picClose.Click += new System.EventHandler(this.picClose_Click);
            this.picClose.MouseDown += new System.Windows.Forms.MouseEventHandler(this.picClose_MouseDown);
            this.picClose.MouseLeave += new System.EventHandler(this.picClose_MouseLeave);
            this.picClose.MouseMove += new System.Windows.Forms.MouseEventHandler(this.picClose_MouseMove);
            // 
            // picSpeakerTrack
            // 
            this.picSpeakerTrack.Location = new System.Drawing.Point(128, 123);
            this.picSpeakerTrack.Name = "picSpeakerTrack";
            this.picSpeakerTrack.Size = new System.Drawing.Size(13, 13);
            this.picSpeakerTrack.TabIndex = 46;
            this.picSpeakerTrack.TabStop = false;
            this.picSpeakerTrack.MouseDown += new System.Windows.Forms.MouseEventHandler(this.picSpeakerTrack_MouseDown);
            this.picSpeakerTrack.MouseMove += new System.Windows.Forms.MouseEventHandler(this.picSpeakerTrack_MouseMove);
            this.picSpeakerTrack.MouseUp += new System.Windows.Forms.MouseEventHandler(this.picSpeakerTrack_MouseUp);
            // 
            // picSpeaker
            // 
            this.picSpeaker.Location = new System.Drawing.Point(103, 122);
            this.picSpeaker.Name = "picSpeaker";
            this.picSpeaker.Size = new System.Drawing.Size(22, 18);
            this.picSpeaker.TabIndex = 45;
            this.picSpeaker.TabStop = false;
            this.picSpeaker.MouseDown += new System.Windows.Forms.MouseEventHandler(this.picSpeaker_MouseDown);
            this.picSpeaker.MouseLeave += new System.EventHandler(this.picSpeaker_MouseLeave);
            this.picSpeaker.MouseMove += new System.Windows.Forms.MouseEventHandler(this.picSpeaker_MouseMove);
            // 
            // lvList
            // 
            this.lvList.BackColor = System.Drawing.SystemColors.Window;
            this.lvList.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.chNum,
            this.chTitle,
            this.chTime});
            this.lvList.FullRowSelect = true;
            this.lvList.GridLines = true;
            this.lvList.HideSelection = false;
            this.lvList.Location = new System.Drawing.Point(13, 151);
            this.lvList.MultiSelect = false;
            this.lvList.Name = "lvList";
            this.lvList.Size = new System.Drawing.Size(303, 236);
            this.lvList.TabIndex = 37;
            this.lvList.UseCompatibleStateImageBehavior = false;
            this.lvList.View = System.Windows.Forms.View.Details;
            // 
            // chNum
            // 
            this.chNum.Text = " NO";
            this.chNum.Width = 40;
            // 
            // chTitle
            // 
            this.chTitle.Text = "TITLE";
            this.chTitle.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.chTitle.Width = 175;
            // 
            // chTime
            // 
            this.chTime.Text = "TIME";
            this.chTime.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lblVolume
            // 
            this.lblVolume.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(38)))), ((int)(((byte)(41)))));
            this.lblVolume.ForeColor = System.Drawing.Color.White;
            this.lblVolume.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lblVolume.Location = new System.Drawing.Point(225, 123);
            this.lblVolume.Name = "lblVolume";
            this.lblVolume.Size = new System.Drawing.Size(99, 14);
            this.lblVolume.TabIndex = 36;
            this.lblVolume.Text = "Volume : ";
            // 
            // cmsMenu
            // 
            this.cmsMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.스킨ToolStripMenuItem});
            this.cmsMenu.Name = "ㅡ";
            this.cmsMenu.Size = new System.Drawing.Size(101, 26);
            // 
            // 스킨ToolStripMenuItem
            // 
            this.스킨ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.표준ToolStripMenuItem,
            this.가벼운ToolStripMenuItem});
            this.스킨ToolStripMenuItem.Name = "스킨ToolStripMenuItem";
            this.스킨ToolStripMenuItem.Size = new System.Drawing.Size(100, 22);
            this.스킨ToolStripMenuItem.Text = "스킨";
            // 
            // 표준ToolStripMenuItem
            // 
            this.표준ToolStripMenuItem.Name = "표준ToolStripMenuItem";
            this.표준ToolStripMenuItem.Size = new System.Drawing.Size(112, 22);
            this.표준ToolStripMenuItem.Text = "표   준";
            this.표준ToolStripMenuItem.Click += new System.EventHandler(this.표준ToolStripMenuItem_Click);
            // 
            // 가벼운ToolStripMenuItem
            // 
            this.가벼운ToolStripMenuItem.Name = "가벼운ToolStripMenuItem";
            this.가벼운ToolStripMenuItem.Size = new System.Drawing.Size(112, 22);
            this.가벼운ToolStripMenuItem.Text = "가벼운";
            this.가벼운ToolStripMenuItem.Click += new System.EventHandler(this.가벼운ToolStripMenuItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(38)))), ((int)(((byte)(41)))));
            this.ClientSize = new System.Drawing.Size(330, 400);
            this.ContextMenuStrip = this.cmsMenu;
            this.Controls.Add(this.picFileOpen);
            this.Controls.Add(this.picStop);
            this.Controls.Add(this.picPause);
            this.Controls.Add(this.picPlay);
            this.Controls.Add(this.picMinimize);
            this.Controls.Add(this.picClose);
            this.Controls.Add(this.picSpeakerTrack);
            this.Controls.Add(this.picSpeaker);
            this.Controls.Add(this.lvList);
            this.Controls.Add(this.lblVolume);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "M Player";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.Form1_Paint);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseMove);
            this.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseUp);
            ((System.ComponentModel.ISupportInitialize)(this.picFileOpen)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picStop)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picPause)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picPlay)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picMinimize)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picClose)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picSpeakerTrack)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picSpeaker)).EndInit();
            this.cmsMenu.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox picFileOpen;
        private System.Windows.Forms.PictureBox picStop;
        private System.Windows.Forms.PictureBox picPause;
        private System.Windows.Forms.PictureBox picPlay;
        private System.Windows.Forms.PictureBox picMinimize;
        private System.Windows.Forms.PictureBox picClose;
        private System.Windows.Forms.PictureBox picSpeakerTrack;
        private System.Windows.Forms.PictureBox picSpeaker;
        private System.Windows.Forms.ListView lvList;
        private System.Windows.Forms.ColumnHeader chNum;
        private System.Windows.Forms.ColumnHeader chTitle;
        private System.Windows.Forms.ColumnHeader chTime;
        private System.Windows.Forms.Label lblVolume;
        private System.Windows.Forms.ContextMenuStrip cmsMenu;
        private System.Windows.Forms.ToolStripMenuItem 스킨ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 표준ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 가벼운ToolStripMenuItem;
    }
}

