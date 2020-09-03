using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;

namespace Proxy_Pattern
{
    public class ProxyShopCatalog : IShopCatalog
    {
        private ShopCatalog catalog;
        private List<string> verifiedUsers;
        private string currentUser;
        public ProxyShopCatalog(string user)
        {
            catalog = new ShopCatalog();
            this.currentUser = user;
        }
        public int Count => catalog.Count;

        public void AddProduct(string product)
        {
            catalog.AddProduct(product);
        }

        public void RemoveProduct(string product)
        {
            if (verifiedUsers.Contains(currentUser))
            {
                catalog.RemoveProduct(product);
            }
            
        }
    }
}
