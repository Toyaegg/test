using System;
using System.Collections.Generic;
using System.Threading;
using System.Timers;
using test.SpaceShips;

namespace test
{
    class Program
    {
        //private static Action act1;
        //private static Action<string, int> act2;
        //private static Func<string, int> func1;
        //private static Func<int, string> func2;

        //delegate int getii(TestDele s);

        //delegate void ppd();

        //private static event ppd pp;

        //private getii moo;

        //static MyTimer mt = new MyTimer(true, false);
        static void Main(string[] args)
        {
            //mt.myEventHandler += TimerDo;
            RPGAbout();
            //SpaceShioAbout();
            //dell();
            //TimerTest();
            Console.ReadLine();
        }

        public static void TimerDo(int timerID, int bindPara)
        {
            //Console.WriteLine("TimerDo timerID : {0}\tbindPara : {1}", timerID, bindPara);
            switch (timerID)
            {
                case 0:
                    {
                        Console.WriteLine("666->" + bindPara);
                        break;
                    }
                case 1:
                    {
                        Console.WriteLine("SB->" + bindPara);
                        break;
                    }
                case 2:
                    {
                        Console.WriteLine("WDNMD->" + bindPara);
                        break;
                    }
                case 3:
                    {
                        Console.WriteLine("QAQ->" + bindPara);
                        GC.Collect();
                        break;
                    }
            }
        }

        #region TimerTest

        //static void TimerTest()
        //{
        //    Console.WriteLine("QAQ->");
        //    mt.SetTimer(0, 1000, -1, 66);

        //    Thread.Sleep(5000);
        //    Console.WriteLine("QAQ->");
        //    mt.SetTimer(0, 1000, -1, 66);
        //    //Console.WriteLine(sizeof(MyTimer));
        //}

        #endregion

        #region Delegate

        static void dell()
        {
            //act1 = pp3;
            //act2 = pp1;
            //func1 = pp4;
            //func2 = pp2;
            //func2 += pp2_1;

            //act1();
            //act2("www", 0);
            //func1("dd");
            //func2(0);
            //List<TestDele> array = new List<TestDele>();
            //Random random = new Random();
            //for (int i = 0; i < 20; i++)
            //{
            //    TestDele t = new TestDele()
            //    {
            //        a = random.Next(1,20),
            //        b = random.Next(21, 50)
            //    };
            //    array.Add(t);
            //}
            //Console.WriteLine(pps(array, g => g.a));
            //Console.WriteLine(pps(array, g => g.b));
            //pp += ddd;
            //pp += ddd;
            //pp += ddd;
            //pp += ddd;
            //pp += ddd;

            //pp();

            //Console.WriteLine("-----------------------");

            //pp -= ddd;
            //pp -= ddd;
            //pp -= ddd;
            //pp -= ddd;

            //pp();

            //Console.WriteLine("-----------------------");
        }

        //private static int tt = 0;
        //static void ddd()
        //{
        //    Console.WriteLine("ddd - " + (++tt));
        //}

        //public static void pp1(string pp, int t)
        //{
        //    Console.WriteLine("pp1 " + pp + " " + t);
        //}
        //public static string pp2(int t)
        //{
        //    Console.WriteLine("pp2 " + t);
        //    return "";
        //}
        //public static string pp2_1(int t)
        //{
        //    Console.WriteLine("pp2_1 " + t);
        //    return "";
        //}
        //public static int pp4(string t)
        //{
        //    Console.WriteLine("pp4 " + t);
        //    return 0;
        //}
        //public static void pp3()
        //{
        //    Console.WriteLine("pp3");
        //}

        //static string pps(List<TestDele> p, getii g)
        //{
        //    int t = 0;
        //    string ss = "mm";
        //    foreach (TestDele sp in p)
        //    {
        //        int ft = g(sp);
        //        Console.WriteLine(ft);
        //        if (ft > t) t = ft;
        //    }
        //    return "Max" + t;
        //}

        #endregion

        #region RPGAbout

        static void RPGAbout()
        {
            //Player p = new Player();

            //GameManager.Instance.RegistPlayer(p);

            //AttributeManager.Instance.ShowAttribute();
            //AttributeManager.Instance.ChangeName("dddd");

            //p.Attribute.curSTR = AttributeManager.Instance.ChangeAttribute(p.Attribute.baseSTR, 30);
            //p.Attribute.curDEX = AttributeManager.Instance.ChangeAttribute(p.Attribute.baseDEX, 6);
            //p.Attribute.curCON = AttributeManager.Instance.ChangeAttributePer(p.Attribute.baseCON, 1.6f);
            //p.Attribute.curSTR = AttributeManager.Instance.ChangeAttribute(p.Attribute.baseSTR, -6);
            //p.Attribute.curSTR = AttributeManager.Instance.ChangeCurAttribute(p.Attribute.curSTR, 16);
            //p.Attribute.curSTR = AttributeManager.Instance.ChangeCurAttributePer(p.Attribute.curSTR, 1.2f);
            //p.Attribute.curMAG = AttributeManager.Instance.ChangeCurAttributePer(p.Attribute.curMAG, 0.2f);

            //AttributeManager.Instance.ShowAttribute();

            //DiceRandomManager.Instance.RandomDice(3, 6);
            ////DiceRandomManager.Instance.RandomDice(3, 1);

            //InventoryManager.Instance.AddMoney(1, 2, 3);
            //InventoryManager.Instance.RemoveMoney(0, 60, 86);

            //Item item = new Item();
            //Item item2 = new Item();
            //item.Name = "皮皮虾";
            //item2.Name = "5";
            //InventoryManager.Instance.AddItem(item, 30);
            //InventoryManager.Instance.RemoveItem(item, 20);
            //InventoryManager.Instance.RemoveItem(item, 20);
            //InventoryManager.Instance.GetItem("5");
            //InventoryManager.Instance.GetItem("皮皮虾");
            //InventoryManager.Instance.RemoveItem(item, 10);
            //InventoryManager.Instance.RemoveItem(item2, 30);

            List<NPC> npcs;
            DrawManager.Instance.NPCDrawTen(out npcs);
            DrawManager.Instance.NPCDrawTen(out npcs);
            DrawManager.Instance.NPCDrawTen(out npcs);
            DrawManager.Instance.NPCDrawTen(out npcs);
            DrawManager.Instance.NPCDrawTen(out npcs);
            DrawManager.Instance.ShowDrawInfo(PrizeType.物品);
            DrawManager.Instance.ShowDrawHistory(PrizeType.物品);
            DrawManager.Instance.ShowDrawInfo(PrizeType.NPC);
            DrawManager.Instance.ShowDrawHistory(PrizeType.NPC);
        }

        #endregion

        #region SpaceShipAbout

        static void SpaceShioAbout()
        {
            SpaceShip spaceShip = new SpaceShip();

            spaceShip.CreateShip("Pogis");
            spaceShip.SetShipShape(800, 150, 85, 4000000);
            spaceShip.SetShipType(10);

            spaceShip.Init();

            DefenseSystemManager.Instance.CheckAll();

            DefenseSystemManager.Instance.DestroyPart("右侧方遮挡用轻型装甲板");
            DefenseSystemManager.Instance.CheckAll();

            var part = DefenseSystemManager.Instance.GetDefensePart(6);
            part.TakeDamage(26);
            DefenseSystemManager.Instance.CheckAll();

            spaceShip.ShowShipInfo();
        }

        #endregion
    }

    struct TestDele
    {
        public int a;
        public int b;
    }
}
