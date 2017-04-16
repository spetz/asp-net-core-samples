using System.Collections.Generic;
using System.Threading.Tasks;
using App.Models;
using MongoDB.Driver;

namespace App.Services
{
    public class MongoService : IMongoService
    {
        private readonly IMongoDatabase _database;

        public MongoService(IMongoDatabase database)
        {
            _database = database;
        }

        public async Task<IEnumerable<User>> GetUsersAsync()
        {
            var users = await _database.GetCollection<User>("Users")
                .AsQueryable()
                .ToListAsync();
            
            return users;
        }
  }
}