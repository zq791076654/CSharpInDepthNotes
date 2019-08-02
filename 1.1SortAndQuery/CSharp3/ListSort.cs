using _1._1SortAndQuery.CSharp2;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;

namespace _1._1SortAndQuery.CSharp3
{
    [Description("c#3 Sort")]
    class ListSort
    {
        static void Main()
        {
            List<Product> products = Product.GetSampleProducts();
            foreach (Product product in products.OrderBy(p => p.Name))
            {
                Console.WriteLine(product);
            }
        }
    }
}
