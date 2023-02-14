namespace mook_WinAPITest
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
            this.gpbCDR = new System.Windows.Forms.GroupBox();
            this.btnStatus = new System.Windows.Forms.Button();
            this.lblStatus = new System.Windows.Forms.Label();
            this.gpbFlash = new System.Windows.Forms.GroupBox();
            this.hsbFlash = new System.Windows.Forms.HScrollBar();
            this.btnFlash = new System.Windows.Forms.Button();
            this.gpbBeep = new System.Windows.Forms.GroupBox();
            this.tkbSound = new System.Windows.Forms.TrackBar();
            this.lblLength = new System.Windows.Forms.Label();
            this.tkbLength = new System.Windows.Forms.TrackBar();
            this.lblSound = new System.Windows.Forms.Label();
            this.btnBeep = new System.Windows.Forms.Button();
            this.gpbCDR.SuspendLayout();
            this.gpbFlash.SuspendLayout();
            this.gpbBeep.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tkbSound)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tkbLength)).BeginInit();
            this.SuspendLayout();
            // 
            // Timer
            // 
            this.Timer.Tick += new System.EventHandler(this.Timer_Tick);
            // 
            // gpbCDR
            // 
            this.gpbCDR.Controls.Add(this.btnStatus);
            this.gpbCDR.Controls.Add(this.lblStatus);
            this.gpbCDR.Location = new System.Drawing.Point(215, 131);
            this.gpbCDR.Name = "gpbCDR";
            this.gpbCDR.Size = new System.Drawing.Size(144, 119);
            this.gpbCDR.TabIndex = 10;
            this.gpbCDR.TabStop = false;
            this.gpbCDR.Text = "CDRom";
            // 
            // btnStatus
            // 
            this.btnStatus.Location = new System.Drawing.Point(28, 74);
            this.btnStatus.Name = "btnStatus";
            this.btnStatus.Size = new System.Drawing.Size(95, 23);
            this.btnStatus.TabIndex = 1;
            this.btnStatus.Text = "CDR Close";
            this.btnStatus.UseVisualStyleBackColor = true;
            this.btnStatus.Click += new System.EventHandler(this.btnStatus_Click);
            // 
            // lblStatus
            // 
            this.lblStatus.AutoSize = true;
            this.lblStatus.Location = new System.Drawing.Point(56, 37);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(40, 12);
            this.lblStatus.TabIndex = 0;
            this.lblStatus.Text = "Status";
            // 
            // gpbFlash
            // 
            this.gpbFlash.Controls.Add(this.hsbFlash);
            this.gpbFlash.Controls.Add(this.btnFlash);
            this.gpbFlash.Location = new System.Drawing.Point(15, 131);
            this.gpbFlash.Name = "gpbFlash";
            this.gpbFlash.Size = new System.Drawing.Size(194, 119);
            this.gpbFlash.TabIndex = 9;
            this.gpbFlash.TabStop = false;
            this.gpbFlash.Text = "Win Flash";
            // 
            // hsbFlash
            // 
            this.hsbFlash.Location = new System.Drawing.Point(21, 37);
            this.hsbFlash.Maximum = 10000;
            this.hsbFlash.Minimum = 500;
            this.hsbFlash.Name = "hsbFlash";
            this.hsbFlash.Size = new System.Drawing.Size(155, 15);
            this.hsbFlash.TabIndex = 1;
            this.hsbFlash.Value = 500;
            // 
            // btnFlash
            // 
            this.btnFlash.Location = new System.Drawing.Point(47, 74);
            this.btnFlash.Name = "btnFlash";
            this.btnFlash.Size = new System.Drawing.Size(106, 23);
            this.btnFlash.TabIndex = 0;
            this.btnFlash.Text = "Flash OFF";
            this.btnFlash.UseVisualStyleBackColor = true;
            this.btnFlash.Click += new System.EventHandler(this.btnFlash_Click);
            // 
            // gpbBeep
            // 
            this.gpbBeep.Controls.Add(this.tkbSound);
            this.gpbBeep.Controls.Add(this.lblLength);
            this.gpbBeep.Controls.Add(this.tkbLength);
            this.gpbBeep.Controls.Add(this.lblSound);
            this.gpbBeep.Controls.Add(this.btnBeep);
            this.gpbBeep.Location = new System.Drawing.Point(15, 12);
            this.gpbBeep.Name = "gpbBeep";
            this.gpbBeep.Size = new System.Drawing.Size(344, 113);
            this.gpbBeep.TabIndex = 8;
            this.gpbBeep.TabStop = false;
            this.gpbBeep.Text = "Beep Sound";
            // 
            // tkbSound
            // 
            this.tkbSound.Location = new System.Drawing.Point(66, 20);
            this.tkbSound.Maximum = 5000;
            this.tkbSound.Minimum = 1;
            this.tkbSound.Name = "tkbSound";
            this.tkbSound.Size = new System.Drawing.Size(186, 45);
            this.tkbSound.TabIndex = 0;
            this.tkbSound.Value = 1;
            // 
            // lblLength
            // 
            this.lblLength.AutoSize = true;
            this.lblLength.Location = new System.Drawing.Point(17, 72);
            this.lblLength.Name = "lblLength";
            this.lblLength.Size = new System.Drawing.Size(43, 12);
            this.lblLength.TabIndex = 4;
            this.lblLength.Text = "Length";
            // 
            // tkbLength
            // 
            this.tkbLength.Location = new System.Drawing.Point(66, 63);
            this.tkbLength.Maximum = 5000;
            this.tkbLength.Minimum = 1;
            this.tkbLength.Name = "tkbLength";
            this.tkbLength.Size = new System.Drawing.Size(186, 45);
            this.tkbLength.TabIndex = 1;
            this.tkbLength.Value = 1;
            // 
            // lblSound
            // 
            this.lblSound.AutoSize = true;
            this.lblSound.Location = new System.Drawing.Point(19, 31);
            this.lblSound.Name = "lblSound";
            this.lblSound.Size = new System.Drawing.Size(41, 12);
            this.lblSound.TabIndex = 3;
            this.lblSound.Text = "Sound";
            // 
            // btnBeep
            // 
            this.btnBeep.Location = new System.Drawing.Point(258, 65);
            this.btnBeep.Name = "btnBeep";
            this.btnBeep.Size = new System.Drawing.Size(75, 23);
            this.btnBeep.TabIndex = 2;
            this.btnBeep.Text = "BEEP";
            this.btnBeep.UseVisualStyleBackColor = true;
            this.btnBeep.Click += new System.EventHandler(this.btnBeep_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(374, 262);
            this.Controls.Add(this.gpbCDR);
            this.Controls.Add(this.gpbFlash);
            this.Controls.Add(this.gpbBeep);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.Text = "WinAPI";
            this.gpbCDR.ResumeLayout(false);
            this.gpbCDR.PerformLayout();
            this.gpbFlash.ResumeLayout(false);
            this.gpbBeep.ResumeLayout(false);
            this.gpbBeep.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tkbSound)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tkbLength)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        internal System.Windows.Forms.Timer Timer;
        internal System.Windows.Forms.GroupBox gpbCDR;
        internal System.Windows.Forms.Button btnStatus;
        internal System.Windows.Forms.Label lblStatus;
        internal System.Windows.Forms.GroupBox gpbFlash;
        internal System.Windows.Forms.HScrollBar hsbFlash;
        internal System.Windows.Forms.Button btnFlash;
        internal System.Windows.Forms.GroupBox gpbBeep;
        internal System.Windows.Forms.TrackBar tkbSound;
        internal System.Windows.Forms.Label lblLength;
        internal System.Windows.Forms.TrackBar tkbLength;
        internal System.Windows.Forms.Label lblSound;
        internal System.Windows.Forms.Button btnBeep;
    }
}

