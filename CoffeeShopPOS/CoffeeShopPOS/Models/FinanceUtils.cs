using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoffeeShopPOS.Models
{
    class FinanceUtils
    {

      
        public static decimal CalculateTax(decimal cost)
        {
            decimal taxRate = .06m;
            decimal result = cost * taxRate;
            return result;
        }



    }
}
