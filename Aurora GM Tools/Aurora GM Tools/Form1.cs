using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Aurora_GM_Tools.Classes;

namespace Aurora_GM_Tools
{
    public partial class Form1 : Form
    {
        private Scribe librarian;
        private string gameLocation;

        private Point activeAnchor = new Point(298, 36);
        private Point storageAnchor = new Point(1000, 1000);

        private bool venusFlag = false;
        private string venusText = "Venusian Military Board";
        private Color[] bgColors = { Color.MediumBlue, ColorTranslator.FromHtml("#FCD116") };
        private Color[] btnColors = { Color.DarkBlue, ColorTranslator.FromHtml("#C6891F") };
        private Color[] foreColors = { Color.Lime, ColorTranslator.FromHtml("#F20D0D") };

        public Form1()
        {
            InitializeComponent();
            librarian = new Scribe();

            DisableDisplay();

        }

        private void CheckForVenus()
        {
            if (librarian.gameLoaded)
            {
                if (cbx_faction.SelectedItem.ToString() == venusText && !venusFlag)
                {
                    RecursiveChange(this, 1);
                }
                else if (cbx_faction.SelectedItem.ToString() != venusText && venusFlag)
                {
                    RecursiveChange(this, 0);
                }
            }
        }

        private void RecursiveChange(Control parent, int val)
        {
            if (!(parent is ComboBox) && !(parent is MenuStrip) && !(parent is TextBox) && !(parent is ListBox))
            {
                if (parent is Button)
                    parent.BackColor = btnColors[val];
                else
                    parent.BackColor = bgColors[val];
                parent.ForeColor = foreColors[val];
                if (parent.Controls.Count > 0)
                    foreach (Control ctrl in parent.Controls)
                        RecursiveChange(ctrl, val);
            }
            return;
        }

        private void gameFileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            librarian.gameLoaded = false;
            ResetDropdowns();
            OpenFileDialog openFile = new OpenFileDialog();
            DialogResult result = openFile.ShowDialog();
            if (result == DialogResult.OK)
            {
                gameLocation = openFile.FileName.ToString();
                librarian.ChangeGamesFile(gameLocation);

                PopulateGamesDropdown();
                MilShipPanel.Enabled = true;
                MilShipPanel.Visible = true;
            }

            return;
        }

        private void gameDirectoryToolStripMenuItem_Click(object sender, EventArgs e)
        {
            librarian.gameLoaded = false;
            ResetDropdowns();
            FolderBrowserDialog openFolder = new FolderBrowserDialog();
            DialogResult result = openFolder.ShowDialog();
            if (result == DialogResult.OK)
            {
                gameLocation = openFolder.SelectedPath.ToString();
                librarian.ChangeGames(gameLocation);

                PopulateGamesDropdown();
                MilShipPanel.Enabled = true;
                MilShipPanel.Visible = true;
            }

            return;
        }
        
        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
            return;
        }

        private void closeGameToolStripMenuItem_Click(object sender, EventArgs e)
        {
            librarian.gameLoaded = false;
            ResetDropdowns();
            librarian.CloseGame();
            DisableDisplay();
            return;
        }

        private void DisableDisplay()
        {
            //Main Game Load
            GameControlsPanel.Visible = false;
            GameControlsPanel.Enabled = false;

            MilShipPanel.Visible = false;
            MilShipPanel.Enabled = false;
            return;
        }

        private void PopulateGamesDropdown()
        {
            cbx_gamesList.Items.Clear();

            cbx_gamesList.Items.AddRange(librarian.GetGamesList());

            if (cbx_gamesList.Items.Count > 0)
                cbx_gamesList.SelectedIndex = 0;

            PopulateFactionDropdown();

            GameControlsPanel.Visible = true;
            GameControlsPanel.Enabled = true;

            return;
        }

        private void PopulateFactionDropdown()
        {
            cbx_faction.Items.Clear();

            cbx_faction.Items.AddRange(librarian.GetFactionList(cbx_gamesList.SelectedIndex));

            if (cbx_faction.Items.Count > 0)
                cbx_faction.SelectedIndex = 0;

            tbctl_SelectionOptions.Visible = true;
            tbctl_SelectionOptions.Enabled = true;

            PopulateFleetDropdown();
            PopulateShippingDropdown();
            PopulateColoniesDropdown();
            return;
        }

        private void PopulateFleetDropdown()
        {
            cbx_fleet.Items.Clear();

            cbx_fleet.Items.AddRange(librarian.GetFleetList(cbx_gamesList.SelectedIndex, cbx_faction.SelectedIndex));

            if (cbx_fleet.Items.Count > 0)
                cbx_fleet.SelectedIndex = 0;

            PopulateWaypointsDropdown();
            PopulateMilShipsList();
            return;
        }

        private void PopulateShippingDropdown()
        {
            cbx_shippingLines.Items.Clear();

            cbx_shippingLines.Items.AddRange(librarian.GetShippingList(cbx_gamesList.SelectedIndex, cbx_faction.SelectedIndex));

            if (cbx_shippingLines.Items.Count > 0)
                cbx_shippingLines.SelectedIndex = 0;

            PopulateShippingFleetsDropdown();

            return;
        }

        private void PopulateShippingFleetsDropdown()
        {
            cbx_shippingFleets.Items.Clear();

            cbx_shippingFleets.Items.AddRange(librarian.GetShippingFleets(cbx_gamesList.SelectedIndex, cbx_faction.SelectedIndex, cbx_shippingLines.SelectedIndex));

            if (cbx_shippingFleets.Items.Count > 0)
                cbx_shippingFleets.SelectedIndex = 0;
        }

        private void PopulateColoniesDropdown()
        {
            cbx_colonies.Items.Clear();

            cbx_colonies.Items.AddRange(librarian.GetColoniesList(cbx_gamesList.SelectedIndex, cbx_faction.SelectedIndex));

            if (cbx_colonies.Items.Count > 0)
                cbx_colonies.SelectedIndex = 0;

            return;
        }

        private void PopulateWaypointsDropdown()
        {
            cbx_waypoints.Items.Clear();

            cbx_waypoints.Items.AddRange(librarian.GetWaypoints(cbx_gamesList.SelectedIndex));

            if (cbx_waypoints.Items.Count > 0)
                cbx_waypoints.SelectedIndex = 0;

            return;
        }

        private void PopulateMilShipsList()
        {
            lbx_ships.Items.Clear();

            lbx_ships.Items.AddRange(librarian.GetMilShipsList(cbx_gamesList.SelectedIndex, cbx_faction.SelectedIndex, cbx_fleet.SelectedIndex));

            if (lbx_ships.Items.Count > 0)
                lbx_ships.SelectedIndex = 0;

            PopulateFleetTraining();
            PopulateCrewTraining();

            return;
        }

        private void PopulateFleetTraining()
        {
            tbx_CurrentTrain.Text = librarian.GetFleetTraining(cbx_gamesList.SelectedIndex, cbx_faction.SelectedIndex, cbx_fleet.SelectedIndex, lbx_ships.SelectedIndex);
            return;
        }

        private void PopulateCrewTraining()
        {
            tbx_CurrentCrew.Text = librarian.GetCrewTraining(cbx_gamesList.SelectedIndex, cbx_faction.SelectedIndex, cbx_fleet.SelectedIndex, lbx_ships.SelectedIndex);
            return;
        }

        private void ResetDropdowns()
        {
            cbx_gamesList.SelectedIndex = -1;
            cbx_gamesList.Items.Clear();

            cbx_faction.SelectedIndex = -1;
            cbx_faction.Items.Clear();

            cbx_fleet.SelectedIndex = -1;
            cbx_fleet.Items.Clear();

            cbx_shippingLines.SelectedIndex = -1;
            cbx_shippingLines.Items.Clear();

            cbx_shippingFleets.SelectedIndex = -1;
            cbx_shippingFleets.Items.Clear();

            cbx_colonies.SelectedIndex = -1;
            cbx_colonies.Items.Clear();

            cbx_waypoints.SelectedIndex = -1;
            cbx_waypoints.Items.Clear();

            return;
        }

        private void cbx_gamesList_SelectedIndexChanged(object sender, EventArgs e)
        {
            PopulateFactionDropdown();
            PopulateShippingDropdown();
            return;
        }

        private void cbx_faction_SelectedIndexChanged(object sender, EventArgs e)
        {
            PopulateFleetDropdown();
            PopulateShippingDropdown();
            PopulateColoniesDropdown();
            CheckForVenus();
            return;
        }

        private void cbx_shippingLines_SelectedIndexChanged(object sender, EventArgs e)
        {
            PopulateShippingFleetsDropdown();
            return;
        }

        private void cbx_fleet_SelectedIndexChanged(object sender, EventArgs e)
        {
            PopulateMilShipsList();
            PopulateFleetTraining();
            PopulateCrewTraining();
            return;
        }

        private void btn_teleportFleet_Click(object sender, EventArgs e)
        {
            bool rv = librarian.TeleportFleet(cbx_gamesList.SelectedIndex, cbx_faction.SelectedIndex, cbx_fleet.SelectedIndex, cbx_waypoints.SelectedIndex);
            if (!rv)
                MessageBox.Show("There was an Error in attempting to Teleport the fleet.\nWas there a Valid Waypoint?");
            return;
        }

        private void tbctl_SelectionOptions_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (tbctl_SelectionOptions.SelectedTab.Text == "Mil. Fleets")
            {
                MilShipPanel.Visible = true;
                MilShipPanel.Enabled = true;
                MilShipPanel.Location = activeAnchor;
            }
            else
            {
                MilShipPanel.Visible = false;
                MilShipPanel.Enabled = false;
                MilShipPanel.Location = storageAnchor;
            }
        }

        private void btn_updateTraining_Click(object sender, EventArgs e)
        {
            double adjustedValue;
            double.TryParse(tbx_Adjustment.Text, out adjustedValue);
            
            if (adjustedValue > 0 && adjustedValue <= 500)
            {
                librarian.UpdateTrainingGrade(cbx_gamesList.SelectedIndex, cbx_faction.SelectedIndex, cbx_fleet.SelectedIndex, lbx_ships.SelectedIndex, adjustedValue);
            }
            else
            {
                MessageBox.Show("The New Value must be a number between 0 and 500.");
            }
            
            PopulateFleetTraining();
            return;
        }

        private void lbx_ships_SelectedIndexChanged(object sender, EventArgs e)
        {
            PopulateFleetTraining();
            PopulateCrewTraining();
        }

        private void btn_applyAll_Click(object sender, EventArgs e)
        {
            double adjustedValue;
            double.TryParse(tbx_Adjustment.Text, out adjustedValue);

            if (adjustedValue > 0 && adjustedValue <= 500)
            {
                for (int i = 0; i < lbx_ships.Items.Count; i++)
                    librarian.UpdateTrainingGrade(cbx_gamesList.SelectedIndex, cbx_faction.SelectedIndex, cbx_fleet.SelectedIndex, i, adjustedValue);
            }
            else
            {
                MessageBox.Show("The New Value must be a number between 0 and 500.");
            }

            PopulateFleetTraining();
            return;
        }

        private void btn_UpdateCrew_Click(object sender, EventArgs e)
        {
            double adjustedValue;
            double.TryParse(tbx_CrewAjustment.Text, out adjustedValue);

            if (adjustedValue > 0 && adjustedValue <= 10000)
            {
                librarian.UpdateCrewGrade(cbx_gamesList.SelectedIndex, cbx_faction.SelectedIndex, cbx_fleet.SelectedIndex, lbx_ships.SelectedIndex, adjustedValue);
            }
            else
            {
                MessageBox.Show("The New Value must be a number between 0 and 1000.");
            }

            PopulateCrewTraining();
            return;
        }

        private void btn_CrewAdjustAll_Click(object sender, EventArgs e)
        {
            double adjustedValue;
            double.TryParse(tbx_CrewAjustment.Text, out adjustedValue);

            if (adjustedValue > 0 && adjustedValue <= 10000)
            {
                for (int i = 0; i < lbx_ships.Items.Count; i++)
                    librarian.UpdateCrewGrade(cbx_gamesList.SelectedIndex, cbx_faction.SelectedIndex, cbx_fleet.SelectedIndex, i, adjustedValue);
            }
            else
            {
                MessageBox.Show("The New Value must be a number between 0 and 1000.");
            }

            PopulateCrewTraining();
            return;
        }
    }
}
