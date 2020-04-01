using System.Threading.Tasks;

namespace RocheDevOpsAssessment.Utils
{
    public interface IHttpClient
    {
        Task<string> GetStringAsync(string uri);
    }
}