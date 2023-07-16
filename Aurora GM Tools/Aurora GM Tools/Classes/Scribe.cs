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
        public bool gameLoaded = false;
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
                PopulateInternalWaypoints();
                PopulateInternalArmies();
                gameLoaded = true;
            }
            else
            {
                gameLoaded = false;
            }

            return;
        }

        public void ChangeGamesFile(string i_file)
        {
            gamesList.Clear();
            // Close DB before we open a new one.
            if (uplink.State != ConnectionState.Closed)
                uplink.Close();

            //Update File Location
            fileLoc = i_file;

            //Correct the \->/
            fileLoc = fileLoc.Replace('\\', '/');

            //Create new tring
            dialup.DataSource = fileLoc;
            if (dialup.Version != 3)
                dialup.Version = 3;

            uplink.ConnectionString = dialup.ConnectionString;
            if(File.Exists(dialup.DataSource))
            {
                PopulateInternalGames();
                PopulateInternalFactions();
                PopulateInternalFleets();
                PopulateInternalShips();
                PopulateInternalColonies();
                PopulateInternalWaypoints();
                PopulateInternalArmies();
                gameLoaded = true;
            }
            else
            {
                gameLoaded = false;
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
                    getFacts.CommandText = "SELECT FCT_Race.RaceTitle, FCT_Race.RaceID, FCT_NavalAdminCommand.NavalAdminCommandID, FCT_Race.WealthPoints, FCT_Race.NPR FROM FCT_Race JOIN FCT_NavalAdminCommand ON FCT_NavalAdminCommand.RaceID = FCT_Race.RaceID WHERE FCT_Race.GameID = " + entry.Game_ID.ToString();
                    using (SQLiteDataReader results = getFacts.ExecuteReader())
                    {
                        while (results.Read())
                        {
                            entry.factionsList.Add(new Faction(results.GetString(0), results.GetInt32(1), results.GetInt32(2), results.GetDouble(3), !results.GetBoolean(4)));
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
                        getFleets.CommandText = "SELECT FleetName, FleetID, Xcor, Ycor, SystemID FROM FCT_Fleet WHERE GameID = " + entry.Game_ID.ToString() + " AND RaceID = " + group.Faction_ID.ToString() + " AND ShippingLine = 0;";
                        using (SQLiteDataReader results = getFleets.ExecuteReader())
                        {
                            while (results.Read())
                            {
                                double[] temp = { results.GetDouble(2), results.GetDouble(3) };
                                group.fleetList.Add(new Fleet(results.GetString(0), results.GetInt32(1), temp, results.GetInt32(4)));
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
                            getFleets.CommandText = "SELECT FleetName, FleetID, Xcor, Ycor, SystemID FROM FCT_Fleet WHERE GameID = " + entry.Game_ID.ToString() + " AND RaceID = " + group.Faction_ID.ToString() + " AND ShippingLine = " + line.Line_ID.ToString() + ";";
                            using (SQLiteDataReader results = getFleets.ExecuteReader())
                            {
                                while (results.Read())
                                {
                                    double[] temp = { results.GetDouble(2), results.GetDouble(3) };
                                    group.fleetList.Add(new Fleet(results.GetString(0), results.GetInt32(1), temp, results.GetInt32(4)));
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
                            getShips.CommandText = "SELECT ShipName, ShipID, GradePoints, TFPoints, ShipClassID FROM FCT_Ship WHERE FleetID = " + flt.Fleet_ID.ToString() + ";";
                            using (SQLiteDataReader results = getShips.ExecuteReader())
                            {
                                while (results.Read())
                                {
                                    flt.shipList.Add(new Ship(results.GetString(0), results.GetInt32(1), results.GetDouble(2), results.GetDouble(3), shipYard.Find(ele => ele.ShipClass_ID == results.GetInt32(4))));
                                }
                            }
                        }

                        foreach(Shipping shipLine in fact.shippingLines)
                        {
                            foreach (Fleet shipFlt in shipLine.shippingFleet)
                            {
                                getShips.CommandText = "SELECT ShipName, ShipID, GradePoints, TFPoints, ShipClassID FROM FCT_Ship WHERE FleetID = " + shipFlt.Fleet_ID.ToString() + ";";
                                using (SQLiteDataReader results = getShips.ExecuteReader())
                                {
                                    while (results.Read())
                                    {
                                        shipFlt.shipList.Add(new Ship(results.GetString(0), results.GetInt32(1), results.GetDouble(2), results.GetDouble(3), shipYard.Find(ele => ele.ShipClass_ID == results.GetInt32(4))));
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

        private void PopulateInternalColonies()
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
                                    col.componentStock.Add(new Component(results.GetString(0), results.GetInt32(1), results.GetDouble(2)));
                                }
                            }
                        
                            getColony.CommandText = "SELECT FCT_Missiles.Name, FCT_PopulationWeapon.MissileID, FCT_PopulationWeapon.Amount FROM FCT_PopulationWeapon JOIN FCT_Missiles ON FCT_PopulationWeapon.MissileID = FCT_Missiles.MissileID WHERE FCT_PopulationWeapon.GameID = " + entry.Game_ID.ToString() + " AND FCT_PopulationWeapon.PopulationID = " + col.Col_ID.ToString() + ";";
                            using (SQLiteDataReader results = getColony.ExecuteReader())
                            {
                                while (results.Read())
                                {
                                    col.missileStock.Add(new Missile(results.GetString(0), results.GetInt32(1), results.GetDouble(2)));
                                }
                            }
                        }
                    }
                }
            }
            uplink.Close();
            return;
        }

        private void PopulateInternalWaypoints()
        {
            uplink.Open();

            using (SQLiteCommand getWaypoints = new SQLiteCommand(uplink))
            {
                foreach (Game entry in gamesList)
                {
                    getWaypoints.CommandText = "SELECT WaypointID, Name, Xcor, Ycor, SystemID FROM FCT_Waypoint WHERE GameID = " + entry.Game_ID.ToString() + ";";
                    using (SQLiteDataReader results = getWaypoints.ExecuteReader())
                    {
                        while (results.Read())
                        {
                            double[] temp = { results.GetDouble(2), results.GetDouble(3) };
                            entry.waypoints.Add(new Waypoint(results.GetInt32(0), results.GetString(1), temp, results.GetInt32(4)));
                        }
                    }
                }
                
            }
            uplink.Close();
            return;
        }

        private void PopulateInternalArmies()
        {
            uplink.Open();

            string command;

            using (SQLiteCommand getArmies = new SQLiteCommand(uplink))
            {
                foreach (Game entry in gamesList)
                {
                    foreach (Faction fact in entry.factionsList)
                    {
                        foreach (Colony cols in fact.coloniesList)
                        {
                            command = "SELECT FormationID, Name, PopulationID, ShipID, ParentFormationID FROM FCT_GroundUnitFormation WHERE PopulationID = " + cols.Col_ID;
                            getArmies.CommandText = command;
                            using (SQLiteDataReader results = getArmies.ExecuteReader())
                            {
                                while (results.Read())
                                {
                                    cols.groundForces.Add(new Army(results.GetInt32(0), results.GetString(1), results.GetInt32(2), results.GetInt32(3), results.GetInt32(4)));
                                }
                            }
                        }
                    }
                }
            }

            uplink.Close();
            return;
        }

        public bool TeleportFleet(int gameSel, int factSel, int fleetSel, int waypointSel)
        {
            if (gameSel > -1 && factSel > -1 && fleetSel > -1 && waypointSel > -1)
            {
                Fleet dock = gamesList[gameSel].factionsList[factSel].fleetList[fleetSel];
                Waypoint PIS = gamesList[gameSel].waypoints[waypointSel];

                string command = "UPDATE FCT_Fleet SET Xcor = " + PIS.getXPart().ToString() + ", Ycor = " + PIS.getYPart().ToString() + ", SystemID = " + PIS.getSytemID().ToString() + " WHERE FleetID = " + dock.Fleet_ID + ";";

                uplink.Open();

                using (SQLiteCommand teleportFleet = new SQLiteCommand(uplink))
                {
                    teleportFleet.CommandText = command;
                    teleportFleet.ExecuteNonQuery();
                }

                uplink.Close();
                return true;
            }
            else
            {
                return false;   
            }
        }

        public void TransferMilFleet(int gameSel, int factSel, int fleetSel, int newFact)
        {
            if (gameSel > -1 && factSel > -1 && fleetSel > -1 && newFact > -1)
            {
                string command = "UPDATE FCT_Fleet SET RaceID = " + gamesList[gameSel].factionsList[newFact].Faction_ID.ToString() + ", ParentCommandID = " + gamesList[gameSel].factionsList[newFact].Naval_Command_ID.ToString() + " WHERE FleetID = " + gamesList[gameSel].factionsList[factSel].fleetList[fleetSel].Fleet_ID.ToString() + ";";
                string shipCommand = "UPDATE FCT_Ship SET RaceID = " + gamesList[gameSel].factionsList[newFact].Faction_ID.ToString() + " WHERE FleetID = " + gamesList[gameSel].factionsList[factSel].fleetList[fleetSel].Fleet_ID.ToString() + ";";
                uplink.Open();

                using (SQLiteCommand transferOwner = new SQLiteCommand(uplink))
                {
                    transferOwner.CommandText = command;
                    transferOwner.ExecuteNonQuery();

                    transferOwner.CommandText = shipCommand;
                    transferOwner.ExecuteNonQuery();
                }

                uplink.Close();

                Fleet transfer = gamesList[gameSel].factionsList[factSel].fleetList[fleetSel];
                gamesList[gameSel].factionsList[newFact].fleetList.Add(transfer);
                gamesList[gameSel].factionsList[factSel].fleetList.Remove(transfer);
            }

            return;
        }

        public bool UpdateTrainingGrade(int gameSel, int factSel, int fleetSel, int shipSel, double val)
        {
            if (gameSel > -1 && factSel > -1 && fleetSel > -1 && fleetSel > -1 && val > -1)
            {
                string command = "UPDATE FCT_Ship SET TFPoints = " + val.ToString() + 
                                 " WHERE ShipID = " + gamesList[gameSel].factionsList[factSel].fleetList[fleetSel].shipList[shipSel].Ship_ID.ToString() + ";";
                uplink.Open();

                using(SQLiteCommand upgradeTraining = new SQLiteCommand(uplink))
                {
                    upgradeTraining.CommandText = command;
                    upgradeTraining.ExecuteNonQuery();
                }

                uplink.Close();

                gamesList[gameSel].factionsList[factSel].fleetList[fleetSel].shipList[shipSel].taskForcePoints = val;

                return true;
            }
            else
            {
                return false;
            }
        }

        public bool UpdateCrewGrade(int gameSel, int factSel, int fleetSel, int shipSel, double val)
        {
            if (gameSel > -1 && factSel > -1 && fleetSel > -1 && shipSel > -1 && val > -1)
            {
                string command = "UPDATE FCT_Ship SET GradePoints = " + val.ToString() +
                                 " WHERE ShipID = " + gamesList[gameSel].factionsList[factSel].fleetList[fleetSel].shipList[shipSel].Ship_ID.ToString() + ";";
                uplink.Open();

                using (SQLiteCommand upgradeCrew = new SQLiteCommand(uplink))
                {
                    upgradeCrew.CommandText = command;
                    upgradeCrew.ExecuteNonQuery();
                }

                uplink.Close();

                gamesList[gameSel].factionsList[factSel].fleetList[fleetSel].shipList[shipSel].gradePoints = val;

                return true;
            }
            else
            {
                return false;
            }
        }

        public bool TransferArmy(int gameSel, int factSel, int colSel, int armSel, int val)
        {
            if (gameSel > -1 && factSel > -1 && colSel > -1 && armSel > -1 && val > -1)
            {
                string command = "UPDATE FCT_GroundUnitFormation SET RaceID = " + val.ToString() +
                                 " WHERE FormationID = " + gamesList[gameSel].factionsList[factSel].coloniesList[colSel].groundForces[armSel].armyID.ToString() + ";";
                uplink.Open();

                using (SQLiteCommand transferArmy = new SQLiteCommand(uplink))
                {
                    transferArmy.CommandText = command;
                    transferArmy.ExecuteNonQuery();
                }

                uplink.Close();

                Army transfer = gamesList[gameSel].factionsList[factSel].coloniesList[colSel].groundForces[armSel];
                gamesList[gameSel].factionsList[factSel].coloniesList[colSel].groundForces.Remove(transfer);
                gamesList[gameSel].factionsList[factSel].coloniesList[colSel].groundForces.Add(transfer);

                return true;
            }
            else
            {
                return false;
            }
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

        public string[] GetColoniesList(int gameSel, int factSel)
        {
            string[] rv_none = { "None" };
            if (gameSel > -1 && factSel > -1)
                return gamesList[gameSel].factionsList[factSel].coloniesList.Select(item => item.Col_Name).ToArray();
            else
                return rv_none;
        }

        public string[] GetColonyComponents(int gameSel, int factSel, int colSel)
        {
            string[] rv_none = { "None" };
            if (gameSel > -1 && factSel > -1 && colSel > -1)
                return gamesList[gameSel].factionsList[factSel].coloniesList[colSel].componentStock.Select(item => item.Comp_Name).ToArray();
            else
                return rv_none;
        }

        public string[] GetColonyMissiles(int gameSel, int factSel, int colSel)
        {
            string[] rv_none = { "None" };
            if (gameSel > -1 && factSel > -1 && colSel > -1)
                return gamesList[gameSel].factionsList[factSel].coloniesList[colSel].missileStock.Select(item => item.misAmount.ToString()).ToArray();
            else
                return rv_none;
        }

        public string[] GetArmies(int gameSel, int factSel, int colSel)
        {
            string[] rv_none = { "None" };
            if (gameSel > -1 && factSel > -1 && colSel > -1)
                return gamesList[gameSel].factionsList[factSel].coloniesList[colSel].groundForces.Select(item => item.armyName.ToString()).ToArray();
            else
                return rv_none;
        }

        public string[] GetWaypoints(int gameSel)
        {
            string[] rv_none = { "None" };
            if (gameSel > -1)
                return gamesList[gameSel].waypoints.Select(item => item.getName()).ToArray();
            else
                return rv_none;
        }

        public string[] GetMilShipsList(int gameSel, int factSel, int fleetSel)
        {
            string[] rv_none = { "None" };
            if (gameSel > -1 && factSel > -1 && fleetSel > -1)
                return gamesList[gameSel].factionsList[factSel].fleetList[fleetSel].shipList.Select(item => item.Ship_Name).ToArray();
            else
                return rv_none;
        }

        public string GetFleetTraining(int gameSel, int factSel, int fleetSel, int shipSel)
        {
            if (gameSel > -1 && factSel > -1 && fleetSel > -1 && shipSel > -1)
            {
                return gamesList[gameSel].factionsList[factSel].fleetList[fleetSel].shipList[shipSel].taskForcePoints.ToString();
            }
            else
                return "";
        }

        public string GetCrewTraining(int gameSel, int factSel, int fleetSel, int shipSel)
        {
            if (gameSel > -1 && factSel > -1 && fleetSel > -1 && shipSel > -1)
            {
                return gamesList[gameSel].factionsList[factSel].fleetList[fleetSel].shipList[shipSel].gradePoints.ToString();
            }
            else
                return "";
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
