namespace gauge_active_admin_example.util
{
    using System;
    using Gauge.CSharp.Lib;
    using Gauge.CSharp.Lib.Attribute;
    using gauge_active_admin_example.util;
    using NUnit.Framework;
    using OpenQA.Selenium;

    public class FlashMessages
    {
        [Step("Show a message <message>")]
        public void showAWelcomeMessage(String message)
        {
            IWebDriver webDriver = Driver.WebDriver;
            IWebElement flashNoticeElement = webDriver.FindElement(By.XPath(String.Format("//div[@id = 'flash_notice' and text() = '%s']", message)));
            Assert.True(flashNoticeElement.Displayed);
        }
    }
}
