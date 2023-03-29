
using NUnit.Framework;
using OpenQA.Selenium;
using trendbuylife.Drivers;

namespace Cactus.Hooks
{
    [Binding]
    internal class Hooks
    {
        private ScenarioContext scenarioContext;
        private Hooks(ScenarioContext scenarioContext)
        {
            scenarioContext = scenarioContext;
        }
        [BeforeScenario("browser")]
        public void BeforeHooBrowser()
        {
            //InitBrowser(Environment.GetEnvironmentVariable("browserType"), arguments);
            string arguments = "--start-maximized --disable-gpu --disable-new-profile-management --disable-extensions --ignore-certificate-errors --no-sandbox";
            SeleniumDriver.InitBroweser(Environment.GetEnvironmentVariable("browserType"),arguments);
        }
        [AfterScenario("browser")]
        [Obsolete]
        public void BrowserAfterHook()
        {
            Console.WriteLine("Hook DisposeBrowser");
            try
            {
                string fileNameBase = string.Format("error_{0}", "Scenario_" + TestContext.CurrentContext.Test.Name);
                var screenshot = ((ITakesScreenshot)SeleniumDriver.Driver).GetScreenshot();
               
                string basepath = Path.Combine(Environment.CurrentDirectory, @"Screenshots\");
                Directory.CreateDirectory(basepath);
                string path = Path.Combine(basepath, fileNameBase + ".png");
                Console.WriteLine("path : " + path);
                screenshot.SaveAsFile(path, ScreenshotImageFormat.Png);
                SeleniumDriver.Driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(5);
               // SeleniumWebDriver.Driver.Quit();

            }
            catch (Exception e)
            {
                Console.WriteLine("Exception was thrown when trying disposing the browser instance.");
                Console.WriteLine(e.Message);
            }

        }
    }
}
