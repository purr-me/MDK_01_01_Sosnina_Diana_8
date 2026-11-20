using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace Shop_Sosnina.Classes
{
    public class Electronics : Shop
    {
        public string BatteryCapacity;
        public string DrivingSpeed;
        public Electronics(string name, int price, string battery, string speed) :
            base(name, price)
        {
            this.BatteryCapacity = battery;
            this.DrivingSpeed = speed;
        }
    }
}
