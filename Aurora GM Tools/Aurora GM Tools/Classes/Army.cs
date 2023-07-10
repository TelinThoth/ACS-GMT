using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aurora_GM_Tools.Classes
{
    class Army
    {
        public int armyID { get; set; }
        public string armyName { get; set; }
        public int populationID { get; set; }
        public int shipID { get; set; }
        public int parentFormationID { get; set; }
        
        public Army()
        {
            armyName = "Default";
            
            armyID = -1;
            populationID = -1;
            shipID = -1;
            parentFormationID = -1;
        }

        public Army(int i_ID, string i_armyName, int i_popID, int i_shipID, int i_parent)
        {
            armyName = i_armyName;

            armyID = i_ID;
            populationID = i_popID;
            shipID = i_shipID;
            parentFormationID = i_parent;
        }
    }
}
