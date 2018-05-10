using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

class EntryPoint
{
    static IWebDriver driver = new ChromeDriver();
    static IWebElement checkbox;
    static IWebElement radio;
    static void Main()
    {
        string url;
        //url = "http://testing.todvachev.com/special-elements/text-input-field/";
        //url = "http://testing.todvachev.com/special-elements/check-button-test-3/";
        url = "http://testing.todvachev.com/special-elements/radio-button-test/";
        driver.Navigate().GoToUrl(url);

        string option = "1";
        string[] options = { "1", "3", "5" };
        string cssSelector = "#post-10 > div > form > p:nth-child(6) > input[type=\"radio\"]:nth-child("+option+")";

        //textbox = driver.FindElement(By.Name("username"));
        //textbox.SendKeys("Test Texts");

        //checkbox = driver.FindElement(By.CssSelector(cssSelector));

        //Thread.Sleep(3000);

        //if(checkbox.GetAttribute("checked") == "true")
        //{
        //    Console.WriteLine("checkbox is checked");
        //}
        //else
        //{
        //    Console.WriteLine("It is NOT checked");
        //}

        //Console.WriteLine(checkbox.GetAttribute("value"));
        //checkbox.Click();
        //Thread.Sleep(3000);
        for(int i=0; i< options.Length; i++)
        {
            cssSelector = "#post-10 > div > form > p:nth-child(6) > input[type=\"radio\"]:nth-child(" + options[i] + ")";

            radio = driver.FindElement(By.CssSelector(cssSelector));

            if (radio.GetAttribute("checked") == "true")
            {
                Console.WriteLine(i+1 + " button is checked");
            }
            else
            {
                Console.WriteLine(i+1 + " button is unchecked");
            }
        }

        driver.Quit();

    }
}

