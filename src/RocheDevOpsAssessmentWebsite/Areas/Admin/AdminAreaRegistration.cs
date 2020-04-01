using System.Web.Mvc;

namespace RocheDevOpsAssessment.Areas.Admin
{
    public class AdminAreaRegistration : AreaRegistration
    {
        public override void RegisterArea(AreaRegistrationContext context)
        {
            context.MapRoute(
                "admin_default",
                "Admin/{controller}/{action}/{id}",
                new { action = "Index", id = UrlParameter.Optional },
                namespaces: new string[] { "RocheDevOpsAssessment.Areas.Admin.Controllers" }
            );
        }

        public override string AreaName
        {
            get { return AdminConstants.Area; }
        }
    }
}