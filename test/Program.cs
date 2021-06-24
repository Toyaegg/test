using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using test.SpaceShips;

namespace test
{
    class Program
    {
        private static Action act1;
        private static Action<string, int> act2;
        private static Func<string, int> func1;
        private static Func<int, string> func2;

        delegate int getii(testDele s);

        private getii moo;
        static void Main(string[] args)
        {
            //RPGAbout();
            //SpaceShioAbout();
            dell();

            Console.ReadLine();
        }

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
            List<testDele> array = new List<testDele>();
            Random random = new Random();
            for (int i = 0; i < 20; i++)
            {
                testDele t = new testDele()
                {
                    a = random.Next(1,20),
                    b = random.Next(21, 50)
                };
                array.Add(t);
            }
            Console.WriteLine(pps(array, g => g.a));
            Console.WriteLine(pps(array, g => g.b));
        }
        public static void pp1(string pp, int t)
        {
            Console.WriteLine("pp1 " + pp + " " + t);
        }
        public static string pp2(int t)
        {
            Console.WriteLine("pp2 " + t);
            return "";
        }
        public static string pp2_1(int t)
        {
            Console.WriteLine("pp2_1 " + t);
            return "";
        }
        public static int pp4(string t)
        {
            Console.WriteLine("pp4 " + t);
            return 0;
        }
        public static void pp3()
        {
            Console.WriteLine("pp3");
        }

        static string pps(List<testDele> p, getii g)
        {
            int t = 0;
            string ss = "mm";
            foreach (testDele sp in p)
            {
                int ft = g(sp);
                Console.WriteLine(ft);
                if (ft > t) t = ft;
            }
            return "Max" + t;
        }

        #endregion

        #region RPGAbout

        //static void RPGAbout()
        //{
        //    Player p = new Player();

        //    GameManager.Instance.RegistPlayer(p);

        //    AttributeManager.Instance.ShowAttribute();
        //    AttributeManager.Instance.ChangeName("dddd");

        //    p.Attribute.curSTR = AttributeManager.Instance.ChangeAttribute(p.Attribute.baseSTR, 30);
        //    p.Attribute.curDEX = AttributeManager.Instance.ChangeAttribute(p.Attribute.baseDEX, 6);
        //    p.Attribute.curCON = AttributeManager.Instance.ChangeAttributePer(p.Attribute.baseCON, 1.6f);
        //    p.Attribute.curSTR = AttributeManager.Instance.ChangeAttribute(p.Attribute.baseSTR, -6);
        //    p.Attribute.curSTR = AttributeManager.Instance.ChangeCurAttribute(p.Attribute.curSTR, 16);
        //    p.Attribute.curSTR = AttributeManager.Instance.ChangeCurAttributePer(p.Attribute.curSTR, 1.2f);
        //    p.Attribute.curMAG = AttributeManager.Instance.ChangeCurAttributePer(p.Attribute.curMAG, 0.2f);

        //    Console.WriteLine("name:{0}", GameManager.Instance.player.Attribute.name);
        //    Console.WriteLine("STR:{0}", GameManager.Instance.player.Attribute.curSTR);
        //    Console.WriteLine("DEX:{0}", GameManager.Instance.player.Attribute.curDEX);
        //    Console.WriteLine("CON:{0}", GameManager.Instance.player.Attribute.curCON);
        //    Console.WriteLine("MAG:{0}", GameManager.Instance.player.Attribute.curMAG);

        //    DiceRandomManager.Instance.RandomDice(3, 6);
        //    //DiceRandomManager.Instance.RandomDice(3, 1);

        //    InventoryManager.Instance.AddMoney(1, 2, 3);
        //    InventoryManager.Instance.RemoveMoney(0, 60, 86);

        //    Item item = new Item();
        //    Item item2 = new Item();
        //    item.Name = "皮皮虾";
        //    item2.Name = "5";
        //    InventoryManager.Instance.AddItem(item, 30);
        //    InventoryManager.Instance.RemoveItem(item, 20);
        //    InventoryManager.Instance.RemoveItem(item, 20);
        //    InventoryManager.Instance.GetItem("5");
        //    InventoryManager.Instance.GetItem("皮皮虾");
        //    InventoryManager.Instance.RemoveItem(item, 10);
        //    InventoryManager.Instance.RemoveItem(item2, 30);
        //}

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

    class testDele
    {
        public int a;
        public int b;
    }
}
