using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using System.Windows;

namespace BansosKu
{
    public partial class App : Application
    {
        public static IHost? AppHost { get; private set; }
        public App() {
            AppHost = Host.CreateDefaultBuilder()
                .ConfigureServices ((hostContext,services) => {
                    services.AddSingleton<MainWindow>();
                }).Build();
        }
    }
}
