using AutoMapper;
using Marlabs_TokenAuthentication.DTOs;
using Marlabs_TokenAuthentication.Models;
using Marlabs_TokenAuthentication.Repository;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.IdentityModel.Tokens;
using System;
using System.Collections.Generic;
using System.IdentityModel.Tokens.Jwt;
using System.Linq;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;

namespace Marlabs_TokenAuthentication.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AuthController : ControllerBase
    {
        private readonly IAuthRepository _repo;
        private readonly IConfiguration _config;
        private readonly IMapper _mapper;

        public AuthController(IAuthRepository repo, IConfiguration config, IMapper mapper)
        {
            _repo = repo;
            _config = config;
            _mapper = mapper;
        }

        [HttpPost("Register")]
        public IActionResult Register(RegisterDTO registerDTO)
        {
            registerDTO.Email = registerDTO.Email.ToLower();

            var userToCreate = _mapper.Map<TblUser>(registerDTO);
            var createUser = _repo.Register(userToCreate);

            return StatusCode(201, new { email = createUser.Email, fullname = createUser.FullName});
        }


        [HttpPost("Login")]
        public IActionResult Login(LoginDTO loginDTO)
        {
            var userFromRepo = _repo.Login(loginDTO.Email.ToLower());
            if (userFromRepo == null)
                return Unauthorized();

            var claims = new[]
            {
                new Claim(ClaimTypes.NameIdentifier,userFromRepo.UserId.ToString()),
                new Claim(ClaimTypes.Name,userFromRepo.Email)
            };

            var key = new SymmetricSecurityKey(Encoding.UTF8
                .GetBytes(_config.GetSection("AppSettings:Token").Value));

            //steps for creating token and adding identity
            var creds = new SigningCredentials(key, SecurityAlgorithms.HmacSha512Signature);

            var tokenDescriptor = new SecurityTokenDescriptor
            {
                Subject = new ClaimsIdentity(claims),
                Expires = DateTime.Now.AddDays(1),
                SigningCredentials = creds
            };

            var tokenHandler = new JwtSecurityTokenHandler();
            var token = tokenHandler.CreateToken(tokenDescriptor); //in memory

            return Ok(new { token = tokenHandler.WriteToken(token),email = userFromRepo.Email, fullname = userFromRepo.FullName });
                
        }
    }
}
