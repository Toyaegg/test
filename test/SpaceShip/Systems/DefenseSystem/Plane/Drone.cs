using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace test.SpaceShips
{
    class Drone : Plane
    {
        public Drone()
        {
            CurHP = HP = 50;
            Type = DefenseType.飞机;
        }
    }
}
