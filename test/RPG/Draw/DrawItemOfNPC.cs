using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace test
{
    class DrawItemOfNPC : DrawItem
    {
        public int ID { get; }
        public string Name { get; set; }
        public int Probability { get; set; }

        public NPC npc = new NPC();

        public DrawItemOfNPC(int id, string name)
        {
            ID = id;
            npc.Attribute.name = Name = name;
        }

        public NPC GetValue()
        {
            return npc;
        }
    }
}
