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
        private int navalCommandID;
        private double wealth;
        private bool playerRace;

        public List<Fleet> fleetList;
        public List<Shipping> shippingLines;
        public List<Colony> coloniesList;

        public string Faction_Name { get { return factionName; } }
        public int Faction_ID { get { return factionID; } }
        public int Naval_Command_ID { get { return navalCommandID; } }
        public double Faction_Wealth { get { return wealth; } }
        public bool Faction_IsHuman { get { return playerRace; } }

        public Faction()
        {
            fleetList = new List<Fleet>();
            shippingLines = new List<Shipping>();
            coloniesList = new List<Colony>();
        }

        public Faction(string i_factionName, int i_factionID, int i_navalID, double i_wealth, bool i_playerRace)
        {
            factionName = i_factionName;
            factionID = i_factionID;
            navalCommandID = i_navalID;
            wealth = i_wealth;
            playerRace = i_playerRace;

            fleetList = new List<Fleet>();
            shippingLines = new List<Shipping>();
            coloniesList = new List<Colony>();
        }
    }
}
