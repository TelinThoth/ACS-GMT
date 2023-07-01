using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aurora_GM_Tools.Classes
{
    class Ship
    {
        private string shipName;
        private int shipID;
        private double gradePoints;

        private ShipClass shipClass;

        public string Ship_Name { get { return shipName; } }
        public int Ship_ID { get { return shipID; } }

        ~ Ship()
        { }

        public Ship()
        {
            shipName = "Default";
            shipID = -1;
            gradePoints = -1;

            shipClass = null;
        }

        public Ship(string i_name, int i_id, double i_grade)
        {
            shipName = i_name;
            shipID = i_id;
            gradePoints = i_grade;

            shipClass = null;
        }

        public Ship(string i_name, int i_id, double i_grade, ShipClass i_hullType)
        {
            shipName = i_name;
            shipID = i_id;
            gradePoints = i_grade;

            shipClass = i_hullType;
        }

        public bool AssignHull(ShipClass i_hullType)
        {
            if(shipClass != null)
            {
                return false;
            }
            else
            {
                shipClass = i_hullType;
                return true;
            }
        }
    }
}
