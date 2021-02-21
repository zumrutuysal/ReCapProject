using DataAccess.Abstract;
using Entity.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;

namespace DataAccess.Concrete.InMemory
{
    public class InMemoryCarDal : ICarDal
    {
        List<Car> _cars;

        public InMemoryCarDal()
        {
            _cars = new List<Car>{
                new Car {Id = 1, BrandId = 1, ColorId = 1, ModelYear = 2021, DailyPrice = 200000, Description = "Audi" },
                new Car {Id = 2, BrandId = 2, ColorId = 2, ModelYear = 2020, DailyPrice = 90000, Description = "Tofaş" },
                new Car {Id = 3, BrandId = 3, ColorId = 2, ModelYear = 1999, DailyPrice = 120000, Description = "Peugeot" },
                new Car {Id = 4, BrandId = 4, ColorId = 1, ModelYear = 2010, DailyPrice = 140000, Description = "Mercedes" },
                new Car {Id = 5, BrandId = 5, ColorId = 1, ModelYear = 2007, DailyPrice = 62000, Description = "Fiat" }
            };
        }

        public void Add(Car car)
        {
            throw new NotImplementedException();
        }

        public void Delete(Car car)
        {
            Car carToDelete = _cars.SingleOrDefault(z => z.Id == car.Id);
            _cars.Remove(carToDelete);
        }

        public Car Get(Expression<Func<Car, bool>> filter)
        {
            throw new NotImplementedException();
        }

        public List<Car> GetAll()
        {
            return _cars;
        }

        public List<Car> GetAll(Expression<Func<Car, bool>> filter = null)
        {
            throw new NotImplementedException();
        }

        public List<Car> GetById(int id)
        {
            //bool result = _cars.Any(z => z.Id == id);
            //Car car = _cars.Find(z => z.Id == id);
            //var resultList = _cars.FindAll(z => z.Id.Equals(id)).OrderByDescending(z => z.ModelYear).ThenBy(z => z.Id);

            //var resultSelect = from z in _cars
            //                   where z.DailyPrice > 1000 && z.ColorId == 12
            //                   orderby z.Id descending, z.BrandId ascending
            //                   select z;

            //var resultSelectDto = from z in _cars
            //                      where z.DailyPrice > 1000 && z.ColorId == 12
            //                      orderby z.Id descending, z.BrandId ascending
            //                      select new CarDto { Id = z.Id, BrandId = z.BrandId };


            //List<Brand> brands = new List<Brand> {
            //    new Brand { Id = 1, Name = "Audi"},
            //    new Brand { Id = 1, Name = "Peuget"},
            //    new Brand { Id = 1, Name = "Mercedes"},
            //};

            //var join = from c in _cars
            //           join b in brands
            //           on c.BrandId equals b.Id
            //           where c.Id == id
            //           orderby c.Id ascending
            //           select new CarDto {BrandName = b.Name, Id=c.Id, BrandId=b.Id };

            //foreach (var item in join)
            //{
            //    Console.WriteLine($"BrandName: {item.BrandName}");
            //}

            return _cars.Where(z => z.Id == id).ToList();
        }

        //class CarDto
        //{
        //    public int Id { get; set; }
        //    public int BrandId { get; set; }
        //    public string BrandName { get; set; }
        //}

        //public class Brand
        //{
        //    public int Id { get; set; }
        //    public string Name { get; set; }
        //}

        public void Update(Car car)
        {
            Car updateToCar = _cars.SingleOrDefault(z => z.Id == car.Id);
            updateToCar.BrandId = car.BrandId;
            updateToCar.ColorId = car.ColorId;
            updateToCar.ModelYear = car.ModelYear;
            updateToCar.DailyPrice = car.DailyPrice;
            updateToCar.Description = car.Description;
        }
    }
}
