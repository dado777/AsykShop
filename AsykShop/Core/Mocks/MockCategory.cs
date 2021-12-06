// Данный класс будет мокать, тобишь реализовать интерфейсы из папки Interfaces, дабы последствие извлечь данные из класса Category

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AsykShop.Core.Interfaces;
using AsykShop.Core.Models;

namespace AsykShop.Core.Mocks
{
    public class MockCategory : IAsyktarCategory
    {
        public IEnumerable<Category> GetAllCategories
        {
            get
            {
                return new List<Category>
            {
                new Category { CategoryName = "Сақа", CategoryDescription = "Асықтың үлкен әрі шымыр түрі."},
                new Category { CategoryName = "Кеней", CategoryDescription = "Көпшілік ойнауға арналған қарапайым асықтар."}
            };
            }
        }
    }
}
