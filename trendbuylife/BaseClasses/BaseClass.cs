using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.IE;
using OpenQA.Selenium;
using trendbuylife.Settings;
using trendbuylife.Configuration;
using trendbuylife.CustomExpection;

namespace trendbuylife.BaseClasses
{

    [TestClass]
    public class BaseClass
    {
        // we will create three methods for the browsers
        private static FirefoxProfile GetFirefox()
        {
            FirefoxProfile profile = new FirefoxProfile();
            FirefoxProfileManager manager = new FirefoxProfileManager();
            profile = manager.GetProfile("default");
            return profile;
        }

        private static ChromeOptions GetChromeOptions()
        {
            ChromeOptions options = new ChromeOptions();
            options.AddArgument("start-maximized");

            return options;
        }

        private static InternetExplorerOptions GetIEOptions()
        {

            InternetExplorerOptions options = new InternetExplorerOptions();

            options.IntroduceInstabilityByIgnoringProtectedModeSettings = true;
            options.EnsureCleanSession = true;

            return options;
        }



        private static IWebDriver GetChromeDriver()
        {
            IWebDriver driver = new ChromeDriver(GetChromeOptions()); // we created chromebrowser up then we implement here 
            return driver;
        }

        private static IWebDriver GetFirefoxDriver()
        {
            IWebDriver driver = new FirefoxDriver(); // I couldnt implement ==>GetFirefox() it is giving an error. solve it 
            return driver;
        }

        private static IWebDriver GetIEDriver()
        {
            IWebDriver driver = new InternetExplorerDriver(GetIEOptions());
            return driver;
        }

        [AssemblyInitialize]
        public static void InitWebdriver(TestContext tc)
        {
            ObjectRepository.Config = new AppConfigReader();

            switch (ObjectRepository.Config.GetBrowser())
            {
                case BrowserType.Firefox:
                    ObjectRepository.Driver = GetFirefoxDriver();
                    break;

                case BrowserType.Chrome:
                    ObjectRepository.Driver = GetChromeDriver();
                    break;

                case BrowserType.IExplorer:
                    ObjectRepository.Driver = GetIEDriver();
                    break;

                default:
                    throw new NoSuitableDriverFound("Driver Not Found : " + ObjectRepository.Config.GetBrowser().ToString());

            }
        }
        // we are creating this method for

        [AssemblyCleanup]
        public static void TearDown()
        {
            if (ObjectRepository.Driver != null)
            {
                //  ObjectRepository.Driver.Close();// close current browser window and it will not stop the webdriver
                //  ObjectRepository.Driver.Quit(); // Tsis will close all the bworser window and also stop the webdriver

            }
        }

    }
}
