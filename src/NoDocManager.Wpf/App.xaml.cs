using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using NoDocManager.Business.Extensions;
using NoDocManager.Data.Extensions;
using NoDocManager.Wpf.Extensions;
using NoDocManager.Wpf.Views;
using System.Windows;

namespace NoDocManager.Wpf;

public partial class App : Application
{
    private readonly IHost _appHost;

    public App()
    {
        _appHost = Host
            .CreateDefaultBuilder()
            .ConfigureServices(services =>
            {
                services
                    .AddDataServices()
                    .AddBusinessServices()
                    .AddWpfServices();
            })
            .Build();
    }

    protected override async void OnStartup(StartupEventArgs e)
    {
        await _appHost.StartAsync();

        _appHost.Services.GetRequiredService<MainWindow>().Show();

        base.OnStartup(e);
    }

    protected override async void OnExit(ExitEventArgs e)
    {
        await _appHost.StopAsync();

        _appHost.Dispose();

        base.OnExit(e);
    }
}
