using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Gauge.CSharp.Lib.Attribute;
using GaugeActiveAdminExample.util;
using System.Configuration;


namespace GaugeActiveAdminExample
{
    public class AppLauncher
    {
        [Step("Go to the store website")]
        public void LaunchTheApplication()
        {
            Driver.WebDriver.Navigate().GoToUrl(Environment.GetEnvironmentVariable("APP_URL"));
            
        }

    }
}
