using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace test
{
    class InventoryManager : Manager<InventoryManager>
    {
        public static Inventory inventory = new Inventory();

        public void AddMoney(int gold, int sliver, int copper)
        {
            inventory.Wealth.AddCoins(gold, sliver, copper);
        }

        public void RemoveMoney(int gold, int sliver, int copper)
        {
            inventory.Wealth.RemoveCoins(gold, sliver, copper);
        }

        public bool AddItem(Item item, int count)
        {
            InventoryCell cell = new InventoryCell();
            cell.Item = item;
            cell.Count = count;
            return inventory.AddItem(cell);
        }

        public bool RemoveItem(Item item, int count)
        {
            InventoryCell cell = new InventoryCell();
            cell.Item = item;
            cell.Count = count;
            return inventory.RemoveItem(cell);
        }

        public Item GetItem(string name)
        {
            return inventory.GetItem(name);
        }
    }
}
