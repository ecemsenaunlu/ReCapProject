using Core.Utilities.Results;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Abstract
{
   public interface ICustomerService
    {
        IDataResult<List<Customer>> GetAll();
        IDataResult<List<Customer>> GetAllByCustomerID(int id);
        IDataResult<Customer> GetById(int customerID);
        IResult Add(Customer customer);
    }
}
