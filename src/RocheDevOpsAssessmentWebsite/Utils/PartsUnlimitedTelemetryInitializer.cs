using Microsoft.ApplicationInsights.Channel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace RocheDevOpsAssessment.Utils
{
    public class RocheDevOpsAssessmentTelemetryInitializer
    {
        string appVersion = GetApplicationVersion();

        private static string GetApplicationVersion()
        {
            return typeof(RocheDevOpsAssessmentTelemetryInitializer).Assembly.GetName().Version.ToString();
        }

        public void Initialize(ITelemetry telemetry)
        {
            telemetry.Context.Component.Version = appVersion;
        }
    }
}