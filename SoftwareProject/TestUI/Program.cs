using Business.Concrete;
using DataAccess.Concrete.Memory;
using System;

namespace TestUI
{
    class Program
    {
        static void Main(string[] args)
        {
            ProductManager productManager = new ProductManager(new MemoryProductDal());

            foreach (var item in productManager.GetAll())
            {
                Console.WriteLine("#" + item.ProductId + ":" + item.ProductName);
            }
            Console.WriteLine("End of Program.cs");
        }
    }
}
