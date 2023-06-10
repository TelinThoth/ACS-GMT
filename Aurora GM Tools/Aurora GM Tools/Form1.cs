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
            GameControlsPanel.Visible = true;
            GameControlsPanel.Enabled = true;
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

            cbx_gamesList.Enabled = true;
            cbx_gamesList.Visible = true;

            cbx_gamesList.SelectedIndex = 0;
            
            lbl_gameList.Visible = true;

            PopulateFactionDropdown();
            return;
        }

        private void PopulateFactionDropdown()
        {
            cbx_faction.Items.Clear();

            cbx_faction.Items.AddRange(librarian.GetFactionList(cbx_gamesList.SelectedIndex));

            cbx_faction.Enabled = true;
            cbx_faction.Visible = true;

            cbx_faction.SelectedIndex = 0;

            lbl_Faction.Visible = true;

            PopulateFleetDropdown();
            return;
        }

        private void PopulateFleetDropdown()
        {
            cbx_fleet.Items.Clear();

            cbx_fleet.Items.AddRange(librarian.GetFleetList(cbx_gamesList.SelectedIndex, cbx_faction.SelectedIndex));

            cbx_fleet.Enabled = true;
            cbx_fleet.Visible = true;

            cbx_fleet.SelectedIndex = 0;

            lbl_fleet.Visible = true;

            tbctl_SelectionOptions.Visible = true;
            tbctl_SelectionOptions.Enabled = true;

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
