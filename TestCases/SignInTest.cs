using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using NUnit.Framework;
using System;
namespace teachingPlatform
{
    class SignInTest
    {
        [Test]
        public void signInTest()
        {
            
            IWebDriver driver = new ChromeDriver();
            driver.Navigate().GoToUrl("https://localhost:44308/LandingPage.aspx");
            driver.Manage().Window.Maximize();
            IWebElement element = driver.FindElement(By.XPath("//*[@id='signInButton']"));
            element.Click();
            element = driver.FindElement(By.XPath("//*[@id='ContentPlaceHolder1_emailIDTextBoxStudent']"));
            element.SendKeys("lisaSamuels@gmail.com");
            element = driver.FindElement(By.XPath("//*[@id='ContentPlaceHolder1_passwordTextBoxStudent']"));
            element.SendKeys("Lisasamuels@12");
            driver.FindElement(By.XPath("//*[@id='ContentPlaceHolder1_signInButtonStudent']")).Click();
            driver.Close();

        }
    }
}