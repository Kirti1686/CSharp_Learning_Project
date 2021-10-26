using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Linq;
using System.Collections.Generic;
using System.Text;
//using OpenQA.Selenium.Support.

namespace AutoTestFramework.Pages
{
    public class LoginPage
    {
        public IWebDriver driver;

        public LoginPage(IWebDriver driver)
        {
           driver = this.driver;
           //PageFactory.InitElements(IWebDdriver, this);
        }
        //[FindsBy(How = How.CssSelector, Using = "body > div.Login")];
        public IWebElement UsernameTxt => driver.FindElement(By.Id("username"));
        public IWebElement PasswordTxt => driver.FindElement(By.Id("password"));
        public IWebElement LogInbtn => driver.FindElement(By.Id("btn-login"));
        private IWebElement DisplayName => driver.FindElement(By.XPath("//span[text()='Good Evening, Tyron!']"));

        public void Login()
        {
            UsernameTxt.SendKeys("HealthTrus_734578498-1");
            PasswordTxt.SendKeys("Password1");
            LogInbtn.Click();
        }
        public bool IsLoginSuccessful()
        {
            return DisplayName.Text.Equals("Good Evening, Tyron!");
        }
    }
}
