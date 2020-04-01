using Microsoft.AspNet.Identity.EntityFramework;

namespace RocheDevOpsAssessment.Models
{
    public class ApplicationUser : IdentityUser
    {
        public string Name { get; set; }
    }
}