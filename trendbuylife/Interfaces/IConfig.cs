using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using trendbuylife.Configuration;

namespace trendbuylife.Interfaces
{
    public interface IConfig
    {
        BrowserType GetBrowser();
        string GetAdminPassword();
        string GetAdminUsername();
        string GetAdminEmail();
        string GetTrendlifeBuyWebsite();
        string GetCustomerPassword();
        string GetCustomerUsername();
        string GetCustomerEmail();
        string GetTrendlifeBuyAdminWebsite();
        // this is going to read the data from the AppConfigKey
        // then we should implement this data in the AppConfigReader class
    }
}
