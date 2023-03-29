using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace trendbuylife.ComponentHelper
{
    public class CheckBoxHelperBase
    {
        private static WebElement element;
        public static bool IsCheckBoxChecked(By Locator)
        {
         //   element = GenericHelper.GetElement(Locator);
            string flag = element.GetAttribute("checked");
            if (flag == null)
                return false;
            else
                return flag.Equals("true") || flag.Equals("checked");
        }
    }
}
