using System.Collections.Generic;
using System.Threading.Tasks;
using App.Models;
using App.Services;
using Microsoft.AspNetCore.Mvc;

namespace App.Controllers
{
    [Route("mongo")]
    public class MongoController : Controller
    {
        private readonly IMongoService _mongoService;

        public MongoController(IMongoService mongoService)
        {
            _mongoService = mongoService;
        }

        [HttpGet]
        public async Task<IEnumerable<User>> Get()
            => await _mongoService.GetUsersAsync();
    }
}