using Business.Concrete;
using DataAccess.Concrete.InMemory;
using System;

namespace ReCapUI
{
    class Program
    {
        static void Main(string[] args)
        {
            CarManager carManager = new CarManager(new InMemoryCarDal());
            foreach (var item in carManager.GetAll())
            {
                Console.WriteLine($"Id: {item.Id} - BrandId: {item.BrandId} - ColorId: {item.ColorId} - ModelYear: {item.ModelYear} - DailyPrice: {item.DailyPrice} - Description: {item.Description}");
            }
        }
    }
}
