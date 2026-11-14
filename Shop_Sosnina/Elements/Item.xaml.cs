using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using Shop_Sosnina.Classes;

namespace Shop_Sosnina.Elements
{
    /// <summary>
    /// Логика взаимодействия для Item.xaml
    /// </summary>
    public partial class Item : UserControl
    {
        public Item(object item)
        {
            InitializeComponent();

            Shop ShopData = item as Shop;
            IName.Content = ShopData.Name;
            IPrice.Content = "Цена: " + ShopData.Price;
            
            if(item is Children)
            {
                Children ChildrenData = item as Children;
                ICharacteristic.Content = "Возраст: " + ChildrenData.Age;
            }
            if(item is Sport)
            {
                Sport SportData = item as Sport;
                ICharacteristic.Content = "Размер: " + SportData.Size;
            }
        }
    }
}
