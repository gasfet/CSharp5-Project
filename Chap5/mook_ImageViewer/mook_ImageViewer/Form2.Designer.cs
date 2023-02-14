namespace mook_ImageViewer
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
            this.components = new System.ComponentModel.Container();
            this.tsBar = new System.Windows.Forms.ToolStrip();
            this.tsddbtnTurn = new System.Windows.Forms.ToolStripDropDownButton();
            this.도회전ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.도회전ToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.도회전ToolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.tsbtnFull = new System.Windows.Forms.ToolStripButton();
            this.tsbtnPre = new System.Windows.Forms.ToolStripButton();
            this.tsbtnNext = new System.Windows.Forms.ToolStripButton();
            this.tsbtnSlide = new System.Windows.Forms.ToolStripButton();
            this.ctmenu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.전체화면끝내기EToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.목록보기LToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.Timer = new System.Windows.Forms.Timer(this.components);
            this.pbImg = new System.Windows.Forms.PictureBox();
            this.tsbtnFileList = new System.Windows.Forms.ToolStripButton();
            this.tsbtnOld = new System.Windows.Forms.ToolStripButton();
            this.tsBar.SuspendLayout();
            this.ctmenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbImg)).BeginInit();
            this.SuspendLayout();
            // 
            // tsBar
            // 
            this.tsBar.ImageScalingSize = new System.Drawing.Size(32, 32);
            this.tsBar.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsbtnFileList,
            this.tsbtnOld,
            this.tsddbtnTurn,
            this.tsbtnFull,
            this.tsbtnPre,
            this.tsbtnNext,
            this.tsbtnSlide});
            this.tsBar.Location = new System.Drawing.Point(0, 0);
            this.tsBar.Name = "tsBar";
            this.tsBar.Size = new System.Drawing.Size(492, 39);
            this.tsBar.TabIndex = 4;
            this.tsBar.Text = "ToolStrip1";
            // 
            // tsddbtnTurn
            // 
            this.tsddbtnTurn.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsddbtnTurn.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.도회전ToolStripMenuItem,
            this.도회전ToolStripMenuItem1,
            this.도회전ToolStripMenuItem2});
            this.tsddbtnTurn.Image = global::mook_ImageViewer.Properties.Resources._9;
            this.tsddbtnTurn.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsddbtnTurn.Name = "tsddbtnTurn";
            this.tsddbtnTurn.Size = new System.Drawing.Size(45, 36);
            this.tsddbtnTurn.Text = "회전";
            // 
            // 도회전ToolStripMenuItem
            // 
            this.도회전ToolStripMenuItem.Name = "도회전ToolStripMenuItem";
            this.도회전ToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.도회전ToolStripMenuItem.Text = "90도 회전";
            this.도회전ToolStripMenuItem.Click += new System.EventHandler(this.도회전ToolStripMenuItem_Click);
            // 
            // 도회전ToolStripMenuItem1
            // 
            this.도회전ToolStripMenuItem1.Name = "도회전ToolStripMenuItem1";
            this.도회전ToolStripMenuItem1.Size = new System.Drawing.Size(152, 22);
            this.도회전ToolStripMenuItem1.Text = "180도 회전";
            this.도회전ToolStripMenuItem1.Click += new System.EventHandler(this.도회전ToolStripMenuItem1_Click);
            // 
            // 도회전ToolStripMenuItem2
            // 
            this.도회전ToolStripMenuItem2.Name = "도회전ToolStripMenuItem2";
            this.도회전ToolStripMenuItem2.Size = new System.Drawing.Size(152, 22);
            this.도회전ToolStripMenuItem2.Text = "270도 회전";
            this.도회전ToolStripMenuItem2.Click += new System.EventHandler(this.도회전ToolStripMenuItem2_Click);
            // 
            // tsbtnFull
            // 
            this.tsbtnFull.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbtnFull.Image = global::mook_ImageViewer.Properties.Resources._7;
            this.tsbtnFull.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbtnFull.Name = "tsbtnFull";
            this.tsbtnFull.Size = new System.Drawing.Size(36, 36);
            this.tsbtnFull.Text = "전체화면";
            this.tsbtnFull.Click += new System.EventHandler(this.tsbtnFull_Click);
            // 
            // tsbtnPre
            // 
            this.tsbtnPre.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbtnPre.Image = global::mook_ImageViewer.Properties.Resources._10;
            this.tsbtnPre.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbtnPre.Name = "tsbtnPre";
            this.tsbtnPre.Size = new System.Drawing.Size(36, 36);
            this.tsbtnPre.Text = "이전";
            this.tsbtnPre.Click += new System.EventHandler(this.tsbtnPre_Click);
            // 
            // tsbtnNext
            // 
            this.tsbtnNext.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbtnNext.Image = global::mook_ImageViewer.Properties.Resources._11;
            this.tsbtnNext.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbtnNext.Name = "tsbtnNext";
            this.tsbtnNext.Size = new System.Drawing.Size(36, 36);
            this.tsbtnNext.Text = "다음";
            this.tsbtnNext.Click += new System.EventHandler(this.tsbtnNext_Click);
            // 
            // tsbtnSlide
            // 
            this.tsbtnSlide.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbtnSlide.Image = global::mook_ImageViewer.Properties.Resources._12;
            this.tsbtnSlide.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbtnSlide.Name = "tsbtnSlide";
            this.tsbtnSlide.Size = new System.Drawing.Size(36, 36);
            this.tsbtnSlide.Text = "슬라이드";
            this.tsbtnSlide.Click += new System.EventHandler(this.tsbtnSlide_Click);
            // 
            // ctmenu
            // 
            this.ctmenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.전체화면끝내기EToolStripMenuItem,
            this.목록보기LToolStripMenuItem});
            this.ctmenu.Name = "ctmenu";
            this.ctmenu.Size = new System.Drawing.Size(177, 48);
            // 
            // 전체화면끝내기EToolStripMenuItem
            // 
            this.전체화면끝내기EToolStripMenuItem.Name = "전체화면끝내기EToolStripMenuItem";
            this.전체화면끝내기EToolStripMenuItem.Size = new System.Drawing.Size(176, 22);
            this.전체화면끝내기EToolStripMenuItem.Text = "전체화면 끝내기(&E)";
            this.전체화면끝내기EToolStripMenuItem.Click += new System.EventHandler(this.전체화면끝내기EToolStripMenuItem_Click);
            // 
            // 목록보기LToolStripMenuItem
            // 
            this.목록보기LToolStripMenuItem.Name = "목록보기LToolStripMenuItem";
            this.목록보기LToolStripMenuItem.Size = new System.Drawing.Size(176, 22);
            this.목록보기LToolStripMenuItem.Text = "목록보기(&L)";
            this.목록보기LToolStripMenuItem.Click += new System.EventHandler(this.목록보기LToolStripMenuItem_Click);
            // 
            // Timer
            // 
            this.Timer.Interval = 2000;
            this.Timer.Tick += new System.EventHandler(this.Timer_Tick);
            // 
            // pbImg
            // 
            this.pbImg.BackColor = System.Drawing.Color.White;
            this.pbImg.Location = new System.Drawing.Point(1, 40);
            this.pbImg.Name = "pbImg";
            this.pbImg.Size = new System.Drawing.Size(160, 160);
            this.pbImg.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pbImg.TabIndex = 5;
            this.pbImg.TabStop = false;
            // 
            // tsbtnFileList
            // 
            this.tsbtnFileList.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbtnFileList.Image = global::mook_ImageViewer.Properties.Resources._6;
            this.tsbtnFileList.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbtnFileList.Name = "tsbtnFileList";
            this.tsbtnFileList.Size = new System.Drawing.Size(36, 36);
            this.tsbtnFileList.Text = "목록보기";
            this.tsbtnFileList.Click += new System.EventHandler(this.tsbtnFileList_Click);
            // 
            // tsbtnOld
            // 
            this.tsbtnOld.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbtnOld.Image = global::mook_ImageViewer.Properties.Resources._21;
            this.tsbtnOld.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbtnOld.Name = "tsbtnOld";
            this.tsbtnOld.Size = new System.Drawing.Size(36, 36);
            this.tsbtnOld.Text = "원본그림";
            this.tsbtnOld.Click += new System.EventHandler(this.tsbtnOld_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(492, 373);
            this.Controls.Add(this.pbImg);
            this.Controls.Add(this.tsBar);
            this.Name = "Form2";
            this.Text = "이미지 보기";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form2_FormClosing);
            this.Load += new System.EventHandler(this.Form2_Load);
            this.tsBar.ResumeLayout(false);
            this.tsBar.PerformLayout();
            this.ctmenu.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbImg)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pbImg;
        private System.Windows.Forms.ToolStrip tsBar;
        private System.Windows.Forms.ToolStripButton tsbtnFileList;
        private System.Windows.Forms.ToolStripButton tsbtnOld;
        private System.Windows.Forms.ToolStripDropDownButton tsddbtnTurn;
        private System.Windows.Forms.ToolStripMenuItem 도회전ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 도회전ToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem 도회전ToolStripMenuItem2;
        private System.Windows.Forms.ToolStripButton tsbtnFull;
        private System.Windows.Forms.ToolStripButton tsbtnPre;
        private System.Windows.Forms.ToolStripButton tsbtnNext;
        private System.Windows.Forms.ToolStripButton tsbtnSlide;
        private System.Windows.Forms.ContextMenuStrip ctmenu;
        private System.Windows.Forms.ToolStripMenuItem 전체화면끝내기EToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 목록보기LToolStripMenuItem;
        private System.Windows.Forms.Timer Timer;

    }
}