namespace mook_FormShow
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
            this.btnModeless = new System.Windows.Forms.Button();
            this.btnModal = new System.Windows.Forms.Button();
            this.btnMsr = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnModeless
            // 
            this.btnModeless.Location = new System.Drawing.Point(137, 39);
            this.btnModeless.Name = "btnModeless";
            this.btnModeless.Size = new System.Drawing.Size(121, 23);
            this.btnModeless.TabIndex = 1;
            this.btnModeless.Text = "모달리스 폼";
            this.btnModeless.UseVisualStyleBackColor = true;
            this.btnModeless.Click += new System.EventHandler(this.btnModeless_Click);
            // 
            // btnModal
            // 
            this.btnModal.Location = new System.Drawing.Point(38, 39);
            this.btnModal.Name = "btnModal";
            this.btnModal.Size = new System.Drawing.Size(75, 23);
            this.btnModal.TabIndex = 0;
            this.btnModal.Text = "모달 폼";
            this.btnModal.UseVisualStyleBackColor = true;
            this.btnModal.Click += new System.EventHandler(this.btnModal_Click);
            // 
            // btnMsr
            // 
            this.btnMsr.Location = new System.Drawing.Point(87, 84);
            this.btnMsr.Name = "btnMsr";
            this.btnMsr.Size = new System.Drawing.Size(121, 23);
            this.btnMsr.TabIndex = 2;
            this.btnMsr.Text = "메신저 알림 폼";
            this.btnMsr.UseVisualStyleBackColor = true;
            this.btnMsr.Click += new System.EventHandler(this.btnMsr_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(292, 147);
            this.Controls.Add(this.btnMsr);
            this.Controls.Add(this.btnModal);
            this.Controls.Add(this.btnModeless);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "부모";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnModeless;
        private System.Windows.Forms.Button btnModal;
        private System.Windows.Forms.Button btnMsr;
    }
}

