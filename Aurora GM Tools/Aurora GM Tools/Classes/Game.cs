using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SQLite;

namespace Aurora_GM_Tools.Classes
{
    class Game
    {
        private string gameName;
        private int gameID;

        public string Game_Name { get { return gameName; } }
        public int Game_ID { get { return gameID; } }
        public string[] Factions_List { get { return factionsList.Select(item => item.Faction_Name).ToArray();} }

        public List<Faction> factionsList;

        public Game()
        { }
        public Game(string i_gameName, int i_gameID)
        {
            gameName = i_gameName;
            gameID = i_gameID;

            factionsList = new List<Faction>();
        }

        public void Populate(Faction i_faction)
        {
            factionsList.Add(i_faction);
            return;
        }
        
        public void PopulateFleets(int i_ID, Fleet i_fleet)
        {
            factionsList[i_ID].Populate(i_fleet);
            return;
        }
    }
}
