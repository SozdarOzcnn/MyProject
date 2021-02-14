using Business.Concete;
using DataAccess.Concete.EntityFramework;
using DataAccess.Concete.InMemory;
using System;

namespace ConsoleUI
{
    //SOLID
    //Open Closed Principle : yapılan yazılıma yeni özellik ekliyorsa mevcut kodu değiştirmeye gerek kalmamalı
    class Program
    {
        static void Main(string[] args)
        {
            ProductManager productManager = new ProductManager(new EfProductDal());

            foreach (var item in productManager.GetByUnitPrice(50,100))
            {
                Console.WriteLine(item.ProductName);
            }
            Console.ReadLine();
        }
    }
}
