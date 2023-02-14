namespace mook_FormControl
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
            this.btnFormShow = new System.Windows.Forms.Button();
            this.btnForm = new System.Windows.Forms.Button();
            this.btnDynamic = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnFormShow
            // 
            this.btnFormShow.Location = new System.Drawing.Point(197, 76);
            this.btnFormShow.Name = "btnFormShow";
            this.btnFormShow.Size = new System.Drawing.Size(75, 23);
            this.btnFormShow.TabIndex = 5;
            this.btnFormShow.Text = "폼 보이기";
            this.btnFormShow.UseVisualStyleBackColor = true;
            this.btnFormShow.Click += new System.EventHandler(this.btnFormShow_Click);
            // 
            // btnForm
            // 
            this.btnForm.Location = new System.Drawing.Point(106, 76);
            this.btnForm.Name = "btnForm";
            this.btnForm.Size = new System.Drawing.Size(75, 23);
            this.btnForm.TabIndex = 4;
            this.btnForm.Text = "폼 흔들기";
            this.btnForm.UseVisualStyleBackColor = true;
            this.btnForm.Click += new System.EventHandler(this.btnForm_Click);
            // 
            // btnDynamic
            // 
            this.btnDynamic.Location = new System.Drawing.Point(12, 76);
            this.btnDynamic.Name = "btnDynamic";
            this.btnDynamic.Size = new System.Drawing.Size(75, 23);
            this.btnDynamic.TabIndex = 3;
            this.btnDynamic.Text = "버튼생성";
            this.btnDynamic.UseVisualStyleBackColor = true;
            this.btnDynamic.Click += new System.EventHandler(this.btnDynamic_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 111);
            this.Controls.Add(this.btnFormShow);
            this.Controls.Add(this.btnForm);
            this.Controls.Add(this.btnDynamic);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.Text = "폼 제어";
            this.ResumeLayout(false);

        }

        #endregion

        internal System.Windows.Forms.Button btnFormShow;
        internal System.Windows.Forms.Button btnForm;
        internal System.Windows.Forms.Button btnDynamic;
    }
}

