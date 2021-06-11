using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace test
{
    class Dice
    {
        private int faceNum;
        private Random random = new Random();
        public Dice(int facenum)
        {
            faceNum = facenum;
            Console.WriteLine("创建一个{0}面骰", faceNum);
        }

        public int GetPoint()
        {
            int tmp = random.Next(1, faceNum);
            Console.WriteLine("本次{0}面骰点数为：{1}", faceNum, tmp);
            return tmp;
        }
    }
}
