using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace test
{
    class NPC : BaseCharacter
    {
        public NPC()
        {
            Attribute.name = "npc";
            Attribute.HP = 10;
            Attribute.MP = 10;
            Attribute.curDEX = Attribute.baseDEX = 10;
            Attribute.curCON = Attribute.baseCON = 10;
            Attribute.curMAG = Attribute.baseMAG = 10;
            Attribute.curSTR = Attribute.baseSTR = 10;
        }
    }
}
