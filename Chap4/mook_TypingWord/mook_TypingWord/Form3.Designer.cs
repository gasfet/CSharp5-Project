namespace mook_TypingWord
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form3));
            this.btnOk = new System.Windows.Forms.Button();
            this.txtName = new System.Windows.Forms.TextBox();
            this.lblName = new System.Windows.Forms.Label();
            this.ImageList = new System.Windows.Forms.ImageList(this.components);
            this.groupBox = new System.Windows.Forms.GroupBox();
            this.rb02Img = new System.Windows.Forms.RadioButton();
            this.rb01Img = new System.Windows.Forms.RadioButton();
            this.groupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnOk
            // 
            this.btnOk.Location = new System.Drawing.Point(10, 226);
            this.btnOk.Name = "btnOk";
            this.btnOk.Size = new System.Drawing.Size(264, 23);
            this.btnOk.TabIndex = 8;
            this.btnOk.Text = "사 용 자 설 정";
            this.btnOk.UseVisualStyleBackColor = true;
            this.btnOk.Click += new System.EventHandler(this.btnOk_Click);
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(107, 16);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(100, 21);
            this.txtName.TabIndex = 6;
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(32, 19);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(37, 12);
            this.lblName.TabIndex = 5;
            this.lblName.Text = "이 름 ";
            // 
            // ImageList
            // 
            this.ImageList.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("ImageList.ImageStream")));
            this.ImageList.TransparentColor = System.Drawing.Color.Transparent;
            this.ImageList.Images.SetKeyName(0, "남자.jpg");
            this.ImageList.Images.SetKeyName(1, "여자.jpg");
            // 
            // groupBox
            // 
            this.groupBox.Controls.Add(this.rb02Img);
            this.groupBox.Controls.Add(this.rb01Img);
            this.groupBox.Location = new System.Drawing.Point(10, 55);
            this.groupBox.Name = "groupBox";
            this.groupBox.Size = new System.Drawing.Size(264, 155);
            this.groupBox.TabIndex = 9;
            this.groupBox.TabStop = false;
            this.groupBox.Text = "얼굴선택";
            // 
            // rb02Img
            // 
            this.rb02Img.AutoSize = true;
            this.rb02Img.ImageKey = "여자.jpg";
            this.rb02Img.ImageList = this.ImageList;
            this.rb02Img.Location = new System.Drawing.Point(137, 27);
            this.rb02Img.Name = "rb02Img";
            this.rb02Img.Size = new System.Drawing.Size(114, 100);
            this.rb02Img.TabIndex = 3;
            this.rb02Img.TabStop = true;
            this.rb02Img.UseVisualStyleBackColor = true;
            // 
            // rb01Img
            // 
            this.rb01Img.AutoSize = true;
            this.rb01Img.ImageKey = "남자.jpg";
            this.rb01Img.ImageList = this.ImageList;
            this.rb01Img.Location = new System.Drawing.Point(14, 27);
            this.rb01Img.Name = "rb01Img";
            this.rb01Img.Size = new System.Drawing.Size(114, 100);
            this.rb01Img.TabIndex = 2;
            this.rb01Img.TabStop = true;
            this.rb01Img.UseVisualStyleBackColor = true;
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 264);
            this.Controls.Add(this.groupBox);
            this.Controls.Add(this.btnOk);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.lblName);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Form3";
            this.Text = "사용자 설정";
            this.groupBox.ResumeLayout(false);
            this.groupBox.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnOk;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.ImageList ImageList;
        private System.Windows.Forms.GroupBox groupBox;
        private System.Windows.Forms.RadioButton rb02Img;
        private System.Windows.Forms.RadioButton rb01Img;
    }
}