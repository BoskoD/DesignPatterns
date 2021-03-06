using FlixOne.InventoryManagement.Commands;
using FlixOne.InventoryManagement.Interfaces;
using Microsoft.Extensions.DependencyInjection;
using System;

namespace FlixOne.InventoryManagementClient
{
    class Program
    {
        private static void Main(string[] args)
        {
            IServiceCollection services = new ServiceCollection();
            ConfigureServices(services);
            IServiceProvider serviceProvider = services.BuildServiceProvider();

            var service = serviceProvider.GetService<ICatalogService>();
            service.Run();

            Console.WriteLine("CatalogService has completed.");
            Console.ReadLine();

        }

        private static void ConfigureServices(IServiceCollection services)
        {
            // Register CRoot
            services.AddTransient<IUserInterface, ConsoleUserInterface>();
            services.AddTransient<ICatalogService, CatalogService>();
            services.AddTransient<IInventoryCommandFactory, InventoryCommandFactory>();
        }
    }
}
