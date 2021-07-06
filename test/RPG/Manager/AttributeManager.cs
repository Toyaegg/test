using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace test
{
    class AttributeManager : Manager<AttributeManager>
    {
        public Attribute attribute = GameManager.Instance.player.Attribute;
        /// <summary>
        /// 打印玩家信息
        /// </summary>
        public void ShowAttribute()
        {
            Console.WriteLine("游戏名：{0}\n玩家名字：{1}\nHP:{2}/{3}   MP:{4}/{5}\n力量：{6}  体质：{7}\n敏捷：{8}  魔力：{9}",
                GameManager.gameName,
                attribute.name,
                attribute.curHP,
                attribute.HP,
                attribute.curMP,
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
            string tmpStr = "增加";
            if (value < 0)
            {
                tmpStr = "减少";
            }
            Console.WriteLine("某属性从{0}{1}了{2}，现为{3}", att, tmpStr, value, tmp);
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
            return (int)(att * value);
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
            Console.WriteLine("某属性从{0}变化了{1}，现为{2}", att, value, tmp);
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
            int tmp = (int)(att * value);
            Console.WriteLine("某属性从{0}变化到{1}%，现为{2}", att, value * 100, tmp);
            return tmp;
        }
    }
}
