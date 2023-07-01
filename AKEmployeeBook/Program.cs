using AKDataAccess;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using Newtonsoft.Json.Linq;
using System.Diagnostics;
using AKDataAccess.ExtentionMethods;

namespace AKEmployeeBook
{
    internal static class Program
    {
        public static IServiceProvider? ServiceProvider { get; private set; }
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.SetHighDpiMode(HighDpiMode.SystemAware);
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.ThreadException += HandleThreadException;
            AppDomain.CurrentDomain.UnhandledException += HandleUnhandledException;
            var host = Host.CreateDefaultBuilder()
             .ConfigureServices((hostContext, services) =>
             {
                 var configuration = new ConfigurationBuilder()
                     .SetBasePath(hostContext.HostingEnvironment.ContentRootPath)
                     .AddJsonFile("appsettings.json", optional: true, reloadOnChange: true)
                     .Build();
                 bool isDbCreated = configuration.GetValue<bool>("IsDbCreated");

                 if (!isDbCreated)
                 {
                     configuration.CreateDatabase();
                     configuration.CreateAddEmployeeStoredProcedure();
                     configuration.CreateGetAllEmployeesStoredProcedure();
                     configuration.CreateGetEmployeeByIdStoredProcedure();
                     configuration.CreateUpdateEmployeeStoredProcedure();
                     UpdateSettings();
                 }

                 ConfigureServices(configuration, services);
             }).Build();

            ServiceProvider = host.Services;

            using (var scope = ServiceProvider.CreateScope())
            {
                try
                {
                    var frmMain = ServiceProvider.GetRequiredService<FrmMain>();
                    Application.Run(frmMain);
                }
                catch (Exception ex)
                {
                    Debug.WriteLine("Failed to launch Application" + ex.Message);
                }
            }
        }

        private static void UpdateSettings()
        {
            string appSettingsPath = "appsettings.json";
            string json = File.ReadAllText(appSettingsPath);
            JObject appSettings = JObject.Parse(json);
            appSettings["IsDbCreated"] = true;
            File.WriteAllText(appSettingsPath, appSettings.ToString(Newtonsoft.Json.Formatting.Indented));
        }

        private static void ConfigureServices(IConfiguration configuration, IServiceCollection services)
        {
            CompositionRoot.RegisterDependencies(services, configuration);
            services.AddSingleton<FrmMain>();
            services.AddTransient<FrmAddEditEmployee>();
            services.AddLogging(configure => configure.AddConsole());
            services.AddLogging(configure => configure.AddDebug());
        }

        private static void HandleThreadException(object sender, ThreadExceptionEventArgs e)
        {
            Exception ex = e.Exception;
            MessageBox.Show($"An unhandled exception occurred: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private static void HandleUnhandledException(object sender, UnhandledExceptionEventArgs e)
        {
            Exception ex = (e.ExceptionObject as Exception)!;
            MessageBox.Show($"An unhandled exception occurred: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

    }
}