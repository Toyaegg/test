using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using test.SpaceShips;

namespace test
{
    class Program
    {
        static void Main(string[] args)
        {
            //RPGAbout();
            SpaceShioAbout();
            Console.ReadLine();
        }

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
            spaceShip.SetShipShape(800, 300, 300, 4000000);
            spaceShip.SetShipType(10);
            spaceShip.Init();
            DefenseSystemManager.Instance.CheckAll();
            Console.WriteLine(spaceShip.GetShipType());
        }

        #endregion
    }
}
