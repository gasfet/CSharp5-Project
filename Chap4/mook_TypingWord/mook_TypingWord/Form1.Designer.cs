namespace mook_TypingWord
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
            this.lblLife = new System.Windows.Forms.Label();
            this.txtInsert = new System.Windows.Forms.TextBox();
            this.btnStop = new System.Windows.Forms.Button();
            this.btnStart = new System.Windows.Forms.Button();
            this.pl02 = new System.Windows.Forms.Panel();
            this.lbljumsu = new System.Windows.Forms.Label();
            this.lbljum02 = new System.Windows.Forms.Label();
            this.txtMaxJumsu = new System.Windows.Forms.TextBox();
            this.lbljum01 = new System.Windows.Forms.Label();
            this.txtJumsu = new System.Windows.Forms.TextBox();
            this.lblGrade = new System.Windows.Forms.Label();
            this.pl01 = new System.Windows.Forms.Panel();
            this.lblImg = new System.Windows.Forms.Label();
            this.ImageList = new System.Windows.Forms.ImageList(this.components);
            this.lblName = new System.Windows.Forms.Label();
            this.plMain = new System.Windows.Forms.Panel();
            this.button5 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.mainMenu = new System.Windows.Forms.MenuStrip();
            this.설정ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.환경설정ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.사용자설정ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.종료ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btn5tim = new System.Windows.Forms.Timer(this.components);
            this.btn4tim = new System.Windows.Forms.Timer(this.components);
            this.btn3tim = new System.Windows.Forms.Timer(this.components);
            this.btn2tim = new System.Windows.Forms.Timer(this.components);
            this.btn1tim = new System.Windows.Forms.Timer(this.components);
            this.randomtim = new System.Windows.Forms.Timer(this.components);
            this.pl02.SuspendLayout();
            this.pl01.SuspendLayout();
            this.plMain.SuspendLayout();
            this.mainMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblLife
            // 
            this.lblLife.BackColor = System.Drawing.Color.Red;
            this.lblLife.Location = new System.Drawing.Point(455, 481);
            this.lblLife.Name = "lblLife";
            this.lblLife.Size = new System.Drawing.Size(150, 10);
            this.lblLife.TabIndex = 14;
            this.lblLife.SizeChanged += new System.EventHandler(this.lblLife_SizeChanged);
            // 
            // txtInsert
            // 
            this.txtInsert.Location = new System.Drawing.Point(197, 475);
            this.txtInsert.Name = "txtInsert";
            this.txtInsert.Size = new System.Drawing.Size(237, 21);
            this.txtInsert.TabIndex = 7;
            this.txtInsert.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtInsert.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtInsert_KeyDown);
            // 
            // btnStop
            // 
            this.btnStop.Enabled = false;
            this.btnStop.ForeColor = System.Drawing.Color.Black;
            this.btnStop.Location = new System.Drawing.Point(100, 473);
            this.btnStop.Name = "btnStop";
            this.btnStop.Size = new System.Drawing.Size(75, 23);
            this.btnStop.TabIndex = 13;
            this.btnStop.Text = "정 지";
            this.btnStop.UseVisualStyleBackColor = true;
            this.btnStop.Click += new System.EventHandler(this.btnStop_Click);
            // 
            // btnStart
            // 
            this.btnStart.Enabled = false;
            this.btnStart.ForeColor = System.Drawing.Color.Black;
            this.btnStart.Location = new System.Drawing.Point(4, 473);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(75, 23);
            this.btnStart.TabIndex = 12;
            this.btnStart.Text = "시 작";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // pl02
            // 
            this.pl02.BackColor = System.Drawing.Color.White;
            this.pl02.Controls.Add(this.lbljumsu);
            this.pl02.Controls.Add(this.lbljum02);
            this.pl02.Controls.Add(this.txtMaxJumsu);
            this.pl02.Controls.Add(this.lbljum01);
            this.pl02.Controls.Add(this.txtJumsu);
            this.pl02.Controls.Add(this.lblGrade);
            this.pl02.Location = new System.Drawing.Point(530, 249);
            this.pl02.Name = "pl02";
            this.pl02.Size = new System.Drawing.Size(155, 197);
            this.pl02.TabIndex = 11;
            // 
            // lbljumsu
            // 
            this.lbljumsu.AutoSize = true;
            this.lbljumsu.Location = new System.Drawing.Point(39, 97);
            this.lbljumsu.Name = "lbljumsu";
            this.lbljumsu.Size = new System.Drawing.Size(57, 12);
            this.lbljumsu.TabIndex = 5;
            this.lbljumsu.Text = "최고 점수";
            // 
            // lbljum02
            // 
            this.lbljum02.AutoSize = true;
            this.lbljum02.Location = new System.Drawing.Point(111, 138);
            this.lbljum02.Name = "lbljum02";
            this.lbljum02.Size = new System.Drawing.Size(17, 12);
            this.lbljum02.TabIndex = 4;
            this.lbljum02.Text = "점";
            // 
            // txtMaxJumsu
            // 
            this.txtMaxJumsu.Location = new System.Drawing.Point(25, 135);
            this.txtMaxJumsu.Name = "txtMaxJumsu";
            this.txtMaxJumsu.Size = new System.Drawing.Size(81, 21);
            this.txtMaxJumsu.TabIndex = 3;
            this.txtMaxJumsu.TabStop = false;
            this.txtMaxJumsu.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // lbljum01
            // 
            this.lbljum01.AutoSize = true;
            this.lbljum01.Location = new System.Drawing.Point(111, 56);
            this.lbljum01.Name = "lbljum01";
            this.lbljum01.Size = new System.Drawing.Size(17, 12);
            this.lbljum01.TabIndex = 2;
            this.lbljum01.Text = "점";
            // 
            // txtJumsu
            // 
            this.txtJumsu.Location = new System.Drawing.Point(25, 53);
            this.txtJumsu.Name = "txtJumsu";
            this.txtJumsu.Size = new System.Drawing.Size(81, 21);
            this.txtJumsu.TabIndex = 1;
            this.txtJumsu.TabStop = false;
            this.txtJumsu.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtJumsu.TextChanged += new System.EventHandler(this.txtJumsu_TextChanged);
            // 
            // lblGrade
            // 
            this.lblGrade.AutoSize = true;
            this.lblGrade.Location = new System.Drawing.Point(64, 20);
            this.lblGrade.Name = "lblGrade";
            this.lblGrade.Size = new System.Drawing.Size(11, 12);
            this.lblGrade.TabIndex = 0;
            this.lblGrade.Text = "1";
            this.lblGrade.TextChanged += new System.EventHandler(this.lblGrade_TextChanged);
            // 
            // pl01
            // 
            this.pl01.BackColor = System.Drawing.Color.White;
            this.pl01.Controls.Add(this.lblImg);
            this.pl01.Controls.Add(this.lblName);
            this.pl01.Location = new System.Drawing.Point(530, 38);
            this.pl01.Name = "pl01";
            this.pl01.Size = new System.Drawing.Size(155, 205);
            this.pl01.TabIndex = 10;
            // 
            // lblImg
            // 
            this.lblImg.BackColor = System.Drawing.Color.Tomato;
            this.lblImg.ImageList = this.ImageList;
            this.lblImg.Location = new System.Drawing.Point(23, 60);
            this.lblImg.Name = "lblImg";
            this.lblImg.Size = new System.Drawing.Size(100, 100);
            this.lblImg.TabIndex = 1;
            this.lblImg.Text = "이미지 출력";
            this.lblImg.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ImageList
            // 
            this.ImageList.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("ImageList.ImageStream")));
            this.ImageList.TransparentColor = System.Drawing.Color.Transparent;
            this.ImageList.Images.SetKeyName(0, "남자.jpg");
            this.ImageList.Images.SetKeyName(1, "여자.jpg");
            // 
            // lblName
            // 
            this.lblName.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(37, 35);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(69, 12);
            this.lblName.TabIndex = 0;
            this.lblName.Text = "사용자 이름";
            // 
            // plMain
            // 
            this.plMain.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.plMain.Controls.Add(this.button5);
            this.plMain.Controls.Add(this.button4);
            this.plMain.Controls.Add(this.button3);
            this.plMain.Controls.Add(this.button2);
            this.plMain.Controls.Add(this.button1);
            this.plMain.Location = new System.Drawing.Point(4, 38);
            this.plMain.Name = "plMain";
            this.plMain.Size = new System.Drawing.Size(520, 408);
            this.plMain.TabIndex = 9;
            // 
            // button5
            // 
            this.button5.Enabled = false;
            this.button5.Location = new System.Drawing.Point(413, 0);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(75, 23);
            this.button5.TabIndex = 4;
            this.button5.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            this.button4.Enabled = false;
            this.button4.Location = new System.Drawing.Point(316, 0);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(75, 23);
            this.button4.TabIndex = 3;
            this.button4.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Enabled = false;
            this.button3.Location = new System.Drawing.Point(218, 0);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 2;
            this.button3.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Enabled = false;
            this.button2.Location = new System.Drawing.Point(122, 0);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 1;
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Enabled = false;
            this.button1.Location = new System.Drawing.Point(24, 0);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 0;
            this.button1.UseVisualStyleBackColor = true;
            // 
            // mainMenu
            // 
            this.mainMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.설정ToolStripMenuItem});
            this.mainMenu.Location = new System.Drawing.Point(0, 0);
            this.mainMenu.Name = "mainMenu";
            this.mainMenu.Size = new System.Drawing.Size(694, 24);
            this.mainMenu.TabIndex = 8;
            // 
            // 설정ToolStripMenuItem
            // 
            this.설정ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.환경설정ToolStripMenuItem,
            this.사용자설정ToolStripMenuItem,
            this.toolStripSeparator,
            this.종료ToolStripMenuItem});
            this.설정ToolStripMenuItem.Name = "설정ToolStripMenuItem";
            this.설정ToolStripMenuItem.Size = new System.Drawing.Size(47, 20);
            this.설정ToolStripMenuItem.Text = "설 정";
            // 
            // 환경설정ToolStripMenuItem
            // 
            this.환경설정ToolStripMenuItem.Name = "환경설정ToolStripMenuItem";
            this.환경설정ToolStripMenuItem.Size = new System.Drawing.Size(138, 22);
            this.환경설정ToolStripMenuItem.Text = "환 경  설 정";
            this.환경설정ToolStripMenuItem.Click += new System.EventHandler(this.환경설정ToolStripMenuItem_Click);
            // 
            // 사용자설정ToolStripMenuItem
            // 
            this.사용자설정ToolStripMenuItem.Name = "사용자설정ToolStripMenuItem";
            this.사용자설정ToolStripMenuItem.Size = new System.Drawing.Size(138, 22);
            this.사용자설정ToolStripMenuItem.Text = "사용자 설정";
            this.사용자설정ToolStripMenuItem.Click += new System.EventHandler(this.사용자설정ToolStripMenuItem_Click);
            // 
            // toolStripSeparator
            // 
            this.toolStripSeparator.Name = "toolStripSeparator";
            this.toolStripSeparator.Size = new System.Drawing.Size(135, 6);
            // 
            // 종료ToolStripMenuItem
            // 
            this.종료ToolStripMenuItem.Name = "종료ToolStripMenuItem";
            this.종료ToolStripMenuItem.Size = new System.Drawing.Size(138, 22);
            this.종료ToolStripMenuItem.Text = " 종         료";
            this.종료ToolStripMenuItem.Click += new System.EventHandler(this.종료ToolStripMenuItem_Click);
            // 
            // btn5tim
            // 
            this.btn5tim.Interval = 1000;
            this.btn5tim.Tick += new System.EventHandler(this.btn5tim_Tick);
            // 
            // btn4tim
            // 
            this.btn4tim.Interval = 1000;
            this.btn4tim.Tick += new System.EventHandler(this.btn4tim_Tick);
            // 
            // btn3tim
            // 
            this.btn3tim.Interval = 1000;
            this.btn3tim.Tick += new System.EventHandler(this.btn3tim_Tick);
            // 
            // btn2tim
            // 
            this.btn2tim.Interval = 1000;
            this.btn2tim.Tick += new System.EventHandler(this.btn2tim_Tick);
            // 
            // btn1tim
            // 
            this.btn1tim.Interval = 1000;
            this.btn1tim.Tick += new System.EventHandler(this.btn1tim_Tick);
            // 
            // randomtim
            // 
            this.randomtim.Tick += new System.EventHandler(this.randomtim_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDark;
            this.ClientSize = new System.Drawing.Size(694, 516);
            this.Controls.Add(this.lblLife);
            this.Controls.Add(this.txtInsert);
            this.Controls.Add(this.btnStop);
            this.Controls.Add(this.btnStart);
            this.Controls.Add(this.pl02);
            this.Controls.Add(this.pl01);
            this.Controls.Add(this.plMain);
            this.Controls.Add(this.mainMenu);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Form1";
            this.Text = "벽돌비";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.pl02.ResumeLayout(false);
            this.pl02.PerformLayout();
            this.pl01.ResumeLayout(false);
            this.pl01.PerformLayout();
            this.plMain.ResumeLayout(false);
            this.mainMenu.ResumeLayout(false);
            this.mainMenu.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblLife;
        private System.Windows.Forms.TextBox txtInsert;
        private System.Windows.Forms.Button btnStop;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.Panel pl02;
        private System.Windows.Forms.Label lbljumsu;
        private System.Windows.Forms.Label lbljum02;
        private System.Windows.Forms.TextBox txtMaxJumsu;
        private System.Windows.Forms.Label lbljum01;
        private System.Windows.Forms.TextBox txtJumsu;
        private System.Windows.Forms.Label lblGrade;
        private System.Windows.Forms.Panel pl01;
        private System.Windows.Forms.Label lblImg;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Panel plMain;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.MenuStrip mainMenu;
        private System.Windows.Forms.ToolStripMenuItem 설정ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 환경설정ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 사용자설정ToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator;
        private System.Windows.Forms.ToolStripMenuItem 종료ToolStripMenuItem;
        private System.Windows.Forms.ImageList ImageList;
        private System.Windows.Forms.Timer btn5tim;
        private System.Windows.Forms.Timer btn4tim;
        private System.Windows.Forms.Timer btn3tim;
        private System.Windows.Forms.Timer btn2tim;
        private System.Windows.Forms.Timer btn1tim;
        private System.Windows.Forms.Timer randomtim;
    }
}

