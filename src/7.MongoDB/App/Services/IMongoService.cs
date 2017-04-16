using System.Collections.Generic;
using System.Threading.Tasks;
using App.Models;

namespace App.Services
{
    public interface IMongoService
    {
        Task<IEnumerable<User>> GetUsersAsync();
    }
}