using System;
using System.Threading.Tasks;
using App.Models;
using App.Repositories;

namespace App.Services
{
    public class UserService : IUserService
    {
        private readonly IUserRepository _userRepository;

        public UserService(IUserRepository userRepository)
        {
            _userRepository = userRepository;
        }

        public async Task<User> GetAsync(string email)
            => await _userRepository.GetAsync(email);

        public async Task CreateAsync(string email, string password)
        {
            var user = await _userRepository.GetAsync(email);
            if(user != null)
            {
                throw new Exception($"User with email: '{email}' already exists.");
            }

            user = new User(email, password);
            await _userRepository.AddAsync(user);
        }
    }
}