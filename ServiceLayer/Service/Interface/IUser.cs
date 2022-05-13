using DomainLayer.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Service_Layer.Service.Interface
{
    public interface IUser
    {
        //GetAll User
        List<User> GetAllRepo();

        //GetSingle User
        User GetSingleRepo(long Id);

        //Add User
        string AddUserRepo(User user);

        //Update User
        string UpdateUserRepo(User user);

        //Delete User
        string DeleteUserRepo(long Id);
    }
}
