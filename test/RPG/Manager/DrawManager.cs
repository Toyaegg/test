using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace test
{
    public enum PrizeType
    {
        未知,
        物品,
        NPC
    }
    class DrawManager : Manager<DrawManager>
    {
        public int itemDrawNum;
        public const int ITEM_FLOORS = 50;
        public int npcDrawNum;
        public const int NPC_FLOORS = 50;

        private List<Item> itemPrizes = new List<Item>();
        private List<NPC> npcPrizes = new List<NPC>();

        public DrawManager()
        {
            InitPrizes();
        }

        private void InitPrizes()
        {
            itemPrizes.Clear();
            npcPrizes.Clear();
        }

        public void ItemDrawOne(out Item item)
        {
            item = new Item();
        }

        public void ItemDrawTen(out List<Item> items)
        {
            items = new List<Item>();
            for (int i = 0; i < 10; i++)
            {
                Random r = new Random();
                items.Add(new Item());
            }
        }

        public void NPCDrawOne(out NPC npc)
        {
            npc = new NPC();
        }

        public void NPCDrawTen(out List<NPC> npc)
        {
            npc = new List<NPC>();
            for (int i = 0; i < 10; i++)
            {
                Random r = new Random();
                npc.Add(new NPC());
            }
        }

        public void ShowDrawInfo(PrizeType type)
        {
            int num = 0, floor = 0;
            switch (type)
            {
                case PrizeType.物品:
                {
                    num = itemDrawNum;
                    floor = ITEM_FLOORS;
                    break;
                }
                case PrizeType.NPC:
                {
                    num = npcDrawNum;
                    floor = NPC_FLOORS;
                    break;
                }
                default:
                {
                    return;
                }
            }
            Console.WriteLine($"当前抽奖次数：{num}，抽奖{floor}次必定获得{type}。");
        }
    }
}
