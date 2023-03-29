using OpenQA.Selenium;
using trendbuylife.Interfaces;

namespace trendbuylife.Settings
{
    public class ObjectRepository
    {
        public static IConfig Config { get; set; }
        public static IWebDriver Driver { get; set; }
    }
}
