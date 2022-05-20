
namespace mushroomtools
{
    partial class Form1
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.LevelList = new System.Windows.Forms.ListBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.toolsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.makeAMapToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.designerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.optionsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.perferencesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.languageToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.LevelPerMain = new System.Windows.Forms.Panel();
            this.mapPanel0 = new System.Windows.Forms.Panel();
            this.mapName = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.mapAuthor = new System.Windows.Forms.Label();
            this.hUDEditorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.playerOffsetEditorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panel1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.LevelPerMain.SuspendLayout();
            this.mapPanel0.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.LevelList);
            this.panel1.Location = new System.Drawing.Point(12, 35);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(235, 515);
            this.panel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(76, 5);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(83, 15);
            this.label1.TabIndex = 2;
            this.label1.Text = "Select a Map...";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // LevelList
            // 
            this.LevelList.FormattingEnabled = true;
            this.LevelList.ItemHeight = 15;
            this.LevelList.Items.AddRange(new object[] {
            "Test1",
            "Test2",
            "Test3",
            "Test4",
            "Test5"});
            this.LevelList.Location = new System.Drawing.Point(6, 27);
            this.LevelList.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.LevelList.Name = "LevelList";
            this.LevelList.Size = new System.Drawing.Size(226, 484);
            this.LevelList.TabIndex = 0;
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.SystemColors.Menu;
            this.menuStrip1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolsToolStripMenuItem,
            this.optionsToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(0, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(933, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // toolsToolStripMenuItem
            // 
            this.toolsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.makeAMapToolStripMenuItem,
            this.designerToolStripMenuItem});
            this.toolsToolStripMenuItem.Name = "toolsToolStripMenuItem";
            this.toolsToolStripMenuItem.Size = new System.Drawing.Size(46, 20);
            this.toolsToolStripMenuItem.Text = "Tools";
            // 
            // makeAMapToolStripMenuItem
            // 
            this.makeAMapToolStripMenuItem.Name = "makeAMapToolStripMenuItem";
            this.makeAMapToolStripMenuItem.Size = new System.Drawing.Size(188, 22);
            this.makeAMapToolStripMenuItem.Text = "Level Template Maker";
            this.makeAMapToolStripMenuItem.Click += new System.EventHandler(this.makeAMapToolStripMenuItem_Click);
            // 
            // designerToolStripMenuItem
            // 
            this.designerToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.hUDEditorToolStripMenuItem,
            this.playerOffsetEditorToolStripMenuItem});
            this.designerToolStripMenuItem.Name = "designerToolStripMenuItem";
            this.designerToolStripMenuItem.Size = new System.Drawing.Size(188, 22);
            this.designerToolStripMenuItem.Text = "Designer";
            this.designerToolStripMenuItem.Click += new System.EventHandler(this.designerToolStripMenuItem_Click);
            // 
            // optionsToolStripMenuItem
            // 
            this.optionsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.perferencesToolStripMenuItem,
            this.languageToolStripMenuItem});
            this.optionsToolStripMenuItem.Name = "optionsToolStripMenuItem";
            this.optionsToolStripMenuItem.Size = new System.Drawing.Size(61, 20);
            this.optionsToolStripMenuItem.Text = "Options";
            // 
            // perferencesToolStripMenuItem
            // 
            this.perferencesToolStripMenuItem.Name = "perferencesToolStripMenuItem";
            this.perferencesToolStripMenuItem.Size = new System.Drawing.Size(135, 22);
            this.perferencesToolStripMenuItem.Text = "Perferences";
            // 
            // languageToolStripMenuItem
            // 
            this.languageToolStripMenuItem.Name = "languageToolStripMenuItem";
            this.languageToolStripMenuItem.Size = new System.Drawing.Size(135, 22);
            this.languageToolStripMenuItem.Text = "Language";
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 10;
            // 
            // LevelPerMain
            // 
            this.LevelPerMain.Controls.Add(this.mapPanel0);
            this.LevelPerMain.Location = new System.Drawing.Point(253, 35);
            this.LevelPerMain.Name = "LevelPerMain";
            this.LevelPerMain.Size = new System.Drawing.Size(668, 515);
            this.LevelPerMain.TabIndex = 2;
            // 
            // mapPanel0
            // 
            this.mapPanel0.Controls.Add(this.mapName);
            this.mapPanel0.Controls.Add(this.label2);
            this.mapPanel0.Controls.Add(this.mapAuthor);
            this.mapPanel0.Location = new System.Drawing.Point(0, 0);
            this.mapPanel0.Name = "mapPanel0";
            this.mapPanel0.Size = new System.Drawing.Size(668, 515);
            this.mapPanel0.TabIndex = 3;
            // 
            // mapName
            // 
            this.mapName.AutoSize = true;
            this.mapName.Font = new System.Drawing.Font("Segoe UI Semibold", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mapName.Location = new System.Drawing.Point(3, 5);
            this.mapName.Margin = new System.Windows.Forms.Padding(0);
            this.mapName.Name = "mapName";
            this.mapName.Size = new System.Drawing.Size(490, 50);
            this.mapName.TabIndex = 0;
            this.mapName.Text = "Mystery of Negaposy Island";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 102);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(131, 15);
            this.label2.TabIndex = 2;
            this.label2.Text = "Map Author: Hengshao";
            // 
            // mapAuthor
            // 
            this.mapAuthor.AutoSize = true;
            this.mapAuthor.Location = new System.Drawing.Point(9, 72);
            this.mapAuthor.Name = "mapAuthor";
            this.mapAuthor.Size = new System.Drawing.Size(131, 15);
            this.mapAuthor.TabIndex = 1;
            this.mapAuthor.Text = "Map Author: Hengshao";
            // 
            // hUDEditorToolStripMenuItem
            // 
            this.hUDEditorToolStripMenuItem.Name = "hUDEditorToolStripMenuItem";
            this.hUDEditorToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.hUDEditorToolStripMenuItem.Text = "HUD";
            this.hUDEditorToolStripMenuItem.Click += new System.EventHandler(this.hUDEditorToolStripMenuItem_Click);
            // 
            // playerOffsetEditorToolStripMenuItem
            // 
            this.playerOffsetEditorToolStripMenuItem.Name = "playerOffsetEditorToolStripMenuItem";
            this.playerOffsetEditorToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.playerOffsetEditorToolStripMenuItem.Text = "Player Offset";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(933, 562);
            this.Controls.Add(this.LevelPerMain);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.menuStrip1);
            this.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "Form1";
            this.Text = "SMBX Launcher";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.LevelPerMain.ResumeLayout(false);
            this.mapPanel0.ResumeLayout(false);
            this.mapPanel0.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem toolsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem optionsToolStripMenuItem;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.ListBox LevelList;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel LevelPerMain;
        private System.Windows.Forms.Label mapName;
        private System.Windows.Forms.Label mapAuthor;
        private System.Windows.Forms.ToolStripMenuItem perferencesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem languageToolStripMenuItem;
        private System.Windows.Forms.Panel mapPanel0;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ToolStripMenuItem makeAMapToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem designerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem hUDEditorToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem playerOffsetEditorToolStripMenuItem;
    }
}

