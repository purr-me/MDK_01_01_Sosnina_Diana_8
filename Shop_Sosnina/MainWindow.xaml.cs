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
using Shop_Sosnina.Elements;

namespace Shop_Sosnina
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        List<object> AllItems = RepoItems.AllItems();

        public MainWindow()
        {
            InitializeComponent();
            CreateUI();
        }

        public void CreateUI()
        {
            foreach(object item in AllItems)
            {
                parent.Children.Add(new Elements.Item(item));
            }
        }
    }
}
