namespace gauge_active_admin_example
{
    using System;
    using Gauge.CSharp.Lib.Attribute;
    using gauge_active_admin_example.util;
    using OpenQA.Selenium;
    using OpenQA.Selenium.Support.UI;

    public class LogOut
    {

        [Step("Log out the customer")]
        public void logOutTheCustomer()
        {
            IWebDriver webDriver = Driver.WebDriver;
            webDriver.FindElement(By.LinkText("Log out")).Click();
        }

        [Step("Option <option> should be available")]
        public void waitForOptionToBeAvailable(String option)
        {
            IWebDriver webDriver = Driver.WebDriver;

            var wait = new WebDriverWait(webDriver, TimeSpan.FromSeconds(5));
            wait.Until(x => x.FindElement(By.LinkText(option)));

        }

    }
}
