using AutoTestFramework.UIElements;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Threading;

namespace AutoTestFramework
{
    public static class Actions
    {
        public static IWebDriver InitDriver()
        {
            IWebDriver driver = new ChromeDriver();
            driver.Navigate().GoToUrl(Config.BaseURL);
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(5);
            return driver;
        }
        public static void FillLoginForm(string username, string password, string repeatpw, IWebDriver driver)
        {
            LoginScenarioPost lsPost = new LoginScenarioPost(driver);

            //Thread.Sleep(3000);
            lsPost.UsernameField.Clear();
            lsPost.UsernameField.SendKeys(username);
            //Thread.Sleep(3000);
            lsPost.PasswordField.Clear();
            lsPost.PasswordField.SendKeys(password);
            //Thread.Sleep(3000);
            lsPost.RepeatPasswordField.Clear();
            lsPost.RepeatPasswordField.SendKeys(repeatpw);
            //Thread.Sleep(3000);
            lsPost.LoginButton.Click();
        }
    }
}
