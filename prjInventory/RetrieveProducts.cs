using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prjInventoryManagement
{
    public static class RetrieveProducts
    {
        public static double GetTotalPrice(List<Product> products)
        {
            // Calculate the total price of all products  
            return products.Sum(p => p.Price);
        }
        public static List<Product> FilterProductsByStock(this List<Product> products)
        {
            // Filter products that are in stock (Quantity >
            return products.OrderBy(p => p.Quantity).ToList();
        }
        public static List<Product> SelectProducts(this List<Product> products)
        {
            // Filter products that are in stock (Quantity >
            return (List<Product>)products.Select(p => new { p.Name, p.Price });
        }
    }
}
