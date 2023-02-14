namespace mook_Browser
{
    partial class Form3
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.gbSetup = new System.Windows.Forms.GroupBox();
            this.btnOk = new System.Windows.Forms.Button();
            this.btnBlank = new System.Windows.Forms.Button();
            this.btnDefault = new System.Windows.Forms.Button();
            this.txtAddress = new System.Windows.Forms.TextBox();
            this.lblAddress = new System.Windows.Forms.Label();
            this.lblTitle = new System.Windows.Forms.Label();
            this.gbSetup.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbSetup
            // 
            this.gbSetup.Controls.Add(this.btnOk);
            this.gbSetup.Controls.Add(this.btnBlank);
            this.gbSetup.Controls.Add(this.btnDefault);
            this.gbSetup.Controls.Add(this.txtAddress);
            this.gbSetup.Controls.Add(this.lblAddress);
            this.gbSetup.Controls.Add(this.lblTitle);
            this.gbSetup.Location = new System.Drawing.Point(24, 12);
            this.gbSetup.Name = "gbSetup";
            this.gbSetup.Size = new System.Drawing.Size(377, 100);
            this.gbSetup.TabIndex = 2;
            this.gbSetup.TabStop = false;
            this.gbSetup.Text = "홈 페이지";
            // 
            // btnOk
            // 
            this.btnOk.Location = new System.Drawing.Point(292, 64);
            this.btnOk.Name = "btnOk";
            this.btnOk.Size = new System.Drawing.Size(64, 23);
            this.btnOk.TabIndex = 6;
            this.btnOk.Text = "적용";
            this.btnOk.UseVisualStyleBackColor = true;
            this.btnOk.Click += new System.EventHandler(this.btnOk_Click);
            // 
            // btnBlank
            // 
            this.btnBlank.Location = new System.Drawing.Point(185, 64);
            this.btnBlank.Name = "btnBlank";
            this.btnBlank.Size = new System.Drawing.Size(85, 23);
            this.btnBlank.TabIndex = 5;
            this.btnBlank.Text = "빈 페이지";
            this.btnBlank.UseVisualStyleBackColor = true;
            this.btnBlank.Click += new System.EventHandler(this.btnBlank_Click);
            // 
            // btnDefault
            // 
            this.btnDefault.Location = new System.Drawing.Point(75, 64);
            this.btnDefault.Name = "btnDefault";
            this.btnDefault.Size = new System.Drawing.Size(85, 23);
            this.btnDefault.TabIndex = 4;
            this.btnDefault.Text = "기본 페이지";
            this.btnDefault.UseVisualStyleBackColor = true;
            this.btnDefault.Click += new System.EventHandler(this.btnDefault_Click);
            // 
            // txtAddress
            // 
            this.txtAddress.Location = new System.Drawing.Point(75, 37);
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.Size = new System.Drawing.Size(281, 21);
            this.txtAddress.TabIndex = 2;
            // 
            // lblAddress
            // 
            this.lblAddress.AutoSize = true;
            this.lblAddress.Location = new System.Drawing.Point(16, 40);
            this.lblAddress.Name = "lblAddress";
            this.lblAddress.Size = new System.Drawing.Size(41, 12);
            this.lblAddress.TabIndex = 1;
            this.lblAddress.Text = "주 소 :";
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Location = new System.Drawing.Point(16, 17);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(269, 12);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "홈페이지로 사용할 페이지를 변경할 수 있습니다.";
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(424, 126);
            this.Controls.Add(this.gbSetup);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Form3";
            this.Text = "인터넷 옵션";
            this.Load += new System.EventHandler(this.Form3_Load);
            this.gbSetup.ResumeLayout(false);
            this.gbSetup.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbSetup;
        private System.Windows.Forms.Button btnOk;
        private System.Windows.Forms.Button btnBlank;
        private System.Windows.Forms.Button btnDefault;
        private System.Windows.Forms.TextBox txtAddress;
        private System.Windows.Forms.Label lblAddress;
        private System.Windows.Forms.Label lblTitle;


    }
}