using AsykShop.Core.Interfaces;
using AsykShop.Core.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AsykShop.Controllers
{
    public class OrderController : Controller
    {
        private readonly IAllOrders _allOrders;
        private readonly AsykShopCart _asykShopCart;

        public OrderController(IAllOrders _allOrders, AsykShopCart _asykShopCart)
        {
            this._allOrders = _allOrders;
            this._asykShopCart = _asykShopCart;
        }

        public IActionResult Checkout()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Checkout(Order order)
        {
            _asykShopCart.ListAsykShopItems = _asykShopCart.GetAsykShopItems();

            if (_asykShopCart.ListAsykShopItems.Count == 0)
                ModelState.AddModelError("", "Сізде тауар жоқ!");

            if (ModelState.IsValid)
            {
                _allOrders.CreateOrder(order);

                return RedirectToAction("Complete");
            }

            return View();
        }

        public IActionResult Complete()
        {
            ViewBag.Message = "Тапсырыз сәтті қабылданды";
            return View();
        }
    }
}
