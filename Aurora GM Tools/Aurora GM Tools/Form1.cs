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

            cbx_faction.SelectedIndex = 0;

            tbctl_SelectionOptions.Visible = true;
            tbctl_SelectionOptions.Enabled = true;

            PopulateFleetDropdown();
            PopulateShippingDropdown();
            return;
        }

        private void PopulateFleetDropdown()
        {
            cbx_fleet.Items.Clear();

            cbx_fleet.Items.AddRange(librarian.GetFleetList(cbx_gamesList.SelectedIndex, cbx_faction.SelectedIndex));

            cbx_fleet.SelectedIndex = 0;

            return;
        }

        private void PopulateShippingDropdown()
        {
            cbx_shippingLines.Items.Clear();

            cbx_shippingLines.Items.AddRange(librarian.GetShippingList(cbx_gamesList.SelectedIndex, cbx_faction.SelectedIndex));

            cbx_shippingLines.SelectedIndex = 0;

            return;
        }

        private void cbx_gamesList_SelectedIndexChanged(object sender, EventArgs e)
        {
            PopulateFactionDropdown();
            return;
        }

        private void cbx_faction_SelectedIndexChanged(object sender, EventArgs e)
        {
            PopulateFleetDropdown();
            return;
        }
    }
}
