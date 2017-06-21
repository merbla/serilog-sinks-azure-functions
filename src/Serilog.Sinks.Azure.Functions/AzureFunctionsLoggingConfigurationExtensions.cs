
using System;
using System.Net.Http;
using Serilog.Configuration;
using Serilog.Events;
using Serilog.Formatting;
using Serilog.Sinks.Splunk;

namespace Serilog
{
    public static class AzureFunctionsLoggingConfigurationExtensions
    {
        internal const string DefaultOutputTemplate =
            "{Timestamp:yyyy-MM-dd HH:mm:ss.fff zzz} [{Level}] {Message}{NewLine}{Exception}";
    }
}