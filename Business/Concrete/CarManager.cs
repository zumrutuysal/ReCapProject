using Business.Abstract;
using DataAccess.Abstract;
using Entity.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Concrete
{
    public class CarManager : ICarService
    {
        ICarDal _carDal;
        public CarManager(ICarDal carDal)
        {
            _carDal = carDal;
        }

        public void Add(Car car)
        {
            if (car.Description.Length >= 2 && car.DailyPrice > 0)
            {
                _carDal.Add(car);
                Console.WriteLine($"Car Id: {car.Id} added.");
            }
            else
            {
                Console.WriteLine("Car add failed! Car Name must be min 2 characters and Car DailyPrice must be greater than 0!");
            }
        }

        public List<Car> GetAll()
        {
            return _carDal.GetAll();
        }

        public Car GetCarById(int id)
        {
            return _carDal.Get(z => z.Id == id);
        }

        public List<Car> GetCarsByBrandId(int id)
        {
            return _carDal.GetAll(z => z.BrandId == id);
        }

        public List<Car> GetCarsByColorId(int id)
        {
            return _carDal.GetAll(z => z.ColorId == id);
        }

        public void Update(Car car)
        {
            _carDal.Update(car);
            Console.WriteLine($"Car Id: {car.Id} updated.");
        }
    }
}
