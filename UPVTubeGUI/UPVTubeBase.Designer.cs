﻿namespace UPVTubeGUI
{
    partial class UPVTubeBase
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
            this.menuStripLoggedOut = new System.Windows.Forms.MenuStrip();
            this.systemToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.initializeDBToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.clearDBToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripSeparator();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.userToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.loginToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.registerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStripLoggedIn = new System.Windows.Forms.MenuStrip();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem3 = new System.Windows.Forms.ToolStripMenuItem();
            this.clearDBToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripMenuItem4 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem5 = new System.Windows.Forms.ToolStripMenuItem();
            this.logoutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.contentToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.historyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.listToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pendingToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.subscribedToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStripLoggedOut.SuspendLayout();
            this.menuStripLoggedIn.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStripLoggedOut
            // 
            this.menuStripLoggedOut.GripMargin = new System.Windows.Forms.Padding(2, 2, 0, 2);
            this.menuStripLoggedOut.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStripLoggedOut.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.systemToolStripMenuItem,
            this.userToolStripMenuItem});
            this.menuStripLoggedOut.Location = new System.Drawing.Point(0, 0);
            this.menuStripLoggedOut.Name = "menuStripLoggedOut";
            this.menuStripLoggedOut.Padding = new System.Windows.Forms.Padding(7, 2, 0, 2);
            this.menuStripLoggedOut.Size = new System.Drawing.Size(824, 33);
            this.menuStripLoggedOut.TabIndex = 2;
            this.menuStripLoggedOut.Text = "menuStripLogout";
            // 
            // systemToolStripMenuItem
            // 
            this.systemToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.initializeDBToolStripMenuItem,
            this.clearDBToolStripMenuItem,
            this.toolStripMenuItem1,
            this.exitToolStripMenuItem});
            this.systemToolStripMenuItem.Name = "systemToolStripMenuItem";
            this.systemToolStripMenuItem.Size = new System.Drawing.Size(85, 29);
            this.systemToolStripMenuItem.Text = "System";
            // 
            // initializeDBToolStripMenuItem
            // 
            this.initializeDBToolStripMenuItem.Name = "initializeDBToolStripMenuItem";
            this.initializeDBToolStripMenuItem.Size = new System.Drawing.Size(205, 34);
            this.initializeDBToolStripMenuItem.Text = "Initialize DB";
            this.initializeDBToolStripMenuItem.Click += new System.EventHandler(this.initializeDBToolStripMenuItem_Click_1);
            // 
            // clearDBToolStripMenuItem
            // 
            this.clearDBToolStripMenuItem.Name = "clearDBToolStripMenuItem";
            this.clearDBToolStripMenuItem.Size = new System.Drawing.Size(205, 34);
            this.clearDBToolStripMenuItem.Text = "Clear DB";
            this.clearDBToolStripMenuItem.Click += new System.EventHandler(this.clearDBToolStripMenuItem1_Click);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(202, 6);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(205, 34);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click_1);
            // 
            // userToolStripMenuItem
            // 
            this.userToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.loginToolStripMenuItem,
            this.registerToolStripMenuItem});
            this.userToolStripMenuItem.Name = "userToolStripMenuItem";
            this.userToolStripMenuItem.Size = new System.Drawing.Size(63, 29);
            this.userToolStripMenuItem.Text = "User";
            // 
            // loginToolStripMenuItem
            // 
            this.loginToolStripMenuItem.Name = "loginToolStripMenuItem";
            this.loginToolStripMenuItem.Size = new System.Drawing.Size(177, 34);
            this.loginToolStripMenuItem.Text = "Login";
            this.loginToolStripMenuItem.Click += new System.EventHandler(this.loginToolStripMenuItem_Click);
            // 
            // registerToolStripMenuItem
            // 
            this.registerToolStripMenuItem.Name = "registerToolStripMenuItem";
            this.registerToolStripMenuItem.Size = new System.Drawing.Size(177, 34);
            this.registerToolStripMenuItem.Text = "Register";
            this.registerToolStripMenuItem.Click += new System.EventHandler(this.registerToolStripMenuItem_Click);
            // 
            // menuStripLoggedIn
            // 
            this.menuStripLoggedIn.GripMargin = new System.Windows.Forms.Padding(2, 2, 0, 2);
            this.menuStripLoggedIn.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStripLoggedIn.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem2,
            this.toolStripMenuItem5,
            this.contentToolStripMenuItem});
            this.menuStripLoggedIn.Location = new System.Drawing.Point(0, 33);
            this.menuStripLoggedIn.Name = "menuStripLoggedIn";
            this.menuStripLoggedIn.Padding = new System.Windows.Forms.Padding(7, 2, 0, 2);
            this.menuStripLoggedIn.Size = new System.Drawing.Size(824, 33);
            this.menuStripLoggedIn.TabIndex = 3;
            this.menuStripLoggedIn.Text = "menuStripLogout";
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem3,
            this.clearDBToolStripMenuItem1,
            this.toolStripSeparator1,
            this.toolStripMenuItem4});
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(85, 29);
            this.toolStripMenuItem2.Text = "System";
            // 
            // toolStripMenuItem3
            // 
            this.toolStripMenuItem3.Name = "toolStripMenuItem3";
            this.toolStripMenuItem3.Size = new System.Drawing.Size(205, 34);
            this.toolStripMenuItem3.Text = "Initialize DB";
            this.toolStripMenuItem3.Click += new System.EventHandler(this.initializeDBToolStripMenuItem_Click_1);
            // 
            // clearDBToolStripMenuItem1
            // 
            this.clearDBToolStripMenuItem1.Name = "clearDBToolStripMenuItem1";
            this.clearDBToolStripMenuItem1.Size = new System.Drawing.Size(205, 34);
            this.clearDBToolStripMenuItem1.Text = "Clear DB";
            this.clearDBToolStripMenuItem1.Click += new System.EventHandler(this.clearDBToolStripMenuItem1_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(202, 6);
            // 
            // toolStripMenuItem4
            // 
            this.toolStripMenuItem4.Name = "toolStripMenuItem4";
            this.toolStripMenuItem4.Size = new System.Drawing.Size(205, 34);
            this.toolStripMenuItem4.Text = "Exit";
            this.toolStripMenuItem4.Click += new System.EventHandler(this.exitToolStripMenuItem_Click_1);
            // 
            // toolStripMenuItem5
            // 
            this.toolStripMenuItem5.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.logoutToolStripMenuItem});
            this.toolStripMenuItem5.Name = "toolStripMenuItem5";
            this.toolStripMenuItem5.Size = new System.Drawing.Size(63, 29);
            this.toolStripMenuItem5.Text = "User";
            // 
            // logoutToolStripMenuItem
            // 
            this.logoutToolStripMenuItem.Name = "logoutToolStripMenuItem";
            this.logoutToolStripMenuItem.Size = new System.Drawing.Size(171, 34);
            this.logoutToolStripMenuItem.Text = "Logout";
            this.logoutToolStripMenuItem.Click += new System.EventHandler(this.logoutToolStripMenuItem_Click);
            // 
            // contentToolStripMenuItem
            // 
            this.contentToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addToolStripMenuItem,
            this.historyToolStripMenuItem,
            this.listToolStripMenuItem,
            this.pendingToolStripMenuItem,
            this.subscribedToolStripMenuItem});
            this.contentToolStripMenuItem.Name = "contentToolStripMenuItem";
            this.contentToolStripMenuItem.Size = new System.Drawing.Size(91, 29);
            this.contentToolStripMenuItem.Text = "Content";
            // 
            // addToolStripMenuItem
            // 
            this.addToolStripMenuItem.Name = "addToolStripMenuItem";
            this.addToolStripMenuItem.Size = new System.Drawing.Size(270, 34);
            this.addToolStripMenuItem.Text = "Add";
            this.addToolStripMenuItem.Click += new System.EventHandler(this.addToolStripMenuItem_Click);
            // 
            // historyToolStripMenuItem
            // 
            this.historyToolStripMenuItem.Name = "historyToolStripMenuItem";
            this.historyToolStripMenuItem.Size = new System.Drawing.Size(270, 34);
            this.historyToolStripMenuItem.Text = "History";
            this.historyToolStripMenuItem.Click += new System.EventHandler(this.historyToolStripMenuItem_Click);
            // 
            // listToolStripMenuItem
            // 
            this.listToolStripMenuItem.Name = "listToolStripMenuItem";
            this.listToolStripMenuItem.Size = new System.Drawing.Size(270, 34);
            this.listToolStripMenuItem.Text = "List";
            this.listToolStripMenuItem.Click += new System.EventHandler(this.listToolStripMenuItem_Click);
            // 
            // pendingToolStripMenuItem
            // 
            this.pendingToolStripMenuItem.Name = "pendingToolStripMenuItem";
            this.pendingToolStripMenuItem.Size = new System.Drawing.Size(270, 34);
            this.pendingToolStripMenuItem.Text = "Pending";
            this.pendingToolStripMenuItem.Click += new System.EventHandler(this.pendingToolStripMenuItem_Click);
            // 
            // subscribedToolStripMenuItem
            // 
            this.subscribedToolStripMenuItem.Name = "subscribedToolStripMenuItem";
            this.subscribedToolStripMenuItem.Size = new System.Drawing.Size(270, 34);
            this.subscribedToolStripMenuItem.Text = "Subscribed";
            this.subscribedToolStripMenuItem.Click += new System.EventHandler(this.subscribedToolStripMenuItem_Click);
            // 
            // UPVTubeBase
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(824, 518);
            this.Controls.Add(this.menuStripLoggedIn);
            this.Controls.Add(this.menuStripLoggedOut);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "UPVTubeBase";
            this.Text = "UPVTubeBase";
            this.Load += new System.EventHandler(this.UPVTubeBase_Load);
            this.menuStripLoggedOut.ResumeLayout(false);
            this.menuStripLoggedOut.PerformLayout();
            this.menuStripLoggedIn.ResumeLayout(false);
            this.menuStripLoggedIn.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStripLoggedOut;
        private System.Windows.Forms.ToolStripMenuItem systemToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem initializeDBToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem userToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem loginToolStripMenuItem;
        private System.Windows.Forms.MenuStrip menuStripLoggedIn;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem3;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem4;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem5;
        private System.Windows.Forms.ToolStripMenuItem logoutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem contentToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem clearDBToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem clearDBToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem addToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem listToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem registerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pendingToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem historyToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem subscribedToolStripMenuItem;
    }
}

