using AsykShop.Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AsykShop.Core.Interfaces
{
    public interface IAllOrders
    {
        void CreateOrder(Order order);
        AsykShopCartItem DeleteAsykFromCart(int asykCartId);
    }
}
