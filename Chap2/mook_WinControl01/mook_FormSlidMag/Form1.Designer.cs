namespace mook_FormSlidMag
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
            this.btnMag = new System.Windows.Forms.Button();
            this.pbImg = new System.Windows.Forms.PictureBox();
            this.btnShow = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pbImg)).BeginInit();
            this.SuspendLayout();
            // 
            // btnMag
            // 
            this.btnMag.Location = new System.Drawing.Point(184, 237);
            this.btnMag.Name = "btnMag";
            this.btnMag.Size = new System.Drawing.Size(98, 23);
            this.btnMag.TabIndex = 5;
            this.btnMag.Text = "폼 붙이기 열기";
            this.btnMag.UseVisualStyleBackColor = true;
            this.btnMag.Click += new System.EventHandler(this.btnMag_Click);
            // 
            // pbImg
            // 
            this.pbImg.Image = global::mook_FormSlidMag.Properties.Resources._01;
            this.pbImg.Location = new System.Drawing.Point(13, 13);
            this.pbImg.Name = "pbImg";
            this.pbImg.Size = new System.Drawing.Size(269, 218);
            this.pbImg.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbImg.TabIndex = 4;
            this.pbImg.TabStop = false;
            // 
            // btnShow
            // 
            this.btnShow.Location = new System.Drawing.Point(12, 237);
            this.btnShow.Name = "btnShow";
            this.btnShow.Size = new System.Drawing.Size(98, 23);
            this.btnShow.TabIndex = 3;
            this.btnShow.Text = "슬라이드 열기";
            this.btnShow.UseVisualStyleBackColor = true;
            this.btnShow.Click += new System.EventHandler(this.btnShow_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(294, 272);
            this.Controls.Add(this.btnMag);
            this.Controls.Add(this.pbImg);
            this.Controls.Add(this.btnShow);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.Text = "폼 슬라이딩 붙이기";
            this.LocationChanged += new System.EventHandler(this.Form1_LocationChanged);
            ((System.ComponentModel.ISupportInitialize)(this.pbImg)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        internal System.Windows.Forms.Button btnMag;
        internal System.Windows.Forms.PictureBox pbImg;
        internal System.Windows.Forms.Button btnShow;
    }
}