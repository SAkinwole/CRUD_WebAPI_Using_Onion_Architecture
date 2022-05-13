using DomainLayer.Model;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Service_Layer.Service.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebAPI_Layer.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        private readonly IUser _user;
        public UserController(IUser user)
        {
            _user = user;
        }

        //GetAll Users

        [HttpGet]
        [Route("getall")]
        public IActionResult GetAllUser()
        {
            var response = _user.GetAllRepo();
            return Ok(response);
        }


        //GetSingle User
        [HttpGet("get")]
        public IActionResult GetSingleUser(long id)
        {
            return Ok(_user.GetSingleRepo(id));
        }



        //Add User
        [HttpPost("add")]
        public IActionResult AddNewUser(User user)
        {
            return Ok(_user.AddUserRepo(user));
        }

        //Update User
        [HttpPut("edit")]
        public IActionResult UpdateUser(User user)
        {
            return Ok(_user.UpdateUserRepo(user));
        }
        
        //Remove USer
        [HttpDelete]
        public IActionResult DeleteUser(long id)
        {
            return Ok(_user.DeleteUserRepo(id));
        }
    }
}
