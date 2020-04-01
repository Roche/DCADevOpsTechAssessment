using System.Collections.Generic;
using System.Threading.Tasks;

namespace RocheDevOpsAssessment.Recommendations
{
    public interface IRecommendationEngine
    {
        Task<IEnumerable<string>> GetRecommendationsAsync(string productId);
    }
}