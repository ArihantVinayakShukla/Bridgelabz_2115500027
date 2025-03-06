using Microsoft.EntityFrameworkCore;
using ModelLayer.DTO;
using NLog;
using RepositoryLayer.Context;
using RepositoryLayer.Entity;
using RepositoryLayer.Interface;
using RepositoryLayer.Helpers;
using Microsoft.Extensions.Caching.Distributed;
using System.Text.Json;

namespace RepositoryLayer.Service
{
    public class UserRegistrationRL : IUserRegistrationRL
    {
        private readonly UserDbContext _context;
        private static readonly Logger logger = LogManager.GetCurrentClassLogger();
        private readonly JwtHelper _jwtHelper;
        private readonly IDistributedCache _cache;

        public UserRegistrationRL(UserDbContext context, JwtHelper jwtHelper, IDistributedCache cache)
        {
            _context = context;
            _jwtHelper = jwtHelper;
            _cache = cache;
        }


        public (string Token, bool IsCached) Login(LoginDTO loginDTO)
        {
            string cacheKey = $"user_data_{loginDTO.Email}";
            
            var cachedUserData = _cache.GetString(cacheKey);
            if (!string.IsNullOrEmpty(cachedUserData))
            {
                
                var cachedUser = JsonSerializer.Deserialize<UserEntity>(cachedUserData);

                
                string cachedToken = _jwtHelper.GenerateToken(cachedUser.UserId, cachedUser.FirstName, cachedUser.LastName, cachedUser.Email);

                logger.Info($"User data retrieved from cache for {loginDTO.Email}");
                return (cachedToken, true); 
            }

            
            var user = _context.Users.FirstOrDefault(e => e.Email == loginDTO.Email);

            if (user == null || user.Password != loginDTO.password)
            {
                return (null, false);
            }

            
            string token = _jwtHelper.GenerateToken(user.UserId, user.FirstName, user.LastName, user.Email);

            
            var serializedUser = JsonSerializer.Serialize(user);
            var options = new DistributedCacheEntryOptions
            {
                AbsoluteExpirationRelativeToNow = TimeSpan.FromMinutes(30) 
            };
            _cache.SetString(cacheKey, serializedUser, options);

            logger.Info($"User data cached for {loginDTO.Email}");

            return (token, false); 
        }

        public bool RegisterUser(UserDTO user)
        {
            try
            {
                var newUser = new UserEntity
                {
                    FirstName = user.FirstName,
                    LastName = user.LastName,
                    Email = user.Email,
                    Password = user.Password
                };

                _context.Users.Add(newUser);
                _context.SaveChanges();
                logger.Info("User registered successfully in the database.");

                
                string cacheKey = $"user_data_{user.Email}";
                _cache.Remove(cacheKey);
                logger.Info($"Cache cleared for {user.Email}");

                return true;
            }
            catch (Exception ex)
            {
                logger.Error(ex, "Error in Repository Layer while registering user.");
                return false;
            }
        }
    }
}
