using System.Collections.Generic;
using System.Threading.Tasks;

namespace App.Services
{
    public interface ISqlService
    {
         Task<IEnumerable<string>> GetDatabasesAsync();
    }
}