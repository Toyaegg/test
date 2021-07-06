using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace test.SpaceShips
{
    class Armor : IDefense
    {

        public int ID { get; set; }
        public string Name { get; set; }
        public int HP { get; set; }
        public int CurHP { get; set; }
        public DefenseSystemManager.DefenseType Type { get; set; }
        public float Completion { get; set; }

        public float thickness;

        public float structStrength;

        public string SelfCheck()
        {
            return "";
        }

        public DefenseSystemManager.Status GetStatus()
        {
            if (Completion < 1 && Completion > 0)
            {
                return DefenseSystemManager.Status.受损;
            }
            else if (Completion == 1)
            {
                return DefenseSystemManager.Status.在线;
            }
            else if (Completion == 0)
            {
                return DefenseSystemManager.Status.离线;
            }

            return DefenseSystemManager.Status.未知;
        }

        public void CalculateCompletion()
        {
            Completion = (float)CurHP / HP;
        }

        public void TakeDamage(int damage)
        {
            if(CurHP < damage)
            {
                Console.WriteLine("数据错误！");
            }
            CurHP -= damage;
            string tmp = String.Format("[{0}]遭到攻击，伤害值为：{1}！\n", Name, damage);
            Console.WriteLine(tmp);
            CalculateCompletion();
        }
    }
}
