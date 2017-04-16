using System.Collections.Generic;
using System.Data.SqlClient;
using System.Threading.Tasks;
using Dapper;

namespace App.Services
{
    public class SqlService : ISqlService
    {
        public async Task<IEnumerable<string>> GetDatabasesAsync()
        {
            using(var connection = new SqlConnection("Server=localhost;User Id=SA; Password=secret;"))
            {
                var names = await connection
                    .QueryAsync<string>("select name from sys.Databases;");
            
                return names;
            }
        }
    }
}