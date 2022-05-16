using AsykShop.Core.Interfaces;
using AsykShop.Core.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.IO;
using System.Linq;

namespace AsykShop.Controllers
{
    public class AdminController : Controller
    {
        IAllAsyktar repository;

        public AdminController(IAllAsyktar repository)
        {
            this.repository = repository;
        }

        public ViewResult Index()
        {
            return View(repository.Asyktar);
        }

        public ViewResult Edit(int id) //works only with "id" identifier, any other identifier (example: asykId or asykid) throw null exception
        {
            Asyk asyk = repository.Asyktar.FirstOrDefault(a => a.Id == id);

            return View(asyk);
        }

        // The version of overloaded method Edit() needs for changings in item(asyk good)
        [HttpPost]
        public ActionResult Edit(Asyk asyk, IFormFile image)
        {
            if(ModelState.IsValid)
            {
                if(image != null)
                {
                    asyk.AsykImageMimeType = image.ContentType;

                    using (var binaryReader = new BinaryReader(image.OpenReadStream()))
                    {
                        asyk.AsykImageData = binaryReader.ReadBytes((int)image.Length);
                    }
                }

                repository.SaveAsyk(asyk);
                TempData["message"] = string.Format("\"{0}\" тауарының өзгерістері сақталды!", asyk.AsykName);
                return RedirectToAction("Index");
            }
            else
            {
                //something wrong with values of item
                return View(asyk);
            }
        }

        public ViewResult Create()
        {
            return View("Edit", new Asyk());
        }

        [HttpPost]
        public ActionResult Delete(int id)
        {
            Asyk deletedAsyk = repository.DeleteAsyk(id);
            if(deletedAsyk != null)
            {
                TempData["message"] = string.Format("Асық \"{0}\" өшірілді!", deletedAsyk.AsykName);
            }

            return RedirectToAction("Index");
        }
    }
}