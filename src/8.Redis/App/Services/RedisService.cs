using System.Threading.Tasks;
using StackExchange.Redis;

namespace App.Services
{
    public class RedisService : IRedisService
    {
        private readonly IDatabase _database;

        public RedisService(IDatabase database)
        {
            _database = database;
        }

        public async Task<string> GetAsync(string key)
             => await _database.StringGetAsync(key);
    }
}