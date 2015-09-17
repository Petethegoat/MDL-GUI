namespace MDL_GUI
{
    partial class Form1
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
            if(disposing && (components != null))
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
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.buttonBrowseTarget = new System.Windows.Forms.Button();
            this.textBoxTarget = new System.Windows.Forms.TextBox();
            this.buttonCompile = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.toolsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.compMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.decompMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.defaultDirMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.unsetDefaultDir = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.byPetethegoatToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.buttonGotoTarget = new System.Windows.Forms.Button();
            this.textBoxConsole = new System.Windows.Forms.TextBox();
            this.setDefaultDir = new System.Windows.Forms.ToolStripMenuItem();
            this.forkMeOnGithubToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.v12ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.AutoScroll = true;
            this.splitContainer1.Panel1.Controls.Add(this.buttonBrowseTarget);
            this.splitContainer1.Panel1.Controls.Add(this.textBoxTarget);
            this.splitContainer1.Panel1.Controls.Add(this.buttonCompile);
            this.splitContainer1.Panel1.Controls.Add(this.menuStrip1);
            this.splitContainer1.Panel1.Controls.Add(this.buttonGotoTarget);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.textBoxConsole);
            this.splitContainer1.Size = new System.Drawing.Size(464, 282);
            this.splitContainer1.SplitterDistance = 88;
            this.splitContainer1.TabIndex = 0;
            // 
            // buttonBrowseTarget
            // 
            this.buttonBrowseTarget.Location = new System.Drawing.Point(323, 27);
            this.buttonBrowseTarget.Name = "buttonBrowseTarget";
            this.buttonBrowseTarget.Size = new System.Drawing.Size(75, 23);
            this.buttonBrowseTarget.TabIndex = 5;
            this.buttonBrowseTarget.Text = "Browse";
            this.buttonBrowseTarget.UseVisualStyleBackColor = true;
            this.buttonBrowseTarget.Click += new System.EventHandler(this.buttonBrowseTarget_Click);
            // 
            // textBoxTarget
            // 
            this.textBoxTarget.Location = new System.Drawing.Point(11, 29);
            this.textBoxTarget.Name = "textBoxTarget";
            this.textBoxTarget.ReadOnly = true;
            this.textBoxTarget.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.textBoxTarget.Size = new System.Drawing.Size(306, 20);
            this.textBoxTarget.TabIndex = 3;
            // 
            // buttonCompile
            // 
            this.buttonCompile.Location = new System.Drawing.Point(11, 56);
            this.buttonCompile.Name = "buttonCompile";
            this.buttonCompile.Size = new System.Drawing.Size(425, 23);
            this.buttonCompile.TabIndex = 0;
            this.buttonCompile.Text = "Compile";
            this.buttonCompile.UseVisualStyleBackColor = true;
            this.buttonCompile.Click += new System.EventHandler(this.buttonCompile_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolsToolStripMenuItem,
            this.aboutToolStripMenuItem,
            this.v12ToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(462, 24);
            this.menuStrip1.TabIndex = 2;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // toolsToolStripMenuItem
            // 
            this.toolsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.compMenu,
            this.decompMenu,
            this.defaultDirMenu});
            this.toolsToolStripMenuItem.Name = "toolsToolStripMenuItem";
            this.toolsToolStripMenuItem.Size = new System.Drawing.Size(48, 20);
            this.toolsToolStripMenuItem.Text = "Tools";
            // 
            // compMenu
            // 
            this.compMenu.Name = "compMenu";
            this.compMenu.Size = new System.Drawing.Size(163, 22);
            this.compMenu.Text = "MDL Compiler";
            this.compMenu.Click += new System.EventHandler(this.compMenu_Click);
            // 
            // decompMenu
            // 
            this.decompMenu.Name = "decompMenu";
            this.decompMenu.Size = new System.Drawing.Size(163, 22);
            this.decompMenu.Text = "MDL Decompiler";
            this.decompMenu.Click += new System.EventHandler(this.decompMenu_Click);
            // 
            // defaultDirMenu
            // 
            this.defaultDirMenu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.setDefaultDir,
            this.unsetDefaultDir});
            this.defaultDirMenu.Name = "defaultDirMenu";
            this.defaultDirMenu.Size = new System.Drawing.Size(163, 22);
            this.defaultDirMenu.Text = "Default Directory";
            // 
            // unsetDefaultDir
            // 
            this.unsetDefaultDir.Name = "unsetDefaultDir";
            this.unsetDefaultDir.Size = new System.Drawing.Size(196, 22);
            this.unsetDefaultDir.Text = "Unset Default Directory";
            this.unsetDefaultDir.Click += new System.EventHandler(this.unsetDefaultDir_Click);
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.byPetethegoatToolStripMenuItem,
            this.forkMeOnGithubToolStripMenuItem});
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(52, 20);
            this.aboutToolStripMenuItem.Text = "About";
            // 
            // byPetethegoatToolStripMenuItem
            // 
            this.byPetethegoatToolStripMenuItem.Name = "byPetethegoatToolStripMenuItem";
            this.byPetethegoatToolStripMenuItem.Size = new System.Drawing.Size(176, 22);
            this.byPetethegoatToolStripMenuItem.Text = "By Petethegoat";
            this.byPetethegoatToolStripMenuItem.ToolTipText = "https://github.com/petethegoat/";
            this.byPetethegoatToolStripMenuItem.Click += new System.EventHandler(this.byPetethegoatToolStripMenuItem_Click);
            // 
            // buttonGotoTarget
            // 
            this.buttonGotoTarget.Location = new System.Drawing.Point(404, 27);
            this.buttonGotoTarget.Name = "buttonGotoTarget";
            this.buttonGotoTarget.Size = new System.Drawing.Size(32, 23);
            this.buttonGotoTarget.TabIndex = 6;
            this.buttonGotoTarget.Text = "..";
            this.buttonGotoTarget.UseVisualStyleBackColor = true;
            this.buttonGotoTarget.Click += new System.EventHandler(this.buttonGotoTarget_Click);
            // 
            // textBoxConsole
            // 
            this.textBoxConsole.BackColor = System.Drawing.SystemColors.Desktop;
            this.textBoxConsole.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxConsole.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBoxConsole.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.textBoxConsole.Location = new System.Drawing.Point(0, 0);
            this.textBoxConsole.Multiline = true;
            this.textBoxConsole.Name = "textBoxConsole";
            this.textBoxConsole.ReadOnly = true;
            this.textBoxConsole.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBoxConsole.Size = new System.Drawing.Size(462, 188);
            this.textBoxConsole.TabIndex = 0;
            // 
            // setDefaultDir
            // 
            this.setDefaultDir.Name = "setDefaultDir";
            this.setDefaultDir.Size = new System.Drawing.Size(196, 22);
            this.setDefaultDir.Text = "Set Default Directory";
            this.setDefaultDir.Click += new System.EventHandler(this.setDefaultDir_Click);
            // 
            // forkMeOnGithubToolStripMenuItem
            // 
            this.forkMeOnGithubToolStripMenuItem.Image = global::MDL_GUI.Properties.Resources.github_32_black;
            this.forkMeOnGithubToolStripMenuItem.Name = "forkMeOnGithubToolStripMenuItem";
            this.forkMeOnGithubToolStripMenuItem.Size = new System.Drawing.Size(176, 22);
            this.forkMeOnGithubToolStripMenuItem.Text = "Fork me on Github!";
            this.forkMeOnGithubToolStripMenuItem.ToolTipText = "https://github.com/Petethegoat/MDL-GUI";
            this.forkMeOnGithubToolStripMenuItem.Click += new System.EventHandler(this.forkMeOnGithubToolStripMenuItem_Click);
            // 
            // v12ToolStripMenuItem
            // 
            this.v12ToolStripMenuItem.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.v12ToolStripMenuItem.Enabled = false;
            this.v12ToolStripMenuItem.Name = "v12ToolStripMenuItem";
            this.v12ToolStripMenuItem.Size = new System.Drawing.Size(41, 20);
            this.v12ToolStripMenuItem.Text = "V1.2";
            // 
            // Form1
            // 
            this.AllowDrop = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(464, 282);
            this.Controls.Add(this.splitContainer1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.ShowIcon = false;
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.Text = "MDL GUI";
            this.DragDrop += new System.Windows.Forms.DragEventHandler(this.Form1_DragDrop);
            this.DragEnter += new System.Windows.Forms.DragEventHandler(this.Form1_DragEnter);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.TextBox textBoxConsole;
        private System.Windows.Forms.Button buttonCompile;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem toolsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem compMenu;
        private System.Windows.Forms.ToolStripMenuItem decompMenu;
        private System.Windows.Forms.TextBox textBoxTarget;
        private System.Windows.Forms.Button buttonBrowseTarget;
        private System.Windows.Forms.Button buttonGotoTarget;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem byPetethegoatToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem forkMeOnGithubToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem defaultDirMenu;
        private System.Windows.Forms.ToolStripMenuItem unsetDefaultDir;
        private System.Windows.Forms.ToolStripMenuItem setDefaultDir;
        private System.Windows.Forms.ToolStripMenuItem v12ToolStripMenuItem;
    }
}