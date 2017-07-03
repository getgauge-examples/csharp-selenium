namespace gauge_active_admin_example
{
    using System;
    using Gauge.CSharp.Lib;
    using Gauge.CSharp.Lib.Attribute;
    using gauge_active_admin_example.util;
    using NUnit.Framework;
    using OpenQA.Selenium;
    using System.Collections.Generic;

    public class PlaceOrder
    {

        [Step("Add item <item> to the cart.")]
        public void addItemToTheBasket(String item)
        {
            IWebDriver webDriver = Driver.WebDriver;
            webDriver.FindElement(By.LinkText(item)).Click();
            webDriver.FindElement(By.LinkText("Add to Card")).Click();
        }

        [Step("Checkout now")]
        public void placeTheOrder()
        {
            IWebDriver webDriver = Driver.WebDriver;
            webDriver.FindElement(By.XPath("//input[@value='Checkout Now!']")).Click();
        }

        [Step("Cart now contains <itemCount> number of items")]
        public void cartNowContains(int numberOfItems)
        {
            IWebDriver webDriver = Driver.WebDriver;
            var products = webDriver.FindElements(By.XPath("//table/tbody/tr"));
            Assert.AreEqual(numberOfItems, products.Count - 2);
        }
    }
}
