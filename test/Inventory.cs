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

    class InventoryCell
    {
        private Item item = new Item();
        private int count;

        public Item Item
        {
            get
            {
                return item;
            }
            set
            {
                item = value;
            }
        }

        public int Count
        {
            get
            {
                return count;
            }
            set
            {
                count = value;
            }
        }
    }

    class Inventory
    {
        public const int INVENTORY_CELLS = 60;
        private Wealth wealth = new Wealth();
        private Dictionary<string, InventoryCell> cells = new Dictionary<string, InventoryCell>();

        public Wealth Wealth
        {
            get
            {
                return wealth;
            }
            set
            {
                wealth = value;
            }
        }

        public bool AddItem(InventoryCell cell)
        {
            if (cells.Count < INVENTORY_CELLS)
            {
                if (!cells.ContainsKey(cell.Item.Name))
                {
                    cells.Add(cell.Item.Name, cell);
                }
                else
                {
                    cells[cell.Item.Name].Count += cell.Count;
                }
                Console.WriteLine("增加了{0}个[{1}]，现有{2}个", cell.Count,cell. Item.Name, cells[cell.Item.Name].Count);
                return true;
            }
            else
            {
                Console.WriteLine("背包格子不足！");
                return false;
            }
        }

        public bool RemoveItem(InventoryCell cell)
        {
            if (cells.Count < INVENTORY_CELLS)
            {
                if (cells.ContainsKey(cell.Item.Name))
                {
                    if (cells[cell.Item.Name].Count > cell.Count)
                    {
                        cells[cell.Item.Name].Count -= cell.Count;
                    }
                    else if (cells[cell.Item.Name].Count == cell.Count)
                    {
                        cells.Remove(cell.Item.Name);
                        Console.WriteLine("减少了{0}个[{1}]，没有了", cell.Count, cell.Item.Name);
                        return true;
                    }
                    else
                    {
                        Console.WriteLine("减少{0}个物品失败，物品[{1}]现有{2}个，数量不足！", cell.Count, cell.Item.Name, cells[cell.Item.Name].Count);
                        return false;
                    }
                    Console.WriteLine("减少了{0}个[{1}]，剩余{2}个", cell.Count, cell.Item.Name, cells[cell.Item.Name].Count);
                    return true;
                }
                else
                {
                    Console.WriteLine("物品[{0}]不存在！", cell.Item.Name);
                    return false;
                }
            }
            else
            {
                Console.WriteLine("背包格子不足！");
                return false;
            }
        }
    }


}
