using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shop_Sosnina.Classes
{
    public class RepoItems
    {
        public static List<object> AllItems()
        {
            List<object> allItems = new List<object>();

            allItems.Add(new Children("Игрушка интерактивная", 2200, 3));
            allItems.Add(new Children("Кактус танцующий", 894, 6));
            allItems.Add(new Children("Мягкая игрушка - кошко подушка", 1754, 6));
            allItems.Add(new Sport("Спортивный мужской костюм", 4913, "S"));
            allItems.Add(new Sport("Мяч для водного поло", 812, "61-61 см."));
            allItems.Add(new Sport("Набор для гольфа Partida", 3950, "600*800 мм."));
            allItems.Add(new Electronics("Электросамокат", 27990, "10 000 мА·ч", "до 25 км/ч"));
            allItems.Add(new Electronics("Электровелосипед ", 48500, "13 000 мА·ч", "до 32 км/ч"));
            return allItems;
        }
    }
}
