using System;
using System.Collections.Generic;
using System.Text;

namespace ZadaciZaDoma
{
    public class VtoraZadaca
    {
        public void RunVtoraZadaca()
        {
            // Ne doresena
            // Kolku proizvodi sakam da vnesam
            Console.WriteLine("smoki 15 den ");
            var brojNaProizvodi1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("coca cola 40 den. ");
            var brojNaProizvodi2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Aleksandria kuve 400 den ");
            var brojNaProizvodi3 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Vkupno denari");
            
            var shoppingCart = new ShoppingCart();

                
            //for loop za vnes na proizvodi
                
            {

                //var product = new Product() { Name = "Smoki", Price = 10 };
                //shoppingCart.AddArticle(product);
                shoppingCart.AddArticle("Smoki", 15);
                shoppingCart.AddArticle("coca cola", 30);
                shoppingCart.AddArticle("Aleksandria kuve", 400);
            }

            Console.WriteLine(shoppingCart.Sum());
        }
    }

    public class ShoppingCart
    {
        public List<ProductQuantity> products { get; set; } = new List<ProductQuantity>();

        public void AddArticle(string name, int price, int quantity = 1 )
        {
            var product = new Product() { Name = name, Price = price };
            products.Add(new ProductQuantity() { Product = product, Quantity = quantity });
        }

        public void AddArticle(Product p, int quantity = 1)
        {
            products.Add(new ProductQuantity() { Product = p, Quantity = quantity });

        }

        public double Sum()
        {
            var total = 0;
            foreach (var product in products)
            {
                total += product.Product.Price * product.Quantity;
            }
            return total;
        }
    }

    public class Product
    {
        public string Name { get; set; }
        public int Price { get; set; }
    }

    public class ProductQuantity
    {
        public Product Product { get; set; }
        public int Quantity { get; set; }
    }
}