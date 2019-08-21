using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CoffeeShopPOS.Models;

namespace CoffeeShopPOS.DB
{
    public class OrderDBCSV : IOrderDB
    {
        public List<Order> GetOrders()
        {
            throw new NotImplementedException();
        }

        public bool SaveOrder(Order order)
        {
            System.IO.StreamWriter sw 
                = new System.IO.StreamWriter(@"c:\test\orders.csv",true);

            sw.WriteLine($"Order,{order.CustomerName}" +
                $",{order.EmployeeName},{order.TotalPrice}");

            sw.Close();
            sw.Dispose();

            return true;
        }
    }
}
