namespace mook_FormMove
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
            this.picMinimize = new System.Windows.Forms.PictureBox();
            this.picClose = new System.Windows.Forms.PictureBox();
            this.lblInform = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.picMinimize)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picClose)).BeginInit();
            this.SuspendLayout();
            // 
            // picMinimize
            // 
            this.picMinimize.Location = new System.Drawing.Point(181, 2);
            this.picMinimize.Name = "picMinimize";
            this.picMinimize.Size = new System.Drawing.Size(17, 17);
            this.picMinimize.TabIndex = 39;
            this.picMinimize.TabStop = false;
            this.picMinimize.MouseLeave += new System.EventHandler(this.picMinimize_MouseLeave);
            this.picMinimize.MouseMove += new System.Windows.Forms.MouseEventHandler(this.picMinimize_MouseMove);
            this.picMinimize.Click += new System.EventHandler(this.picMinimize_Click);
            this.picMinimize.MouseDown += new System.Windows.Forms.MouseEventHandler(this.picMinimize_MouseDown);
            // 
            // picClose
            // 
            this.picClose.Location = new System.Drawing.Point(201, 2);
            this.picClose.Name = "picClose";
            this.picClose.Size = new System.Drawing.Size(17, 17);
            this.picClose.TabIndex = 38;
            this.picClose.TabStop = false;
            this.picClose.MouseLeave += new System.EventHandler(this.picClose_MouseLeave);
            this.picClose.MouseMove += new System.Windows.Forms.MouseEventHandler(this.picClose_MouseMove);
            this.picClose.Click += new System.EventHandler(this.picClose_Click);
            this.picClose.MouseDown += new System.Windows.Forms.MouseEventHandler(this.picClose_MouseDown);
            // 
            // lblInform
            // 
            this.lblInform.AutoSize = true;
            this.lblInform.Font = new System.Drawing.Font("굴림", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lblInform.ForeColor = System.Drawing.Color.White;
            this.lblInform.Location = new System.Drawing.Point(26, 70);
            this.lblInform.Name = "lblInform";
            this.lblInform.Size = new System.Drawing.Size(176, 13);
            this.lblInform.TabIndex = 40;
            this.lblInform.Text = "폼을 클릭하여 이동하세요!";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DimGray;
            this.ClientSize = new System.Drawing.Size(225, 157);
            this.Controls.Add(this.lblInform);
            this.Controls.Add(this.picMinimize);
            this.Controls.Add(this.picClose);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "폼 이동";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseUp);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseMove);
            ((System.ComponentModel.ISupportInitialize)(this.picMinimize)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picClose)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblInform;
        private System.Windows.Forms.PictureBox picMinimize;
        private System.Windows.Forms.PictureBox picClose;
    }
}

