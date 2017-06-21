# Serilog.Sinks.Azure.Functions

A Sink to write to components within https://github.com/Azure/azure-webjobs-sdk-script

## Azure Functions

* The traceWriter param in an Azure function is a `Microsoft.Azure.WebJobs.Script.InterceptingTraceWriter`
* Details at https://github.com/Azure/azure-webjobs-sdk-script/blob/dev/src/WebJobs.Script/Diagnostics/InterceptingTraceWriter.cs




https://www.nuget.org/packages/Microsoft.Azure.WebJobs.Script/1.0.0-beta3

WebJobs.Script

Microsoft.Azure.WebJobs.Script.WebHost
https://www.nuget.org/packages/Microsoft.Azure.WebJobs.Script.WebHost/1.0.0-beta3


Microsoft.Azure.WebJobs.Script

Microsoft.Azure.WebJobs.Script.WebHost
Microsoft.Azure.WebJobs.Script 
Microsoft.Azure.WebJobs.Script.Extensibility



{
    "frameworks": {
        "net46": {
            "dependencies": {
                "Serilog": "2.4.0",
                "Microsoft.Azure.WebJobs.Script.WebHost": "1.0.0-beta3"
            }
        }
    }
}