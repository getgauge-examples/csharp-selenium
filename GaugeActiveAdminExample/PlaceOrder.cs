namespace GaugeActiveAdminExample
{
    using System;
    using Gauge.CSharp.Lib;
    using Gauge.CSharp.Lib.Attribute;
    using GaugeActiveAdminExample.util;
    using FluentAssertions;
    using OpenQA.Selenium;
    using System.Collections.Generic;

    public class PlaceOrder
    {

        [Step("Add item <item> to the cart.")]
        public void AddItemToTheBasket(string item)
        {
            IWebDriver webDriver = Driver.WebDriver;
            webDriver.FindElement(By.LinkText(item)).Click();
            webDriver.FindElement(By.LinkText("Add to Card")).Click();
        }

        [Step("Checkout now")]
        public void PlaceTheOrder()
        {
            IWebDriver webDriver = Driver.WebDriver;
            webDriver.FindElement(By.XPath("//input[@value='Checkout Now!']")).Click();
        }

        [Step("Cart now contains <itemCount> number of items")]
        public void CartNowContains(int numberOfItems)
        {
            IWebDriver webDriver = Driver.WebDriver;
            var products = webDriver.FindElements(By.XPath("//table/tbody/tr"));
            int HEADERCOUNT = 1;
            int FOOTERCOUNT = 1;
            (products.Count - HEADERCOUNT - FOOTERCOUNT).Should().Be(numberOfItems);
        }
    }
}
