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

        public List<Faction> factionsList;

        public Game()
        {
            factionsList = new List<Faction>();
        }
        public Game(string i_gameName, int i_gameID)
        {
            gameName = i_gameName;
            gameID = i_gameID;

            factionsList = new List<Faction>();
        }
    }
}
