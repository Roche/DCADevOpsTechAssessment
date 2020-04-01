using System.Data.Entity;
using System.Linq;
using System.Threading.Tasks;
using System.Web.Mvc;
using RocheDevOpsAssessment.Models;
using RocheDevOpsAssessment.Recommendations;
using RocheDevOpsAssessment.Utils;

namespace RocheDevOpsAssessment.Controllers
{
    public class RecommendationsController : Controller
    {
        private readonly IRocheDevOpsAssessmentContext db;
        private readonly IRecommendationEngine recommendation;

        public RecommendationsController(IRocheDevOpsAssessmentContext context, IRecommendationEngine recommendationEngine)
        {
            db = context;
            recommendation = recommendationEngine;
        }

        public async Task<ActionResult> GetRecommendations(string productId)
        {
            if (!ConfigurationHelpers.GetBool("ShowRecommendations"))
            {
                return new EmptyResult();
            }

            var recommendedProductIds = await recommendation.GetRecommendationsAsync(productId);

            var recommendedProducts = await db.Products.Where(x => recommendedProductIds.Contains(x.ProductId.ToString())).ToListAsync();

            return PartialView("_Recommendations", recommendedProducts);
        }
    }
}
