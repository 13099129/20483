using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoffeeShopPOS.Models
{
    public class Order
    {
        public Order()
        {
            Drinks = new List<Drink>();
        }

        public Order(string employeeName):this()
        {

            this.EmployeeName = employeeName;
            
        }
        public Order(string e, string c) : this(e)
        {
            this.CustomerName = c;
        }

        public string EmployeeName { get; set; }
        public string CustomerName { get; set; }
        public System.Collections.Generic.List<Drink> Drinks { get; set; }

        public override string ToString()
        {
            
            System.Text.StringBuilder sb = new StringBuilder();
            sb.AppendLine($"Order For:{CustomerName}");
            sb.AppendLine($"SalesPerson:{EmployeeName}");
            foreach(var drink in Drinks)
            {
                sb.AppendLine($"  {drink.Name}:{drink.Price}");
            }
            sb.AppendLine($"Total:{TotalPrice}");
            sb.AppendLine($"Tax:{FinanceUtils.CalculateTax(TotalPrice)}");
            return sb.ToString();
        }

        public decimal TotalPrice
        {
            get
            {
                decimal result = 0m;
                foreach(var drink in Drinks)
                {
                    result += drink.Price;
                }
                return result;
            }
        }


    }
}
