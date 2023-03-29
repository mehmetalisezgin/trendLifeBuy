using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using trendbuylife.Settings;

namespace trendbuylife.ComponentHelper
{
    public class NavigationHelper
    {
        public static void NavigateToUrl()
        {
            INavigation page = ObjectRepository.Driver.Navigate();
            page.GoToUrl(ObjectRepository.Config.GetTrendlifeBuyWebsite());

        }
        // Bu method bir web sayfasina gitmek icin kullanilan sik kullanilan method gibi 
    }
}
