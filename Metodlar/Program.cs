using System;

namespace Metodlar
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //DRY - Dont Repeat Yourself 
            //Celan code - temiz kod yazmaq
            //Best Practice - Dogru uygulama taktikleri

            string prudoctName = "Apple";
            double Price = 15;
            string Description = "Red apple";

            string[] fruits = new string[] { };

            Product product1 = new Product();
            product1.Name = "Apple";
            product1.Price = 15;
            product1.Description = "Red apple";

            Product product2 = new Product();
            product2.Name = "Watermelon";
            product2.Price = 80;
            product2.Description = "Aqueous watermelon";

            Product[] products = new Product[] { product1,product2};

            foreach (Product prudoct in products)
            {
                Console.WriteLine(prudoct.Name);
                Console.WriteLine(prudoct.Price);
                Console.WriteLine(prudoct.Description);
                Console.WriteLine("-----------------");
            }

            Console.WriteLine("-----------------Methods-----------------");

            //instance - class orneyi
            //encapsulation
            BasketManager basketManager = new BasketManager();
            basketManager.Add(product1);
            basketManager.Add(product2);

            basketManager.Add2("Pear", "Yellow", 12,10);
            basketManager.Add2("Apple", "Yellow Apple", 8,20);
            basketManager.Add2("Waternelon", "Yellow waternelon", 15,30);
        }
    }
}
