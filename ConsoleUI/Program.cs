using Business.Concrete;
using DataAccess.Concrete.InMemory;
using DataAccess.Concrete.EntityFramework;
using System;

namespace ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            ProductTest();
            //CategoryTest();

        }

        private static void CategoryTest()
        {
            CategoryManager categoryManager = new CategoryManager(new EfCategoryDal());

            foreach (var category in categoryManager.GetAll())
            {
                Console.WriteLine(category.CategoryID + " " + category.CategoryName);
            }
        }

        private static void ProductTest()
        {
            ProductManager productManager = new ProductManager(new EfProductDal());

            var result = productManager.GetProductDetails();

            if(result.Succees)
            {
                foreach (var product in result.Data)
                {
                    Console.WriteLine(product.ProductID + " Ürün adı: " + product.ProductName + "    Kategori adı: " + product.CategoryName);
                }
                Console.WriteLine(result.Message);
            }
            else
            {
                Console.WriteLine(result.Message);
            }


            Console.WriteLine("--------------------------------------");
            foreach (var pro in productManager.GetByUnitPrice(30, 35).Data)
            {
                Console.WriteLine(pro.ProductName);
            }
        }
    }
}