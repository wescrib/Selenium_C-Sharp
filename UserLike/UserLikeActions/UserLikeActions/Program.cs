using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Interactions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

class EntryPoint
{
    static void Main(string[] args)
    {
        IWebDriver driver = new ChromeDriver();

        string url = "http://testing.todvachev.com/draganddrop/draganddrop.html";

        driver.Navigate().GoToUrl(url);

        string[] dragElementIds =
        {
            "Drag1",
            "Drag2",
            "Drag3",
            "Drag4",
            "Drag5"
        };

        IWebElement[] webElements = {
            driver.FindElement(By.Id(dragElementIds[0])),
            driver.FindElement(By.Id(dragElementIds[1])),
            driver.FindElement(By.Id(dragElementIds[2])),
            driver.FindElement(By.Id(dragElementIds[3])),
            driver.FindElement(By.Id(dragElementIds[4]))
        };

        Actions actions = new Actions(driver);
        actions.MoveToElement(webElements[3]).Build().Perform();

        Thread.Sleep(1500);

        MoveElement(new Actions(driver), webElements[0], webElements[3]);
        Thread.Sleep(2000);
        MoveElement(new Actions(driver), webElements[1], webElements[4]);
        Thread.Sleep(2000);
        MoveElement(new Actions(driver), webElements[2], webElements[0]);
        Thread.Sleep(5000);

        driver.Quit();
    }
    public static void MoveElement(Actions actions, IWebElement from, IWebElement to, int x = 0, int y = 10)
    {
        actions.ClickAndHold(from)
            .MoveToElement(to)
            .MoveByOffset(x, y)
            .Release()
            .Build()
            .Perform();

    }
}

