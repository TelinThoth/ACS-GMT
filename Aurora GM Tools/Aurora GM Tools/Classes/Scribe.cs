﻿using System;
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

        private List<Game> gamesList;

        private SQLiteConnection uplink = new SQLiteConnection();
        private SQLiteConnectionStringBuilder dialup = new SQLiteConnectionStringBuilder();
        public Scribe()
        {
            gamesList = new List<Game>();
        }

        ~Scribe()
        {
            
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
            
            PopulateInternalGames();
            PopulateInternalFactions();
            PopulateInternalFleets();
            
            return;
        }

        private void PopulateInternalGames()
        {
            uplink.Open();
            using (SQLiteCommand getGames = new SQLiteCommand(uplink))
            {
                getGames.CommandText = "SELECT GameName, GameID FROM FCT_Game";
                using (SQLiteDataReader results = getGames.ExecuteReader())
                {
                    while (results.Read())
                    {
                        gamesList.Add(new Game(results.GetString(0), results.GetInt32(1)));
                    }
                }
            }
            uplink.Close();
            return;
        }

        private void PopulateInternalFactions()
        {
            uplink.Open();

            using (SQLiteCommand getFacts = new SQLiteCommand(uplink))
            {
                foreach (Game entry in gamesList)
                {
                    getFacts.CommandText = "SELECT RaceTitle, RaceID, WealthPoints, NPR FROM FCT_Race WHERE GameID = " + entry.Game_ID.ToString();
                    using (SQLiteDataReader results = getFacts.ExecuteReader())
                    {
                        while (results.Read())
                        {
                            entry.Populate(new Faction(results.GetString(0), results.GetInt32(1), results.GetDouble(2), !results.GetBoolean(3)));
                        }
                    }
                }
            }
            uplink.Close();
            return;
        }

        private void PopulateInternalFleets()
        {
            uplink.Open();

            using (SQLiteCommand getFleets = new SQLiteCommand(uplink))
            {
                foreach (Game entry in gamesList)
                {
                    foreach (Faction group in entry.factionsList)
                    {
                        getFleets.CommandText = "SELECT FleetName, FleetID FROM FCT_Fleet WHERE GameID = " + entry.Game_ID.ToString() + " AND RaceID = " + group.Faction_ID.ToString() + " AND CivilianFunction = 0;";
                        using (SQLiteDataReader results = getFleets.ExecuteReader())
                        {
                            while (results.Read())
                            {
                                group.Populate(new Fleet(results.GetString(0), results.GetInt32(1)));
                            }
                        }

                        getFleets.CommandText = "SELECT FleetName, FleetID FROM FCT_Fleet WHERE GameID = " + entry.Game_ID.ToString() + " AND RaceID = " + group.Faction_ID.ToString() + " AND CivilianFunction != 0;";
                    }
                }
            }
            uplink.Close();
            return;
        }

        public string[] GetGamesList()
        {
            return gamesList.Select(item => item.Game_Name).ToArray();
        }

        public string[] GetFactionList(int selection)
        {
            return gamesList[selection].Factions_List;
        }

        public string[] GetFleetList(int gameSel, int factSel)
        {
            return gamesList[gameSel].factionsList[factSel].Fleets;
        }

        public void CloseGame()
        {
            if(uplink.State != ConnectionState.Closed)
                uplink.Close();
            fileLoc = "";

            return;
        }
    }
}