using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace test
{
    class Manager<T> where T : new()
    {
        static readonly object _lock = new object();
        private static T instance;

        public static T Instance
        {
            get
            {
                if (instance == null)
                {
                    lock (_lock)
                    {
                        instance = new T();
                    }
                }

                return instance;
            }
        }

    }

    class GameManager : Manager<GameManager>
    {
        public Player player = null;

        public const string gameName = "PP's Father and Balloons";
        /// <summary>
        /// 注册玩家
        /// </summary>
        /// <param name="player">玩家对象</param>
        public void RegistPlayer(Player player)
        {
            this.player = player;
        }


    }

    class AttributeManager : Manager<AttributeManager>
    {
        public Attribute attribute = GameManager.Instance.player.Attribute;
        /// <summary>
        /// 打印玩家信息
        /// </summary>
        public void ShowAttribute()
        {
            Console.WriteLine("游戏名：{0}\n玩家名字：{1}\nHP:{2}   MP:{3}\n力量：{4}\n体质：{5}\n敏捷：{6}\n魔力：{7}", 
                GameManager.gameName, 
                attribute.name,
                attribute.HP,
                attribute.MP,
                attribute.curSTR,
                attribute.curCON,
                attribute.curDEX,
                attribute.curMAG);
        }
        /// <summary>
        /// 技能修改属性
        /// </summary>
        public void SkillChangeAttribute()
        {

        }
        /// <summary>
        /// 修改玩家名字
        /// </summary>
        /// <param name="str">玩家名字</param>
        public void ChangeName(string str)
        {
            attribute.name = str;
        }

        /// <summary>
        /// 修改基础属性
        /// </summary>
        /// <param name="att">属性</param>
        /// <param name="value">数值</param>
        /// <returns>修改后的属性</returns>
        public int ChangeAttribute(int att, int value)
        {
            int tmp = att + value;
            Console.WriteLine("某属性从{0}变化了{1}，现为{2}", att, value, tmp);
            return att + value;
        }

        /// <summary>
        /// 百分比修改基础属性
        /// </summary>
        /// <param name="att">属性</param>
        /// <param name="value">数值</param>
        /// <returns>修改后的属性</returns>
        public int ChangeAttributePer(int att, float value)
        {
            int tmp = (int)(att * value);
            Console.WriteLine("某属性从{0}变化到{1}%，现为{2}", att, value * 100, tmp);
            return (int) (att * value);
        }

        /// <summary>
        /// 修改当前属性
        /// </summary>
        /// <param name="att">属性</param>
        /// <param name="value">数值</param>
        /// <returns>修改后的属性</returns>
        public int ChangeCurAttribute(int att, int value)
        {
            int tmp = att + value;
            Console.WriteLine("某属性从{0}变化了{1}，现为{2}", att,value, tmp);
            return tmp;
        }

        /// <summary>
        /// 百分比修改当前属性
        /// </summary>
        /// <param name="att">属性</param>
        /// <param name="value">数值</param>
        /// <returns>修改后的属性</returns>
        public int ChangeCurAttributePer(int att, float value)
        {
            int tmp = (int) (att * value);
            Console.WriteLine("某属性从{0}变化到{1}%，现为{2}", att, value * 100, tmp);
            return tmp;
        }
    }

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

            Console.WriteLine("{0}次投掷{1}面骰点数为：{2}",count, faceNum, tmpPoint);
            return tmpPoint;
        }
    }

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
    }
}
