using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Threading.Tasks;

namespace AsykShop.Core.Models
{
    public class AsykShopCart
    {
        private readonly AppDBContent _appDBContent;

        public AsykShopCart(AppDBContent appDBContent)
        {
            _appDBContent = appDBContent;
        }

        public string AsykShopCartId { get; set; }
        public List<AsykShopCartItem> ListAsykShopItems { get; set; }

        public static AsykShopCart GetCart(IServiceProvider services)
        {
            ISession session = services.GetRequiredService<IHttpContextAccessor>()?.HttpContext.Session;
            var context = services.GetService<AppDBContent>();
            string asykShopCartId = session.GetString("CartId") ?? Guid.NewGuid().ToString();

            session.SetString("CartId", asykShopCartId);

            return new AsykShopCart(context) { AsykShopCartId = asykShopCartId };
        }

        public void AddToCart(Asyk asyk)
        {
            _appDBContent.AsykShopCartItem.Add(new AsykShopCartItem { AsykShopCartId = AsykShopCartId, Asyktar = asyk, Price = asyk.AsykPrice});

            _appDBContent.SaveChanges();
        }

        public List<AsykShopCartItem> GetAsykShopItems()
        {
            return _appDBContent.AsykShopCartItem.Where(a => a.AsykShopCartId == AsykShopCartId).Include(a => a.Asyktar).ToList();
        }
    }
}
