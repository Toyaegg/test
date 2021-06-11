using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace test
{
    abstract class BaseCharacter
    {

    }

    class Attribute
    {
        public int HP;
        public int curHP;
        public string name;
        public int MP;
        public int curInt;

        public int baseSTR;
        public int curSTR;

        public int baseDEX;
        public int curDEX;

        public int baseCON;
        public int curCON;

        public int baseMAG;
        public int curMAG;
    }

    class Player
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

        public Player()
        {
            attribute.name = "dd";
            attribute.HP = 10;
            attribute.MP = 10;
            attribute.curDEX = attribute.baseDEX = 10;
            attribute.curCON = attribute.baseCON = 10;
            attribute.curMAG = attribute.baseMAG = 10;
            attribute.curSTR = attribute.baseSTR = 10;
        }
    }
}
