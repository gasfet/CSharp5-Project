namespace mook_MP3
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
            this.Timer = new System.Windows.Forms.Timer(this.components);
            this.ofdMp3File = new System.Windows.Forms.OpenFileDialog();
            this.lblVolume = new System.Windows.Forms.Label();
            this.lblBalance = new System.Windows.Forms.Label();
            this.BalanceBar = new System.Windows.Forms.TrackBar();
            this.VolumeBar = new System.Windows.Forms.TrackBar();
            this.lblPlayResult = new System.Windows.Forms.Label();
            this.btnPause = new System.Windows.Forms.Button();
            this.lblCurPos = new System.Windows.Forms.Label();
            this.btnStop = new System.Windows.Forms.Button();
            this.btnPlay = new System.Windows.Forms.Button();
            this.btnFileOpen = new System.Windows.Forms.Button();
            this.PlayBar = new System.Windows.Forms.TrackBar();
            this.lvMp3List = new System.Windows.Forms.ListView();
            this.chNum = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chTitle = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chTime = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            ((System.ComponentModel.ISupportInitialize)(this.BalanceBar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.VolumeBar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PlayBar)).BeginInit();
            this.SuspendLayout();
            // 
            // Timer
            // 
            this.Timer.Enabled = true;
            this.Timer.Interval = 1000;
            this.Timer.Tick += new System.EventHandler(this.Timer_Tick);
            // 
            // ofdMp3File
            // 
            this.ofdMp3File.Filter = "음악파일(mp3,wav)|*.mp3;*.wav|All Files|*.*";
            // 
            // lblVolume
            // 
            this.lblVolume.AutoSize = true;
            this.lblVolume.Location = new System.Drawing.Point(152, 60);
            this.lblVolume.Name = "lblVolume";
            this.lblVolume.Size = new System.Drawing.Size(48, 12);
            this.lblVolume.TabIndex = 34;
            this.lblVolume.Text = "Volume";
            // 
            // lblBalance
            // 
            this.lblBalance.AutoSize = true;
            this.lblBalance.Location = new System.Drawing.Point(17, 60);
            this.lblBalance.Name = "lblBalance";
            this.lblBalance.Size = new System.Drawing.Size(51, 12);
            this.lblBalance.TabIndex = 33;
            this.lblBalance.Text = "Balance";
            // 
            // BalanceBar
            // 
            this.BalanceBar.AutoSize = false;
            this.BalanceBar.Location = new System.Drawing.Point(72, 56);
            this.BalanceBar.Maximum = 100;
            this.BalanceBar.Name = "BalanceBar";
            this.BalanceBar.Size = new System.Drawing.Size(80, 23);
            this.BalanceBar.TabIndex = 32;
            this.BalanceBar.TickStyle = System.Windows.Forms.TickStyle.None;
            this.BalanceBar.Value = 50;
            this.BalanceBar.Scroll += new System.EventHandler(this.BalanceBar_Scroll);
            // 
            // VolumeBar
            // 
            this.VolumeBar.AutoSize = false;
            this.VolumeBar.Location = new System.Drawing.Point(194, 56);
            this.VolumeBar.Maximum = 100;
            this.VolumeBar.Name = "VolumeBar";
            this.VolumeBar.Size = new System.Drawing.Size(119, 23);
            this.VolumeBar.TabIndex = 28;
            this.VolumeBar.TickStyle = System.Windows.Forms.TickStyle.None;
            this.VolumeBar.Value = 100;
            this.VolumeBar.Scroll += new System.EventHandler(this.VolumeBar_Scroll);
            // 
            // lblPlayResult
            // 
            this.lblPlayResult.Location = new System.Drawing.Point(17, 39);
            this.lblPlayResult.Name = "lblPlayResult";
            this.lblPlayResult.Size = new System.Drawing.Size(99, 14);
            this.lblPlayResult.TabIndex = 31;
            this.lblPlayResult.Text = "STATUS";
            // 
            // btnPause
            // 
            this.btnPause.Location = new System.Drawing.Point(89, 85);
            this.btnPause.Name = "btnPause";
            this.btnPause.Size = new System.Drawing.Size(65, 23);
            this.btnPause.TabIndex = 30;
            this.btnPause.Text = "일시정지";
            this.btnPause.UseVisualStyleBackColor = true;
            this.btnPause.Click += new System.EventHandler(this.btnPause_Click);
            // 
            // lblCurPos
            // 
            this.lblCurPos.Location = new System.Drawing.Point(214, 36);
            this.lblCurPos.Name = "lblCurPos";
            this.lblCurPos.Size = new System.Drawing.Size(99, 14);
            this.lblCurPos.TabIndex = 27;
            this.lblCurPos.Text = "00:00:00/00:00:00";
            // 
            // btnStop
            // 
            this.btnStop.Location = new System.Drawing.Point(160, 85);
            this.btnStop.Name = "btnStop";
            this.btnStop.Size = new System.Drawing.Size(65, 23);
            this.btnStop.TabIndex = 26;
            this.btnStop.Text = "정지";
            this.btnStop.UseVisualStyleBackColor = true;
            this.btnStop.Click += new System.EventHandler(this.btnStop_Click);
            // 
            // btnPlay
            // 
            this.btnPlay.Location = new System.Drawing.Point(19, 85);
            this.btnPlay.Name = "btnPlay";
            this.btnPlay.Size = new System.Drawing.Size(64, 23);
            this.btnPlay.TabIndex = 25;
            this.btnPlay.Text = "재생";
            this.btnPlay.UseVisualStyleBackColor = true;
            this.btnPlay.Click += new System.EventHandler(this.btnPlay_Click);
            // 
            // btnFileOpen
            // 
            this.btnFileOpen.Location = new System.Drawing.Point(231, 85);
            this.btnFileOpen.Name = "btnFileOpen";
            this.btnFileOpen.Size = new System.Drawing.Size(73, 23);
            this.btnFileOpen.TabIndex = 24;
            this.btnFileOpen.Text = "파일";
            this.btnFileOpen.UseVisualStyleBackColor = true;
            this.btnFileOpen.Click += new System.EventHandler(this.btnFileOpen_Click);
            // 
            // PlayBar
            // 
            this.PlayBar.AutoSize = false;
            this.PlayBar.Location = new System.Drawing.Point(17, 13);
            this.PlayBar.Maximum = 200;
            this.PlayBar.Name = "PlayBar";
            this.PlayBar.Size = new System.Drawing.Size(295, 23);
            this.PlayBar.TabIndex = 29;
            this.PlayBar.TickStyle = System.Windows.Forms.TickStyle.None;
            this.PlayBar.Scroll += new System.EventHandler(this.PlayBar_Scroll);
            // 
            // lvMp3List
            // 
            this.lvMp3List.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.chNum,
            this.chTitle,
            this.chTime});
            this.lvMp3List.FullRowSelect = true;
            this.lvMp3List.GridLines = true;
            this.lvMp3List.HideSelection = false;
            this.lvMp3List.Location = new System.Drawing.Point(12, 118);
            this.lvMp3List.MultiSelect = false;
            this.lvMp3List.Name = "lvMp3List";
            this.lvMp3List.Size = new System.Drawing.Size(299, 232);
            this.lvMp3List.TabIndex = 23;
            this.lvMp3List.UseCompatibleStateImageBehavior = false;
            this.lvMp3List.View = System.Windows.Forms.View.Details;
            this.lvMp3List.SelectedIndexChanged += new System.EventHandler(this.lvMp3List_SelectedIndexChanged);
            this.lvMp3List.DoubleClick += new System.EventHandler(this.lvMp3List_DoubleClick);
            // 
            // chNum
            // 
            this.chNum.Text = " NO";
            this.chNum.Width = 45;
            // 
            // chTitle
            // 
            this.chTitle.Text = "TITLE";
            this.chTitle.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.chTitle.Width = 180;
            // 
            // chTime
            // 
            this.chTime.Text = "TIME";
            this.chTime.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(324, 362);
            this.Controls.Add(this.lblVolume);
            this.Controls.Add(this.lblBalance);
            this.Controls.Add(this.BalanceBar);
            this.Controls.Add(this.VolumeBar);
            this.Controls.Add(this.lblPlayResult);
            this.Controls.Add(this.btnPause);
            this.Controls.Add(this.lblCurPos);
            this.Controls.Add(this.btnStop);
            this.Controls.Add(this.btnPlay);
            this.Controls.Add(this.btnFileOpen);
            this.Controls.Add(this.PlayBar);
            this.Controls.Add(this.lvMp3List);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "MP3 플레이어";
            ((System.ComponentModel.ISupportInitialize)(this.BalanceBar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.VolumeBar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PlayBar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        internal System.Windows.Forms.Timer Timer;
        internal System.Windows.Forms.OpenFileDialog ofdMp3File;
        private System.Windows.Forms.Label lblVolume;
        private System.Windows.Forms.Label lblBalance;
        internal System.Windows.Forms.TrackBar BalanceBar;
        internal System.Windows.Forms.TrackBar VolumeBar;
        private System.Windows.Forms.Label lblPlayResult;
        private System.Windows.Forms.Button btnPause;
        private System.Windows.Forms.Label lblCurPos;
        private System.Windows.Forms.Button btnStop;
        private System.Windows.Forms.Button btnPlay;
        private System.Windows.Forms.Button btnFileOpen;
        private System.Windows.Forms.TrackBar PlayBar;
        private System.Windows.Forms.ListView lvMp3List;
        private System.Windows.Forms.ColumnHeader chNum;
        private System.Windows.Forms.ColumnHeader chTitle;
        private System.Windows.Forms.ColumnHeader chTime;
    }
}

