using System.Collections.Generic;
using System.Web.Mvc;
using RocheDevOpsAssessment.Models;

namespace RocheDevOpsAssessment.ViewModels
{
    public class EditProductViewModel
    {
        public Product Product { get; set; }
        public IEnumerable<SelectListItem> Categories { get; set; }
    }
}