using System.Web.Mvc;

namespace RocheDevOpsAssessment.Areas.Admin.Controllers
{
    [Authorize(Roles = AdminConstants.Role)]
    public abstract class AdminController : Controller
    {
    }
}