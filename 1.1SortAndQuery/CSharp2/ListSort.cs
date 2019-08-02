using System;
using System.Collections.Generic;
using System.ComponentModel;

namespace _1._1SortAndQuery.CSharp2
{
    [Description("c#2 Sort")]
    class ListSort
    {
        static void Main()
        {
            List<Product> products = Product.GetSampleProducts();
            products.Sort(delegate (Product first, Product second)
            { return first.Name.CompareTo(second.Name); }
            );
            foreach (Product product in products)
            {
                Console.WriteLine(product);
            }
        }
    }
}
