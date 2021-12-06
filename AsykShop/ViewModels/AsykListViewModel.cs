using AsykShop.Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AsykShop.ViewModels
{
    public class AsykListViewModel
    {
        public IEnumerable<Asyk> getAllAsyktar { get; set; }

        public string currentCategory { get; set; }
    }
}
