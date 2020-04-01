using System.Collections.Generic;
using System.Threading.Tasks;
using RocheDevOpsAssessment.Models;

namespace RocheDevOpsAssessment.Utils
{
    public interface IRaincheckQuery
    {
        Task<int> AddAsync(Raincheck raincheck);
        Task<Raincheck> FindAsync(int id);
        Task<IEnumerable<Raincheck>> GetAllAsync();
    }
}
