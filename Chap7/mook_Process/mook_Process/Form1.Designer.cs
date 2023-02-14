namespace mook_Process
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
            this.ssBar = new System.Windows.Forms.StatusStrip();
            this.tsslProcess = new System.Windows.Forms.ToolStripStatusLabel();
            this.tsslCpu = new System.Windows.Forms.ToolStripStatusLabel();
            this.tsslMem = new System.Windows.Forms.ToolStripStatusLabel();
            this.btnKill = new System.Windows.Forms.Button();
            this.lvView = new System.Windows.Forms.ListView();
            this.chName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chPid = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chCPU = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chMemor = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ssBar.SuspendLayout();
            this.SuspendLayout();
            // 
            // ssBar
            // 
            this.ssBar.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsslProcess,
            this.tsslCpu,
            this.tsslMem});
            this.ssBar.Location = new System.Drawing.Point(0, 312);
            this.ssBar.Name = "ssBar";
            this.ssBar.Size = new System.Drawing.Size(414, 22);
            this.ssBar.TabIndex = 7;
            this.ssBar.Text = "StatusStrip1";
            // 
            // tsslProcess
            // 
            this.tsslProcess.Name = "tsslProcess";
            this.tsslProcess.Size = new System.Drawing.Size(85, 17);
            this.tsslProcess.Text = "프로세스 : 0개";
            // 
            // tsslCpu
            // 
            this.tsslCpu.Name = "tsslCpu";
            this.tsslCpu.Size = new System.Drawing.Size(86, 17);
            this.tsslCpu.Text = "CPU 사용 : 0%";
            // 
            // tsslMem
            // 
            this.tsslMem.Name = "tsslMem";
            this.tsslMem.Size = new System.Drawing.Size(99, 17);
            this.tsslMem.Text = "실제 메모리 : 0%";
            // 
            // btnKill
            // 
            this.btnKill.Location = new System.Drawing.Point(283, 276);
            this.btnKill.Name = "btnKill";
            this.btnKill.Size = new System.Drawing.Size(119, 23);
            this.btnKill.TabIndex = 6;
            this.btnKill.Text = "프로세스 끝내기";
            this.btnKill.UseVisualStyleBackColor = true;
            this.btnKill.Click += new System.EventHandler(this.btnKill_Click);
            // 
            // lvView
            // 
            this.lvView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.chName,
            this.chPid,
            this.chCPU,
            this.chMemor});
            this.lvView.FullRowSelect = true;
            this.lvView.GridLines = true;
            this.lvView.Location = new System.Drawing.Point(12, 5);
            this.lvView.Name = "lvView";
            this.lvView.Size = new System.Drawing.Size(390, 265);
            this.lvView.TabIndex = 5;
            this.lvView.UseCompatibleStateImageBehavior = false;
            this.lvView.View = System.Windows.Forms.View.Details;
            this.lvView.ColumnClick += new System.Windows.Forms.ColumnClickEventHandler(this.lvView_ColumnClick);
            // 
            // chName
            // 
            this.chName.Text = "프로세스 이름";
            this.chName.Width = 108;
            // 
            // chPid
            // 
            this.chPid.Text = "PID";
            this.chPid.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // chCPU
            // 
            this.chCPU.Text = "CPU";
            this.chCPU.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.chCPU.Width = 94;
            // 
            // chMemor
            // 
            this.chMemor.Text = "메모리 사용";
            this.chMemor.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.chMemor.Width = 102;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(414, 334);
            this.Controls.Add(this.ssBar);
            this.Controls.Add(this.btnKill);
            this.Controls.Add(this.lvView);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.Text = "프로세스 관리";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ssBar.ResumeLayout(false);
            this.ssBar.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        internal System.Windows.Forms.StatusStrip ssBar;
        internal System.Windows.Forms.ToolStripStatusLabel tsslProcess;
        internal System.Windows.Forms.ToolStripStatusLabel tsslCpu;
        internal System.Windows.Forms.ToolStripStatusLabel tsslMem;
        private System.Windows.Forms.Button btnKill;
        private System.Windows.Forms.ListView lvView;
        private System.Windows.Forms.ColumnHeader chName;
        private System.Windows.Forms.ColumnHeader chPid;
        private System.Windows.Forms.ColumnHeader chCPU;
        private System.Windows.Forms.ColumnHeader chMemor;
    }
}

