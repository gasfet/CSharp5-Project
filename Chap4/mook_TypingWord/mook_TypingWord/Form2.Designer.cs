namespace mook_TypingWord
{
    partial class Form2
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
            this.btnOk = new System.Windows.Forms.Button();
            this.btnInsert = new System.Windows.Forms.Button();
            this.txtInsert = new System.Windows.Forms.TextBox();
            this.lvWord = new System.Windows.Forms.ListView();
            this.chWord = new System.Windows.Forms.ColumnHeader();
            this.cbKind = new System.Windows.Forms.ComboBox();
            this.cbGrade = new System.Windows.Forms.ComboBox();
            this.lblWord = new System.Windows.Forms.Label();
            this.lblKind = new System.Windows.Forms.Label();
            this.lblGrade = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnOk
            // 
            this.btnOk.Location = new System.Drawing.Point(11, 182);
            this.btnOk.Name = "btnOk";
            this.btnOk.Size = new System.Drawing.Size(375, 23);
            this.btnOk.TabIndex = 17;
            this.btnOk.Text = "환 경 설 정";
            this.btnOk.UseVisualStyleBackColor = true;
            this.btnOk.Click += new System.EventHandler(this.btnOk_Click);
            // 
            // btnInsert
            // 
            this.btnInsert.Location = new System.Drawing.Point(265, 84);
            this.btnInsert.Name = "btnInsert";
            this.btnInsert.Size = new System.Drawing.Size(121, 23);
            this.btnInsert.TabIndex = 16;
            this.btnInsert.Text = "단어 추가";
            this.btnInsert.UseVisualStyleBackColor = true;
            this.btnInsert.Click += new System.EventHandler(this.btnInsert_Click);
            // 
            // txtInsert
            // 
            this.txtInsert.Location = new System.Drawing.Point(265, 56);
            this.txtInsert.Name = "txtInsert";
            this.txtInsert.Size = new System.Drawing.Size(121, 21);
            this.txtInsert.TabIndex = 15;
            // 
            // lvWord
            // 
            this.lvWord.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.chWord});
            this.lvWord.GridLines = true;
            this.lvWord.Location = new System.Drawing.Point(53, 59);
            this.lvWord.Name = "lvWord";
            this.lvWord.Size = new System.Drawing.Size(201, 109);
            this.lvWord.TabIndex = 14;
            this.lvWord.UseCompatibleStateImageBehavior = false;
            this.lvWord.View = System.Windows.Forms.View.Details;
            // 
            // chWord
            // 
            this.chWord.Text = "단 어";
            this.chWord.Width = 170;
            // 
            // cbKind
            // 
            this.cbKind.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbKind.FormattingEnabled = true;
            this.cbKind.Items.AddRange(new object[] {
            "한글",
            "영어"});
            this.cbKind.Location = new System.Drawing.Point(265, 22);
            this.cbKind.Name = "cbKind";
            this.cbKind.Size = new System.Drawing.Size(121, 20);
            this.cbKind.TabIndex = 13;
            this.cbKind.SelectedIndexChanged += new System.EventHandler(this.cbKind_SelectedIndexChanged);
            // 
            // cbGrade
            // 
            this.cbGrade.FormattingEnabled = true;
            this.cbGrade.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10"});
            this.cbGrade.Location = new System.Drawing.Point(53, 22);
            this.cbGrade.Name = "cbGrade";
            this.cbGrade.Size = new System.Drawing.Size(121, 20);
            this.cbGrade.TabIndex = 12;
            this.cbGrade.Text = "1";
            // 
            // lblWord
            // 
            this.lblWord.AutoSize = true;
            this.lblWord.Location = new System.Drawing.Point(9, 59);
            this.lblWord.Name = "lblWord";
            this.lblWord.Size = new System.Drawing.Size(33, 12);
            this.lblWord.TabIndex = 11;
            this.lblWord.Text = "단 어";
            // 
            // lblKind
            // 
            this.lblKind.AutoSize = true;
            this.lblKind.Location = new System.Drawing.Point(221, 25);
            this.lblKind.Name = "lblKind";
            this.lblKind.Size = new System.Drawing.Size(33, 12);
            this.lblKind.TabIndex = 10;
            this.lblKind.Text = "종 류";
            // 
            // lblGrade
            // 
            this.lblGrade.AutoSize = true;
            this.lblGrade.Location = new System.Drawing.Point(9, 25);
            this.lblGrade.Name = "lblGrade";
            this.lblGrade.Size = new System.Drawing.Size(33, 12);
            this.lblGrade.TabIndex = 9;
            this.lblGrade.Text = "단 계";
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(394, 226);
            this.Controls.Add(this.btnOk);
            this.Controls.Add(this.btnInsert);
            this.Controls.Add(this.txtInsert);
            this.Controls.Add(this.lvWord);
            this.Controls.Add(this.cbKind);
            this.Controls.Add(this.cbGrade);
            this.Controls.Add(this.lblWord);
            this.Controls.Add(this.lblKind);
            this.Controls.Add(this.lblGrade);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Form2";
            this.Text = "환경설정";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnOk;
        private System.Windows.Forms.Button btnInsert;
        private System.Windows.Forms.TextBox txtInsert;
        private System.Windows.Forms.ListView lvWord;
        private System.Windows.Forms.ComboBox cbKind;
        private System.Windows.Forms.ComboBox cbGrade;
        private System.Windows.Forms.Label lblWord;
        private System.Windows.Forms.Label lblKind;
        private System.Windows.Forms.Label lblGrade;
        private System.Windows.Forms.ColumnHeader chWord;
    }
}