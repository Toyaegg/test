using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace test.SpaceShips
{
    abstract class ShipSystem
    {
        private SystemStatus systemStatus = SystemStatus.离线;
        public string Name;
        public SystemStatus currentSystemStatus
        {
            get { return systemStatus; }
        }

        public enum SystemStatus
        {
            未知错误,
            在线,
            受损,
            离线,
            损坏
        }
        public virtual void Init()
        {
            Console.WriteLine("{0}初始化....", Name);
            Console.WriteLine("{0}自检结束：{1}", Name, SelfCheck());
            Console.WriteLine("{0}初始化完成。\n", Name);
        }
        public abstract SystemStatus GetStatus();


        public virtual void Offline()
        {
            SetStatus(SystemStatus.离线);
        }

        public virtual void Online()
        {
            SetStatus(SystemStatus.在线);
        }

        public virtual void Destroy()
        {
            SetStatus(SystemStatus.损坏);
        }

        public virtual void Damage()
        {
            SetStatus(SystemStatus.受损);
        }

        public virtual void Shutdown()
        {
            SetStatus(SystemStatus.未知错误);
        }

        protected void SetStatus(SystemStatus status)
        {
            systemStatus = status;
        }

        protected string SelfCheck()
        {
            return systemStatus.ToString();
        }
    }
}
