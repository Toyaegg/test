using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace test.SpaceShips
{
    class EnergySystem : ShipSystem
    {
        public EnergySystem()
        {
            Name = "能源系统";
            Console.WriteLine("{0}已安装。", Name);
            base.Online();
        }

        public override void Init()
        {
            Console.WriteLine("{0}初始化....", Name);
            Console.WriteLine("{0}自检结束：{1}", Name, SelfCheck());
            Console.WriteLine("{0}初始化完成。\n", Name);
        }

        public override SystemStatus GetStatus()
        {
            return currentSystemStatus;
        }

        public override void Offline()
        {

        }

        public override void Online()
        {

        }

        public override void Destroy()
        {

        }

        public override void Damage()
        {

        }

        public override void Shutdown()
        {

        }
    }
}
