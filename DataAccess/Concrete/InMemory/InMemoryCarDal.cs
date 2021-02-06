using DataAccess.Abstract;
using Entities.Concrete;
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
            _cars = new List<Car> { 
                new Car {CarID=1,BrandID=1,ColorID=1,DailyPrice=13000,ModelYear=2016,Descriptions="Egea"},
                new Car {CarID =2,BrandID=2,ColorID=2,DailyPrice=15000,ModelYear=2017,Descriptions="Megan"},
                new Car {CarID = 3,BrandID=1,ColorID=1,DailyPrice=20000,ModelYear=2018,Descriptions="Palio"},
                new Car {CarID = 4,BrandID=1,ColorID=2,DailyPrice=12000,ModelYear=2016,Descriptions="Doblo"},
                new Car {CarID = 5,BrandID=2,ColorID=1,DailyPrice=10000,ModelYear=2014,Descriptions="Fiorino"}
            };
        }
        public void Add(Car car)
        {
            _cars.Add(car);
        }

        public void Delete(Car car)
        {
            Car carToDelete = _cars.SingleOrDefault(p=>p.BrandID==car.BrandID);
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

        public List<Car> GetById(int BrandId)
        {
           return _cars.Where(p => p.BrandID == BrandId).ToList();
        }

        public void Update(Car car)
        {
            Car carToUpdate = _cars.SingleOrDefault(p => p.BrandID == car.BrandID);
            carToUpdate.BrandID= car.BrandID;
            carToUpdate.ColorID = car.ColorID;
            carToUpdate.DailyPrice = car.DailyPrice;
            carToUpdate.Descriptions = car.Descriptions;
            carToUpdate.ModelYear = car.ModelYear;
        }
    }
}
