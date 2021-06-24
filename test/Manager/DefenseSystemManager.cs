using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace test.SpaceShips
{
    class DefenseSystemManager : Manager<DefenseSystemManager>
    {
        readonly List<IDefense> defenses = new List<IDefense>();

        public void InsertPart(IDefense part)
        {
            if (!defenses.Contains(part))
            {
                defenses.Add(part);
            }
            Refresh();
        }

        public void RemovePart(IDefense part)
        {
            if (!defenses.Contains(part))
            {
                string tmp = "该物品不存在！";
                Console.WriteLine(tmp);
            }
            else
            {
                defenses.Remove(part);
            }
            Refresh();
        }

        public void DestroyPart(string name)
        {
            GetDefensePart(name).Completion = 0;
        }

        public IDefense GetDefensePart(string name)
        {
            for (int i = 0; i < defenses.Count; i++)
            {
                if (defenses[i].Name == name)
                    return defenses[i];
            }

            return null;
        }

        public IDefense GetDefensePart(int id)
        {
            return defenses[id];
        }

        public int GetDefensePartCount()
        {
            return defenses.Count;
        }

        private void Refresh()
        {
            for (int i = 0; i < defenses.Count; i++)
            {
                defenses[i].ID = i;
            }
        }

        public void CheckAll()
        {
            string tmp;
            tmp = "防御系统开始遍历系统成员：";
            Console.WriteLine(tmp);
            for (int i = 0; i < defenses.Count; i++)
            {
                if(defenses[i].Completion == 0)
                {
                    tmp = String.Format("成员[{0}]已{1}，注销。", defenses[i].Name, defenses[i].GetStatus());
                    Console.WriteLine(tmp);
                    RemovePart(defenses[i]);
                }
                tmp = String.Format("系统内编号：{0} -- 类型：{1} {2} -- 完整度{3:P} -- {4}", defenses[i].ID, defenses[i].Type, defenses[i].Name, defenses[i].Completion, defenses[i].GetStatus());
                Console.WriteLine(tmp);
            }
            Console.WriteLine();
        }

        public enum DefenseType
        {
            未知,
            装甲,
            飞机,
            舰船,
            武器
        }
        public enum Status
        {
            未知,
            离线,
            受损,
            在线
        }
    }
}
