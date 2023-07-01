using System;
using System.IO;
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
            gamesList.Clear();
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
            if (File.Exists(dialup.DataSource))
            {
                PopulateInternalGames();
                PopulateInternalFactions();
                PopulateInternalFleets();
                PopulateInternalShips();
                PopulateInternalColonies();
            }

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
                            entry.factionsList.Add(new Faction(results.GetString(0), results.GetInt32(1), results.GetDouble(2), !results.GetBoolean(3)));
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
                        getFleets.CommandText = "SELECT FleetName, FleetID FROM FCT_Fleet WHERE GameID = " + entry.Game_ID.ToString() + " AND RaceID = " + group.Faction_ID.ToString() + " AND ShippingLine = 0;";
                        using (SQLiteDataReader results = getFleets.ExecuteReader())
                        {
                            while (results.Read())
                            {
                                group.fleetList.Add(new Fleet(results.GetString(0), results.GetInt32(1)));
                            }
                        }

                        getFleets.CommandText = "SELECT ShortName, ShippingLineID FROM FCT_ShippingLines WHERE GameID = " + entry.Game_ID.ToString() + " AND EmpireID = " + group.Faction_ID.ToString() + ";";
                        using (SQLiteDataReader results = getFleets.ExecuteReader())
                        {
                            while (results.Read())
                            {
                                group.shippingLines.Add(new Shipping(results.GetString(0), results.GetInt32(1)));
                            }
                        }

                        foreach (Shipping line in group.shippingLines)
                        {
                            getFleets.CommandText = "SELECT FleetName, FleetID FROM FCT_Fleet WHERE GameID = " + entry.Game_ID.ToString() + " AND RaceID = " + group.Faction_ID.ToString() + " AND ShippingLine = " + line.Line_ID.ToString() + ";";
                            using (SQLiteDataReader results = getFleets.ExecuteReader())
                            {
                                while (results.Read())
                                {
                                    line.shippingFleet.Add(new Fleet(results.GetString(0), results.GetInt32(1)));
                                }
                            }
                        }
                    }
                }
            }
            uplink.Close();
            return;
        }

        private void PopulateInternalShips()
        {
            List<ShipClass> shipYard = new List<ShipClass>();

            uplink.Open();
            using (SQLiteCommand getShips = new SQLiteCommand(uplink))
            {
                foreach (Game entry in gamesList)
                {
                    foreach (Faction fact in entry.factionsList)
                    {
                        getShips.CommandText = "SELECT ClassName, ShipClassID FROM FCT_ShipClass WHERE GameID = " + entry.Game_ID.ToString() + " AND RaceID = " + fact.Faction_ID.ToString() + ";";
                        using (SQLiteDataReader results = getShips.ExecuteReader())
                        {
                            while (results.Read())
                            {
                                shipYard.Add(new ShipClass(results.GetString(0), results.GetInt32(1)));
                            }
                        }

                        foreach (Fleet flt in fact.fleetList)
                        {
                            getShips.CommandText = "SELECT ShipName, ShipID, GradePoints, ShipClassID FROM FCT_Ship WHERE GameID = " + entry.Game_ID.ToString() + " AND RaceID = " + fact.Faction_ID.ToString() + " AND FleetID = " + flt.Fleet_ID.ToString() + ";";
                            using (SQLiteDataReader results = getShips.ExecuteReader())
                            {
                                while (results.Read())
                                {
                                    flt.shipList.Add(new Ship(results.GetString(0), results.GetInt32(1), results.GetDouble(2), shipYard.Find(ele => ele.ShipClass_ID == results.GetInt32(3))));
                                }
                            }
                        }

                        foreach(Shipping shipLine in fact.shippingLines)
                        {
                            foreach (Fleet shipFlt in shipLine.shippingFleet)
                            {
                                getShips.CommandText = "SELECT ShipName, ShipID, GradePoints, ShipClassID FROM FCT_Ship WHERE GameID = " + entry.Game_ID.ToString() + " AND RaceID = " + fact.Faction_ID.ToString() + " AND FleetID = " + shipFlt.Fleet_ID.ToString() + ";";
                                using (SQLiteDataReader results = getShips.ExecuteReader())
                                {
                                    while (results.Read())
                                    {
                                        shipFlt.shipList.Add(new Ship(results.GetString(0), results.GetInt32(1), results.GetDouble(2), shipYard.Find(ele => ele.ShipClass_ID == results.GetInt32(3))));
                                    }
                                }
                            }
                        }
                    }
                }
            }
            uplink.Close();
            return;
        }

        void PopulateInternalColonies()
        {
            uplink.Open();

            using (SQLiteCommand getColony = new SQLiteCommand(uplink))
            {
                foreach (Game entry in gamesList)
                {
                    foreach (Faction fact in entry.factionsList)
                    {
                        getColony.CommandText = "SELECT PopName, PopulationID FROM FCT_Population WHERE GameID = " + entry.Game_ID.ToString() + " AND RaceID = " + fact.Faction_ID.ToString() + ";";
                        using (SQLiteDataReader results = getColony.ExecuteReader())
                        {
                            while (results.Read())
                            {
                                fact.coloniesList.Add(new Colony(results.GetString(0), results.GetInt32(1)));
                            }
                        }

                        foreach (Colony col in fact.coloniesList)
                        {
                            getColony.CommandText = "SELECT FCT_ShipDesignComponents.Name, FCT_PopComponent.ComponentID, FCT_PopComponent.Amount FROM FCT_PopComponent JOIN FCT_ShipDesignComponents ON FCT_PopComponent.ComponentID = FCT_ShipDesignComponents.SDComponentID WHERE FCT_PopComponent.GameID = " + entry.Game_ID.ToString() + " AND FCT_PopComponent.PopulationID = " + col.Col_ID.ToString() + ";";
                            using (SQLiteDataReader results = getColony.ExecuteReader())
                            {
                                while (results.Read())
                                {
                                    fact.coloniesList.Add(new Colony(results.GetString(0), results.GetInt32(1)));
                                }
                            }

                            getColony.CommandText = "SELECT FCT_ShipDesignComponents.Name, FCT_PopComponent.ComponentID, FCT_PopComponent.Amount FROM FCT_PopComponent JOIN FCT_ShipDesignComponents ON FCT_PopComponent.ComponentID = FCT_ShipDesignComponents.SDComponentID WHERE FCT_PopComponent.GameID = " + entry.Game_ID.ToString() + " AND FCT_PopComponent.PopulationID = " + col.Col_ID.ToString() + ";";
                            {

                            }
                        }
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
            string[] rv_none = { "None" };
            if (selection > -1)
                return gamesList[selection].factionsList.Select(item => item.Faction_Name).ToArray();
            else
                return rv_none;
        }

        public string[] GetFleetList(int gameSel, int factSel)
        {
            string[] rv_none = { "None" };
            if (gameSel > -1 && factSel > -1)
                return gamesList[gameSel].factionsList[factSel].fleetList.Select(item => item.Fleet_Name).ToArray();
            else
                return rv_none;
        }

        public string[] GetShippingList(int gameSel, int factSel)
        {
            string[] rv_none = { "None" };
            if (gameSel > -1 && factSel > -1)
                return gamesList[gameSel].factionsList[factSel].shippingLines.Select(item => item.Line_Name).ToArray();
            else
                return rv_none;
        }

        public string[] GetShippingFleets(int gameSel, int factSel, int lineSel)
        {
            string[] rv_none = { "None" };
            if (gameSel > -1 && factSel > -1 && lineSel > -1)
                return gamesList[gameSel].factionsList[factSel].shippingLines[lineSel].shippingFleet.Select(item => item.Fleet_Name).ToArray();
            else
                return rv_none;
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
