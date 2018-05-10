
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Threading;

class EntryPoint
{
    static void Main()
    {

        string url = "http://testing.todvachev.com/selectors/css-path/";
        string id = "testImage";
        string className = "tesClass";

        string cssPath = "#post-108 > div > figur > img";
        string xPath = "//*[@id=\"post-108\"]/div/figure/img";

        IWebDriver driver = new ChromeDriver();
        driver.Navigate().GoToUrl(url);

        //IWebElement element = driver.FindElement(By.ClassName(className));
        //IWebElement element = driver.FindElement(By.Id(id));
        IWebElement cssEl;
        IWebElement xPathEl = driver.FindElement(By.XPath(xPath));

        try
        {
            cssEl = driver.FindElement(By.CssSelector(cssPath));
            if (cssEl.Displayed)
            {
                GreenMessage("CSS path is there!");
            }
            if (xPathEl.Displayed)
            {
                GreenMessage("xPath is there!!");
            }
        }
        catch(Exception e)
        {
            RedMessage(e.Message);
        }

        driver.Quit();
    }

    private static void RedMessage(string msg)
    {
        Console.ForegroundColor = ConsoleColor.Red;
        Console.WriteLine(msg);
        Console.ForegroundColor = ConsoleColor.White;
    }

    private static void GreenMessage(string msg)
    {
        Console.ForegroundColor = ConsoleColor.Green;
        Console.WriteLine(msg);
        Console.ForegroundColor = ConsoleColor.White;
    }
}

