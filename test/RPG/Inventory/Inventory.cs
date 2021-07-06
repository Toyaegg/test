using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace test
{

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
            if (cells.Count <= INVENTORY_CELLS)
            {
                if (!cells.ContainsKey(cell.Item.Name))
                {
                    cells.Add(cell.Item.Name, cell);
                }
                else
                {
                    cells[cell.Item.Name].Count += cell.Count;
                }
                Console.WriteLine("增加了{0}个[{1}]，现有{2}个。", cell.Count,cell. Item.Name, cells[cell.Item.Name].Count);
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
            if (cells.Count <= INVENTORY_CELLS)
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
                        Console.WriteLine("减少了{0}个[{1}]，没有了。", cell.Count, cell.Item.Name);
                        return true;
                    }
                    else
                    {
                        Console.WriteLine("减少{0}个物品失败，物品[{1}]现有{2}个，数量不足！", cell.Count, cell.Item.Name, cells[cell.Item.Name].Count);
                        return false;
                    }
                    Console.WriteLine("减少了{0}个[{1}]，剩余{2}个。", cell.Count, cell.Item.Name, cells[cell.Item.Name].Count);
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

        public Item GetItem(string name)
        {
            if (cells.ContainsKey(name))
            {
                Console.WriteLine("获取物品[{0}]。", name);
                return cells[name].Item;
            }
            else
            {
                Console.WriteLine("物品[{0}]不存在！", name);
                return null;
            }
        }
    }
}
