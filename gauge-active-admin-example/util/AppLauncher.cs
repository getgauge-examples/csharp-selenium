using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Gauge.CSharp.Lib.Attribute;
using gauge_active_admin_example.util;
using System.Configuration;


namespace gauge_active_admin_example
{
    public class AppLauncher
    {
        [Step("Go to the store website")]
        public void launchTheApplication()
        {
            Driver.WebDriver.Navigate().GoToUrl(Environment.GetEnvironmentVariable("APP_URL"));
            
        }

    }
}
