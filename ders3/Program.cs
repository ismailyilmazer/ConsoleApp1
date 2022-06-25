using System;

namespace ders3 {

class program
    {

        static void Main(string[] args)
        {
            Product product1 = new Product();
            product1.cost = 23;
            product1.Name = "milk";
            product1.Id = 4716;

            Product product2 = new Product();
            product2.cost = 26;
            product2.Name = "watermalona";
            product2.Id = 4716;

            Product[] products = new Product[] { product1, product2 };

            foreach (Product a in products)
            {
                Console .WriteLine(a.Name); 
            }

            SepetManager sepetManager = new SepetManager();
            sepetManager.Ekle(product1);
        }
    }


}
