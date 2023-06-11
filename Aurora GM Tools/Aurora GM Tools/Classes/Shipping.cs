using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aurora_GM_Tools.Classes
{
    class Shipping
    {
        private string lineName;
        private int lineID;
        public List<Fleet> shippingFleet;

        public string Line_Name { get { return lineName; } }
        public int Line_ID { get { return lineID; } }

        public Shipping()
        {
            shippingFleet = new List<Fleet>();
        }

        public Shipping(string i_lineName, int i_lineID)
        {
            lineName = i_lineName;
            lineID = i_lineID;

            shippingFleet = new List<Fleet>();
        }
    }
}
