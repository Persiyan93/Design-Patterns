using System;
using System.Collections.Generic;
using System.Text;

namespace Decorator_Pattern
{
    public class DecoratorProduct:Product
    {
        Product product;
        public DecoratorProduct(Product product)
        {
            this.product = product;
            this.Name = product.Name;
            this.Price = product.Price;
        }
        public void AddSugar()
        {
            Console.WriteLine("Add sugar");
        }
        public void AddMilk()
        {
            Console.WriteLine("Add milk");
        }
    }
}
