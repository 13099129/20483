using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoffeeShopPOS.DB
{
    public interface IOrderDB
    {
        bool SaveOrder(Models.Order order);
        List<Models.Order> GetOrders();


    }
}
