using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aurora_GM_Tools.Classes
{
    class ShipClass
    {
        private string shipClassName;
        private int shipClassID;

        public string ShipClass_Name { get { return shipClassName; } }
        public int ShipClass_ID { get { return shipClassID; } }

        public ShipClass()
        {
            shipClassName = "Default";
            shipClassID = -1;
        }

        public ShipClass(string i_name, int i_id)
        {
            shipClassName = i_name;
            shipClassID = i_id;
        }
    }
}
