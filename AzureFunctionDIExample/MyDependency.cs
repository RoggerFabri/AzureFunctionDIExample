using System;

namespace AzureFunctionDIExample
{
    public class MyDependency : IMyDependency
    {
        public string DoSomething()
        {
            var @value = "Hey I'm here :)";

            Console.WriteLine(@value);

            return @value;
        }
    }
}