using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Edge;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace trendbuylife.Drivers
{
    [Binding]
    static class SeleniumDriver
    {
        static public IWebDriver Driver {get; set;}
        static public WebDriverWait Wait {get; set;}
        static public void InitBroweser(string browser, string arguments)

        {
            switch (browser.ToUpper())
            {
               
                case "EDGE":
                    EdgeOptions edgeOptions = new EdgeOptions();
                    edgeOptions.AddArguments(arguments);
                    Driver = new EdgeDriver(EdgeDriverService.CreateDefaultService(Environment.GetEnvironmentVariable("chromeWebDriver")), edgeOptions);
                    break;
                default:
                    throw new Exception("Broeser name " + browser + "is not supported");
            }
            Wait = new WebDriverWait(Driver, new TimeSpan(0, 0, 15));
            Driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(3);
        }





    }
}
