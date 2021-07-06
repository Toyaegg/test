using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace test
{
    class DiceRandomManager : Manager<DiceRandomManager>
    {
        //所有的骰子
        public static Dictionary<int, Dice> AllDices = new Dictionary<int, Dice>();
        /// <summary>
        /// 按照传入的次数及面数投掷骰子
        /// </summary>
        /// <param name="count">次数</param>
        /// <param name="faceNum">面数</param>
        /// <returns>骰子的点数</returns>
        public int RandomDice(int count, int faceNum)
        {
            //初始化变量
            int tmpPoint = 0;
            Dice thisDice;

            //选择或创建骰子
            if (!AllDices.ContainsKey(faceNum))
            {
                thisDice = new Dice(faceNum);
                AllDices.Add(faceNum, thisDice);
            }
            else
            {
                thisDice = AllDices[faceNum];
            }

            //按次数投掷骰子
            for (int i = 0; i < count; i++)
            {
                tmpPoint += thisDice.GetPoint();
            }

            Console.WriteLine("{0}次投掷{1}面骰点数为：{2}", count, faceNum, tmpPoint);
            return tmpPoint;
        }
    }
}
