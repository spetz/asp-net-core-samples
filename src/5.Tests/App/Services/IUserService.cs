using System.Threading.Tasks;
using App.Models;

namespace App.Services
{
    public interface IUserService
    {
        Task<User> GetAsync(string email);
        Task CreateAsync(string email, string password);
    }
}