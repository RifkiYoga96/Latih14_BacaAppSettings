using Microsoft.Extensions.Configuration;

namespace Latih14_BacaAppSettings
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            LoadConfig();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
        private void LoadConfig()
        {
            var AppSettings = Program.Configuration.GetSection("AppSettings");
            var connectionString = Program.Configuration.GetConnectionString("DefaultConnection");

            string appName = AppSettings["ApplicationName"];
            string version = AppSettings["Version"];
            string theme = AppSettings.GetSection("Settings")["Theme"];
            string language = AppSettings.GetSection("Settings")["Language"];

            MessageBox.Show($"App Name: {appName}\nVersion: {version}\nTheme: {theme}\nLanguage: {language}\nConnection String: {connectionString}");
        }
    }
}
