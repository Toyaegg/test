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
        private ECOSystem eCOSystem;//生态系统
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

        public void Init(string name, float length, float height, float width, float weight)
        {
            defenseSystem = new DefenseSystem();
            eCOSystem = new ECOSystem();
            energySystem = new EnergySystem();
            firepowerSystem = new FirepowerSystem();
            powerSystem = new PowerSystem();
            recyclingSystem = new RecyclingSystem();
            resourceSystem = new ResourceSystem();
            supportSystem = new SupportSystem();

            shipName = name;
            shipLength = length;
            shipHeight = height;
            shipWidht = width;
            shipWeight = weight;

            shipType = GetShipTypeP();
        }

        public string GetShipType()
        {
            return shipType.ToString();
        }

        private ShipType GetShipTypeP()
        {
            if (IsConformTo(1, 3, 2, 4, 2, 4, 0.50f, 2))
            {
                return ShipType.Hatch;
            }
            if (IsConformTo(4, 30, 5, 20, 5, 40, 2.001f, 200))
            {
                return ShipType.Fighter;
            }
            if (IsConformTo(31, 50, 21, 35, 21, 40, 200.001f, 3000))
            {
                return ShipType.Destroyer;
            }
            if (IsConformTo(51, 80, 36, 50, 41, 65, 3000.001f, 50000))
            {
                return ShipType.LightFrigate;
            }
            if (IsConformTo(81, 107, 51, 80, 66, 77, 50001, 600000))
            {
                return ShipType.HeavyFrigate;
            }
            if (IsConformTo(108, 300, 81, 104, 78, 120, 600001, 1000000))
            {
                return ShipType.LightCruiser;
            }
            if (IsConformTo(301, 500, 105, 220, 121, 265, 1000001, 3000000))
            {
                return ShipType.HeavyCruiser;
            }
            if (IsConformTo(501, 800, 221, 386, 266, 500, 3000001, 8000000))
            {
                return ShipType.BattleCruiser;
            }
            if (IsConformTo(801, 1500, 387, 614, 501, 775, 8000001, 18000000))
            {
                return ShipType.FighterCarrier;
            }
            if (IsConformTo(1501, 3800, 615, 800, 776, 1300, 18000001, 40000000))
            {
                return ShipType.FighterBattleship;
            }
            if (IsConformTo(3801, 5000, 801, 1700, 1301, 2240, 40000001, 160000000))
            {
                return ShipType.Battleship;
            }
            if (IsConformTo(5001, 10000, 1701, 2844, 2241, 3244, 160000001, 400000000))
            {
                return ShipType.Dreadnought;
            }
            if (IsConformTo(10001, 500000, 2845, 18731, 3245, 28514, 400000001, 2600000000))
            {
                return ShipType.MotherShip;
            }
            if (IsConformTo(500001, 1600000, 18732, 130000, 28515, 566734, 2600000001, 9000000000))
            {
                return ShipType.Fortress;
            }
            if (IsConformTo(1600001, 80000000, 130001, 8000000, 566735, 80000000, 9000000001, 20000000000))
            {
                return ShipType.Star;
            }

            return ShipType.Unknow;
        }

        private bool IsConformTo(float lenMin, float lenMax, float heiMin, float heiMax, float widMin, float widMax, float weiMin,float weiMax)
        {
            if (MathUtil.ClampT(shipLength, lenMin, lenMax)
                && MathUtil.ClampT(shipHeight, heiMin, heiMax)
                && MathUtil.ClampT(shipWidht, widMin, widMax)
                && MathUtil.ClampT(shipWeight, weiMin, weiMax))
            {
                return true;
            }

            return false;
        }

        public enum ShipType
        {
            Unknow,//未知类型
            Star,//星球级舰船
            Fortress,//要塞（堡垒）
            MotherShip,//母舰
            Dreadnought,//无畏舰
            Battleship,//战列舰
            FighterBattleship,//战斗机战列舰
            FighterCarrier,//战斗机母舰
            BattleCruiser,//战列巡洋舰
            HeavyCruiser,//重型巡洋舰
            LightCruiser,//轻型巡洋舰
            HeavyFrigate,//重型护卫舰
            LightFrigate,//轻型护卫舰
            Destroyer,//驱逐舰
            Fighter,//战斗机
            Hatch//维生舱
        }
    }
}
