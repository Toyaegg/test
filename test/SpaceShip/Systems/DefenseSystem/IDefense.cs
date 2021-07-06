using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace test.SpaceShips
{
    interface IDefense
    {
        int ID { get; set; }
        string Name { get; set; }
        int HP { get; set; }
        int CurHP { get; set; }

        DefenseType Type { get; set; }

        float Completion { get; set; }

        Status GetStatus();

        void CalculateCompletion();

        void TakeDamage(int damage);
    }
}
