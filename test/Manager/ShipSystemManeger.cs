using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace test.SpaceShips
{
    class ShipSystemManager : Manager<ShipSystemManager>
    {
        readonly Dictionary<string, ShipSystem> systems = new Dictionary<string, ShipSystem>();
        public void Init(ShipSystem system)
        {
            system.Init();
            if (!systems.ContainsKey(system.Name))
            {
                systems.Add(system.Name, system);
            }
        }
    }
}
