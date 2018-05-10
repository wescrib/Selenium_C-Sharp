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
    static IAlert alert;
    static IWebElement image;
    static void Main()
    {
        url = "http://testing.todvachev.com/special-elements/alert-box/";

        driver.Navigate().GoToUrl(url);
        alert = driver.SwitchTo().Alert();
        Console.WriteLine(alert.Text);
        alert.Accept();
        try
        {
            image = driver.FindElement(By.CssSelector("#post-119 > div > figure > img"));
            if (image.Displayed)
            {
                Console.WriteLine("The alert was accepted successfully");
            }
        }catch(Exception e)
        {
            Console.WriteLine("No that did not work");
        }
        Thread.Sleep(4000);
        driver.Quit();
    }
}
