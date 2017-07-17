namespace GaugeActiveAdminExample.util
{
    using System;
    using Gauge.CSharp.Lib;
    using Gauge.CSharp.Lib.Attribute;
    using GaugeActiveAdminExample.util;
    using FluentAssertions;
    using OpenQA.Selenium;

    public class FlashMessages
    {
        [Step("Show a message <message>")]
        public void ShowAWelcomeMessage(string message)
        {
            IWebDriver webDriver = Driver.WebDriver;
            IWebElement flashNoticeElement = webDriver.FindElement(By.XPath(String.Format("//div[@id = 'flash_notice' and text() = '{0}']", message)));
            flashNoticeElement.Displayed.Should().BeTrue();
        }
    }
}
