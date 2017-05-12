# Serilog.Sinks.Azure.Functions

A Sink to write to components within https://github.com/Azure/azure-webjobs-sdk-script

## Azure Functions

* The traceWriter param in an Azure function is a `Microsoft.Azure.WebJobs.Script.InterceptingTraceWriter`
* Details at https://github.com/Azure/azure-webjobs-sdk-script/blob/dev/src/WebJobs.Script/Diagnostics/InterceptingTraceWriter.cs


Microsoft.Azure.WebJobs.Script