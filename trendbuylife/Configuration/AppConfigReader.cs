
using System.Configuration;
using trendbuylife.Interfaces;
using trendbuylife.Settings;

namespace trendbuylife.Configuration
{
    public class AppConfigReader : IConfig // I Config is an interface we implemented it
    {
        public object AppConfgKeys { get; private set; }

        public BrowserType GetBrowser()
        {

            // here as we know that the config file will have everything inside the string and the return type
            // we need to do some additional configuration to convert our string value in the enum
            string browser = ConfigurationManager.AppSettings.Get(AppConfigKeys.Browser);
            // here we are going to take us to the enum type so far that we have a utilitiy method in class
            // which takes the argument first, the type of enum

            return (BrowserType)Enum.Parse(typeof(BrowserType), browser);

            // 

        }

        public string GetAdminPassword()
        {
            return ConfigurationManager.AppSettings.Get(AppConfigKeys.adminPassword);
        }

        public string GetAdminUsername()
        {
            return ConfigurationManager.AppSettings.Get(AppConfigKeys.adminUsername);
        }
        public string GetAdminEmail()
        {
            return ConfigurationManager.AppSettings.Get(AppConfigKeys.adminEmail);
        }

        public string GetTrendlifeBuyWebsite()
        {
            return ConfigurationManager.AppSettings.Get(AppConfigKeys.TrendlifeBuyWebSite);
        }

        public string GetCustomerPassword()
        {
            return ConfigurationManager.AppSettings.Get(AppConfigKeys.customerPassword);
        }

        public string GetCustomerUsername()
        {
            return ConfigurationManager.AppSettings.Get(AppConfigKeys.customerUsername);
        }
        public string GetCustomerEmail()
        {
            return ConfigurationManager.AppSettings.Get(AppConfigKeys.customerEmail);
        }

        public string GetTrendlifeBuyAdminWebsite()
        {
            return ConfigurationManager.AppSettings.Get(AppConfigKeys.TrendlifeBuyAdminWebSite);
        }

        
    }
}
