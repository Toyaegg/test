using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace test
{
    abstract class BaseCharacter
    {
        private Attribute attribute = new Attribute();

        public Attribute Attribute
        {
            get
            {
                return attribute;
            }
            set
            {
                attribute = value;
            }
        }
    }
}
