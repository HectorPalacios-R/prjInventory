using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prjInventoryManagement
{
    //(Ślusarczyk, 2025) I am referencing this a source for all the code here except for the ones I referenced with another source
    //Extension Methods require a static class and static methods
    public static class RetrieveProducts
    {

        public static double GetTotalPrice(List<Product> products)
        {
            // Calculate the total price of all products
            // The Sum() method is used to sum up the Price property of each product
            return products.Sum(p => p.Price);
        }
        public static List<Product> FilterProductsByStock(this List<Product> products)
        {
            // Filter products that are in low stock
            return products.OrderBy(p => p.Quantity).ToList();
        }
        public static IEnumerable<object> SelectProducts(this IEnumerable<Product> products)
        {
            // Select the name and price from the product list
            //return an Inenumerable with anonymous type containing Name and Price
            return products.Select(p => new { p.Name, p.Price });
        }
    }
}
/*
 Reference List:
 Ślusarczyk, K. 2025. Ultimate C# Masterclass for 2025. [online] Available at: <https://www.udemy.com/course/ultimate-csharp-masterclass/?couponCode=25BBPMXPLOYCTRL> [Accessed 23 March 2025]
 */
