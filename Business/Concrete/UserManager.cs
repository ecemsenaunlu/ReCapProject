using Business.Abstract;
using Business.Constants;
using Core.Utilities.Results;
using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Concrete
{
    public class UserManager : IUserService
    {
        IUserDal _userDal;

        public UserManager(IUserDal userDal)
        {
            _userDal = userDal;
        }

        public IResult Add(User user)
        {
            if (user.FirstName.Length < 2)
            {
                return new ErrorResult(Messages.DescriptionsInvalid);
            }
            _userDal.Add(user);
            return new SuccessResult(Messages.UserAdded);
        }

       public IDataResult<List<User>> GetAll()
        {
            if (DateTime.Now.Hour == 15)
            {
                return new ErrorDataResult<List<User>>(Messages.MaintenanceTime);
            }
            return new SuccessDataResult<List<User>>(_userDal.GetAll(), Messages.UsersListed);

        }

        public IDataResult<List<User>> GetAllByUserID(int id)
        {
         
            return new SuccessDataResult<List<User>>(_userDal.GetAll(u => u.UserID == id));
        }

        public IDataResult<User> GetById(int userID)
        {
            return new SuccessDataResult<User>(_userDal.Get(u => u.UserID == userID));
        }

        
    }
}
