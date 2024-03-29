using System;
using System.Collections.Generic;
using System.IdentityModel.Tokens.Jwt;
using System.Linq;
using System.Security.Claims;
using System.Text;
using Microsoft.Extensions.Options;
using Microsoft.IdentityModel.Tokens;
using Survivor.Models;
using Survivor.Helpers;
using Microsoft.AspNetCore.Authorization;


namespace Survivor.Services
{
    public interface IUserService
    {
        User1 Authenticate(string username, string password);
        IEnumerable<User1> GetAll();
        void Create(User1 user);
    }

    public class UserService : IUserService
    {
         private SurvivorContext _db;
        // users hardcoded for simplicity, store in a db with hashed passwords in production applications
        private List<User1> _users;
       
        private readonly AppSettings _appSettings;

        public UserService(SurvivorContext db, IOptions<AppSettings> appSettings)
        {
            _db = db;
            _users = _db.Users.ToList();
            _appSettings = appSettings.Value;
        }

        public User1 Authenticate(string username, string password)
        {
            var user = _users.SingleOrDefault(x => x.Username == username && x.Password == password);

            // return null if user not found
            if (user == null)
                return null;
                    // authentication successful so generate jwt token
            var tokenHandler = new JwtSecurityTokenHandler();
            var key = Encoding.ASCII.GetBytes(_appSettings.Secret);
            var tokenDescriptor = new SecurityTokenDescriptor
            {
                Subject = new ClaimsIdentity(new Claim[] 
                {
                    new Claim(ClaimTypes.Name, user.User1Id.ToString())
                }),
                Expires = DateTime.UtcNow.AddDays(7),
                SigningCredentials = new SigningCredentials(new SymmetricSecurityKey(key), SecurityAlgorithms.HmacSha256Signature)
            };
            var token = tokenHandler.CreateToken(tokenDescriptor);
            user.Token = tokenHandler.WriteToken(token);

            // remove password before returning
            user.Password = null;

            return user;
        }

        public IEnumerable<User1> GetAll()
        {
            // return users without passwords
            return _users.Select(x => {
                x.Password = null;
                return x;
            });
        }

        public void Create(User1 newUser)
        {
            _db.Users.Add(newUser);
            _db.SaveChanges();
        }
    }
}