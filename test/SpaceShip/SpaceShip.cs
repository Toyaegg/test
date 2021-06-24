using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using test.SpaceShips;

namespace test.SpaceShips
{
    class SpaceShip
    {
        private DefenseSystem defenseSystem;//防御系统
        private ECOSystem ecoSystem;//生态系统
        private EnergySystem energySystem;//能源系统
        private FirepowerSystem firepowerSystem;//火力系统
        private PowerSystem powerSystem;//动力系统
        private RecyclingSystem recyclingSystem;//循环系统
        private ResourceSystem resourceSystem;//资源系统
        private SupportSystem supportSystem;//辅助系统
        //通信系统
        //数据中心
        //舰船辅助AI
        //控制系统
        //损害管制系统
        //

        public string shipName;//名字
        public ShipType shipType;//舰船类型
        public float shipLength;//长度
        public float shipHeight;//高度
        public float shipWidht;//宽度
        public float shipWeight;//重量
        public int shipCrew;//后勤人员数量
        public int shipOfficer;//辅助人员数量
        public int shipPilot;//舰载机飞行员数量
        public int shipCaptain;//战术小队队长数量
        public int shipCorrespondent;//通讯人员数量
        //各系统管理人员数量
        //各部门管理人员数量
        //舱段组长数量
        //舰长数量
        //副舰长数量
        //参谋数量
        //步兵数量
        //

        public void CreateShip(string name)
        {
            defenseSystem = new DefenseSystem();
            ecoSystem = new ECOSystem();
            energySystem = new EnergySystem();
            firepowerSystem = new FirepowerSystem();
            powerSystem = new PowerSystem();
            recyclingSystem = new RecyclingSystem();
            resourceSystem = new ResourceSystem();
            supportSystem = new SupportSystem();

            shipName = name;

            Console.WriteLine();
            Console.WriteLine("舰船[{0}]已创建，开始出场测试。", name);
            Console.WriteLine();
        }

        public void Init()
        {
            ShipSystemManager.Instance.Init(defenseSystem);
            ShipSystemManager.Instance.Init(ecoSystem);
            ShipSystemManager.Instance.Init(energySystem);
            ShipSystemManager.Instance.Init(firepowerSystem);
            ShipSystemManager.Instance.Init(powerSystem);
            ShipSystemManager.Instance.Init(recyclingSystem);
            ShipSystemManager.Instance.Init(resourceSystem);
            ShipSystemManager.Instance.Init(supportSystem);
        }

        public void SetShipType(int type)
        {
            shipType = (ShipType) type;
        }

        public void SetShipShape(float length, float width, float height, float weight)
        {
            shipLength = length;
            shipWidht = width;
            shipHeight = height;
            shipWeight = weight;
        }

        public string GetShipType()
        {
            return "舰船类型：" + shipType.ToString();
        }

        //private ShipType GetShipTypeP()
        //{
        //    if (IsConformTo(1, 3, 2, 4, 2, 4, 0.50f, 2))
        //    {
        //        return ShipType.维生舱;
        //    }
        //    if (IsConformTo(4, 30, 5, 20, 5, 40, 2.001f, 200))
        //    {
        //        return ShipType.战斗机;
        //    }
        //    if (IsConformTo(31, 50, 21, 35, 21, 40, 200.001f, 3000))
        //    {
        //        return ShipType.驱逐舰;
        //    }
        //    if (IsConformTo(51, 80, 36, 50, 41, 65, 3000.001f, 50000))
        //    {
        //        return ShipType.轻型护卫舰;
        //    }
        //    if (IsConformTo(81, 107, 51, 80, 66, 77, 50001, 600000))
        //    {
        //        return ShipType.重型护卫舰;
        //    }
        //    if (IsConformTo(108, 300, 81, 104, 78, 120, 600001, 1000000))
        //    {
        //        return ShipType.轻型巡洋舰;
        //    }
        //    if (IsConformTo(301, 500, 105, 220, 121, 265, 1000001, 3000000))
        //    {
        //        return ShipType.重型巡洋舰;
        //    }
        //    if (IsConformTo(501, 800, 221, 386, 266, 500, 3000001, 8000000))
        //    {
        //        return ShipType.战列巡洋舰;
        //    }
        //    if (IsConformTo(801, 1500, 387, 614, 501, 775, 8000001, 18000000))
        //    {
        //        return ShipType.战斗机母舰;
        //    }
        //    if (IsConformTo(1501, 3800, 615, 800, 776, 1300, 18000001, 40000000))
        //    {
        //        return ShipType.战斗机战列舰;
        //    }
        //    if (IsConformTo(3801, 5000, 801, 1700, 1301, 2240, 40000001, 160000000))
        //    {
        //        return ShipType.战列舰;
        //    }
        //    if (IsConformTo(5001, 10000, 1701, 2844, 2241, 3244, 160000001, 400000000))
        //    {
        //        return ShipType.无畏舰;
        //    }
        //    if (IsConformTo(10001, 500000, 2845, 18731, 3245, 28514, 400000001, 2600000000))
        //    {
        //        return ShipType.母舰;
        //    }
        //    if (IsConformTo(500001, 1600000, 18732, 130000, 28515, 566734, 2600000001, 9000000000))
        //    {
        //        return ShipType.要塞堡垒;
        //    }
        //    if (IsConformTo(1600001, 80000000, 130001, 8000000, 566735, 80000000, 9000000001, 20000000000))
        //    {
        //        return ShipType.星球级舰船;
        //    }

        //    return ShipType.未知类型;
        //}

        //private bool IsConformTo(float lenMin, float lenMax, float heiMin, float heiMax, float widMin, float widMax, float weiMin,float weiMax)
        //{
        //    if (MathUtil.ClampT(shipLength, lenMin, lenMax)
        //        && MathUtil.ClampT(shipHeight, heiMin, heiMax)
        //        && MathUtil.ClampT(shipWidht, widMin, widMax)
        //        && MathUtil.ClampT(shipWeight, weiMin, weiMax))
        //    {
        //        return true;
        //    }

        //    return false;
        //}

        public enum ShipType
        {
            //Unknow,//未知类型
            //Star,//星球级舰船
            //Fortress,//要塞（堡垒）
            //MotherShip,//母舰
            //Dreadnought,//无畏舰
            //Battleship,//战列舰
            //FighterBattleship,//战斗机战列舰
            //FighterCarrier,//战斗机母舰
            //BattleCruiser,//战列巡洋舰
            //HeavyCruiser,//重型巡洋舰
            //LightCruiser,//轻型巡洋舰
            //HeavyFrigate,//重型护卫舰
            //LightFrigate,//轻型护卫舰
            //Destroyer,//驱逐舰
            //Fighter,//战斗机
            //Hatch//维生舱
            未知类型,
            星球级舰船,
            要塞堡垒,
            母舰,
            无畏舰,
            战列舰,
            战斗机战列舰,
            战斗机母舰,
            战列巡洋舰,
            重型巡洋舰,
            轻型巡洋舰,
            重型护卫舰,
            轻型护卫舰,
            驱逐舰,
            战斗机,
            维生舱
        }

        public void ShowShipInfo()
        {
            string tmp = String.Format(
                "舰船名：{0}\n规格：{1}x{2}x{3}(长x宽x高，单位：米)\n质量：{4}吨\n{5}\n",
                shipName, shipLength, shipWidht, shipHeight, shipWeight, GetShipType());
            Console.WriteLine(tmp);
        }
    }
}
