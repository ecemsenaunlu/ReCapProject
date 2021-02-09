using Core.DataAccess.EntityFramework;
using DataAccess.Abstract;
using Entities.Concrete;
using Entities.DTOs;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;

namespace DataAccess.Concrete.EntityFramework
{
    public class EfCarDal : EfEntityRepositoryBase<Car, CarRentSystemContext>, ICarDal
    {
        public List<CarDetailDto> GetCarDetails()
        {
            using (CarRentSystemContext context = new CarRentSystemContext())
            {
                var result = from c in context.Cars
                             join b in context.Brands
                             on c.BrandID equals b.BrandID
                             join d in context.Colors
                             on c.ColorID equals d.ColorID
                             select new CarDetailDto { CarID = c.CarID, BrandName = b.BrandName, ColorName = d.ColorName, DailyPrice = c.DailyPrice };
                return result.ToList();
            }
           
            
        }
    }
}
