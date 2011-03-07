﻿namespace PokerMuck
{
    partial class HudWindow
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
            this.lblPlayerName = new System.Windows.Forms.Label();
            this.contextMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.resetPlayerStatisticsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripSeparator();
            this.resetEverybodysStatisticsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lblTotalHandsPlayed = new System.Windows.Forms.Label();
            this.contextMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblPlayerName
            // 
            this.lblPlayerName.Cursor = System.Windows.Forms.Cursors.Default;
            this.lblPlayerName.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPlayerName.Location = new System.Drawing.Point(1, 0);
            this.lblPlayerName.Name = "lblPlayerName";
            this.lblPlayerName.Size = new System.Drawing.Size(105, 13);
            this.lblPlayerName.TabIndex = 0;
            this.lblPlayerName.Text = "playerName";
            // 
            // contextMenu
            // 
            this.contextMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.resetPlayerStatisticsToolStripMenuItem,
            this.toolStripMenuItem1,
            this.resetEverybodysStatisticsToolStripMenuItem});
            this.contextMenu.Name = "contextMenu";
            this.contextMenu.Size = new System.Drawing.Size(218, 54);
            // 
            // resetPlayerStatisticsToolStripMenuItem
            // 
            this.resetPlayerStatisticsToolStripMenuItem.Name = "resetPlayerStatisticsToolStripMenuItem";
            this.resetPlayerStatisticsToolStripMenuItem.Size = new System.Drawing.Size(217, 22);
            this.resetPlayerStatisticsToolStripMenuItem.Text = "Reset Player\'s Statistics";
            this.resetPlayerStatisticsToolStripMenuItem.Click += new System.EventHandler(this.resetPlayerStatisticsToolStripMenuItem_Click);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(214, 6);
            // 
            // resetEverybodysStatisticsToolStripMenuItem
            // 
            this.resetEverybodysStatisticsToolStripMenuItem.Name = "resetEverybodysStatisticsToolStripMenuItem";
            this.resetEverybodysStatisticsToolStripMenuItem.Size = new System.Drawing.Size(217, 22);
            this.resetEverybodysStatisticsToolStripMenuItem.Text = "Reset Everybody\'s Statistics";
            this.resetEverybodysStatisticsToolStripMenuItem.Click += new System.EventHandler(this.resetEverybodysStatisticsToolStripMenuItem_Click);
            // 
            // lblTotalHandsPlayed
            // 
            this.lblTotalHandsPlayed.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblTotalHandsPlayed.Location = new System.Drawing.Point(137, 0);
            this.lblTotalHandsPlayed.Name = "lblTotalHandsPlayed";
            this.lblTotalHandsPlayed.Size = new System.Drawing.Size(22, 13);
            this.lblTotalHandsPlayed.TabIndex = 1;
            this.lblTotalHandsPlayed.Text = "(0)";
            this.lblTotalHandsPlayed.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // HudWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.BurlyWood;
            this.ClientSize = new System.Drawing.Size(159, 49);
            this.ContextMenuStrip = this.contextMenu;
            this.Controls.Add(this.lblPlayerName);
            this.Controls.Add(this.lblTotalHandsPlayed);
            this.Cursor = System.Windows.Forms.Cursors.SizeAll;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "HudWindow";
            this.Opacity = 0.9D;
            this.Text = "HudWindow";
            this.TopMost = true;
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.HudWindow_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.HudWindow_MouseMove);
            this.MouseUp += new System.Windows.Forms.MouseEventHandler(this.HudWindow_MouseUp);
            this.contextMenu.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblPlayerName;
        private System.Windows.Forms.ContextMenuStrip contextMenu;
        private System.Windows.Forms.ToolStripMenuItem resetPlayerStatisticsToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem resetEverybodysStatisticsToolStripMenuItem;
        private System.Windows.Forms.Label lblTotalHandsPlayed;
    }
}