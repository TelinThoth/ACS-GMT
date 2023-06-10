﻿
namespace Aurora_GM_Tools
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openGameFileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.closeGameToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cbx_gamesList = new System.Windows.Forms.ComboBox();
            this.lbl_gameList = new System.Windows.Forms.Label();
            this.GameControlsPanel = new System.Windows.Forms.Panel();
            this.cbx_faction = new System.Windows.Forms.ComboBox();
            this.lbl_Faction = new System.Windows.Forms.Label();
            this.cbx_fleet = new System.Windows.Forms.ComboBox();
            this.lbl_fleet = new System.Windows.Forms.Label();
            this.tbctl_SelectionOptions = new System.Windows.Forms.TabControl();
            this.tab_fleets = new System.Windows.Forms.TabPage();
            this.tab_Colonies = new System.Windows.Forms.TabPage();
            this.menuStrip1.SuspendLayout();
            this.GameControlsPanel.SuspendLayout();
            this.tbctl_SelectionOptions.SuspendLayout();
            this.tab_fleets.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.GripMargin = new System.Windows.Forms.Padding(2, 2, 0, 2);
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1253, 33);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.openGameFileToolStripMenuItem,
            this.closeGameToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(54, 29);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // openGameFileToolStripMenuItem
            // 
            this.openGameFileToolStripMenuItem.Name = "openGameFileToolStripMenuItem";
            this.openGameFileToolStripMenuItem.Size = new System.Drawing.Size(240, 34);
            this.openGameFileToolStripMenuItem.Text = "Open Game File";
            this.openGameFileToolStripMenuItem.Click += new System.EventHandler(this.openGameFileToolStripMenuItem_Click);
            // 
            // closeGameToolStripMenuItem
            // 
            this.closeGameToolStripMenuItem.Name = "closeGameToolStripMenuItem";
            this.closeGameToolStripMenuItem.Size = new System.Drawing.Size(240, 34);
            this.closeGameToolStripMenuItem.Text = "Close Game";
            this.closeGameToolStripMenuItem.Click += new System.EventHandler(this.closeGameToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(240, 34);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // cbx_gamesList
            // 
            this.cbx_gamesList.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbx_gamesList.Enabled = false;
            this.cbx_gamesList.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbx_gamesList.FormattingEnabled = true;
            this.cbx_gamesList.Location = new System.Drawing.Point(106, 13);
            this.cbx_gamesList.Name = "cbx_gamesList";
            this.cbx_gamesList.Size = new System.Drawing.Size(295, 37);
            this.cbx_gamesList.TabIndex = 1;
            this.cbx_gamesList.Visible = false;
            this.cbx_gamesList.SelectedIndexChanged += new System.EventHandler(this.cbx_gamesList_SelectedIndexChanged);
            // 
            // lbl_gameList
            // 
            this.lbl_gameList.AutoSize = true;
            this.lbl_gameList.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_gameList.ForeColor = System.Drawing.Color.Lime;
            this.lbl_gameList.Location = new System.Drawing.Point(3, 16);
            this.lbl_gameList.Name = "lbl_gameList";
            this.lbl_gameList.Size = new System.Drawing.Size(84, 29);
            this.lbl_gameList.TabIndex = 2;
            this.lbl_gameList.Text = "Game:";
            this.lbl_gameList.Visible = false;
            // 
            // GameControlsPanel
            // 
            this.GameControlsPanel.Controls.Add(this.tbctl_SelectionOptions);
            this.GameControlsPanel.Controls.Add(this.cbx_faction);
            this.GameControlsPanel.Controls.Add(this.lbl_Faction);
            this.GameControlsPanel.Controls.Add(this.cbx_gamesList);
            this.GameControlsPanel.Controls.Add(this.lbl_gameList);
            this.GameControlsPanel.Location = new System.Drawing.Point(10, 55);
            this.GameControlsPanel.Name = "GameControlsPanel";
            this.GameControlsPanel.Size = new System.Drawing.Size(421, 778);
            this.GameControlsPanel.TabIndex = 3;
            // 
            // cbx_faction
            // 
            this.cbx_faction.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbx_faction.Enabled = false;
            this.cbx_faction.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbx_faction.FormattingEnabled = true;
            this.cbx_faction.Location = new System.Drawing.Point(106, 56);
            this.cbx_faction.Name = "cbx_faction";
            this.cbx_faction.Size = new System.Drawing.Size(295, 37);
            this.cbx_faction.TabIndex = 3;
            this.cbx_faction.Visible = false;
            this.cbx_faction.SelectedIndexChanged += new System.EventHandler(this.cbx_faction_SelectedIndexChanged);
            // 
            // lbl_Faction
            // 
            this.lbl_Faction.AutoSize = true;
            this.lbl_Faction.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Faction.ForeColor = System.Drawing.Color.Lime;
            this.lbl_Faction.Location = new System.Drawing.Point(3, 59);
            this.lbl_Faction.Name = "lbl_Faction";
            this.lbl_Faction.Size = new System.Drawing.Size(98, 29);
            this.lbl_Faction.TabIndex = 4;
            this.lbl_Faction.Text = "Faction:";
            this.lbl_Faction.Visible = false;
            // 
            // cbx_fleet
            // 
            this.cbx_fleet.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbx_fleet.Enabled = false;
            this.cbx_fleet.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbx_fleet.FormattingEnabled = true;
            this.cbx_fleet.Location = new System.Drawing.Point(111, 6);
            this.cbx_fleet.Name = "cbx_fleet";
            this.cbx_fleet.Size = new System.Drawing.Size(258, 37);
            this.cbx_fleet.TabIndex = 5;
            this.cbx_fleet.Visible = false;
            // 
            // lbl_fleet
            // 
            this.lbl_fleet.AutoSize = true;
            this.lbl_fleet.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_fleet.ForeColor = System.Drawing.Color.Lime;
            this.lbl_fleet.Location = new System.Drawing.Point(8, 9);
            this.lbl_fleet.Name = "lbl_fleet";
            this.lbl_fleet.Size = new System.Drawing.Size(68, 29);
            this.lbl_fleet.TabIndex = 6;
            this.lbl_fleet.Text = "Fleet";
            this.lbl_fleet.Visible = false;
            // 
            // tbctl_SelectionOptions
            // 
            this.tbctl_SelectionOptions.Controls.Add(this.tab_fleets);
            this.tbctl_SelectionOptions.Controls.Add(this.tab_Colonies);
            this.tbctl_SelectionOptions.Enabled = false;
            this.tbctl_SelectionOptions.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbctl_SelectionOptions.Location = new System.Drawing.Point(5, 99);
            this.tbctl_SelectionOptions.Name = "tbctl_SelectionOptions";
            this.tbctl_SelectionOptions.SelectedIndex = 0;
            this.tbctl_SelectionOptions.Size = new System.Drawing.Size(396, 525);
            this.tbctl_SelectionOptions.TabIndex = 4;
            this.tbctl_SelectionOptions.Visible = false;
            // 
            // tab_fleets
            // 
            this.tab_fleets.BackColor = System.Drawing.Color.MediumBlue;
            this.tab_fleets.Controls.Add(this.cbx_fleet);
            this.tab_fleets.Controls.Add(this.lbl_fleet);
            this.tab_fleets.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tab_fleets.ForeColor = System.Drawing.Color.Lime;
            this.tab_fleets.Location = new System.Drawing.Point(4, 38);
            this.tab_fleets.Name = "tab_fleets";
            this.tab_fleets.Padding = new System.Windows.Forms.Padding(3);
            this.tab_fleets.Size = new System.Drawing.Size(388, 483);
            this.tab_fleets.TabIndex = 0;
            this.tab_fleets.Text = "Fleets";
            // 
            // tab_Colonies
            // 
            this.tab_Colonies.BackColor = System.Drawing.Color.MediumBlue;
            this.tab_Colonies.ForeColor = System.Drawing.Color.Lime;
            this.tab_Colonies.Location = new System.Drawing.Point(4, 29);
            this.tab_Colonies.Name = "tab_Colonies";
            this.tab_Colonies.Padding = new System.Windows.Forms.Padding(3);
            this.tab_Colonies.Size = new System.Drawing.Size(388, 492);
            this.tab_Colonies.TabIndex = 1;
            this.tab_Colonies.Text = "Colonies";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MediumBlue;
            this.ClientSize = new System.Drawing.Size(1253, 1051);
            this.Controls.Add(this.GameControlsPanel);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Telin\'s Aurora4x GM Tools";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.GameControlsPanel.ResumeLayout(false);
            this.GameControlsPanel.PerformLayout();
            this.tbctl_SelectionOptions.ResumeLayout(false);
            this.tab_fleets.ResumeLayout(false);
            this.tab_fleets.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openGameFileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem closeGameToolStripMenuItem;
        private System.Windows.Forms.ComboBox cbx_gamesList;
        private System.Windows.Forms.Label lbl_gameList;
        private System.Windows.Forms.Panel GameControlsPanel;
        private System.Windows.Forms.ComboBox cbx_faction;
        private System.Windows.Forms.Label lbl_Faction;
        private System.Windows.Forms.TabControl tbctl_SelectionOptions;
        private System.Windows.Forms.TabPage tab_fleets;
        private System.Windows.Forms.ComboBox cbx_fleet;
        private System.Windows.Forms.Label lbl_fleet;
        private System.Windows.Forms.TabPage tab_Colonies;
    }
}

