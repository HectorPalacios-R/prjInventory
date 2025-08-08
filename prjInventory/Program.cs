using prjInventoryManagement;

namespace prjInventory
{
    public class Program
    {
        //(Ślusarczyk, 2025) I am referencing this a source for all the code here except for the ones I referenced with another source
        static void Main(string[] args)
        {
           var products = new List<Product>()
           { new Product { ID = 1, Name = "Laptop", Quantity = 5, Price = 1200.00 },
             new Product { ID = 2, Name = "Smartphone", Quantity = 10, Price = 800.00 },
             new Product { ID = 3, Name = "Tablet", Quantity = 3, Price = 600.00 },
             new Product { ID = 4, Name = "Monitor", Quantity = 8, Price = 300.00 },
             new Product { ID = 5, Name = "Keyboard", Quantity = 15, Price = 50.00 }
           };
            //Display the total price of all products
            RetrieveProducts.GetTotalPrice(products);
            // Display the products from low stock to high stock
            RetrieveProducts.FilterProductsByStock(products);
            var selectedProducts = RetrieveProducts.SelectProducts(products);
            foreach (Product product in selectedProducts)
            {
                Console.WriteLine($"Product Name: {product.Name}, Price: {product.Price}");
            }

        }
        
    }
}
/*
 Reference List:
 Ślusarczyk, K. 2025. Ultimate C# Masterclass for 2025. [online] Available at: <https://www.udemy.com/course/ultimate-csharp-masterclass/?couponCode=25BBPMXPLOYCTRL> [Accessed 23 March 2025]
 */