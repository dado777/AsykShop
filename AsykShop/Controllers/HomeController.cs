using AsykShop.Core.Interfaces;
using AsykShop.ViewModels;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AsykShop.Controllers
{
    public class HomeController : Controller
    {
        private readonly IAllAsyktar _asykRepos;

        public HomeController(IAllAsyktar asykRepos)
        {
            _asykRepos = asykRepos;
        }

        public ViewResult Index()
        {
            var homeAsyktar = new HomeViewModel
            {
                FavouriteAsyktar = _asykRepos.GetFavorAsyk
            };
            return View(homeAsyktar);
        }
    }
}
