using System;
using System.Collections.Generic;
using System.Net.Http.Headers;
using System.Text;
using System.Threading;

namespace Proxy_Pattern
{
    public class ShopCatalog : IShopCatalog
    {
        List<string> products;
        public ShopCatalog()
        {
            this.products = new List<string>();
        }

        public int Count => products.Count;

        public void AddProduct(string product)
        {
            products.Add(product);
        }

        

        public void RemoveProduct(string product)
        {
            products.Remove(product);
        }
    }
}
