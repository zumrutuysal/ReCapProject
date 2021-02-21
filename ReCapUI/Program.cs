using Business.Concrete;
using DataAccess.Concrete.InMemory;
using DataAccess.EntityFramework;
using Entity.Concrete;
using System;

namespace ReCapUI
{
    class Program
    {
        static void Main(string[] args)
        {
            //InMemoryCarGetData();

            EntityFrameworkGetDataTest();
            EntityFrameworkAddTest();
            EntityFrameworkUpdateTest();
        }

        private static void EntityFrameworkGetDataTest()
        {
            CarManager carManager = new CarManager(new EfCarDal());
            foreach (var item in carManager.GetAll())
            {
                Console.WriteLine($"Id: {item.Id} - BrandId: {item.BrandId} - ColorId: {item.ColorId} - ModelYear: {item.ModelYear} - DailyPrice: {item.DailyPrice} - Description: {item.Description}");
            }
        }
        
        private static void EntityFrameworkAddTest()
        {
            CarManager carManager = new CarManager(new EfCarDal());
            Car carToAdd = new Car { Id = 7, BrandId = 3, ColorId = 2, ModelYear = 2020, DailyPrice = 300, Description = "Peugeot 308" };
            carManager.Add(carToAdd);
        }

        public static void EntityFrameworkUpdateTest()
        {

            CarManager carManager = new CarManager(new EfCarDal());
            carManager.Update(new Car { Id = 2, BrandId = 1, ColorId = 1, ModelYear = 2016, Description = "Manuel", DailyPrice = 200 });            
        }

        private static void InMemoryCarGetData()
        {
            CarManager carManager = new CarManager(new InMemoryCarDal());
            foreach (var item in carManager.GetAll())
            {
                Console.WriteLine($"Id: {item.Id} - BrandId: {item.BrandId} - ColorId: {item.ColorId} - ModelYear: {item.ModelYear} - DailyPrice: {item.DailyPrice} - Description: {item.Description}");
            }
        }
    }
}
