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
        private string[] gamesList;
        private string[] factionsList;

        public Form1()
        {
            InitializeComponent();
            librarian = new Scribe();
            DisableDisplay();
        }

        private void openGameFileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ResetDropdowns();
            FolderBrowserDialog openFolder = new FolderBrowserDialog();
            DialogResult result = openFolder.ShowDialog();
            if (result == DialogResult.OK)
            {
                gameLocation = openFolder.SelectedPath.ToString();
                librarian.ChangeGames(gameLocation);

                PopulateGamesDropdown();
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

            return;
        }

        private void PopulateGamesDropdown()
        {
            cbx_gamesList.Items.Clear();

            cbx_gamesList.Items.AddRange(librarian.GetGamesList());

            if(cbx_gamesList.Items.Count > 0)
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
            return;
        }

        private void cbx_shippingLines_SelectedIndexChanged(object sender, EventArgs e)
        {
            PopulateShippingFleetsDropdown();
            return;
        }
    }
}
