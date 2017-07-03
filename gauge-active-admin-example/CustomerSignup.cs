using System;
using Gauge.CSharp.Lib;
using Gauge.CSharp.Lib.Attribute;
using gauge_active_admin_example.util;
using NUnit.Framework;
using OpenQA.Selenium;
using System.Collections.Generic;

namespace gauge_active_admin_example
{
    public class CustomerSignup
    {
        [Step("Sign up as <customer> with email <customer@example.com> and <password>")]
        public void registerCustomerWith(String customer, String email, String password)
        {
            IWebDriver webDriver = Driver.WebDriver;
            webDriver.FindElement(By.LinkText("Sign up")).Click();

            IWebElement form = webDriver.FindElement(By.Id("new_user"));
            form.FindElement(By.Name("user[username]")).SendKeys(customer);
            form.FindElement(By.Name("user[email]")).SendKeys(email);
            form.FindElement(By.Name("user[password]")).SendKeys(password);
            form.FindElement(By.Name("user[password_confirmation]")).SendKeys(password);
            form.FindElement(By.Name("commit")).Click();
        }

    [Step("See items available for purchase.")]
    public void seeItemsAvailableForPurchase()
        {
            IWebDriver webDriver = Driver.WebDriver;
            var products = webDriver.FindElements(By.ClassName("product"));
            Assert.That(products.Count, Is.Not.Zero);
        }
    }

}
