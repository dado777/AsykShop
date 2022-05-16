// Данный класс будет мокать, тобишь реализовать интерфейсы из папки Interfaces, дабы последствие извлечь данные из класса Asyk

using AsykShop.Core.Interfaces;
using AsykShop.Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AsykShop.Core.Mocks
{
    public class MockAsyktar
    {
        private readonly IAsyktarCategory _categoryAsyk = new MockCategory();
        public IEnumerable<Asyk> Asyktar {
            get {
                return new List<Asyk>
                    {
                     new Asyk{
                    AsykName = "СоқырМерген",
                    AsykShortDesc = "Lorem ipsum dolor sit amet",
                    AsykLongDesc = "consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et ",
                    AsykImageMimeType = "/AsykImage/1.png",
                    AsykPrice = 589,
                    isFavorAsyk = true,
                    AsykAvailable = true,
                    Category = _categoryAsyk.GetAllCategories.First()
                    },
                     new Asyk{
                    AsykName = "МергенСоқыр",
                    AsykShortDesc = "dolore magna aliqua. Ut enim ad minim veniam",
                    AsykLongDesc = "Duis aute irure dolor in reprehenderit in voluptate velit esse cillum dolore eu fugiat nulla pariatur.",
                    AsykImageMimeType = "/AsykImage/2.png",
                    AsykPrice = 421,
                    isFavorAsyk = true,
                    AsykAvailable = true,
                    Category = _categoryAsyk.GetAllCategories.Last()
                     },
                     new Asyk{
                    AsykName = "Жұмыр",
                    AsykShortDesc = "Lorem ipsum dolor sit amet",
                    AsykLongDesc = "consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et ",
                    AsykImageMimeType = "/AsykImage/3.png",//Url.Content( "~/AsykImage/МергенСоқыр.jpg" )
                    AsykPrice = 511,
                    isFavorAsyk = true,
                    AsykAvailable = true,
                    Category = _categoryAsyk.GetAllCategories.First()
                    },
                     new Asyk{
                    AsykName = "СынықАсық",
                    AsykShortDesc = "Excepteur sint occaecat cupidatat non proident",
                    AsykLongDesc = "sunt in culpa qui officia deserunt mollit anim id est laborum.",
                    AsykImageMimeType = "/AsykImage/4.png",
                    AsykPrice = 447,
                    isFavorAsyk = true,
                    AsykAvailable = false,
                    Category = _categoryAsyk.GetAllCategories.Last()
                     },
                     new Asyk{
                    AsykName = "Ауыр",
                    AsykShortDesc = "Excepteur sint occaecat cupidatat non proident",
                    AsykLongDesc = "sunt in culpa qui officia deserunt mollit anim id est laborum.",
                    AsykImageMimeType = "/AsykImage/5.png",
                    AsykPrice = 600,
                    isFavorAsyk = true,
                    AsykAvailable = false,
                    Category = _categoryAsyk.GetAllCategories.First()
                     }
                    };
                }
            }
        public IEnumerable<Asyk> GetFavorAsyk { get; set; }

        public Asyk GetAsykObject(int asykId)
        {
            throw new NotImplementedException();
        }

    }
}
