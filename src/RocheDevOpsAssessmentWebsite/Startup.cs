using Microsoft.ApplicationInsights.Extensibility;
using Microsoft.Owin;
using Owin;
using RocheDevOpsAssessment;
using System.Web.Configuration;

[assembly: OwinStartup(typeof(Startup))]

namespace RocheDevOpsAssessment
{
	
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);

            TelemetryConfiguration.Active.InstrumentationKey = WebConfigurationManager.AppSettings["Keys:ApplicationInsights:InstrumentationKey"];

        }
    }
}
