using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aurora_GM_Tools.Classes
{
    class Waypoint
    {
        private int waypointID;
        private string waypointName; 
        private double[] position; // System Position: X, Y
        private int system; // System ID

        public Waypoint(int i_ID, string i_name, double[] i_pos, int i_sys)
        {
            waypointID = i_ID;
            waypointName = i_name;
            position = i_pos;
            system = i_sys;
        }

        public double getXPart()
        {
            return position[0];
        }

        public double getYPart()
        {
            return position[1];
        }

        public int getSytemID()
        {
            return system;
        }

        public string getName()
        {
            return waypointName;
        }

        public string[] getWaypoint()
        {
            string[] rv_value =
            {
                waypointName,
                waypointID.ToString(),
                position[0].ToString(),
                position[1].ToString(),
                system.ToString()
            };
            return rv_value;
        }

    }
}
