
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
            this.gameDirectoryToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gameFileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.closeGameToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cbx_gamesList = new System.Windows.Forms.ComboBox();
            this.lbl_gameList = new System.Windows.Forms.Label();
            this.GameControlsPanel = new System.Windows.Forms.Panel();
            this.tbctl_SelectionOptions = new System.Windows.Forms.TabControl();
            this.tab_fleets = new System.Windows.Forms.TabPage();
            this.label7 = new System.Windows.Forms.Label();
            this.lbl_Waypoints = new System.Windows.Forms.Label();
            this.cbx_newOwner = new System.Windows.Forms.ComboBox();
            this.cbx_fleet = new System.Windows.Forms.ComboBox();
            this.btn_TransferOwners = new System.Windows.Forms.Button();
            this.cbx_waypoints = new System.Windows.Forms.ComboBox();
            this.lbl_fleet = new System.Windows.Forms.Label();
            this.btn_teleportFleet = new System.Windows.Forms.Button();
            this.lbl_Fleet_Actions = new System.Windows.Forms.Label();
            this.tab_CivFleets = new System.Windows.Forms.TabPage();
            this.cbx_shippingFleets = new System.Windows.Forms.ComboBox();
            this.lbl_shippingLines = new System.Windows.Forms.Label();
            this.cbx_shippingLines = new System.Windows.Forms.ComboBox();
            this.lbl_shippingFleets = new System.Windows.Forms.Label();
            this.tab_Colonies = new System.Windows.Forms.TabPage();
            this.cbx_colonies = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cbx_faction = new System.Windows.Forms.ComboBox();
            this.lbl_Faction = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btn_updateTraining = new System.Windows.Forms.Button();
            this.tbx_CurrentTrain = new System.Windows.Forms.TextBox();
            this.tbx_Adjustment = new System.Windows.Forms.TextBox();
            this.lbl_TrainingGrade = new System.Windows.Forms.Label();
            this.lbx_ships = new System.Windows.Forms.ListBox();
            this.MilShipPanel = new System.Windows.Forms.Panel();
            this.btn_CrewAdjustAll = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.btn_UpdateCrew = new System.Windows.Forms.Button();
            this.tbx_CurrentCrew = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.tbx_CrewAjustment = new System.Windows.Forms.TextBox();
            this.btn_applyAll = new System.Windows.Forms.Button();
            this.lbl_MilShips = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.cbx_newArmyOwner = new System.Windows.Forms.ComboBox();
            this.btn_transferArmyOwner = new System.Windows.Forms.Button();
            this.label11 = new System.Windows.Forms.Label();
            this.cbx_Army = new System.Windows.Forms.ComboBox();
            this.menuStrip1.SuspendLayout();
            this.GameControlsPanel.SuspendLayout();
            this.tbctl_SelectionOptions.SuspendLayout();
            this.tab_fleets.SuspendLayout();
            this.tab_CivFleets.SuspendLayout();
            this.tab_Colonies.SuspendLayout();
            this.MilShipPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1236, 33);
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
            this.openGameFileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.gameDirectoryToolStripMenuItem,
            this.gameFileToolStripMenuItem});
            this.openGameFileToolStripMenuItem.Name = "openGameFileToolStripMenuItem";
            this.openGameFileToolStripMenuItem.Size = new System.Drawing.Size(209, 34);
            this.openGameFileToolStripMenuItem.Text = "Open Game";
            // 
            // gameDirectoryToolStripMenuItem
            // 
            this.gameDirectoryToolStripMenuItem.Name = "gameDirectoryToolStripMenuItem";
            this.gameDirectoryToolStripMenuItem.Size = new System.Drawing.Size(237, 34);
            this.gameDirectoryToolStripMenuItem.Text = "Game Directory";
            this.gameDirectoryToolStripMenuItem.Click += new System.EventHandler(this.gameDirectoryToolStripMenuItem_Click);
            // 
            // gameFileToolStripMenuItem
            // 
            this.gameFileToolStripMenuItem.Name = "gameFileToolStripMenuItem";
            this.gameFileToolStripMenuItem.Size = new System.Drawing.Size(237, 34);
            this.gameFileToolStripMenuItem.Text = "Game File";
            this.gameFileToolStripMenuItem.Click += new System.EventHandler(this.gameFileToolStripMenuItem_Click);
            // 
            // closeGameToolStripMenuItem
            // 
            this.closeGameToolStripMenuItem.Name = "closeGameToolStripMenuItem";
            this.closeGameToolStripMenuItem.Size = new System.Drawing.Size(209, 34);
            this.closeGameToolStripMenuItem.Text = "Close Game";
            this.closeGameToolStripMenuItem.Click += new System.EventHandler(this.closeGameToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(209, 34);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // cbx_gamesList
            // 
            this.cbx_gamesList.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbx_gamesList.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbx_gamesList.FormattingEnabled = true;
            this.cbx_gamesList.Location = new System.Drawing.Point(106, 12);
            this.cbx_gamesList.Name = "cbx_gamesList";
            this.cbx_gamesList.Size = new System.Drawing.Size(256, 37);
            this.cbx_gamesList.TabIndex = 1;
            this.cbx_gamesList.SelectedIndexChanged += new System.EventHandler(this.cbx_gamesList_SelectedIndexChanged);
            // 
            // lbl_gameList
            // 
            this.lbl_gameList.AutoSize = true;
            this.lbl_gameList.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_gameList.ForeColor = System.Drawing.Color.Lime;
            this.lbl_gameList.Location = new System.Drawing.Point(3, 15);
            this.lbl_gameList.Name = "lbl_gameList";
            this.lbl_gameList.Size = new System.Drawing.Size(84, 29);
            this.lbl_gameList.TabIndex = 2;
            this.lbl_gameList.Text = "Game:";
            // 
            // GameControlsPanel
            // 
            this.GameControlsPanel.Controls.Add(this.tbctl_SelectionOptions);
            this.GameControlsPanel.Controls.Add(this.cbx_faction);
            this.GameControlsPanel.Controls.Add(this.lbl_Faction);
            this.GameControlsPanel.Controls.Add(this.cbx_gamesList);
            this.GameControlsPanel.Controls.Add(this.lbl_gameList);
            this.GameControlsPanel.ForeColor = System.Drawing.Color.Lime;
            this.GameControlsPanel.Location = new System.Drawing.Point(10, 55);
            this.GameControlsPanel.Name = "GameControlsPanel";
            this.GameControlsPanel.Size = new System.Drawing.Size(429, 985);
            this.GameControlsPanel.TabIndex = 3;
            // 
            // tbctl_SelectionOptions
            // 
            this.tbctl_SelectionOptions.Controls.Add(this.tab_fleets);
            this.tbctl_SelectionOptions.Controls.Add(this.tab_CivFleets);
            this.tbctl_SelectionOptions.Controls.Add(this.tab_Colonies);
            this.tbctl_SelectionOptions.Enabled = false;
            this.tbctl_SelectionOptions.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbctl_SelectionOptions.Location = new System.Drawing.Point(8, 114);
            this.tbctl_SelectionOptions.Name = "tbctl_SelectionOptions";
            this.tbctl_SelectionOptions.SelectedIndex = 0;
            this.tbctl_SelectionOptions.Size = new System.Drawing.Size(380, 525);
            this.tbctl_SelectionOptions.TabIndex = 4;
            this.tbctl_SelectionOptions.Visible = false;
            this.tbctl_SelectionOptions.SelectedIndexChanged += new System.EventHandler(this.tbctl_SelectionOptions_SelectedIndexChanged);
            // 
            // tab_fleets
            // 
            this.tab_fleets.BackColor = System.Drawing.Color.MediumBlue;
            this.tab_fleets.Controls.Add(this.label7);
            this.tab_fleets.Controls.Add(this.lbl_Waypoints);
            this.tab_fleets.Controls.Add(this.cbx_newOwner);
            this.tab_fleets.Controls.Add(this.cbx_fleet);
            this.tab_fleets.Controls.Add(this.btn_TransferOwners);
            this.tab_fleets.Controls.Add(this.cbx_waypoints);
            this.tab_fleets.Controls.Add(this.lbl_fleet);
            this.tab_fleets.Controls.Add(this.btn_teleportFleet);
            this.tab_fleets.Controls.Add(this.lbl_Fleet_Actions);
            this.tab_fleets.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tab_fleets.ForeColor = System.Drawing.Color.Lime;
            this.tab_fleets.Location = new System.Drawing.Point(4, 38);
            this.tab_fleets.Name = "tab_fleets";
            this.tab_fleets.Padding = new System.Windows.Forms.Padding(3);
            this.tab_fleets.Size = new System.Drawing.Size(372, 483);
            this.tab_fleets.TabIndex = 0;
            this.tab_fleets.Text = "Mil. Fleets";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(36, 322);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(175, 29);
            this.label7.TabIndex = 14;
            this.label7.Text = "Target Faction:";
            // 
            // lbl_Waypoints
            // 
            this.lbl_Waypoints.AutoSize = true;
            this.lbl_Waypoints.Location = new System.Drawing.Point(36, 152);
            this.lbl_Waypoints.Name = "lbl_Waypoints";
            this.lbl_Waypoints.Size = new System.Drawing.Size(124, 29);
            this.lbl_Waypoints.TabIndex = 11;
            this.lbl_Waypoints.Text = "Waypoints";
            // 
            // cbx_newOwner
            // 
            this.cbx_newOwner.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbx_newOwner.FormattingEnabled = true;
            this.cbx_newOwner.Location = new System.Drawing.Point(40, 355);
            this.cbx_newOwner.Name = "cbx_newOwner";
            this.cbx_newOwner.Size = new System.Drawing.Size(310, 37);
            this.cbx_newOwner.TabIndex = 13;
            // 
            // cbx_fleet
            // 
            this.cbx_fleet.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbx_fleet.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbx_fleet.FormattingEnabled = true;
            this.cbx_fleet.Location = new System.Drawing.Point(14, 42);
            this.cbx_fleet.Name = "cbx_fleet";
            this.cbx_fleet.Size = new System.Drawing.Size(336, 37);
            this.cbx_fleet.TabIndex = 5;
            this.cbx_fleet.SelectedIndexChanged += new System.EventHandler(this.cbx_fleet_SelectedIndexChanged);
            // 
            // btn_TransferOwners
            // 
            this.btn_TransferOwners.BackColor = System.Drawing.Color.DarkBlue;
            this.btn_TransferOwners.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btn_TransferOwners.Location = new System.Drawing.Point(41, 398);
            this.btn_TransferOwners.Name = "btn_TransferOwners";
            this.btn_TransferOwners.Size = new System.Drawing.Size(309, 42);
            this.btn_TransferOwners.TabIndex = 12;
            this.btn_TransferOwners.Text = "Transfer Ownership";
            this.btn_TransferOwners.UseVisualStyleBackColor = false;
            this.btn_TransferOwners.Click += new System.EventHandler(this.btn_TransferOwners_Click);
            // 
            // cbx_waypoints
            // 
            this.cbx_waypoints.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbx_waypoints.FormattingEnabled = true;
            this.cbx_waypoints.Location = new System.Drawing.Point(40, 185);
            this.cbx_waypoints.Name = "cbx_waypoints";
            this.cbx_waypoints.Size = new System.Drawing.Size(310, 37);
            this.cbx_waypoints.TabIndex = 10;
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
            // 
            // btn_teleportFleet
            // 
            this.btn_teleportFleet.BackColor = System.Drawing.Color.DarkBlue;
            this.btn_teleportFleet.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btn_teleportFleet.Location = new System.Drawing.Point(41, 228);
            this.btn_teleportFleet.Name = "btn_teleportFleet";
            this.btn_teleportFleet.Size = new System.Drawing.Size(309, 42);
            this.btn_teleportFleet.TabIndex = 7;
            this.btn_teleportFleet.Text = "Teleport to Waypoint";
            this.btn_teleportFleet.UseVisualStyleBackColor = false;
            this.btn_teleportFleet.Click += new System.EventHandler(this.btn_teleportFleet_Click);
            // 
            // lbl_Fleet_Actions
            // 
            this.lbl_Fleet_Actions.AutoSize = true;
            this.lbl_Fleet_Actions.Location = new System.Drawing.Point(8, 123);
            this.lbl_Fleet_Actions.Name = "lbl_Fleet_Actions";
            this.lbl_Fleet_Actions.Size = new System.Drawing.Size(152, 29);
            this.lbl_Fleet_Actions.TabIndex = 8;
            this.lbl_Fleet_Actions.Text = "Fleet Actions";
            // 
            // tab_CivFleets
            // 
            this.tab_CivFleets.BackColor = System.Drawing.Color.MediumBlue;
            this.tab_CivFleets.Controls.Add(this.cbx_shippingFleets);
            this.tab_CivFleets.Controls.Add(this.lbl_shippingLines);
            this.tab_CivFleets.Controls.Add(this.cbx_shippingLines);
            this.tab_CivFleets.Controls.Add(this.lbl_shippingFleets);
            this.tab_CivFleets.ForeColor = System.Drawing.Color.Lime;
            this.tab_CivFleets.Location = new System.Drawing.Point(4, 38);
            this.tab_CivFleets.Name = "tab_CivFleets";
            this.tab_CivFleets.Padding = new System.Windows.Forms.Padding(3);
            this.tab_CivFleets.Size = new System.Drawing.Size(372, 483);
            this.tab_CivFleets.TabIndex = 2;
            this.tab_CivFleets.Text = "Civ. Fleets";
            // 
            // cbx_shippingFleets
            // 
            this.cbx_shippingFleets.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbx_shippingFleets.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbx_shippingFleets.FormattingEnabled = true;
            this.cbx_shippingFleets.Location = new System.Drawing.Point(8, 118);
            this.cbx_shippingFleets.Name = "cbx_shippingFleets";
            this.cbx_shippingFleets.Size = new System.Drawing.Size(487, 37);
            this.cbx_shippingFleets.TabIndex = 10;
            // 
            // lbl_shippingLines
            // 
            this.lbl_shippingLines.AutoSize = true;
            this.lbl_shippingLines.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_shippingLines.ForeColor = System.Drawing.Color.Lime;
            this.lbl_shippingLines.Location = new System.Drawing.Point(3, 3);
            this.lbl_shippingLines.Name = "lbl_shippingLines";
            this.lbl_shippingLines.Size = new System.Drawing.Size(155, 29);
            this.lbl_shippingLines.TabIndex = 8;
            this.lbl_shippingLines.Text = "Civ. Shipping";
            // 
            // cbx_shippingLines
            // 
            this.cbx_shippingLines.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbx_shippingLines.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbx_shippingLines.FormattingEnabled = true;
            this.cbx_shippingLines.Location = new System.Drawing.Point(8, 35);
            this.cbx_shippingLines.Name = "cbx_shippingLines";
            this.cbx_shippingLines.Size = new System.Drawing.Size(487, 37);
            this.cbx_shippingLines.TabIndex = 7;
            this.cbx_shippingLines.SelectedIndexChanged += new System.EventHandler(this.cbx_shippingLines_SelectedIndexChanged);
            // 
            // lbl_shippingFleets
            // 
            this.lbl_shippingFleets.AutoSize = true;
            this.lbl_shippingFleets.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_shippingFleets.ForeColor = System.Drawing.Color.Lime;
            this.lbl_shippingFleets.Location = new System.Drawing.Point(2, 86);
            this.lbl_shippingFleets.Name = "lbl_shippingFleets";
            this.lbl_shippingFleets.Size = new System.Drawing.Size(188, 29);
            this.lbl_shippingFleets.TabIndex = 9;
            this.lbl_shippingFleets.Text = "Shipping Fleets:";
            // 
            // tab_Colonies
            // 
            this.tab_Colonies.BackColor = System.Drawing.Color.MediumBlue;
            this.tab_Colonies.Controls.Add(this.label10);
            this.tab_Colonies.Controls.Add(this.cbx_newArmyOwner);
            this.tab_Colonies.Controls.Add(this.btn_transferArmyOwner);
            this.tab_Colonies.Controls.Add(this.label11);
            this.tab_Colonies.Controls.Add(this.cbx_Army);
            this.tab_Colonies.Controls.Add(this.cbx_colonies);
            this.tab_Colonies.Controls.Add(this.label1);
            this.tab_Colonies.ForeColor = System.Drawing.Color.Lime;
            this.tab_Colonies.Location = new System.Drawing.Point(4, 38);
            this.tab_Colonies.Name = "tab_Colonies";
            this.tab_Colonies.Padding = new System.Windows.Forms.Padding(3);
            this.tab_Colonies.Size = new System.Drawing.Size(372, 483);
            this.tab_Colonies.TabIndex = 1;
            this.tab_Colonies.Text = "Colonies";
            // 
            // cbx_colonies
            // 
            this.cbx_colonies.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbx_colonies.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbx_colonies.FormattingEnabled = true;
            this.cbx_colonies.Location = new System.Drawing.Point(6, 34);
            this.cbx_colonies.Name = "cbx_colonies";
            this.cbx_colonies.Size = new System.Drawing.Size(344, 37);
            this.cbx_colonies.TabIndex = 7;
            this.cbx_colonies.SelectedIndexChanged += new System.EventHandler(this.cbx_colonies_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Lime;
            this.label1.Location = new System.Drawing.Point(2, 2);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(109, 29);
            this.label1.TabIndex = 8;
            this.label1.Text = "Colonies";
            // 
            // cbx_faction
            // 
            this.cbx_faction.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbx_faction.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbx_faction.FormattingEnabled = true;
            this.cbx_faction.Location = new System.Drawing.Point(106, 55);
            this.cbx_faction.Name = "cbx_faction";
            this.cbx_faction.Size = new System.Drawing.Size(256, 37);
            this.cbx_faction.TabIndex = 3;
            this.cbx_faction.SelectedIndexChanged += new System.EventHandler(this.cbx_faction_SelectedIndexChanged);
            // 
            // lbl_Faction
            // 
            this.lbl_Faction.AutoSize = true;
            this.lbl_Faction.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Faction.ForeColor = System.Drawing.Color.Lime;
            this.lbl_Faction.Location = new System.Drawing.Point(3, 58);
            this.lbl_Faction.Name = "lbl_Faction";
            this.lbl_Faction.Size = new System.Drawing.Size(98, 29);
            this.lbl_Faction.TabIndex = 4;
            this.lbl_Faction.Text = "Faction:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(608, 160);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(127, 29);
            this.label3.TabIndex = 18;
            this.label3.Text = "New Level";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(453, 160);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(92, 29);
            this.label2.TabIndex = 17;
            this.label2.Text = "Current";
            // 
            // btn_updateTraining
            // 
            this.btn_updateTraining.BackColor = System.Drawing.Color.DarkBlue;
            this.btn_updateTraining.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btn_updateTraining.Location = new System.Drawing.Point(420, 194);
            this.btn_updateTraining.Name = "btn_updateTraining";
            this.btn_updateTraining.Size = new System.Drawing.Size(327, 42);
            this.btn_updateTraining.TabIndex = 16;
            this.btn_updateTraining.Text = "Upgrade Single";
            this.btn_updateTraining.UseVisualStyleBackColor = false;
            this.btn_updateTraining.Click += new System.EventHandler(this.btn_updateTraining_Click);
            // 
            // tbx_CurrentTrain
            // 
            this.tbx_CurrentTrain.BackColor = System.Drawing.SystemColors.Control;
            this.tbx_CurrentTrain.Cursor = System.Windows.Forms.Cursors.No;
            this.tbx_CurrentTrain.Location = new System.Drawing.Point(420, 121);
            this.tbx_CurrentTrain.Name = "tbx_CurrentTrain";
            this.tbx_CurrentTrain.ReadOnly = true;
            this.tbx_CurrentTrain.Size = new System.Drawing.Size(152, 35);
            this.tbx_CurrentTrain.TabIndex = 15;
            // 
            // tbx_Adjustment
            // 
            this.tbx_Adjustment.Location = new System.Drawing.Point(597, 121);
            this.tbx_Adjustment.Name = "tbx_Adjustment";
            this.tbx_Adjustment.Size = new System.Drawing.Size(150, 35);
            this.tbx_Adjustment.TabIndex = 14;
            // 
            // lbl_TrainingGrade
            // 
            this.lbl_TrainingGrade.AutoSize = true;
            this.lbl_TrainingGrade.Location = new System.Drawing.Point(414, 78);
            this.lbl_TrainingGrade.Name = "lbl_TrainingGrade";
            this.lbl_TrainingGrade.Size = new System.Drawing.Size(236, 29);
            this.lbl_TrainingGrade.TabIndex = 13;
            this.lbl_TrainingGrade.Text = "Fleet Training Grade";
            // 
            // lbx_ships
            // 
            this.lbx_ships.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbx_ships.FormattingEnabled = true;
            this.lbx_ships.ItemHeight = 29;
            this.lbx_ships.Location = new System.Drawing.Point(25, 85);
            this.lbx_ships.Name = "lbx_ships";
            this.lbx_ships.Size = new System.Drawing.Size(374, 555);
            this.lbx_ships.TabIndex = 5;
            this.lbx_ships.SelectedIndexChanged += new System.EventHandler(this.lbx_ships_SelectedIndexChanged);
            // 
            // MilShipPanel
            // 
            this.MilShipPanel.Controls.Add(this.btn_CrewAdjustAll);
            this.MilShipPanel.Controls.Add(this.label4);
            this.MilShipPanel.Controls.Add(this.label5);
            this.MilShipPanel.Controls.Add(this.btn_UpdateCrew);
            this.MilShipPanel.Controls.Add(this.tbx_CurrentCrew);
            this.MilShipPanel.Controls.Add(this.label6);
            this.MilShipPanel.Controls.Add(this.tbx_CrewAjustment);
            this.MilShipPanel.Controls.Add(this.btn_applyAll);
            this.MilShipPanel.Controls.Add(this.label3);
            this.MilShipPanel.Controls.Add(this.lbl_MilShips);
            this.MilShipPanel.Controls.Add(this.label2);
            this.MilShipPanel.Controls.Add(this.lbx_ships);
            this.MilShipPanel.Controls.Add(this.btn_updateTraining);
            this.MilShipPanel.Controls.Add(this.tbx_CurrentTrain);
            this.MilShipPanel.Controls.Add(this.lbl_TrainingGrade);
            this.MilShipPanel.Controls.Add(this.tbx_Adjustment);
            this.MilShipPanel.Enabled = false;
            this.MilShipPanel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.MilShipPanel.ForeColor = System.Drawing.Color.Lime;
            this.MilShipPanel.Location = new System.Drawing.Point(445, 55);
            this.MilShipPanel.Name = "MilShipPanel";
            this.MilShipPanel.Size = new System.Drawing.Size(794, 985);
            this.MilShipPanel.TabIndex = 4;
            this.MilShipPanel.Visible = false;
            // 
            // btn_CrewAdjustAll
            // 
            this.btn_CrewAdjustAll.BackColor = System.Drawing.Color.DarkBlue;
            this.btn_CrewAdjustAll.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btn_CrewAdjustAll.Location = new System.Drawing.Point(420, 598);
            this.btn_CrewAdjustAll.Name = "btn_CrewAdjustAll";
            this.btn_CrewAdjustAll.Size = new System.Drawing.Size(327, 42);
            this.btn_CrewAdjustAll.TabIndex = 26;
            this.btn_CrewAdjustAll.Text = "Apply To All";
            this.btn_CrewAdjustAll.UseVisualStyleBackColor = false;
            this.btn_CrewAdjustAll.Click += new System.EventHandler(this.btn_CrewAdjustAll_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(608, 516);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(127, 29);
            this.label4.TabIndex = 25;
            this.label4.Text = "New Level";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(453, 516);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(92, 29);
            this.label5.TabIndex = 24;
            this.label5.Text = "Current";
            // 
            // btn_UpdateCrew
            // 
            this.btn_UpdateCrew.BackColor = System.Drawing.Color.DarkBlue;
            this.btn_UpdateCrew.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btn_UpdateCrew.Location = new System.Drawing.Point(420, 550);
            this.btn_UpdateCrew.Name = "btn_UpdateCrew";
            this.btn_UpdateCrew.Size = new System.Drawing.Size(327, 42);
            this.btn_UpdateCrew.TabIndex = 23;
            this.btn_UpdateCrew.Text = "Upgrade Single";
            this.btn_UpdateCrew.UseVisualStyleBackColor = false;
            this.btn_UpdateCrew.Click += new System.EventHandler(this.btn_UpdateCrew_Click);
            // 
            // tbx_CurrentCrew
            // 
            this.tbx_CurrentCrew.Cursor = System.Windows.Forms.Cursors.No;
            this.tbx_CurrentCrew.Location = new System.Drawing.Point(420, 477);
            this.tbx_CurrentCrew.Name = "tbx_CurrentCrew";
            this.tbx_CurrentCrew.ReadOnly = true;
            this.tbx_CurrentCrew.Size = new System.Drawing.Size(152, 35);
            this.tbx_CurrentCrew.TabIndex = 22;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(414, 434);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(220, 29);
            this.label6.TabIndex = 20;
            this.label6.Text = "Ship Crew Training";
            // 
            // tbx_CrewAjustment
            // 
            this.tbx_CrewAjustment.Location = new System.Drawing.Point(597, 477);
            this.tbx_CrewAjustment.Name = "tbx_CrewAjustment";
            this.tbx_CrewAjustment.Size = new System.Drawing.Size(150, 35);
            this.tbx_CrewAjustment.TabIndex = 21;
            // 
            // btn_applyAll
            // 
            this.btn_applyAll.BackColor = System.Drawing.Color.DarkBlue;
            this.btn_applyAll.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btn_applyAll.Location = new System.Drawing.Point(420, 242);
            this.btn_applyAll.Name = "btn_applyAll";
            this.btn_applyAll.Size = new System.Drawing.Size(327, 42);
            this.btn_applyAll.TabIndex = 19;
            this.btn_applyAll.Text = "Apply To All";
            this.btn_applyAll.UseVisualStyleBackColor = false;
            this.btn_applyAll.Click += new System.EventHandler(this.btn_applyAll_Click);
            // 
            // lbl_MilShips
            // 
            this.lbl_MilShips.AutoSize = true;
            this.lbl_MilShips.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lbl_MilShips.ForeColor = System.Drawing.Color.Lime;
            this.lbl_MilShips.Location = new System.Drawing.Point(20, 53);
            this.lbl_MilShips.Name = "lbl_MilShips";
            this.lbl_MilShips.Size = new System.Drawing.Size(162, 29);
            this.lbl_MilShips.TabIndex = 6;
            this.lbl_MilShips.Text = "Military Ships:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(34, 331);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(175, 29);
            this.label10.TabIndex = 22;
            this.label10.Text = "Target Faction:";
            // 
            // cbx_newArmyOwner
            // 
            this.cbx_newArmyOwner.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbx_newArmyOwner.FormattingEnabled = true;
            this.cbx_newArmyOwner.Location = new System.Drawing.Point(11, 364);
            this.cbx_newArmyOwner.Name = "cbx_newArmyOwner";
            this.cbx_newArmyOwner.Size = new System.Drawing.Size(339, 37);
            this.cbx_newArmyOwner.TabIndex = 21;
            // 
            // btn_transferArmyOwner
            // 
            this.btn_transferArmyOwner.BackColor = System.Drawing.Color.DarkBlue;
            this.btn_transferArmyOwner.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btn_transferArmyOwner.Location = new System.Drawing.Point(11, 414);
            this.btn_transferArmyOwner.Name = "btn_transferArmyOwner";
            this.btn_transferArmyOwner.Size = new System.Drawing.Size(339, 42);
            this.btn_transferArmyOwner.TabIndex = 20;
            this.btn_transferArmyOwner.Text = "Transfer Ownership of Army";
            this.btn_transferArmyOwner.UseVisualStyleBackColor = false;
            this.btn_transferArmyOwner.Click += new System.EventHandler(this.btn_transferArmyOwner_Click);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(6, 250);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(147, 29);
            this.label11.TabIndex = 19;
            this.label11.Text = "Ground Unit:";
            // 
            // cbx_Army
            // 
            this.cbx_Army.FormattingEnabled = true;
            this.cbx_Army.Location = new System.Drawing.Point(9, 282);
            this.cbx_Army.Name = "cbx_Army";
            this.cbx_Army.Size = new System.Drawing.Size(341, 37);
            this.cbx_Army.TabIndex = 18;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MediumBlue;
            this.ClientSize = new System.Drawing.Size(1236, 1051);
            this.Controls.Add(this.MilShipPanel);
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
            this.tab_CivFleets.ResumeLayout(false);
            this.tab_CivFleets.PerformLayout();
            this.tab_Colonies.ResumeLayout(false);
            this.tab_Colonies.PerformLayout();
            this.MilShipPanel.ResumeLayout(false);
            this.MilShipPanel.PerformLayout();
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
        private System.Windows.Forms.ComboBox cbx_shippingLines;
        private System.Windows.Forms.Label lbl_shippingLines;
        private System.Windows.Forms.ComboBox cbx_shippingFleets;
        private System.Windows.Forms.Label lbl_shippingFleets;
        private System.Windows.Forms.TabPage tab_CivFleets;
        private System.Windows.Forms.ComboBox cbx_colonies;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbl_Fleet_Actions;
        private System.Windows.Forms.Button btn_teleportFleet;
        private System.Windows.Forms.Label lbl_Waypoints;
        private System.Windows.Forms.ComboBox cbx_waypoints;
        private System.Windows.Forms.Button btn_updateTraining;
        private System.Windows.Forms.TextBox tbx_CurrentTrain;
        private System.Windows.Forms.TextBox tbx_Adjustment;
        private System.Windows.Forms.Label lbl_TrainingGrade;
        private System.Windows.Forms.ListBox lbx_ships;
        private System.Windows.Forms.Panel MilShipPanel;
        private System.Windows.Forms.Label lbl_MilShips;
        private System.Windows.Forms.ToolStripMenuItem gameFileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem gameDirectoryToolStripMenuItem;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btn_applyAll;
        private System.Windows.Forms.Button btn_CrewAdjustAll;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btn_UpdateCrew;
        private System.Windows.Forms.TextBox tbx_CurrentCrew;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox tbx_CrewAjustment;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox cbx_newOwner;
        private System.Windows.Forms.Button btn_TransferOwners;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ComboBox cbx_newArmyOwner;
        private System.Windows.Forms.Button btn_transferArmyOwner;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.ComboBox cbx_Army;
    }
}

