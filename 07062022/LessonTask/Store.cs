using System;
using System.Collections.Generic;
using System.Text;

namespace LessonTask
{
    internal class Store
    {
        public Store()
        {
            Products = new Product[0];
        }
        public Product[] Products;

        public void AddProduct(Product product)
        {
            Array.Resize(ref Products, Products.Length + 1);
            Products[Products.Length - 1] = product;
        }

        public int GetNotebookCount()
        {
            int count = 0;
            foreach (var item in Products)
            {
                if (item is Notebook)
                    count++;
            }

            return count;
        }

        public int GetPhoneCount()
        {
            int count = 0;

            foreach (var item in Products)
            {
                if (item is Phone)
                    count++;
            }

            return count;
        }
    }
}
