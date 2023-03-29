using OpenQA.Selenium;
using SeleniumExtras.PageObjects;
using trendbuylife.Drivers;

namespace trendbuylife.Pages
{
    internal class MainPage
    {
        private IWebDriver driver = SeleniumDriver.Driver;
        
        public MainPage() {
            PageFactory.InitElements(driver, this);
                
     }

        private IWebElement trendBuyHeaderText => driver.FindElement(By.XPath("(//img[@title='Trendlifebuy | Online Shopping'])[1]"));






    }
}
