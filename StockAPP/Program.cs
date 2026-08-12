using Microsoft.Extensions.DependencyInjection;
using StockAPP.Presenters.Main;
using StockAPP.Service.Api;
using StockAPP.Service.Navigation;
using StockAPP.Views.MainContainer;
using StockAPP.Views.RegisterForm;

namespace StockAPP
{
    internal static class Program
    {
        [STAThread]
        static void Main()
        {
            var services = new ServiceCollection();

            ConfigureServices(services);

            using (var builder = services.BuildServiceProvider())
            {
                ApplicationConfiguration.Initialize();

                var mainContainer = builder.GetRequiredService<MainContainerMDI>();
                var presenter = builder.GetRequiredService<MainPresenter>();

                Application.Run(mainContainer);
            }
        }

        private static void ConfigureServices(IServiceCollection services)
        {
            //Main Container
            services.AddSingleton<MainContainerMDI>();

            //Forms
            services.AddTransient<RegisterDialog>();

            //Presenters
            services.AddTransient<MainPresenter>();

            //Interfaces
            services.AddTransient<IMainView>(sp => sp.GetRequiredService<MainContainerMDI>());

            //Services
            services.AddSingleton<INavigationService, NavigationService>();
            services.AddHttpClient<IProductService, ProductService>()
                .ConfigureHttpClient(client =>
                {
                    client.BaseAddress = new Uri("https://localhost:7091/api/products/");
                    client.DefaultRequestHeaders.Add("Accept", "application/json");
                });
        }
    }
}