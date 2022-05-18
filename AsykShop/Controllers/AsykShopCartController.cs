using AsykShop.Core.Interfaces;
using AsykShop.Core.Models;
using AsykShop.ViewModels;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AsykShop.Controllers
{
    public class AsykShopCartController : Controller
    {
        private readonly IAllAsyktar _asykRepos;
        private readonly AsykShopCart _asykShopCart;
        private readonly IAllOrders _allOrders;

        public AsykShopCartController(IAllAsyktar asykRepos, AsykShopCart asykShopCart, IAllOrders allOrders)
        {
            _asykRepos = asykRepos;
            _asykShopCart = asykShopCart;
            _allOrders = allOrders;
        }

        public ViewResult Index()
        {
            var items = _asykShopCart.GetAsykShopItems();
            _asykShopCart.ListAsykShopItems = items;

            var obj = new AsykShopCartViewModel { AsyktarShopCart = _asykShopCart };

            return View(obj);
        }

        public RedirectToActionResult AddToCartController(int id)
        {
            var item = _asykRepos.Asyktar.FirstOrDefault(i => i.Id == id);

            if (item != null)
                _asykShopCart.AddToCart(item);

            return RedirectToAction("Index");
        }

        [HttpPost]
        public ActionResult Delete(int idCartContent)
        {
            AsykShopCartItem deletedAsyk = _allOrders.DeleteAsykFromCart(idCartContent);

            if(deletedAsyk != null)
            {
                TempData["message"] = string.Format("Асық себеттен өшірілді!");
            }

            return RedirectToAction("Index");
        }
    }
}
