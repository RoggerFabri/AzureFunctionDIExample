using AzureFunctionDIExample;
using Microsoft.Azure.WebJobs;
using Microsoft.Azure.WebJobs.Hosting;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.DependencyModel;

[assembly: WebJobsStartup(typeof(StartUp))]
namespace AzureFunctionDIExample
{
    public class StartUp : IWebJobsStartup
    {
        public void Configure(IWebJobsBuilder builder)
        {
            builder.Services.Add(new ServiceDescriptor(typeof(IMyDependency), typeof(MyDependency), ServiceLifetime.Transient));
        }
    }
}