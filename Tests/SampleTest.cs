using OpenQA.Selenium;
using OpenQA.Selenium.Edge;
using System;
namespace teachingPlatform
{
    class SampleTest
    {
        static void signInTest()
        {
            IWebDriver driver = new EdgeDriver();
            driver.Navigate().GoToUrl("https://localhost:44308/LandingPage.aspx");
            driver.Manage().Window.Maximize();
            IWebElement element = driver.FindElement(By.XPath("//*[@id='signInButton']"));
            element.Click();
            element = driver.FindElement(By.XPath("//*[@id='ContentPlaceHolder1_emailIDTextBoxStudent']"));
            element.SendKeys("lisaSamuels@gmail.com");
            element = driver.FindElement(By.XPath("//*[@id='ContentPlaceHolder1_passwordTextBoxStudent']"));
            element.SendKeys("Lisasamuels@12");
            driver.FindElement(By.XPath("//*[@id='ContentPlaceHolder1_signInButtonStudent']")).Click();



        }
    }
}