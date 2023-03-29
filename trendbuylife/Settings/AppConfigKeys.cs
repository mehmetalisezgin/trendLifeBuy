using OpenQA.Selenium;
using trendbuylife.Interfaces;

namespace trendbuylife.Settings
{
    public class AppConfigKeys
    {
        public const string Browser = "Browser";
        public const string adminUsername = "adminUsername";
        public const string adminPassword = "adminPassword";
        public const string TrendlifeBuyWebSite = "TrendlifeBuy"; // after this class we should add it interface 
        public const string TrendlifeBuyAdminWebSite = "TrendlifeBuyAdmin";
        public const string adminEmail = "adminEmail";
        public const string customerEmail = "customerEmail";
        public const string customerUsername = "customerUsername";
        public const string customerPassword = "customerPassword";


        // using this keyword, it is specifying this brower is a constraint==>> like hashmap
    }
}
