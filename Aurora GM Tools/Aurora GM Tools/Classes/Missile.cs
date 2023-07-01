using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aurora_GM_Tools.Classes
{
    class Missile
    {
        private string misName;
        private int misID;
        public double misAmount { get; set; }

        public string Missile_Name { get { return misName; } }
        public int    Missile_ID   { get { return misID; } }

        public Missile()
        {
            misName = "Default";
            misID = -1;
            misAmount = 0;
        }

        public Missile(string i_name, int i_ID, double i_amount)
        {
            misName = i_name;
            misID = i_ID;
            misAmount = i_amount;
        }
    }
}
