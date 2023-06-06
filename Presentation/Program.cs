using DataAccess.Context;
using Microsoft.Extensions.DependencyInjection;
using Presentation.Presenters;
using Presentation.Views;
using System;
using System.Windows.Forms;

namespace Presentation
{
    static class Program
    {
        public static ServiceProvider ServiceProvider { get; private set; }

        static void ConfigureServices()
        {
            ServiceProvider = new ServiceCollection()
                .AddDbContext<BibliotecaContext>()
                .AddSingleton<FormBase>()
                .AddSingleton<BasePresenter>()
                .BuildServiceProvider();
        }

        static void Shutdown()
        {
            ServiceProvider?.Dispose();
        }

        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.SetHighDpiMode(HighDpiMode.SystemAware);
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            ConfigureServices();

            var formBase = ServiceProvider.GetRequiredService<FormBase>();
            Application.Run(formBase);

            Shutdown();
        }
    }
}
