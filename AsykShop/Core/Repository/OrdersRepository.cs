using AsykShop.Core.Interfaces;
using AsykShop.Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AsykShop.Core.Repository
{
    public class OrdersRepository : IAllOrders
    {
        private readonly AppDBContent _appDBContent;
        private readonly AsykShopCart _asykShopCart;

        public OrdersRepository(AppDBContent _appDBContent, AsykShopCart _asykShopCart)
        {
            this._appDBContent = _appDBContent;
            this._asykShopCart = _asykShopCart;
        }

        public void CreateOrder(Order order)
        {
            order.OrderDate = DateTime.Now;
            _appDBContent.Order.Add(order);
            //_appDBContent.SaveChanges();

            var items = _asykShopCart.ListAsykShopItems;

            foreach (var item in items)
            {
                var orderDetail = new OrderDetail()
                {
                    AsykId = item.Asyktar.Id,
                    OrderId = order.Id,
                    Price = item.Asyktar.AsykPrice
                };

                _appDBContent.OrderDetail.Add(orderDetail);
            }

            _appDBContent.SaveChanges();
        }
    }
}
