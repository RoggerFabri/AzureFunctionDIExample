using System;
using Microsoft.Azure.WebJobs;
using Microsoft.Extensions.Logging;

namespace AzureFunctionDIExample
{
    public class ExampleFunction
    {
        private readonly IMyDependency myDependency;

        public ExampleFunction(IMyDependency myDependency)
        {
            this.myDependency = myDependency;
        }

        [FunctionName("ExampleFunction")]
        public void Run([TimerTrigger("0 */1 * * * *")]TimerInfo myTimer, ILogger log)
        {
            var result = myDependency.DoSomething();
            log.LogInformation($"C# Timer trigger function executed at: {DateTime.Now}");
        }
    }
}