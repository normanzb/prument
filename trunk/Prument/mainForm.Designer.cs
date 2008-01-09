namespace Prument
{
    partial class mainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(mainForm));
            this.menMain = new System.Windows.Forms.MenuStrip();
            this.iteFile = new System.Windows.Forms.ToolStripMenuItem();
            this.iteNew = new System.Windows.Forms.ToolStripMenuItem();
            this.iteSave = new System.Windows.Forms.ToolStripMenuItem();
            this.iteFind = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripSeparator();
            this.iteExit = new System.Windows.Forms.ToolStripMenuItem();
            this.iteHelp = new System.Windows.Forms.ToolStripMenuItem();
            this.iteAbout = new System.Windows.Forms.ToolStripMenuItem();
            this.ssMain = new System.Windows.Forms.StatusStrip();
            this.tsslMain = new System.Windows.Forms.ToolStripStatusLabel();
            this.tspbMain = new System.Windows.Forms.ToolStripProgressBar();
            this.menMain.SuspendLayout();
            this.ssMain.SuspendLayout();
            this.SuspendLayout();
            // 
            // menMain
            // 
            this.menMain.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.iteFile,
            this.iteHelp});
            this.menMain.Location = new System.Drawing.Point(0, 0);
            this.menMain.Name = "menMain";
            this.menMain.Size = new System.Drawing.Size(702, 24);
            this.menMain.TabIndex = 9;
            this.menMain.Text = "menuStrip1";
            this.menMain.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.menMain_ItemClicked);
            // 
            // iteFile
            // 
            this.iteFile.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.iteNew,
            this.iteSave,
            this.iteFind,
            this.toolStripMenuItem2,
            this.iteExit});
            this.iteFile.Name = "iteFile";
            this.iteFile.Size = new System.Drawing.Size(57, 20);
            this.iteFile.Text = "文件(&F)";
            // 
            // iteNew
            // 
            this.iteNew.Name = "iteNew";
            this.iteNew.Size = new System.Drawing.Size(124, 22);
            this.iteNew.Text = "新产品(&P)";
            this.iteNew.Click += new System.EventHandler(this.iteNew_Click);
            // 
            // iteSave
            // 
            this.iteSave.Enabled = false;
            this.iteSave.Name = "iteSave";
            this.iteSave.Size = new System.Drawing.Size(124, 22);
            this.iteSave.Text = "保存(&S)";
            this.iteSave.Click += new System.EventHandler(this.iteSave_Click);
            // 
            // iteFind
            // 
            this.iteFind.Name = "iteFind";
            this.iteFind.Size = new System.Drawing.Size(124, 22);
            this.iteFind.Text = "搜索(&F)";
            this.iteFind.Click += new System.EventHandler(this.iteFind_Click);
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(121, 6);
            // 
            // iteExit
            // 
            this.iteExit.Name = "iteExit";
            this.iteExit.Size = new System.Drawing.Size(124, 22);
            this.iteExit.Text = "离开(&X)";
            this.iteExit.Click += new System.EventHandler(this.iteExit_Click);
            // 
            // iteHelp
            // 
            this.iteHelp.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.iteAbout});
            this.iteHelp.Name = "iteHelp";
            this.iteHelp.Size = new System.Drawing.Size(58, 20);
            this.iteHelp.Text = "帮助(&H)";
            // 
            // iteAbout
            // 
            this.iteAbout.Name = "iteAbout";
            this.iteAbout.Size = new System.Drawing.Size(113, 22);
            this.iteAbout.Text = "关于(&A)";
            this.iteAbout.Click += new System.EventHandler(this.iteAbout_Click);
            // 
            // ssMain
            // 
            this.ssMain.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsslMain,
            this.tspbMain});
            this.ssMain.Location = new System.Drawing.Point(0, 471);
            this.ssMain.Name = "ssMain";
            this.ssMain.Size = new System.Drawing.Size(702, 22);
            this.ssMain.TabIndex = 11;
            // 
            // tsslMain
            // 
            this.tsslMain.Name = "tsslMain";
            this.tsslMain.Size = new System.Drawing.Size(38, 17);
            this.tsslMain.Text = "Ready";
            // 
            // tspbMain
            // 
            this.tspbMain.Name = "tspbMain";
            this.tspbMain.Size = new System.Drawing.Size(100, 16);
            // 
            // mainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(702, 493);
            this.Controls.Add(this.ssMain);
            this.Controls.Add(this.menMain);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menMain;
            this.Name = "mainForm";
            this.Text = "Prument!";
            this.Resize += new System.EventHandler(this.mainForm_Resize);
            this.Load += new System.EventHandler(this.mainForm_Load);
            this.menMain.ResumeLayout(false);
            this.menMain.PerformLayout();
            this.ssMain.ResumeLayout(false);
            this.ssMain.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menMain;
        private System.Windows.Forms.ToolStripMenuItem iteFile;
        private System.Windows.Forms.ToolStripMenuItem iteNew;
        private System.Windows.Forms.ToolStripMenuItem iteFind;
        private System.Windows.Forms.ToolStripMenuItem iteHelp;
        private System.Windows.Forms.ToolStripMenuItem iteAbout;
        public System.Windows.Forms.ToolStripMenuItem iteSave;
        private System.Windows.Forms.ToolStripMenuItem iteExit;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem2;
        private System.Windows.Forms.StatusStrip ssMain;
        public System.Windows.Forms.ToolStripStatusLabel tsslMain;
        public System.Windows.Forms.ToolStripProgressBar tspbMain;
    }
}

