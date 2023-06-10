using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aurora_GM_Tools.Classes
{
    class Faction
    {
        private string factionName;
        private int factionID;
        private double wealth;
        private bool playerRace;
        private List<Fleet> fleetList;
        private List<Fleet> civFleetList;
        private List<Colony> coloniesList;

        public string Faction_Name { get { return factionName; } }
        public int Faction_ID { get { return factionID; } }
        public double Faction_Wealth { get { return wealth; } }
        public bool Faction_IsHuman { get { return playerRace; } }

        public string[] Fleets { get { return fleetList.Select(item => item.Fleet_Name).ToArray(); } }

        public Faction()
        { }

        public Faction(string i_factionName, int i_factionID, double i_wealth, bool i_playerRace)
        {
            factionName = i_factionName;
            factionID = i_factionID;
            wealth = i_wealth;
            playerRace = i_playerRace;

            fleetList = new List<Fleet>();
        }

        public void Populate(Fleet i_fleet)
        {
            fleetList.Add(i_fleet);
            return;
        }

        public void PopulateCivFleets(Fleet i_fleet)
        {

            return;
        }
    }
}
