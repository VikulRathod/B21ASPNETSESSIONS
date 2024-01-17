using _2_Routing.Models;
using System;
using System.Collections.Generic;
using System.IdentityModel.Tokens.Jwt;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Security.Claims;
using System.Web.Http;

namespace _2_Routing.Controllers
{
    public class AccountController : ApiController
    {
        ProductDbContext _db = new ProductDbContext();
        public IHttpActionResult Authenticate(User user)
        {
            if (ModelState.IsValid)
            {
                bool isAuthenticated = _db.Users.Any(u =>
                u.Email == user.Email && u.Password == user.Password);

                if (isAuthenticated)
                {
                    // create token
                    string token = createToken(user.Email);

                    // return token in this response
                    return Ok(token);
                }

                return Unauthorized(null);
            }
            return BadRequest();
        }

        private string createToken(string username)
        {
            DateTime issuedAt = DateTime.UtcNow;
            DateTime expires = DateTime.UtcNow.AddMinutes(10);
            var tokenHandler = new JwtSecurityTokenHandler();
            ClaimsIdentity claimsIdentity = new ClaimsIdentity(new[]
            {
                    new Claim(ClaimTypes.Name, username),
                   new Claim(ClaimTypes.Email, username)
            });

            const string sec =
                "401b09eab3c013d4ca54922bb802bec8fd5318192b0a75f201d8b3727429090fb337591abd3e44453b954555b7a0812e1081c39b740293f765eae731f5a65ed1";
            var now = DateTime.UtcNow;
            var securityKey = new Microsoft.IdentityModel.Tokens.SymmetricSecurityKey(System.Text.Encoding.Default.GetBytes(sec));
            var signingCredentials = new Microsoft.IdentityModel.Tokens.SigningCredentials(securityKey, Microsoft.IdentityModel.Tokens.SecurityAlgorithms.HmacSha256Signature);

            var token = (JwtSecurityToken)
        tokenHandler.CreateJwtSecurityToken(issuer: "http://localhost:44344",
        audience: "http://localhost:44344",
            subject: claimsIdentity,
            notBefore: issuedAt, expires: expires,
            signingCredentials: signingCredentials);
            var tokenString = tokenHandler.WriteToken(token);

            return tokenString;
        }
    }
}
