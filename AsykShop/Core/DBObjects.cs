using AsykShop.Core.Models;
using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AsykShop.Core
{
    public class DBObjects
    {
        private static Dictionary<string, Category> _category;

        public static void Initiate(AppDBContent content)
        {

            if(!content.Category.Any())
                content.Category.AddRange(Categories.Select(v => v.Value));

            if (!content.Asyk.Any())
            {
                content.AddRange(
                     new Asyk
                     {
                         AsykName = "СоқырМерген",
                         AsykShortDesc = "Lorem ipsum dolor sit amet",
                         AsykLongDesc = "consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et ",
                         AsykImageMimeType = "/AsykImage/1.png",
                         AsykPrice = 589,
                         isFavorAsyk = true,
                         AsykAvailable = true,
                         Category = Categories["Сақа"]
                     },
                     new Asyk
                     {
                         AsykName = "МергенСоқыр",
                         AsykShortDesc = "dolore magna aliqua. Ut enim ad minim veniam",
                         AsykLongDesc = "Duis aute irure dolor in reprehenderit in voluptate velit esse cillum dolore eu fugiat nulla pariatur.",
                         AsykImageMimeType = "/AsykImage/2.png",
                         AsykPrice = 421,
                         isFavorAsyk = true,
                         AsykAvailable = true,
                         Category = Categories["Кеней"]
                     },
                     new Asyk
                     {
                         AsykName = "Жұмыр",
                         AsykShortDesc = "Lorem ipsum dolor sit amet",
                         AsykLongDesc = "consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et ",
                         AsykImageMimeType = "/AsykImage/3.png",//Url.Content( "~/AsykImage/МергенСоқыр.jpg" )
                         AsykPrice = 511,
                         isFavorAsyk = true,
                         AsykAvailable = true,
                         Category = Categories["Сақа"]
                     },
                     new Asyk
                     {
                         AsykName = "СынықАсық",
                         AsykShortDesc = "Excepteur sint occaecat cupidatat non proident",
                         AsykLongDesc = "sunt in culpa qui officia deserunt mollit anim id est laborum.",
                         AsykImageMimeType = "/AsykImage/4.png",
                         AsykPrice = 447,
                         isFavorAsyk = true,
                         AsykAvailable = false,
                         Category = Categories["Кеней"]
                     },
                     new Asyk
                     {
                         AsykName = "Ауыр",
                         AsykShortDesc = "Excepteur sint occaecat cupidatat non proident",
                         AsykLongDesc = "sunt in culpa qui officia deserunt mollit anim id est laborum.",
                         AsykImageMimeType = "/AsykImage/5.png",
                         AsykPrice = 600,
                         isFavorAsyk = true,
                         AsykAvailable = false,
                         Category = Categories["Сақа"]
                     }
                    );
            }

            content.SaveChanges();

        }

        public static Dictionary<string, Category> Categories
        {
            get
            {
                if (_category == null)
                {
                    var list = new Category[]
                    {
                        new Category { CategoryName = "Сақа", CategoryDescription = "Асықтың үлкен әрі шымыр түрі."},
                        new Category { CategoryName = "Кеней", CategoryDescription = "Көпшілік ойнауға арналған қарапайым асықтар."}
                    };

                    _category = new Dictionary<string, Category>();

                    foreach (Category item in list)
                        _category.Add(item.CategoryName, item);
                }

                return _category;
            }
        }
    }
}
