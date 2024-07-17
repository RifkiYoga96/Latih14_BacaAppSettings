using Microsoft.Extensions.Configuration;
using System.Configuration;

namespace Latih14_BacaAppSettings
{
    internal static class Program
    {

        public static IConfiguration Configuration { get; private set; }
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();
            Application.Run(new Form1());
        }

        static Program()
        {
            var builder = new ConfigurationBuilder()
                .SetBasePath(Directory.GetCurrentDirectory())
                .AddJsonFile("AppSettings.json", true, true);

            Configuration = builder.Build();
        }
    }
}