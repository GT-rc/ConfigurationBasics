using System;
using System.Collections.Generic;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Configuration.EnvironmentVariables;

namespace ConfigurationBasics
{
    class Program
    {
        static void Main(string[] args)
        {
            // In Memory Config Collection
            var settings = new Dictionary<string, string>
            {
                ["HelloMessage"] = "Hiya buddy!",
                ["GoodbyeMessage"] = "So long, buddy!"
            };

            var builder = new ConfigurationBuilder()
                .AddInMemoryCollection(settings)
                .AddJsonFile("appsettings.json")
                .AddEnvironmentVariables("ConfigurationBasics.");
            var config = builder.Build();

            Console.WriteLine($"{config["HelloMessage"]}");
            Console.WriteLine($"{config["GoodbyeMessage"]}");

            Console.ReadKey();
        }
    }
}
