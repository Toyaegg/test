using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace test
{
    class Wealth
    {
        private int goldCoin;
        private int sliverCoin;
        private int copperCoin;

        public int GoldCoin { get; }
        public int SliverCoin { get; }
        public int CopperCoin { get; }

        public void AddCoins(int gold, int sliver, int copper)
        {
            Console.WriteLine("原有{0}金{1}银{2}铜", goldCoin, sliverCoin, copperCoin);

            long addTmp = AllTransToCopper(gold, sliver, copper);
            long nowTmp = AllTransToCopper(goldCoin, sliverCoin, copperCoin);
            CopperFormat(nowTmp + addTmp);
            Console.WriteLine("增加了{0}金{1}银{2}铜，现有{3}金{4}银{5}铜", gold, sliver, copper, goldCoin, sliverCoin, copperCoin);
        }
        public void RemoveCoins(int gold, int sliver, int copper)
        {
            Console.WriteLine("原有{0}金{1}银{2}铜", goldCoin, sliverCoin, copperCoin);

            long removeTmp = AllTransToCopper(gold, sliver, copper);
            long nowTmp = AllTransToCopper(goldCoin, sliverCoin, copperCoin);
            CopperFormat(nowTmp - removeTmp);

            Console.WriteLine("减少了{0}金{1}银{2}铜，现有{3}金{4}银{5}铜", gold, sliver, copper, goldCoin, sliverCoin, copperCoin);
        }

        private long AllTransToCopper(int gold, int sliver, int copper)
        {
            //Console.WriteLine("原有{0}金{1}银{2}铜", gold, sliver, copper);
            long tmp = gold * 10000 + sliver * 100 + copper;
            //Console.WriteLine("转换为{0}铜", tmp);
            return tmp;
        }

        private void CopperFormat(long copper)
        {
            //Console.WriteLine("将{0}铜", copper);
            goldCoin = (int)(copper / 10000);
            copper -= goldCoin * 10000;
            sliverCoin = (int)(copper / 100);
            copper -= sliverCoin * 100;
            copperCoin = (int)copper;
            //Console.WriteLine("转换为{0}金{1}银{2}铜", goldCoin, sliverCoin, copperCoin);
        }
    }
}
