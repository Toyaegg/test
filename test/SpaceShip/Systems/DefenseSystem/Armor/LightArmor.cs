using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace test.SpaceShips
{
    class LightArmor : Armor
    {
        public LightArmor()
        {
            CurHP = HP = 350;
            Type = DefenseType.装甲;
        }
    }
}
