using AsykShop.Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AsykShop.ViewModels
{
    public class HomeViewModel
    {
        public IEnumerable<Asyk> FavouriteAsyktar { get; set; }
    }
}
