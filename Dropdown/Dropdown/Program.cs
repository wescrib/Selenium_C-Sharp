using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

class Program
{
    static string url;
    static IWebDriver driver = new ChromeDriver();
    static IWebElement dropDownMenu;
    static IWebElement elementFromDropDownMenu;
    static void Main()
    {
        url = "http://testing.todvachev.com/special-elements/drop-down-menu-test/";
        string dropDownMenuElements = " #post-6 > div > p:nth-child(6) > select > option:nth-child(3)";

        driver.Navigate().GoToUrl(url);
        dropDownMenu = driver.FindElement(By.Name("DropDownTest"));

        Console.WriteLine(dropDownMenu.GetAttribute("value"));

        elementFromDropDownMenu = driver.FindElement(By.CssSelector(dropDownMenuElements));

        Console.WriteLine(elementFromDropDownMenu.GetAttribute("value"));

        elementFromDropDownMenu.Click();

        Thread.Sleep(5000);

        driver.Quit();
    }
}

