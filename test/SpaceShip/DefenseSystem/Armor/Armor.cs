using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace test.SpaceShips
{
    class Armor : IDefense
    {
        public enum ArmorStatus
        {
            未知,
            离线,
            受损,
            在线
        }

        public string Name { get; set; }
        public float Completion { get; set; }

        public float thickness;

        public float structStrength;

        public string SelfCheck()
        {
            return "";
        }
    }
}
