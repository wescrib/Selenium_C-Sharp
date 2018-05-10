using NUnit.Framework;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoTestFramework.Scenarios
{
    [Parallelizable]
    public class LoginInvalidPassword
    {
        IAlert alert;
        public IWebDriver Driver { get; set; }

        public LoginInvalidPassword()
        {

        }

        [OneTimeSetUp]
        public void Init()
        {
            Driver = Actions.InitDriver();
            NavigateTo.LoginScenarioThroughTestCases(Driver);

        }

        [TestCase]
        public void LessThan4Chars()
        {
            NavigateTo.LoginFormThroughMenu(Driver);
            Actions.FillLoginForm(Config.Credentials.Valid.Username, Config.Credentials.Invalid.Password.BasicFiveCharPW, Config.Credentials.Invalid.Password.BasicFiveCharPW, Driver);
            alert = Driver.SwitchTo().Alert();

            Assert.AreEqual(Config.AlertMessages.PasswordLengthOutOfRange, alert.Text);
            alert.Accept();
        }

        [TestCase]
        public void MoreThan12Char()
        {
            Actions.FillLoginForm(Config.Credentials.Valid.Username, Config.Credentials.Invalid.Password.MoreThanTwelveCharPW, Config.Credentials.Invalid.Password.MoreThanTwelveCharPW, Driver);
            alert = Driver.SwitchTo().Alert();

            Assert.AreEqual(Config.AlertMessages.PasswordLengthOutOfRange, alert.Text);
            alert.Accept();
        }

        [OneTimeTearDown]
        public void CleanUp()
        {
            Driver.Quit();
        }
    }
}
