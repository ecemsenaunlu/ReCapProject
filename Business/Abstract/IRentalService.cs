using Core.Utilities.Results;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Abstract
{
    public interface IRentalService
    {
        IDataResult<List<Rental>> GetAll();
        IDataResult<List<Rental>> GetAllByRentalID(int id);
        IDataResult<Rental> GetById(int rentalID);
        IResult Add(Rental rental);
    }
}
