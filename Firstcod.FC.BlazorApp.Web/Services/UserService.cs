using Firstcod.FC.Provider;
using Firstcod.FC.Provider.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Firstcod.FC.BlazorApp.Web.Services
{
    public class UserService
    {
        private readonly IUnitOfWork _unitOfWork;

        public UserService(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        public List<User> GetUser()
        {
            try
            {
                return _unitOfWork.User.GetAll().ToList();
            }
            catch
            {
                return null;
            }
        }

        public User GetUser(long Id)
        {
            try
            {
                return _unitOfWork.User.FindById(s=>s.Id == Id);
            }
            catch
            {
                return null;
            }
        }

        public List<User> InsertUser(User user)
        {
            try
            {
                user.CreateDate = DateTime.Now;
                user.State = 1;

                _unitOfWork.User.Add(user);
                _unitOfWork.User.Save();

                return _unitOfWork.User.GetAll().ToList();
            }
            catch
            {
                return null;
            }
        }

        public List<User> UpdateUser(User user)
        {
            try
            {
                var userDetail = _unitOfWork.User.FindById(s => s.Id == user.Id);

                if (userDetail != null)
                {
                    userDetail.FirstName = user.FirstName;
                    userDetail.LastName = user.LastName;
                    userDetail.EmailAddress = user.EmailAddress;
                    userDetail.CreateDate = DateTime.Now;

                    _unitOfWork.User.Update(userDetail);
                    _unitOfWork.User.Save();

                    return _unitOfWork.User.GetAll().ToList();
                }
                else
                    return null;
            }
            catch
            {
                return null;
            }
        }

        public List<User> DeleteUser(long Id)
        {
            try
            {
                var deleteUser = _unitOfWork.User.FindById(s => s.Id == Id);

                if(deleteUser != null)
                {
                    _unitOfWork.User.Delete(deleteUser);
                    _unitOfWork.User.Save();
                }

                return _unitOfWork.User.GetAll().ToList();
            }
            catch
            {
                return null;
            }
        }
    }
}
