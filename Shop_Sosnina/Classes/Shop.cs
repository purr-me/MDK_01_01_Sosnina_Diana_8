using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shop_Sosnina.Classes
{
    public class Shop
    {
        public string Name { get; set; }
        public int Prace { get; set; }
        public Shop(string name, int prace)
        {
            this.Name = name;
            this.Prace = prace;
        }
    }
}
