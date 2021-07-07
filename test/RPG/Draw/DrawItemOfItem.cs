using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace test
{
    class DrawItemOfItem : DrawItem
    {
        public int ID { get; }
        public string Name { get; set; }
        public int Probability { get; set; }

        public Item item = new Item();

        public DrawItemOfItem(int id,string name)
        {
            ID = id;
            item.Name = Name = name;
        }

        public Item GetValue()
        {
            return item;
        }
    }
}
