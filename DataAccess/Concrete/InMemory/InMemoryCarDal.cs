using DataAccess.Abstract;
using Entity.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
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
            Car carToDelete = _cars.SingleOrDefault(z=>z.Id == car.Id);
            _cars.Remove(carToDelete);
        }

        public List<Car> GetAll()
        {
            return _cars;
        }

        public List<Car> GetById(int id)
        {
            return _cars.Where(z => z.Id == id).ToList();
        }

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
