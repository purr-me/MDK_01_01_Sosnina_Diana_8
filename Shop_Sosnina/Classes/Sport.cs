using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shop_Sosnina.Classes
{
    public class Sport : Shop
    {
        public string Size;
        public Sport(string name, int price, string size) :
            base(name, price)
        {
            this.Size = size;
        }

        public override string GetCharacteristic()
        {
            return "Размер: " + Size;
        }
    }
}
