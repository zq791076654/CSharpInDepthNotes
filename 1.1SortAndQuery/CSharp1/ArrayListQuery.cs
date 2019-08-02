using System;
using System.Collections;
using System.ComponentModel;

namespace _1._1SortAndQuery.CSharp1
{
    [Description("c#1 Query")]
    class ArrayListQuery
    {
        static void Main()
        {
            ArrayList products = Product.GetSampleProducts();
            foreach (Product product in products)
            {
                if (product.Price > 10m)
                {
                    Console.WriteLine(product);
                }
            }
        }
    }
}
