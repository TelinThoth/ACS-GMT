using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aurora_GM_Tools.Classes
{
    class Fleet
    {
        private string fleetName;
        private int fleetID;
        public int training { get; set; }
        public double[] position { get; set; } // System locations: x, y
        public int systemLoc; // System ID

        public List<Ship> shipList;

        public string Fleet_Name { get { return fleetName; } }
        public int Fleet_ID { get { return fleetID; } }

        ~Fleet()
        {}

        public Fleet()
        {
            shipList = new List<Ship>();
            position = new double[2];
        }

        public Fleet(string i_fleetName, int i_fleetID, double[] i_pos, int i_system)
        {
            fleetName = i_fleetName;
            fleetID = i_fleetID;

            shipList = new List<Ship>();
            position = i_pos;
            systemLoc = i_system;
        }
    }
}
