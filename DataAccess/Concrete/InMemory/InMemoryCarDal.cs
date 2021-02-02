using DataAccess.Abstract;
using Entities.Concrete;
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
            _cars = new List<Car> { 
                new Car {Id=1,BrandId=1,ColorId=1,DailyPrice=13000,ModelYear=2016,Description="Egea"},
                new Car {Id=2,BrandId=2,ColorId=2,DailyPrice=15000,ModelYear=2017,Description="Megan"},
                new Car {Id=3,BrandId=1,ColorId=1,DailyPrice=20000,ModelYear=2018,Description="Palio"},
                new Car {Id=4,BrandId=1,ColorId=2,DailyPrice=12000,ModelYear=2016,Description="Doblo"},
                new Car {Id=5,BrandId=2,ColorId=1,DailyPrice=10000,ModelYear=2014,Description="Fiorino"}
            };
        }
        public void Add(Car car)
        {
            _cars.Add(car);
        }

        public void Delete(Car car)
        {
            Car carToDelete = _cars.SingleOrDefault(p=>p.BrandId==car.BrandId);
            _cars.Remove(carToDelete);
        }

        public List<Car> GetAll()
        {
            return _cars;
        }

        public List<Car> GetById(int BrandId)
        {
           return _cars.Where(p => p.BrandId == BrandId).ToList();
        }

        public void Update(Car car)
        {
            Car carToUpdate = _cars.SingleOrDefault(p => p.BrandId == car.BrandId);
            carToUpdate.BrandId = car.BrandId;
            carToUpdate.ColorId = car.ColorId;
            carToUpdate.DailyPrice = car.DailyPrice;
            carToUpdate.Description = car.Description;
            carToUpdate.ModelYear = car.ModelYear;
        }
    }
}
