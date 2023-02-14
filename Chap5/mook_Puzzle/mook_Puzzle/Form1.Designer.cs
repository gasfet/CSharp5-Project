namespace mook_Puzzle
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
            this.btnReStart = new System.Windows.Forms.Button();
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.ofdIamgeopen = new System.Windows.Forms.OpenFileDialog();
            this.btnStart = new System.Windows.Forms.Button();
            this.gbView = new System.Windows.Forms.GroupBox();
            this.lblTime = new System.Windows.Forms.Label();
            this.lblAction = new System.Windows.Forms.Label();
            this.txtTime = new System.Windows.Forms.TextBox();
            this.txtAction = new System.Windows.Forms.TextBox();
            this.pictureBox = new System.Windows.Forms.PictureBox();
            this.tsTools = new System.Windows.Forms.ToolStrip();
            this.tsbtnOpen = new System.Windows.Forms.ToolStripButton();
            this.tsbtnBeginner = new System.Windows.Forms.ToolStripButton();
            this.tsbtnIntermediate = new System.Windows.Forms.ToolStripButton();
            this.tsbtnExpert = new System.Windows.Forms.ToolStripButton();
            this.msMenu = new System.Windows.Forms.MenuStrip();
            this.파일FToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.새게임NToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.열기OToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.끝내기XToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.옵션OToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.초급ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.중급ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.고급ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gbView.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).BeginInit();
            this.tsTools.SuspendLayout();
            this.msMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnReStart
            // 
            this.btnReStart.Enabled = false;
            this.btnReStart.Location = new System.Drawing.Point(600, 360);
            this.btnReStart.Name = "btnReStart";
            this.btnReStart.Size = new System.Drawing.Size(72, 23);
            this.btnReStart.TabIndex = 3;
            this.btnReStart.Text = "다시 시작";
            this.btnReStart.Click += new System.EventHandler(this.btnReStart_Click);
            // 
            // timer
            // 
            this.timer.Interval = 1000;
            this.timer.Tick += new System.EventHandler(this.timer_Tick);
            // 
            // ofdIamgeopen
            // 
            this.ofdIamgeopen.Filter = "JPEG Images(*.jpg,*.jpeg)|*.jpg;*.jpeg|GIF Image(*.gif)|*.gif|Bitmap(*.bmp)|*.bmp" +
    "|All Image Format|*.jpg;*.jpeg;*.gif*.bmp";
            // 
            // btnStart
            // 
            this.btnStart.Enabled = false;
            this.btnStart.Location = new System.Drawing.Point(448, 360);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(75, 23);
            this.btnStart.TabIndex = 2;
            this.btnStart.Text = "게임 시작";
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // gbView
            // 
            this.gbView.Controls.Add(this.lblTime);
            this.gbView.Controls.Add(this.lblAction);
            this.gbView.Controls.Add(this.txtTime);
            this.gbView.Controls.Add(this.txtAction);
            this.gbView.Controls.Add(this.pictureBox);
            this.gbView.Location = new System.Drawing.Point(448, 65);
            this.gbView.Name = "gbView";
            this.gbView.Size = new System.Drawing.Size(230, 280);
            this.gbView.TabIndex = 5;
            this.gbView.TabStop = false;
            this.gbView.Text = "정보";
            // 
            // lblTime
            // 
            this.lblTime.Location = new System.Drawing.Point(16, 240);
            this.lblTime.Name = "lblTime";
            this.lblTime.Size = new System.Drawing.Size(80, 23);
            this.lblTime.TabIndex = 4;
            this.lblTime.Text = "남은시간";
            this.lblTime.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblAction
            // 
            this.lblAction.Location = new System.Drawing.Point(16, 208);
            this.lblAction.Name = "lblAction";
            this.lblAction.Size = new System.Drawing.Size(80, 23);
            this.lblAction.TabIndex = 3;
            this.lblAction.Text = "이동수";
            this.lblAction.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtTime
            // 
            this.txtTime.Enabled = false;
            this.txtTime.Location = new System.Drawing.Point(104, 240);
            this.txtTime.Name = "txtTime";
            this.txtTime.Size = new System.Drawing.Size(100, 21);
            this.txtTime.TabIndex = 2;
            // 
            // txtAction
            // 
            this.txtAction.Enabled = false;
            this.txtAction.Location = new System.Drawing.Point(104, 208);
            this.txtAction.Name = "txtAction";
            this.txtAction.Size = new System.Drawing.Size(100, 21);
            this.txtAction.TabIndex = 2;
            // 
            // pictureBox
            // 
            this.pictureBox.Location = new System.Drawing.Point(24, 32);
            this.pictureBox.Name = "pictureBox";
            this.pictureBox.Size = new System.Drawing.Size(176, 168);
            this.pictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox.TabIndex = 0;
            this.pictureBox.TabStop = false;
            // 
            // tsTools
            // 
            this.tsTools.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsbtnOpen,
            this.tsbtnBeginner,
            this.tsbtnIntermediate,
            this.tsbtnExpert});
            this.tsTools.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.Flow;
            this.tsTools.Location = new System.Drawing.Point(0, 24);
            this.tsTools.Name = "tsTools";
            this.tsTools.Size = new System.Drawing.Size(684, 23);
            this.tsTools.TabIndex = 8;
            this.tsTools.Text = "toolStrip1";
            // 
            // tsbtnOpen
            // 
            this.tsbtnOpen.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbtnOpen.Image = global::mook_Puzzle.Properties.Resources.open;
            this.tsbtnOpen.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbtnOpen.Name = "tsbtnOpen";
            this.tsbtnOpen.Size = new System.Drawing.Size(23, 20);
            this.tsbtnOpen.Text = "열기";
            this.tsbtnOpen.ToolTipText = "열기";
            this.tsbtnOpen.Click += new System.EventHandler(this.tsbtnOpen_Click);
            // 
            // tsbtnBeginner
            // 
            this.tsbtnBeginner.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbtnBeginner.Enabled = false;
            this.tsbtnBeginner.Image = global::mook_Puzzle.Properties.Resources._1;
            this.tsbtnBeginner.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbtnBeginner.Name = "tsbtnBeginner";
            this.tsbtnBeginner.Size = new System.Drawing.Size(23, 20);
            this.tsbtnBeginner.Text = "초급";
            this.tsbtnBeginner.ToolTipText = "초급";
            this.tsbtnBeginner.Click += new System.EventHandler(this.tsbtnBeginner_Click);
            // 
            // tsbtnIntermediate
            // 
            this.tsbtnIntermediate.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbtnIntermediate.Enabled = false;
            this.tsbtnIntermediate.Image = global::mook_Puzzle.Properties.Resources._2;
            this.tsbtnIntermediate.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbtnIntermediate.Name = "tsbtnIntermediate";
            this.tsbtnIntermediate.Size = new System.Drawing.Size(23, 20);
            this.tsbtnIntermediate.Text = "중급";
            this.tsbtnIntermediate.ToolTipText = "중급";
            this.tsbtnIntermediate.Click += new System.EventHandler(this.tsbtnIntermediate_Click);
            // 
            // tsbtnExpert
            // 
            this.tsbtnExpert.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbtnExpert.Enabled = false;
            this.tsbtnExpert.Image = global::mook_Puzzle.Properties.Resources._3;
            this.tsbtnExpert.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbtnExpert.Name = "tsbtnExpert";
            this.tsbtnExpert.Size = new System.Drawing.Size(23, 20);
            this.tsbtnExpert.Text = "고급";
            this.tsbtnExpert.ToolTipText = "고급";
            this.tsbtnExpert.Click += new System.EventHandler(this.tsbtnExpert_Click);
            // 
            // msMenu
            // 
            this.msMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.파일FToolStripMenuItem1,
            this.옵션OToolStripMenuItem1});
            this.msMenu.Location = new System.Drawing.Point(0, 0);
            this.msMenu.Name = "msMenu";
            this.msMenu.Size = new System.Drawing.Size(684, 24);
            this.msMenu.TabIndex = 9;
            this.msMenu.Text = "menuStrip1";
            // 
            // 파일FToolStripMenuItem1
            // 
            this.파일FToolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.새게임NToolStripMenuItem,
            this.열기OToolStripMenuItem,
            this.toolStripSeparator1,
            this.끝내기XToolStripMenuItem});
            this.파일FToolStripMenuItem1.Name = "파일FToolStripMenuItem1";
            this.파일FToolStripMenuItem1.Size = new System.Drawing.Size(57, 20);
            this.파일FToolStripMenuItem1.Text = "파일(&F)";
            // 
            // 새게임NToolStripMenuItem
            // 
            this.새게임NToolStripMenuItem.Enabled = false;
            this.새게임NToolStripMenuItem.Name = "새게임NToolStripMenuItem";
            this.새게임NToolStripMenuItem.Size = new System.Drawing.Size(127, 22);
            this.새게임NToolStripMenuItem.Text = "새게임(&N)";
            this.새게임NToolStripMenuItem.Click += new System.EventHandler(this.새게임NToolStripMenuItem_Click);
            // 
            // 열기OToolStripMenuItem
            // 
            this.열기OToolStripMenuItem.Name = "열기OToolStripMenuItem";
            this.열기OToolStripMenuItem.Size = new System.Drawing.Size(127, 22);
            this.열기OToolStripMenuItem.Text = "열기(&O)";
            this.열기OToolStripMenuItem.Click += new System.EventHandler(this.tsbtnOpen_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(124, 6);
            // 
            // 끝내기XToolStripMenuItem
            // 
            this.끝내기XToolStripMenuItem.Name = "끝내기XToolStripMenuItem";
            this.끝내기XToolStripMenuItem.Size = new System.Drawing.Size(127, 22);
            this.끝내기XToolStripMenuItem.Text = "끝내기(&X)";
            this.끝내기XToolStripMenuItem.Click += new System.EventHandler(this.끝내기XToolStripMenuItem_Click);
            // 
            // 옵션OToolStripMenuItem1
            // 
            this.옵션OToolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.초급ToolStripMenuItem,
            this.중급ToolStripMenuItem,
            this.고급ToolStripMenuItem});
            this.옵션OToolStripMenuItem1.Name = "옵션OToolStripMenuItem1";
            this.옵션OToolStripMenuItem1.Size = new System.Drawing.Size(60, 20);
            this.옵션OToolStripMenuItem1.Text = "옵션(&O)";
            // 
            // 초급ToolStripMenuItem
            // 
            this.초급ToolStripMenuItem.Enabled = false;
            this.초급ToolStripMenuItem.Name = "초급ToolStripMenuItem";
            this.초급ToolStripMenuItem.Size = new System.Drawing.Size(98, 22);
            this.초급ToolStripMenuItem.Text = "초급";
            this.초급ToolStripMenuItem.Click += new System.EventHandler(this.tsbtnBeginner_Click);
            // 
            // 중급ToolStripMenuItem
            // 
            this.중급ToolStripMenuItem.Enabled = false;
            this.중급ToolStripMenuItem.Name = "중급ToolStripMenuItem";
            this.중급ToolStripMenuItem.Size = new System.Drawing.Size(98, 22);
            this.중급ToolStripMenuItem.Text = "중급";
            this.중급ToolStripMenuItem.Click += new System.EventHandler(this.tsbtnIntermediate_Click);
            // 
            // 고급ToolStripMenuItem
            // 
            this.고급ToolStripMenuItem.Enabled = false;
            this.고급ToolStripMenuItem.Name = "고급ToolStripMenuItem";
            this.고급ToolStripMenuItem.Size = new System.Drawing.Size(98, 22);
            this.고급ToolStripMenuItem.Text = "고급";
            this.고급ToolStripMenuItem.Click += new System.EventHandler(this.tsbtnExpert_Click);
            // 
            // Form1
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Inherit;
            this.ClientSize = new System.Drawing.Size(684, 452);
            this.Controls.Add(this.tsTools);
            this.Controls.Add(this.gbView);
            this.Controls.Add(this.btnReStart);
            this.Controls.Add(this.btnStart);
            this.Controls.Add(this.msMenu);
            this.MainMenuStrip = this.msMenu;
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(700, 490);
            this.MinimumSize = new System.Drawing.Size(700, 490);
            this.Name = "Form1";
            this.Text = "퍼즐 게임";
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.Form1_Paint);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseDown);
            this.gbView.ResumeLayout(false);
            this.gbView.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).EndInit();
            this.tsTools.ResumeLayout(false);
            this.tsTools.PerformLayout();
            this.msMenu.ResumeLayout(false);
            this.msMenu.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblAction;
        private System.Windows.Forms.TextBox txtTime;
        private System.Windows.Forms.Label lblTime;
        private System.Windows.Forms.TextBox txtAction;
        private System.Windows.Forms.PictureBox pictureBox;
        private System.Windows.Forms.GroupBox gbView;
        private System.Windows.Forms.Button btnReStart;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.OpenFileDialog ofdIamgeopen;
        private System.Windows.Forms.Timer timer;
        private System.Windows.Forms.ToolStrip tsTools;
        private System.Windows.Forms.ToolStripButton tsbtnOpen;
        private System.Windows.Forms.ToolStripButton tsbtnBeginner;
        private System.Windows.Forms.ToolStripButton tsbtnIntermediate;
        private System.Windows.Forms.ToolStripButton tsbtnExpert;
        private System.Windows.Forms.MenuStrip msMenu;
        private System.Windows.Forms.ToolStripMenuItem 파일FToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem 새게임NToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 열기OToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 끝내기XToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 옵션OToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem 초급ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 중급ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 고급ToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
    }
}


