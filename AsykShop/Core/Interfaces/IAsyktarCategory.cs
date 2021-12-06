// Данный интерфейс описывает одну свойству, цель которого получить/присваивать данные из класса Category
using AsykShop.Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AsykShop.Core.Interfaces
{
    public interface IAsyktarCategory
    {
        IEnumerable<Category> GetAllCategories { get; }
    }
}
