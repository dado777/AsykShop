using AsykShop.Core.Interfaces;
using AsykShop.ViewModels;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AsykShop.Controllers
{
    public class AsyktarController : Controller
    {
        private readonly IAllAsyktar iAllAsyktar;
        private readonly IAsyktarCategory iAsyktarCategory;
        
        public AsyktarController(IAllAsyktar allAsyktar, IAsyktarCategory asyktarCategory)
        {
            iAllAsyktar = allAsyktar;
            iAsyktarCategory = asyktarCategory;
        }

        public ViewResult ListofAsyk()
        {
            ViewBag.Title = "Асықтар парақшасы";
            AsykListViewModel asykObj = new AsykListViewModel();
            asykObj.getAllAsyktar = iAllAsyktar.Asyktar;
            asykObj.currentCategory = "Асықтар";
            
            return View(asykObj);
        }
    }
}
