using AutoTestFramework.UIElements;
using OpenQA.Selenium;
using System.Threading;

namespace AutoTestFramework
{
    class NavigateTo
    {
        public static void LoginFormThroughMenu(IWebDriver driver)
        {
            Menu menu = new Menu(driver);
            TestScenariosPage tsPage = new TestScenariosPage(driver);

            menu.TestScenarios.Click();
            //Thread.Sleep(2000);
            tsPage.LoginForm.Click();
            //Thread.Sleep(3000);

        }

        public static void LoginScenarioThroughTestCases(IWebDriver driver)
        {
            Menu menu = new Menu(driver);
            TestCasesPage tcPage = new TestCasesPage(driver);
            TestScenariosPage tsPage = new TestScenariosPage(driver);
            UsernameFieldPost ufPost = new UsernameFieldPost(driver);

            menu.TestCases.Click();
            //Thread.Sleep(2000);
            tcPage.UsernameField.Click();
            //Thread.Sleep(2000);
            ufPost.LoginFormLink.Click();
            //Thread.Sleep(5000);
        }
    }
}
