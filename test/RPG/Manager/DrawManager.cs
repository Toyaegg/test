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
        public int itemDrawNum = 0;
        public const int ITEM_FLOORS = 50;
        public int npcDrawNum = 0;
        public const int NPC_FLOORS = 50;

        public static int allItemCount = 5;
        public static int allNPCCount = 5;

        public int[] npcCount = new int[allNPCCount];
        public int[] itemCount = new int[allItemCount];

        private List<DrawItemOfItem> itemPrizes = new List<DrawItemOfItem>();
        private List<DrawItemOfNPC> npcPrizes = new List<DrawItemOfNPC>();

        Random r = new Random();

        public DrawManager()
        {
            InitPrizes();
        }

        private void InitPrizes()
        {
            itemPrizes.Clear();
            npcPrizes.Clear();

            for (int i = 0; i < allItemCount; i++)
            {
                itemPrizes.Add(new DrawItemOfItem(i,$"{i + 1}"));
                itemPrizes[i].Probability = i * 100;
            }

            for (int i = 0; i < allNPCCount; i++)
            {
                npcPrizes.Add(new DrawItemOfNPC(i, $"{i + 1}"));
                npcPrizes[i].Probability = i * 100;
            }
        }

        public void ItemDrawOne(out Item item)
        {
            Console.WriteLine("物品单抽：");

            itemDrawNum++;

            int tmpPro = r.Next(1, 500);

            if (itemDrawNum == 50)
            {
                tmpPro = 500;
                Console.WriteLine("保底！");
            }

            item = GetItemPrize(tmpPro);

            npcCount[int.Parse(item.Name) - 1]++;

            Console.WriteLine($"物品：{item.Name}");
        }

        public void ItemDrawTen(out List<Item> items)
        {
            Console.WriteLine("物品十连：");

            items = new List<Item>();

            for (int i = 0; i < 10; i++)
            {
                itemDrawNum++;

                int tmpPro = r.Next(1, 500);

                if (itemDrawNum == 50)
                {
                    tmpPro = 500;
                    Console.WriteLine("保底！");
                }

                var item = GetItemPrize(tmpPro);

                items.Add(item);

                npcCount[int.Parse(item.Name) - 1]++;

                Console.WriteLine($"物品：{items[i].Name}");
            }
        }

        public void NPCDrawOne(out NPC npc)
        {
            Console.WriteLine("人物单抽：");

            npcDrawNum++;

            int tmpPro = r.Next(1, 500);

            if (npcDrawNum == 50)
            {
                tmpPro = 500;
                Console.WriteLine("保底！");
            }

            npc = GetNPCPrize(tmpPro);

            npcCount[int.Parse(npc.Attribute.name) - 1]++;

            Console.WriteLine($"人物：{npc.Attribute.name}");
        }

        public void NPCDrawTen(out List<NPC> npcs)
        {
            Console.WriteLine("人物十连：");

            npcs = new List<NPC>();

            for (int i = 0; i < 10; i++)
            {
                npcDrawNum++;

                int tmpPro = r.Next(1,500);

                if (npcDrawNum == 50)
                {
                    tmpPro = 500;
                    Console.WriteLine("保底！");
                }

                var npc = GetNPCPrize(tmpPro);
                npcs.Add(npc);

                npcCount[int.Parse(npc.Attribute.name) - 1]++;

                Console.WriteLine($"人物：{npcs[i].Attribute.name}");
            }
        }

        private NPC GetNPCPrize(int probability)
        {
            return npcPrizes[GetRare(probability)].GetValue();
        }

        private Item GetItemPrize(int probability)
        {
            return itemPrizes[GetRare(probability)].GetValue();
        }

        int GetRare(int probability)
        {
            int tmp = 0;

            if (probability > 300 && probability <= 400)
            {
                tmp = 1;
            }
            if (probability > 400 && probability <= 450)
            {
                tmp = 2;
            }
            if (probability > 450 && probability <= 490)
            {
                tmp = 3;
            }
            if (probability > 490 && probability <= 500)
            {
                tmp = 4;
            }

            return tmp;
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

            Console.WriteLine($"当前抽奖次数：{num}，抽奖{floor}次必定获得5星{type}。");
        }

        public void ShowDrawHistory(PrizeType type)
        {
            int[] tmp;
            switch (type)
            {
                case PrizeType.物品:
                {
                    tmp = itemCount;
                    break;
                }
                case PrizeType.NPC:
                {
                    tmp = npcCount;
                    break;
                }
                default:
                {
                    return;
                }
            }

            for (int i = 0;i < tmp.Length; i++)
            {
                Console.Write($"{i + 1}星{type} {tmp[i]}个  ");
            }
            Console.WriteLine();
        }
    }
}
