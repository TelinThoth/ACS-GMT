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
                string tmp = librarian.GetGamesList();
            }
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
