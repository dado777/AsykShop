using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AsykShop.Core.Models
{
    public class AsykShopCartItem
    {
        public int Id { get; set; }
        public int Price { get; set; }
        public string AsykShopCartId { get; set; }
        public Asyk Asyktar { get; set; }
    }
}
