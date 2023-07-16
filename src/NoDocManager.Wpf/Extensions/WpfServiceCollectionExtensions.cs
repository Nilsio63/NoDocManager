using Microsoft.Extensions.DependencyInjection;
using NoDocManager.Wpf.ViewModels;
using NoDocManager.Wpf.Views;

namespace NoDocManager.Wpf.Extensions;

public static class WpfServiceCollectionExtensions
{
    public static IServiceCollection AddWpfServices(this IServiceCollection services)
    {
        return services
            .AddTransient<MainWindow>()
            .AddTransient<MainViewModel>();
    }
}
