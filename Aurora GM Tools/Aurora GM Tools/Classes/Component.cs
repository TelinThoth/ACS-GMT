using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aurora_GM_Tools.Classes
{
    class Component
    {
        private string compName;
        private int compID;
        private int compCount;

        public string Comp_Name { get { return compName; } }
        public int Comp_ID { get { return compID; } }
        public int Comp_Count { get { return compCount; } }

        public Component()
        {
            compName = "None";
            compID = -1;
            compCount = 0;
        }

        public Component(string i_name, int i_id, int i_count)
        {
            compName = i_name;
            compID = i_id;
            compCount = i_count;
        }

    }
}
