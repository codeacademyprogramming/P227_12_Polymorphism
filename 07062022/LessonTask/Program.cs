using System;

namespace LessonTask
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Store store = new Store();

            Notebook nt1 = new Notebook
            {
                Brand = "Apple",
                Model = "Macbook pro 13",
                CPU = 3,
                RAM = 16,
                Price = 3800
            };

            Notebook nt2 = new Notebook
            {
                Brand = "Acer",
                Model = "Predator",
                CPU = 4,
                RAM = 32,
                Price = 3200
            };

            Notebook nt3 = new Notebook
            {
                Brand = "Apple",
                Model = "Macbook pro 15",
                CPU = 3,
                RAM = 32,
                Price = 4200
            };

            Phone phone1 = new Phone
            {
                Brand = "Apple",
                Model = "Iphone X",
                Price = 2000,
                SimCount = 1
            };
            Phone phone2 = new Phone
            {
                Brand = "Samsung",
                Model = "S20 Ultra",
                Price = 2200,
                SimCount = 2
            };


            store.AddProduct(nt1);
            store.AddProduct(nt2);
            store.AddProduct(nt3);
            store.AddProduct(phone1);
            store.AddProduct(phone2);


            Console.WriteLine(store.GetNotebookCount());
            Console.WriteLine(store.GetPhoneCount());


        }
    }
}
