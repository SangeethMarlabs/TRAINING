using Domain.Models;
using Marlabs_OnionArchitecture.DTO;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Marlabs_OnionArchitecture.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        IUserRepository iuserRepository;
        IUserProfileRepository iuserProfileRepository;

        public UserController(IUserRepository _iuserRepository, IUserProfileRepository _iuserProfileRepository)
        {
            this.iuserRepository = _iuserRepository;
            this.iuserProfileRepository = _iuserProfileRepository;
        }

        [HttpGet("ListUsers")]
        public ActionResult ListUsers()
        {
            List<User> lstUser = new List<User>();
            iuserRepository.GetUsers().ToList().ForEach(u =>
            {
                User user = null;
                UserProfile userProfile = iuserProfileRepository.GetUserProfile(u.Id);
                user = new User()
                {
                    Id = u.Id,
                    UserNmae = u.UserNmae,
                    Email = u.Email,
                    Password = u.Password,
                    ModifiedDate = u.ModifiedDate,
                    IpAddress = u.IpAddress,
                    UserProfile = new UserProfile()
                    {
                        FirstName = userProfile.FirstName,
                        LastName = userProfile.LastName,
                        ContactNo = userProfile.ContactNo,
                        Address = userProfile.Address,
                        ModifiedDate = userProfile.ModifiedDate,
                        IpAddress = userProfile.IpAddress,
                        User = user,
                        Id = u.Id
                    }
                };
                lstUser.Add(user);
            });
            return Ok(lstUser);
        }

        [HttpPost("CreateUsers")]
        public int CreateUsers(UserDTO model)
        {
            User UserEntity = new User
            {
                UserNmae = model.UserName,
                Email = model.Email,
                Password = model.Password,
                ModifiedDate = DateTime.UtcNow,
                IpAddress = Request.HttpContext.Connection.RemoteIpAddress.ToString(),
                UserProfile = new UserProfile
                {
                    FirstName = model.UserName,
                    Address = model.Address,
                    ContactNo = model.ContactNo,
                    LastName = model.LasttName,
                    ModifiedDate = DateTime.UtcNow,
                    IpAddress = Request.HttpContext.Connection.RemoteIpAddress.ToString()
                }
            };
            iuserRepository.InsertUser(UserEntity);
            return 1;
        }

        [HttpPut("UpdateUser")]
        public int UpdateUser(UserDTO model)
        {
            User UserEntity = new User
            {
                Id = model.Id,
                UserNmae = model.UserName,
                Email = model.Email,
                Password = model.Password,
                ModifiedDate = DateTime.UtcNow,
                IpAddress = Request.HttpContext.Connection.RemoteIpAddress.ToString(),
                UserProfile = new UserProfile
                {
                    Id = model.Id,
                    FirstName = model.UserName,
                    Address = model.Address,
                    ContactNo = model.ContactNo,
                    LastName = model.LasttName,
                    ModifiedDate = DateTime.UtcNow,
                    IpAddress = Request.HttpContext.Connection.RemoteIpAddress.ToString()
                }
            };
            iuserRepository.UpdatetUser(UserEntity);
            return 1;
        }

        [HttpDelete("DeleteUser")]
        public int DeleteUser(long id)
        {
            iuserRepository.DeleteUser(id);
            return 1;
        }



    }
}
