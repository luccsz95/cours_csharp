﻿namespace e_project
{
    partial class Main
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
            menuStrip1 = new MenuStrip();
            productToolStripMenuItem = new ToolStripMenuItem();
            appartmentToolStripMenuItem = new ToolStripMenuItem();
            housesToolStripMenuItem = new ToolStripMenuItem();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { productToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(800, 28);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // productToolStripMenuItem
            // 
            productToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { appartmentToolStripMenuItem, housesToolStripMenuItem });
            productToolStripMenuItem.Name = "productToolStripMenuItem";
            productToolStripMenuItem.Size = new Size(79, 24);
            productToolStripMenuItem.Text = "Proprety";
            productToolStripMenuItem.Click += productToolStripMenuItem_Click;
            // 
            // appartmentToolStripMenuItem
            // 
            appartmentToolStripMenuItem.Name = "appartmentToolStripMenuItem";
            appartmentToolStripMenuItem.Size = new Size(292, 26);
            appartmentToolStripMenuItem.Text = "Add";
            appartmentToolStripMenuItem.Click += appartmentToolStripMenuItem_Click;
            // 
            // housesToolStripMenuItem
            // 
            housesToolStripMenuItem.Name = "housesToolStripMenuItem";
            housesToolStripMenuItem.Size = new Size(292, 26);
            housesToolStripMenuItem.Text = "Modify (not implemented yet)";
            // 
            // Main
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(menuStrip1);
            IsMdiContainer = true;
            MainMenuStrip = menuStrip1;
            Name = "Main";
            Text = "Main";
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem productToolStripMenuItem;
        private ToolStripMenuItem appartmentToolStripMenuItem;
        private ToolStripMenuItem housesToolStripMenuItem;
    }
}