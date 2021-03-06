using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace test.SpaceShips
{
    class PowerSystem : ShipSystem
    {
        public PowerSystem()
        {
            Name = "动力系统";
            Console.WriteLine("{0}已安装。", Name);
            SetStatus(SystemStatus.在线);
        }

        public override void Init()
        {
            Console.WriteLine("{0}初始化....", Name);
            Console.WriteLine("{0}自检结束：{1}", Name, SelfCheck());
            Console.WriteLine("{0}初始化完成。\n", Name);
        }

        public override SystemStatus GetStatus()
        {
            return CurrentSystemStatus;
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
