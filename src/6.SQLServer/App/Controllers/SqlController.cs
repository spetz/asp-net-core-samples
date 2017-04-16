using System.Collections.Generic;
using System.Threading.Tasks;
using App.Services;
using Microsoft.AspNetCore.Mvc;

namespace App.Controllers
{
    [Route("sql")]
    public class SqlController : Controller
    {
        private readonly ISqlService _sqlService;

        public SqlController(ISqlService sqlService)
        {
            _sqlService = sqlService;
        }

        [HttpGet]
        public async Task<IEnumerable<string>> Get()
            => await _sqlService.GetDatabasesAsync();
    }
}