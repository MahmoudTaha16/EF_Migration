using EF_Migration.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Options;
using System;
using System.Linq;

namespace EF_Migration
{
    internal class Program
    {
        private static void Main(string[] args)
        {

            //we put the connection string here to apply the dependency injection

            string? ConnString = new ConfigurationBuilder().AddJsonFile("D:\\Programming\\EF\\EF_Migration\\appSettings.json")
                                     .Build().GetSection("ConnString").Value;

           

            var services = new ServiceCollection();
            services.AddDbContext<AppDbContext>(Options =>
            {
                Options.UseSqlServer(ConnString);
            });


            IServiceProvider serviceProvider = services.BuildServiceProvider();

            using (AppDbContext? context = serviceProvider.GetService<AppDbContext>())
            {
                foreach (var item in context?.Instructors?.Select(x => x.Name))
                {
                    Console.WriteLine(item);
                } ;
            }
        }
    }
}