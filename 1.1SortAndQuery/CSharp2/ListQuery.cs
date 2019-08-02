using System;
using System.Collections.Generic;
using System.ComponentModel;

namespace _1._1SortAndQuery.CSharp2
{
    [Description("c#2 Query")]
    class ListQuery
    {
        static void Main()
        {
            List<Product> products = Product.GetSampleProducts();
            products.FindAll(delegate (Product p) { return p.Price > 10; })
                    .ForEach(delegate (Product p) { Console.WriteLine(p); });
        }
    }
}
