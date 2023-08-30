using Marlabs_LoginService.Model;
using Marlabs_LoginService.Repository;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Marlabs_LoginService.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        private readonly IUserRepository iuserRepository;

        public UserController(IUserRepository _iuserRepository)
        {
            iuserRepository = _iuserRepository;
        }

        [HttpPost("LoginUser")]//create data httpget, put - to update recordrs , delete - deletion 
        public IActionResult LoginValidate([FromBody] User objUser)
        {
            var result = this.iuserRepository.LoginValidate(objUser.UserName, objUser.Password);
            return Ok(result);
        }

        [HttpPost("RegisterUser")]
        public IActionResult CreateUser([FromBody] User objUser)
        {
            var result = this.iuserRepository.CreateUser(objUser);
            return Ok(result);
        }
    }
}
