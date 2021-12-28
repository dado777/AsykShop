using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AsykShop.Core.Models
{
    public class OrderDetail
    {
        public int Id { get; set; }
        public int OrderId { get; set; }
        public int AsykId { get; set; }
        public uint Price { get; set; }

        public virtual Asyk asyk { get; set; }
        public virtual Order order { get; set; }
    }
}
