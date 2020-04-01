using System.Collections.Generic;
using System.Threading.Tasks;
using RocheDevOpsAssessment.Models;

namespace RocheDevOpsAssessment.ProductSearch
{
    public interface IProductSearch
    {
        Task<IEnumerable<Product>> Search(bool query);
    }
}
