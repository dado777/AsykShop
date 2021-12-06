using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AsykShop.Core.Models
{
    public class Asyk
    {
        public int Id { get; set; }
        public string AsykName { get; set; }
        public string AsykShortDesc { get; set; }
        public string AsykLongDesc { get; set; }
        public string AsykImage { get; set; }
        public ushort AsykPrice { get; set; }
        public bool isFavorAsyk { get; set; }
        public bool AsykAvailable { get; set; }

        public int CategoryId { get; set; }
        public virtual Category Category {get; set;}
    }
}
