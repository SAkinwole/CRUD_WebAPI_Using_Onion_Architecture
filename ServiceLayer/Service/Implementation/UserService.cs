using DomainLayer.Model;
using RepositoryLayer;
using Service_Layer.Service.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Service_Layer.Service.Implementation
{
    public class UserService : IUser
    {
        private readonly AppDbContext _dbContext;
        public UserService(AppDbContext dbContext)
        {
            _dbContext = dbContext;
        }


        //AddNew User
        public string AddUserRepo(User user)
        {
            try
            {
                _dbContext.users.Add(user);
                _dbContext.SaveChanges();
                return "Success";
            }
            catch (Exception ex)
            {
                return ex.Message;
            }

        }

        //Remove User
        public string DeleteUserRepo(long Id)
        {
            try
            {
                var user = _dbContext.users.Find(Id);
                _dbContext.Remove(user);
                _dbContext.SaveChanges();
                return "Deleted Successfully";
            }
            catch (Exception ex)
            {
                return ex.Message;
            }

        }

        //GetAll Users
        public List<User> GetAllRepo()
        {
            return _dbContext.users.ToList();
        }

        //Get SingleUser
        public User GetSingleRepo(long Id)
        {
            //return _dbContext.users.Where(x => x.UserId == Id).FirstOrDefault();
            return _dbContext.users.Find(Id);
        }


        //Update UserDetails
        public string UpdateUserRepo(User user)
        {
            try
            {
                var userValue = _dbContext.users.Find(user.UserId);

                if (userValue != null)
                {
                    userValue.UserName = user.UserName;
                    _dbContext.Update(userValue);
                    _dbContext.SaveChanges();

                    return "Updated Successfully";
                }
                else
                    return "No Record Found";
            }
            catch (Exception ex)
            {
                return ex.Message;
            }
        }


    }
}

