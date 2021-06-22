using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace test.SpaceShips
{
    class DefenseSystem : ShipSystem
    {
        public DefenseSystem()
        {
            Name = "防御系统";
            Console.WriteLine("{0}已安装。", Name);
            base.Online();
        }

        public override void Init()
        {
            Console.WriteLine("{0}初始化....", Name);
            CheckOutAllPart();
            Console.WriteLine("{0}自检结束：{1}", Name, SelfCheck());
            Console.WriteLine("{0}初始化完成。\n", Name);
        }

        private void CheckOutAllPart()
        {
            LightArmor lightArmor = new LightArmor();
            lightArmor.Name = "左侧方遮挡用轻型装甲板";
            lightArmor.thickness = 30;
            lightArmor.structStrength = 16;
            DefenseSystemManager.Instance.InsertPart(lightArmor);
            lightArmor = new LightArmor();
            lightArmor.Name = "右侧方遮挡用轻型装甲板";
            lightArmor.thickness = 30;
            lightArmor.structStrength = 16;
            DefenseSystemManager.Instance.InsertPart(lightArmor);
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
