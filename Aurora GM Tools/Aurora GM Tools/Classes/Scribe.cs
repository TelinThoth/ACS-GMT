using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SQLite;

namespace Aurora_GM_Tools.Classes
{
    class Scribe
    {
        private string fileLoc = "";
        private string fileName = "AuroraDB.db";

        private SQLiteConnection uplink = new SQLiteConnection();
        private SQLiteConnectionStringBuilder dialup = new SQLiteConnectionStringBuilder();
        public Scribe()
        {}

        ~Scribe()
        {
            //Ensure the DB Connection is closed when we deconstruct.
            if(uplink.State != ConnectionState.Closed)
                uplink.Close();
        }
        public void ChangeGames(string i_location)
        {
            //Close the DB beore we open a new one.
            if (uplink.State != ConnectionState.Closed)
                uplink.Close();

            //Update File Location
            fileLoc = i_location;

            // Correct the \->/
            fileLoc = fileLoc.Replace('\\', '/');

            //Create new string, if needed.
            dialup.DataSource = fileLoc + '/' + fileName;
            if (dialup.Version != 3)
                dialup.Version = 3;

            //Set the New connection.
            uplink.ConnectionString = dialup.ConnectionString;
            return;
        }

        public string GetGamesList()
        {
            string rv_lists = "";
            string[] rv_games = new string[1];
            int[] rv_gameIDs = new int[1];

            uplink.Open();
            using (SQLiteCommand getGames = new SQLiteCommand(uplink))
            {
                getGames.CommandText = "SELECT GameName, GameID FROM FCT_Game";
                using (SQLiteDataReader results = getGames.ExecuteReader())
                {
                    int i = 0;
                    while (results.Read())
                    {
                        if (i > 0)
                        {
                            Array.Resize(ref rv_games, i + 1);
                            Array.Resize(ref rv_gameIDs, i + 1);
                        }
                        rv_games[i] = results.GetString(0);
                        rv_gameIDs[i] = results.GetInt32(1);
                        i++;
                    }
                }
            }
            uplink.Close();

            for (int i = 0; i < rv_games.Length; i++)
            {
                if (rv_lists.Length != 0)
                    rv_lists += "|";
                rv_lists += rv_games[i] + ' ' + rv_gameIDs[i].ToString();
            }

            return rv_lists;
        }
    }
}
