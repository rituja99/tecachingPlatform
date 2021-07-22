using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using NUnit.Framework;
using OpenQA.Selenium.Support.UI;
namespace teachingPlatform
{
    class SignUp
    {
        [Test]
        public void signUp()
        {

            IWebDriver driver = new ChromeDriver();
            driver.Navigate().GoToUrl("https://localhost:44308/LandingPage.aspx");
            driver.Manage().Window.Maximize();
            IWebElement element = driver.FindElement(By.XPath("//*[@id='signUpButton']"));
            element.Click();
            element = driver.FindElement(By.XPath("//*[@id='ContentPlaceHolder1_txt_fullname']"));
            element.SendKeys("Ruby James");
            element = driver.FindElement(By.XPath("//*[@id='ContentPlaceHolder1_txt_emailid']"));
            element.SendKeys("rubyJames@gmail.com");
            SelectElement role = new SelectElement(driver.
                FindElement(By.XPath("//*[@id='ContentPlaceHolder1_modeDropDownList']")));
            role.SelectByText("Student");
            element = driver.FindElement(By.XPath("//*[@id='ContentPlaceHolder1_txt_password']"));
            element.SendKeys("Rubyjames@12");
            element = driver.FindElement(By.XPath("//*[@id='ContentPlaceHolder1_passwordConfirmationTextBox']"));
            element.SendKeys("Rubyjames@12");
            driver.FindElement(By.XPath("//*[@id='ContentPlaceHolder1_submitButton']")).Click();
            

        }
    }
}