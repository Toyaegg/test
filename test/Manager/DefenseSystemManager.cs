using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace test.SpaceShips
{
    class DefenseSystemManager : Manager<DefenseSystemManager>
    {
        readonly Dictionary<int, IDefense> defenses = new Dictionary<int, IDefense>();
        private int nowIndex = 0;

        public void InsertPart(IDefense part)
        {
            if (!defenses.ContainsValue(part))
            {
                defenses.Add(nowIndex, part);
                nowIndex++;
            }
        }

        public void CheckAll()
        {
            Console.WriteLine("防御系统开始遍历系统成员：");
            for (int i = 0; i < defenses.Count; i++)
            {
                Console.WriteLine("系统内编号：{0} -- {1}", i, defenses[i].Name);
            }
            Console.WriteLine();
        }
    }
}
