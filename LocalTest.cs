using System;
using System.Threading;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Appium;
using OpenQA.Selenium.Appium.iOS;
using OpenQA.Selenium.Support.UI;
using OpenQA.Selenium.Remote;

namespace ios
{
    [TestFixture("local", "iphone-xs")]
    public class LocalTest : BrowserStackNUnitTest
    {
        public LocalTest(string profile, string environment) : base(profile,environment){ }

        [Test]
        [Obsolete]
        public void testLocal()
        {
            var usernameInputBox = (RemoteWebElement)new WebDriverWait(driver, TimeSpan.FromMinutes(2)).Until(
            SeleniumExtras.WaitHelpers.ExpectedConditions.ElementExists(By.ClassName("XCUIElementTypeTextField")));
            usernameInputBox.SendKeys("qacon1");
            var passwordInputBox = (RemoteWebElement)new WebDriverWait(driver, TimeSpan.FromMinutes(2)).Until(
            SeleniumExtras.WaitHelpers.ExpectedConditions.ElementExists(By.ClassName("XCUIElementTypeSecureTextField")));
            passwordInputBox.SendKeys("east@1234");
            driver.HideKeyboard();
            var signInButton = (RemoteWebElement)new WebDriverWait(driver, TimeSpan.FromMinutes(2)).Until(
            SeleniumExtras.WaitHelpers.ExpectedConditions.ElementExists(By.Name("Sign In")));
            signInButton.Click();
            Thread.Sleep(50000);
        }
    }
}
