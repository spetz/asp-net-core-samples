using System.Threading.Tasks;
using App.Services;
using Microsoft.AspNetCore.Mvc;

namespace App.Controllers
{
    [Route("redis")]
    public class RedisController : Controller
    {
        private readonly IRedisService _redisService;

        public RedisController(IRedisService redisService)
        {
            _redisService = redisService;
        }

        [HttpGet("{key}")]
        public async Task<string> Get(string key)
            => await _redisService.GetAsync(key);
    }
}