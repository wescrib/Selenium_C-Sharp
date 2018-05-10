using NUnit.Framework;
using OpenQA.Selenium;

namespace AutoTestFramework.Scenarios
{
    [Parallelizable]
    public class LoginInvalidUsername
    {
        IAlert alert;

        public IWebDriver Driver { get; set; }

        public LoginInvalidUsername()
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
            Actions.FillLoginForm(Config.Credentials.Invalid.Username.FourChar, Config.Credentials.Valid.Password, Config.Credentials.Valid.Password, Driver);
            alert = Driver.SwitchTo().Alert();

            Assert.AreEqual(Config.AlertMessages.UsernameLengthOutOfRange, alert.Text);
            alert.Accept();
        }

        [TestCase]
        public void MoreThan12Char()
        {
            Actions.FillLoginForm(Config.Credentials.Invalid.Username.ThirteenChar, Config.Credentials.Valid.Password, Config.Credentials.Valid.Password,Driver);
            alert = Driver.SwitchTo().Alert();

            Assert.AreEqual(Config.AlertMessages.UsernameLengthOutOfRange, alert.Text);
            alert.Accept();
        }

        [OneTimeTearDown]
        public void CleanUp()
        {
            Driver.Quit();
        }
    }
}
