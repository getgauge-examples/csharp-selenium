namespace GaugeActiveAdminExample
{
    using System;
    using Gauge.CSharp.Lib;
    using Gauge.CSharp.Lib.Attribute;
    using GaugeActiveAdminExample.util;
    using NUnit.Framework;
    using OpenQA.Selenium;

    public class LogIn
    {
        [Step("Login as name <name> and <password>")]
        public void LoginAsNameNameandPassword(string name, string password)
        {
            IWebDriver webDriver = Driver.WebDriver;
            webDriver.FindElement(By.LinkText("Log in")).Click();
            
            WebDriverWaitWrapper.WaitForElement(By.Name("login"));
            webDriver.FindElement(By.Name("login")).SendKeys(name);
            webDriver.FindElement(By.Name("password")).SendKeys(password);
            webDriver.FindElement(By.Name("commit")).Click();
        }

        [Step("Show the log in status for user <customer>")]
        public void ShowTheLogInStatusForUser(string customer)
        {
            IWebDriver webDriver = Driver.WebDriver;
            IWebElement authenticatedInfo = webDriver.FindElement(By.Id("auth"));
            Assert.IsTrue(authenticatedInfo.Displayed);
            Assert.IsTrue((authenticatedInfo.Text.Contains("Welcome " + customer + "! Not you?")));
        }

    }
}
