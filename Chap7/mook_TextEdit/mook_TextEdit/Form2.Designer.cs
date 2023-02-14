namespace mook_TextEdit
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
            this.sfdFile = new System.Windows.Forms.SaveFileDialog();
            this.fontdlg = new System.Windows.Forms.FontDialog();
            this.msBar = new System.Windows.Forms.MenuStrip();
            this.모양ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.글자모양ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.글자색상ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.colordlg = new System.Windows.Forms.ColorDialog();
            this.rtbText = new System.Windows.Forms.RichTextBox();
            this.msBar.SuspendLayout();
            this.SuspendLayout();
            // 
            // sfdFile
            // 
            this.sfdFile.FileName = "text.txt";
            this.sfdFile.Filter = "서식파일(*.rtf)|*.rtf|텍스트 파일(*.txt)|*.txt|모든 파일(*.*)|*.*";
            // 
            // msBar
            // 
            this.msBar.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.모양ToolStripMenuItem});
            this.msBar.Location = new System.Drawing.Point(0, 0);
            this.msBar.Name = "msBar";
            this.msBar.Size = new System.Drawing.Size(284, 24);
            this.msBar.TabIndex = 0;
            this.msBar.Text = "menuStrip1";
            this.msBar.Visible = false;
            // 
            // 모양ToolStripMenuItem
            // 
            this.모양ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.글자모양ToolStripMenuItem,
            this.글자색상ToolStripMenuItem});
            this.모양ToolStripMenuItem.Name = "모양ToolStripMenuItem";
            this.모양ToolStripMenuItem.Size = new System.Drawing.Size(41, 20);
            this.모양ToolStripMenuItem.Text = "모양";
            // 
            // 글자모양ToolStripMenuItem
            // 
            this.글자모양ToolStripMenuItem.Name = "글자모양ToolStripMenuItem";
            this.글자모양ToolStripMenuItem.Size = new System.Drawing.Size(128, 22);
            this.글자모양ToolStripMenuItem.Text = "글자 모양";
            this.글자모양ToolStripMenuItem.Click += new System.EventHandler(this.글자모양ToolStripMenuItem_Click);
            // 
            // 글자색상ToolStripMenuItem
            // 
            this.글자색상ToolStripMenuItem.Name = "글자색상ToolStripMenuItem";
            this.글자색상ToolStripMenuItem.Size = new System.Drawing.Size(128, 22);
            this.글자색상ToolStripMenuItem.Text = "글자 색상";
            this.글자색상ToolStripMenuItem.Click += new System.EventHandler(this.글자색상ToolStripMenuItem_Click);
            // 
            // rtbText
            // 
            this.rtbText.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rtbText.Location = new System.Drawing.Point(0, 0);
            this.rtbText.Name = "rtbText";
            this.rtbText.Size = new System.Drawing.Size(284, 264);
            this.rtbText.TabIndex = 2;
            this.rtbText.Text = "";
            this.rtbText.TextChanged += new System.EventHandler(this.rtbText_TextChanged);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 264);
            this.Controls.Add(this.msBar);
            this.Controls.Add(this.rtbText);
            this.Name = "Form2";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "새창";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form2_FormClosing);
            this.Load += new System.EventHandler(this.Form2_Load);
            this.msBar.ResumeLayout(false);
            this.msBar.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.SaveFileDialog sfdFile;
        private System.Windows.Forms.FontDialog fontdlg;
        private System.Windows.Forms.ToolStripMenuItem 모양ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 글자모양ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 글자색상ToolStripMenuItem;
        private System.Windows.Forms.ColorDialog colordlg;
        internal System.Windows.Forms.MenuStrip msBar;
        internal System.Windows.Forms.RichTextBox rtbText;
    }
}