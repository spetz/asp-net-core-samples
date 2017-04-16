using System.Threading.Tasks;

namespace App.Services
{
    public interface IRedisService
    {
         Task<string> GetAsync(string key);
    }
}