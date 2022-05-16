using AsykShop.Core.Interfaces;
using AsykShop.Core.Models;
using AsykShop.ViewModels;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Http;

namespace AsykShop.Controllers
{
    public class AsyktarController : Controller
    {
        private readonly IAllAsyktar _iAllAsyktar;
        private readonly IAsyktarCategory _iAsyktarCategory;
        
        public AsyktarController(IAllAsyktar allAsyktar, IAsyktarCategory asyktarCategory)
        {
            _iAllAsyktar = allAsyktar;
            _iAsyktarCategory = asyktarCategory;
        }

        [Route("Asyktar/List")]
        [Route("Asyktar/List/{category}")]
        public ViewResult ListofAsyk(string category)
        {
            string _category = category;
            string currentCategory = null;
            IEnumerable<Asyk> asyktar = null;

            if (string.IsNullOrEmpty(category))
            {
                asyktar = _iAllAsyktar.Asyktar.OrderBy(i => i.Id);
            }
            else
            {
                if(string.Equals("Keney", category, StringComparison.OrdinalIgnoreCase))
                {
                    asyktar = _iAllAsyktar.Asyktar.Where(i => i.Category.CategoryName.Equals("Кеней")).OrderBy(i => i.Id);
                    currentCategory = "Кеней";
                }
                else if (string.Equals("Saka", category, StringComparison.OrdinalIgnoreCase))
                {
                    asyktar = _iAllAsyktar.Asyktar.Where(i => i.Category.CategoryName.Equals("Сақа")).OrderBy(i => i.Id);
                    currentCategory = "Сақа";
                }
            }

            var asykObj = new AsykListViewModel
            {
                getAllAsyktar = asyktar,
                currentCategory = currentCategory
            };

            ViewBag.Title = "Асықтар парақшасы";
            
            return View(asykObj);
        }

        public FileContentResult GetAsykImage(int asykId) //works any other identifier, but not "id" identifier. "id" identifier has 0 value, so Model.Id in AllAsyktar.cshtml assign nothing and image doesn't display
        {
            Asyk asyk = _iAllAsyktar.Asyktar.FirstOrDefault(a => a.Id == asykId);

            if (asyk != null)
                return File(asyk.AsykImageData, asyk.AsykImageMimeType);
            else
                return null;
        }
    }
}
