using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace test
{
    class MathUtil
    {
        public static bool ClampT(int value, int min, int max)
        {
            if (value >= min && value <= max)
            {
                return true;
            }

            return false;
        }
        public static bool ClampT(float value, float min, float max)
        {
            if (value >= min && value <= max)
            {
                return true;
            }

            return false;
        }
    }
}
