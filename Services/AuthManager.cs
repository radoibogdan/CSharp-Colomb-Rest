using Colomb.Data;
using Colomb.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.Extensions.Configuration;
using Microsoft.IdentityModel.Tokens;
using System;
using System.Collections.Generic;
using System.IdentityModel.Tokens.Jwt;
using System.Linq;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;

namespace Colomb.Services
{
    public class AuthManager : IAuthManager
    {
        private readonly UserManager<Compte> _userManager;
        private readonly IConfiguration _configuration;
        private Compte _user;

        /* 14.35*/

        public AuthManager(UserManager<Compte> userManager, IConfiguration configuration) 
        {
            _userManager = userManager;
            _configuration = configuration;
        }
        
        public async Task<string> CreateToken()
        {
            // get the signing credentials
            var signingCredentials = GetSigningCredentials();
            // get claims
            var claims = await GetClaims();
            // get token options
            var token = GenerateTokenOptions(signingCredentials, claims);
            // Serialize token to string 
            return new JwtSecurityTokenHandler().WriteToken(token);
        }

        private JwtSecurityToken GenerateTokenOptions(SigningCredentials signingCredentials, List<Claim> claims)
        {
            var jwtSettings = _configuration.GetSection("Jwt");
            var expiration = DateTime.Now.AddMinutes(Convert.ToDouble(jwtSettings.GetSection("lifetime").Value));
            var token = new JwtSecurityToken(
                issuer: jwtSettings.GetSection("Issuer").Value,
                claims: claims,
                expires: expiration,
                signingCredentials: signingCredentials
                );
            
            return token;
        }

        // Who or what you can do
        private async Task<List<Claim>> GetClaims()
        {
            var claims = new List<Claim>
            {
                new Claim(ClaimTypes.Name, _user.UserName)
            };
            var roles = await _userManager.GetRolesAsync(_user);
            foreach (var role in roles)
            {
                claims.Add(new Claim(ClaimTypes.Role, role));
            }
            return claims;
        }

        private SigningCredentials GetSigningCredentials()
        {
            var key = Environment.GetEnvironmentVariable("KEY");
            var secret = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(key));
            return new SigningCredentials(secret, SecurityAlgorithms.HmacSha256);
        }

        // Validating the user - does the user exist in the db and is pwd valid
        public async Task<bool> ValidateUser(CompteDTO userDTO)
        {
            _user = await _userManager.FindByNameAsync(userDTO.Email);
            return (_user != null && await _userManager.CheckPasswordAsync(_user, userDTO.Password));
        }
    }
}
