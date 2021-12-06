// Данный интерфейс описывает одну свойству, цель которого получить/присваивать данные из класса Asyk
using AsykShop.Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AsykShop.Core.Interfaces
{
    public interface IAllAsyktar
    {
        IEnumerable<Asyk> Asyktar { get; }
        IEnumerable<Asyk> GetFavorAsyk { get; set; }
        Asyk GetAsykObject(int asykId);
    }
}
