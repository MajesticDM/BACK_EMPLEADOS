﻿using Microsoft.Extensions.Configuration;
using Microsoft.AspNetCore.Mvc;
using Microsoft.IdentityModel.Tokens;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;
using System;
using CORE.EMPLEADOS.Interfaces;
using CORE.EMPLEADOS.Entidades;

namespace API.EMPLEADOS.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TokenController : ControllerBase
    {
        private readonly IConfiguration _configuration;
        private readonly ILogin _security;
        public TokenController(IConfiguration configuration, ILogin security)
        {
            _configuration = configuration;
            _security = security;
        }
        [HttpPost]
        public async Task<IActionResult> Authentication(Login login)
        {
            var users = await _security.GetLoginByCredential(login);
            if (users != null)
            {
                var token = GenerateToken();
                return Ok(new { token });
            }
            return NotFound("Usuario no encontrado");
        }
        private string GenerateToken()
        {
            //Header
            var SymmetricSecurityKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(_configuration["Authentication:SecretKey"]));

            var SigningCredentials = new SigningCredentials(SymmetricSecurityKey, SecurityAlgorithms.HmacSha256);

            var header = new JwtHeader(SigningCredentials);

            //Claims
            var claims = new[]
            {
                new Claim(ClaimTypes.UserData, "noInfo"),
                new Claim(ClaimTypes.Email, "noInfo"),
                new Claim(ClaimTypes.Name, "noInfo"),
            };

            //Payload
            var payload = new JwtPayload
            (
                _configuration["Authentication:Issuer"],
                _configuration["Authentication:Audience"],
                claims,
                DateTime.Now,
                DateTime.UtcNow.AddMinutes(10)
            );

            //Generate token
            var token = new JwtSecurityToken(header, payload);

            return new JwtSecurityTokenHandler().WriteToken(token);
        
    }
}
}
