using System;
using System.Collections.Generic;
using System.Text;

namespace Proxy_Pattern
{
    public interface IShopCatalog
    {
        public int Count { get; }
        public void AddProduct(string product);
        public void RemoveProduct(string product );

        
    }
}
