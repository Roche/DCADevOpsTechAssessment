using System;
using System.Threading.Tasks;
using RocheDevOpsAssessment.Models;
using RocheDevOpsAssessment.ViewModels;

namespace RocheDevOpsAssessment.Utils
{
    public interface IOrdersQuery
    {
        Task<Order> FindOrderAsync(int id);
        Task<OrdersModel> IndexHelperAsync(string username, DateTime? start, DateTime? end, string invalidOrderSearch, bool isAdminSearch);
    }
}
