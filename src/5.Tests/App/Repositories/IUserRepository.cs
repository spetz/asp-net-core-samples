using System.Threading.Tasks;
using App.Models;

namespace App.Repositories
{
    public interface IUserRepository
    {
        Task<User> GetAsync(string email);
        Task AddAsync(User user);         
    }
}