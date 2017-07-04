namespace GaugeActiveAdminExample
{
    using System;
    using Gauge.CSharp.Lib.Attribute;
    using GaugeActiveAdminExample.util;
    using OpenQA.Selenium;
    using OpenQA.Selenium.Support.UI;

    public class LogOut
    {

        [Step("Log out the customer")]
        public void LogOutTheCustomer()
        {
            IWebDriver webDriver = Driver.WebDriver;
            webDriver.FindElement(By.LinkText("Log out")).Click();
        }

        [Step("Option <option> should be available")]
        public void WaitForOptionToBeAvailable(string option)
        {
            IWebDriver webDriver = Driver.WebDriver;

            WebDriverWaitWrapper.WaitForElement(By.LinkText(option));
        }

    }
}
