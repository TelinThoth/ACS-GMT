using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aurora_GM_Tools.Classes
{
    class Colony
    {
        private string colName;
        private int colID;

        public string Col_Name { get { return colName; } }
        public int Col_ID { get { return colID; } }

        public List<Component> componentStock;
        public List<Missile> missileStock;
        public List<Army> groundForces;

        public Colony()
        {
            componentStock = new List<Component>();
            missileStock = new List<Missile>();
            groundForces = new List<Army>();

            colName = "Default";
            colID = -1;
        }

        public Colony(string i_name, int i_id)
        {
            colName = i_name;
            colID = i_id;

            componentStock = new List<Component>();
            missileStock = new List<Missile>();
            groundForces = new List<Army>();
        }
    }
}
