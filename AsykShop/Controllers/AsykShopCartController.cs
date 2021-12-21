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

        public AsykShopCartController(IAllAsyktar asykRepos, AsykShopCart asykShopCart)
        {
            _asykRepos = asykRepos;
            _asykShopCart = asykShopCart;
        }

        public ViewResult Index()
        {
            var obj = new AsykShopCartViewModel { AsyktarShopCart = _asykShopCart };
            var items = _asykShopCart.GetAsykShopItems();
            _asykShopCart.ListAsykShopItems = items;

            return View(obj);
        }

        public RedirectToActionResult AddToCart(int id)
        {
            var item = _asykRepos.Asyktar.FirstOrDefault(i => i.Id == id);

            if (item != null)
                _asykShopCart.AddToCart(item);

            return RedirectToAction("Index");
        }
    }
}
