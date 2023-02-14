namespace mook_NetCheck
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
            this.lblIp = new System.Windows.Forms.Label();
            this.lblRoundtripTime = new System.Windows.Forms.Label();
            this.lblTtl = new System.Windows.Forms.Label();
            this.lblState = new System.Windows.Forms.Label();
            this.lblBuffer = new System.Windows.Forms.Label();
            this.txtIP = new System.Windows.Forms.TextBox();
            this.btnCheck = new System.Windows.Forms.Button();
            this.lblBufferView = new System.Windows.Forms.Label();
            this.lblStateView = new System.Windows.Forms.Label();
            this.lblTtlView = new System.Windows.Forms.Label();
            this.lblRoundtripTimeView = new System.Windows.Forms.Label();
            this.lblTimeView = new System.Windows.Forms.Label();
            this.lblTime = new System.Windows.Forms.Label();
            this.cbTime = new System.Windows.Forms.ComboBox();
            this.lbResult = new System.Windows.Forms.ListBox();
            this.lblConnection = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Timer
            // 
            this.Timer.Interval = 2000;
            this.Timer.Tick += new System.EventHandler(this.Timer_Tick);
            // 
            // lblIp
            // 
            this.lblIp.AutoSize = true;
            this.lblIp.Location = new System.Drawing.Point(22, 15);
            this.lblIp.Name = "lblIp";
            this.lblIp.Size = new System.Drawing.Size(24, 12);
            this.lblIp.TabIndex = 0;
            this.lblIp.Text = "IP :";
            // 
            // lblRoundtripTime
            // 
            this.lblRoundtripTime.AutoSize = true;
            this.lblRoundtripTime.Location = new System.Drawing.Point(22, 73);
            this.lblRoundtripTime.Name = "lblRoundtripTime";
            this.lblRoundtripTime.Size = new System.Drawing.Size(37, 12);
            this.lblRoundtripTime.TabIndex = 1;
            this.lblRoundtripTime.Text = "지연 :";
            // 
            // lblTtl
            // 
            this.lblTtl.AutoSize = true;
            this.lblTtl.Location = new System.Drawing.Point(22, 92);
            this.lblTtl.Name = "lblTtl";
            this.lblTtl.Size = new System.Drawing.Size(36, 12);
            this.lblTtl.TabIndex = 2;
            this.lblTtl.Text = "TTL :";
            // 
            // lblState
            // 
            this.lblState.AutoSize = true;
            this.lblState.Location = new System.Drawing.Point(22, 111);
            this.lblState.Name = "lblState";
            this.lblState.Size = new System.Drawing.Size(37, 12);
            this.lblState.TabIndex = 3;
            this.lblState.Text = "상태 :";
            // 
            // lblBuffer
            // 
            this.lblBuffer.AutoSize = true;
            this.lblBuffer.Location = new System.Drawing.Point(22, 130);
            this.lblBuffer.Name = "lblBuffer";
            this.lblBuffer.Size = new System.Drawing.Size(37, 12);
            this.lblBuffer.TabIndex = 4;
            this.lblBuffer.Text = "패킷 :";
            // 
            // txtIP
            // 
            this.txtIP.Location = new System.Drawing.Point(56, 12);
            this.txtIP.Name = "txtIP";
            this.txtIP.Size = new System.Drawing.Size(162, 21);
            this.txtIP.TabIndex = 5;
            this.txtIP.TextChanged += new System.EventHandler(this.txtIP_TextChanged);
            // 
            // btnCheck
            // 
            this.btnCheck.Enabled = false;
            this.btnCheck.Location = new System.Drawing.Point(224, 12);
            this.btnCheck.Name = "btnCheck";
            this.btnCheck.Size = new System.Drawing.Size(47, 23);
            this.btnCheck.TabIndex = 6;
            this.btnCheck.Text = "체크";
            this.btnCheck.UseVisualStyleBackColor = true;
            this.btnCheck.Click += new System.EventHandler(this.btnCheck_Click);
            // 
            // lblBufferView
            // 
            this.lblBufferView.AutoSize = true;
            this.lblBufferView.Location = new System.Drawing.Point(78, 130);
            this.lblBufferView.Name = "lblBufferView";
            this.lblBufferView.Size = new System.Drawing.Size(0, 12);
            this.lblBufferView.TabIndex = 10;
            // 
            // lblStateView
            // 
            this.lblStateView.AutoSize = true;
            this.lblStateView.Location = new System.Drawing.Point(78, 111);
            this.lblStateView.Name = "lblStateView";
            this.lblStateView.Size = new System.Drawing.Size(0, 12);
            this.lblStateView.TabIndex = 9;
            // 
            // lblTtlView
            // 
            this.lblTtlView.AutoSize = true;
            this.lblTtlView.Location = new System.Drawing.Point(78, 92);
            this.lblTtlView.Name = "lblTtlView";
            this.lblTtlView.Size = new System.Drawing.Size(0, 12);
            this.lblTtlView.TabIndex = 8;
            // 
            // lblRoundtripTimeView
            // 
            this.lblRoundtripTimeView.AutoSize = true;
            this.lblRoundtripTimeView.Location = new System.Drawing.Point(78, 73);
            this.lblRoundtripTimeView.Name = "lblRoundtripTimeView";
            this.lblRoundtripTimeView.Size = new System.Drawing.Size(0, 12);
            this.lblRoundtripTimeView.TabIndex = 7;
            // 
            // lblTimeView
            // 
            this.lblTimeView.AutoSize = true;
            this.lblTimeView.Location = new System.Drawing.Point(77, 148);
            this.lblTimeView.Name = "lblTimeView";
            this.lblTimeView.Size = new System.Drawing.Size(0, 12);
            this.lblTimeView.TabIndex = 12;
            // 
            // lblTime
            // 
            this.lblTime.AutoSize = true;
            this.lblTime.Location = new System.Drawing.Point(21, 148);
            this.lblTime.Name = "lblTime";
            this.lblTime.Size = new System.Drawing.Size(37, 12);
            this.lblTime.TabIndex = 11;
            this.lblTime.Text = "시간 :";
            // 
            // cbTime
            // 
            this.cbTime.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbTime.FormattingEnabled = true;
            this.cbTime.Items.AddRange(new object[] {
            "1초",
            "2초",
            "3초",
            "4초",
            "5초"});
            this.cbTime.Location = new System.Drawing.Point(56, 39);
            this.cbTime.Name = "cbTime";
            this.cbTime.Size = new System.Drawing.Size(162, 20);
            this.cbTime.TabIndex = 13;
            this.cbTime.SelectedIndexChanged += new System.EventHandler(this.cbTime_SelectedIndexChanged);
            // 
            // lbResult
            // 
            this.lbResult.FormattingEnabled = true;
            this.lbResult.ItemHeight = 12;
            this.lbResult.Location = new System.Drawing.Point(12, 173);
            this.lbResult.Name = "lbResult";
            this.lbResult.ScrollAlwaysVisible = true;
            this.lbResult.Size = new System.Drawing.Size(448, 136);
            this.lbResult.TabIndex = 14;
            // 
            // lblConnection
            // 
            this.lblConnection.AutoSize = true;
            this.lblConnection.BackColor = System.Drawing.Color.LightSkyBlue;
            this.lblConnection.Font = new System.Drawing.Font("굴림", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lblConnection.ForeColor = System.Drawing.Color.DarkSlateBlue;
            this.lblConnection.Location = new System.Drawing.Point(307, 139);
            this.lblConnection.Name = "lblConnection";
            this.lblConnection.Size = new System.Drawing.Size(129, 21);
            this.lblConnection.TabIndex = 15;
            this.lblConnection.Text = "Net Connect";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(472, 323);
            this.Controls.Add(this.lblConnection);
            this.Controls.Add(this.lbResult);
            this.Controls.Add(this.cbTime);
            this.Controls.Add(this.lblTimeView);
            this.Controls.Add(this.lblTime);
            this.Controls.Add(this.lblBufferView);
            this.Controls.Add(this.lblStateView);
            this.Controls.Add(this.lblTtlView);
            this.Controls.Add(this.lblRoundtripTimeView);
            this.Controls.Add(this.btnCheck);
            this.Controls.Add(this.txtIP);
            this.Controls.Add(this.lblBuffer);
            this.Controls.Add(this.lblState);
            this.Controls.Add(this.lblTtl);
            this.Controls.Add(this.lblRoundtripTime);
            this.Controls.Add(this.lblIp);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(480, 350);
            this.MinimumSize = new System.Drawing.Size(480, 350);
            this.Name = "Form1";
            this.Text = "Net Check";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblIp;
        private System.Windows.Forms.Label lblRoundtripTime;
        private System.Windows.Forms.Label lblTtl;
        private System.Windows.Forms.Label lblState;
        private System.Windows.Forms.Label lblBuffer;
        private System.Windows.Forms.Button btnCheck;
        private System.Windows.Forms.Label lblBufferView;
        private System.Windows.Forms.Label lblStateView;
        private System.Windows.Forms.Label lblTtlView;
        private System.Windows.Forms.Label lblRoundtripTimeView;
        private System.Windows.Forms.Label lblTimeView;
        private System.Windows.Forms.Label lblTime;
        private System.Windows.Forms.ComboBox cbTime;
        private System.Windows.Forms.ListBox lbResult;
        private System.Windows.Forms.Label lblConnection;
        public System.Windows.Forms.TextBox txtIP;
        private System.Windows.Forms.Timer Timer;
    }
}


