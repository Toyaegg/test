using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace test
{
    class Player : BaseCharacter
    {
        public Player()
        {
            Attribute.name = "dd";
            Attribute.curHP = Attribute.HP = 10;
            Attribute.curMP = Attribute.MP = 10;
            Attribute.curDEX = Attribute.baseDEX = 10;
            Attribute.curCON = Attribute.baseCON = 10;
            Attribute.curMAG = Attribute.baseMAG = 10;
            Attribute.curSTR = Attribute.baseSTR = 10;
        }
    }
}
