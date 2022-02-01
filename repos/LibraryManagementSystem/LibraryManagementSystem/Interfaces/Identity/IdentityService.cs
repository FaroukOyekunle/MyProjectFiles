using LibraryManagementSystem.Entities;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.Extensions.Configuration;
using Microsoft.IdentityModel.Tokens;
using System;
using System.Collections.Generic;
using System.IdentityModel.Tokens.Jwt;
using System.Linq;
using System.Security.Claims;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace LibraryManagementSystem.Interfaces.Identity
{
    public class IdentityService: IIdentityService
    {
        private readonly IHttpContextAccessor _context;
        private readonly IConfiguration _configuration;
        private readonly IPasswordHasher<User> _password;

        public IdentityService(IHttpContextAccessor context, IConfiguration configuration, IPasswordHasher<User> password)
        {
            _context = context ?? throw new ArgumentNullException(nameof(context));
            _configuration = configuration ?? throw new ArgumentException(nameof(configuration));
            _password = password ?? throw new ArgumentException(nameof(password));
        }

        public string GetUserIdentity()
        {
            return _context.HttpContext?.User?.FindFirst(ClaimTypes.NameIdentifier)?.Value;
        }

        public string GenerateToken(User user, IEnumerable<string> roles)
        {
            var securityKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(_configuration.GetValue<string>("JwtTokenSettings:TokenKey")));
            var credentials = new SigningCredentials(securityKey, SecurityAlgorithms.HmacSha512);
            IList<Claim> claims = new List<Claim>
            {
                new Claim(JwtRegisteredClaimNames.Sub, user.Id.ToString()),
                new Claim(JwtRegisteredClaimNames.Jti, Guid.NewGuid().ToString()),
                new Claim(JwtRegisteredClaimNames.Email, user.Email)
            };
            foreach (var role in roles)
            {
                claims.Add(new Claim(ClaimTypes.Role, role));
            }
            var token = new JwtSecurityToken(_configuration.GetValue<string>("JwtTokenSettings:TokenIssuer"),
                _configuration.GetValue<string>("JwtTokenSettings:TokenIssuer"),
                claims,
                DateTime.UtcNow,
                expires: DateTime.UtcNow.AddMinutes(Convert.ToInt32(_configuration.GetValue<string>("JwtTokenSettings:TokenExpiryPeriod"))),
                signingCredentials: credentials);

            return new JwtSecurityTokenHandler().WriteToken(token);
        }

        public JwtSecurityToken GetClaims(string token)
        {
            if (!string.IsNullOrEmpty(token))
            {
                if (token.StartsWith("B"))
                {
                    token = token.Split(" ")[1];
                }
                var handler = new JwtSecurityTokenHandler();

                var decodedToken = handler.ReadToken(token) as JwtSecurityToken;

                return decodedToken;
            }
            return null;
        }

        public string GetClaimValue(string type)
        {

            return _context.HttpContext.User.FindFirst(type).Value;

        }

        public string GetUniqueKey(int size)
        {
            char[] chars = "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ1234567890".ToCharArray();
            byte[] data = new byte[size];
            using (RNGCryptoServiceProvider crypto = new RNGCryptoServiceProvider())
            {
                crypto.GetBytes(data);
            }
            StringBuilder result = new StringBuilder(size);
            foreach (byte b in data)
            {
                result.Append(chars[b % (chars.Length)]);
            }
            return result.ToString();
        }

        public string GetPasswordHash(string password, string salt = null)
        {
            if (string.IsNullOrEmpty(salt))
            {
                return _password.HashPassword(new User(), password);
            }
            return _password.HashPassword(new User(), $"{password}{salt}");
        }

        public string GenerateSalt()
        {
            RNGCryptoServiceProvider cryptoServiceProvider = new RNGCryptoServiceProvider();
            byte[] buffer = new byte[10];
            cryptoServiceProvider.GetBytes(buffer);
            return Convert.ToBase64String(buffer);
        }
    }
}
