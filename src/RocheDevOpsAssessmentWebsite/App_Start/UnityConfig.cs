using Microsoft.Practices.Unity;
using RocheDevOpsAssessment.Models;
using RocheDevOpsAssessment.ProductSearch;
using RocheDevOpsAssessment.Recommendations;
using RocheDevOpsAssessment.Utils;

namespace RocheDevOpsAssessment
{
    public class UnityConfig
    {
        public static UnityContainer BuildContainer()
        {
            var container = new UnityContainer();

            container.RegisterType<IRocheDevOpsAssessmentContext, RocheDevOpsAssessmentContext>();
            container.RegisterType<IOrdersQuery, OrdersQuery>();
            container.RegisterType<IRaincheckQuery, RaincheckQuery>();
            container.RegisterType<IRecommendationEngine, AzureMLFrequentlyBoughtTogetherRecommendationEngine>();
            container.RegisterType<ITelemetryProvider, TelemetryProvider>();
            container.RegisterType<IProductSearch, StringContainsProductSearch>();
            container.RegisterType<IShippingTaxCalculator, DefaultShippingTaxCalculator>();

			container.RegisterInstance<IHttpClient>(container.Resolve<HttpClientWrapper>());

            return container;
        }
    }
}