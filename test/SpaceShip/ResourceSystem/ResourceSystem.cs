using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace test.SpaceShips
{
    class ResourceSystem : ShipSystem
    {
        public ResourceSystem()
        {
            Name = "资源系统";
            Console.WriteLine("{0}已安装。", Name);
            base.Online();
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
