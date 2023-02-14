namespace mook_WebXML
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
            this.btnSearch = new System.Windows.Forms.Button();
            this.lvFile = new System.Windows.Forms.ListView();
            this.chName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.lklblNews = new System.Windows.Forms.LinkLabel();
            this.ttipMemo = new System.Windows.Forms.ToolTip(this.components);
            this.SuspendLayout();
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(242, 12);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(75, 23);
            this.btnSearch.TabIndex = 0;
            this.btnSearch.Text = "검  색";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // lvFile
            // 
            this.lvFile.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.chName});
            this.lvFile.GridLines = true;
            this.lvFile.Location = new System.Drawing.Point(12, 12);
            this.lvFile.Name = "lvFile";
            this.lvFile.Size = new System.Drawing.Size(218, 249);
            this.lvFile.TabIndex = 1;
            this.lvFile.UseCompatibleStateImageBehavior = false;
            this.lvFile.View = System.Windows.Forms.View.Details;
            // 
            // chName
            // 
            this.chName.Text = "이  름";
            this.chName.Width = 200;
            // 
            // lklblNews
            // 
            this.lklblNews.AutoSize = true;
            this.lklblNews.Location = new System.Drawing.Point(12, 278);
            this.lklblNews.Name = "lklblNews";
            this.lklblNews.Size = new System.Drawing.Size(69, 12);
            this.lklblNews.TabIndex = 5;
            this.lklblNews.TabStop = true;
            this.lklblNews.Text = "기상청 날씨";
            this.lklblNews.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lklblNews_LinkClicked);
            // 
            // ttipMemo
            // 
            this.ttipMemo.ToolTipTitle = "클릭하면 웹 브라우저와 연결됩니다.";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(329, 308);
            this.Controls.Add(this.lklblNews);
            this.Controls.Add(this.lvFile);
            this.Controls.Add(this.btnSearch);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "XML 파일 검색";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.ListView lvFile;
        private System.Windows.Forms.ColumnHeader chName;
        internal System.Windows.Forms.LinkLabel lklblNews;
        private System.Windows.Forms.ToolTip ttipMemo;
    }
}

