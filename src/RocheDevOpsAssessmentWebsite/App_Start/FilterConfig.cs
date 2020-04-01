using System.Web.Mvc;
using RocheDevOpsAssessment.Utils;

namespace RocheDevOpsAssessment
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
            filters.Add(new LayoutDataAttribute());
        }
    }
}