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
        private List<Ship> shipList;

        public string Fleet_Name { get { return fleetName; } }
        public int Fleet_ID { get { return fleetID; } }

        public Fleet()
        { }

        public Fleet(string i_fleetName, int i_fleetID)
        {
            fleetName = i_fleetName;
            fleetID = i_fleetID;
        }
    }
}
