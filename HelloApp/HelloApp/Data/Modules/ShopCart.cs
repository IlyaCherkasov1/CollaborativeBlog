using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HelloApp.Data.Modules
{
    public class ShopCart
    {
        private readonly AppDBContent appDBContent;
        public ShopCart( AppDBContent appDBContent)
        {
            this.appDBContent = appDBContent;
        }
        
        public string ShopCartId { get; set; }
        public List<ShopCarItem> listShopItem { get; set; }

        public static ShopCart GetCart(IServiceProvider service)
        {
            ISession session = service.GetRequiredService<IHttpContextAccessor>()?.HttpContext.Session;
            var context = service.GetService<AppDBContent>();
            string shopCartId = session.GetString("CartId") ?? Guid.NewGuid.ToString();
        }
    }
}
