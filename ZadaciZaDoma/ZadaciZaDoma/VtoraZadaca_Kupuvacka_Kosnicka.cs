using System;
using System.Collections.Generic;
using System.Text;

namespace ZadaciZaDoma
{
    public class VtoraZadaca_Kupuvacka_Kosnicka
    {
        public void RunVtoraZadaca()
        {
            // Ne doresena
            // Kolku proizvodi sakam da vnesam
            var shoppingCart = new ShoppingCart();
            var shoppingCart2 = new ShoppingCart();
            var shoppingCart3 = new ShoppingCart();
            var totalPrice = new ShoppingCart();

            //for loop za vnes na proizvodi
            Console.Write("Smoki 15 denari x ");
            var brojNaProizvodi = Convert.ToInt32(Console.ReadLine());
            for (int i = 0; i < brojNaProizvodi; i++)
            {
                shoppingCart.AddArticle("Smoki", 15);       //  3
            }
            Console.Write(shoppingCart.Sum());
            Console.WriteLine(" denari");
          
            Console.Write("Coca Cola 75 denari x ");
            var brojNaProizvodi2 = Convert.ToInt32(Console.ReadLine());
            for (int i = 0; i < brojNaProizvodi2; i++)
            {
                shoppingCart2.AddArticle("Coca Cola", 75);
            }
            Console.Write(shoppingCart2.Sum());
            Console.WriteLine(" denari");

            Console.Write("Coko Banana 5 denari x ");
            var brojNaProizvodi3 = Convert.ToInt32(Console.ReadLine());
            for (int i = 0; i < brojNaProizvodi3; i++)
            {
                shoppingCart3.AddArticle("Coko Banana", 5);
            }
            Console.Write(shoppingCart3.Sum());
            Console.WriteLine(" denari");
       
            Console.WriteLine();
            Console.Write("Total : ");
            Console.WriteLine(" denari");

            Console.Write("Coko Banana 5 denari x ");
            var topalPrice = Convert.ToInt32(Console.ReadLine());
            for (int i = 0; i < brojNaProizvodi3; i++)
            {
                shoppingCart3.AddArticle("Coko Banana", 5);
            }
            Console.Write(shoppingCart3.Sum());
            Console.WriteLine(" denari");
        }
        public static void Total()
        {
            
        }
        public class ShoppingCart
        {
            public List<Product> products { get; set; } = new List<Product>();

            public void AddArticle(string name, int price, int quantity = 1)
            {
                for (int i = 0; i < quantity; i++)
                {
                    products.Add(new Product() { Name = name, Price = price });
                }
            }
            public void AddArticle(Product p, int? quantity = 1)
            {
                for (int i = 0; i < quantity; i++)
                {
                    products.Add(p);
                }
            }
            public double Sum()
            {
                var total = 0;
                foreach (var product in products)
                {
                    total += product.Price;
                }
                return total;
            }
            public static void  SumTotal()
            {

            }
        }
        public class Product
        {
            public string Name { get; set; }
            public int Price { get; set; }
        }
    }
}