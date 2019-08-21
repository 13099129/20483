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

namespace CoffeeShopPOS
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private CoffeeShopPOS.Models.Order currentOrder
            = new Models.Order();

        public MainWindow()
        {
            InitializeComponent();
        }

        private void CreateOrder(object sender, RoutedEventArgs e)
        {
            currentOrder = new Models.Order(System.Environment.UserName);
            // currentOrder.EmployeeName = System.Environment.UserName;
            //currentOrder  = new Models.Order()
            //    { EmployeeName = System.Environment.UserName
            //    , CustomerName="Matt" };
        }

        private void AddCoffee(object sender, RoutedEventArgs e)
        {
            Models.Drink drink = new Models.Drink();
            drink.Name = "COFFEE";
            drink.Price = 1m;
            currentOrder.Drinks.Add(drink);

        }

        private void AddTea(object sender, RoutedEventArgs e)
        {
            Models.Drink drink = new Models.Drink();
            drink.Name = "TEA";
            drink.Price = 1m;
            currentOrder.Drinks.Add(drink);
        }

        private void ReviewOrder(object sender, RoutedEventArgs e)
        {
            MessageBox.Show(currentOrder.ToString());
        }

        private void SaveOrder(object sender, RoutedEventArgs e)
        {
            DB.IOrderDB db = new DB.OrderDBCSV();

            db.SaveOrder(currentOrder);
        }
    }
}
