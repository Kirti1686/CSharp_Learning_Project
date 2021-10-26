using AutoTestFramework.Baseclass;
using AutoTestFramework.Pages;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Text;


namespace AutoTestFramework.Test
{
    public class Login_Test
    {
        IWebDriver driver;
        public Login_Test(IWebDriver driver)
        {
            this.driver = driver;
        }
        public void Login()
        {
            LoginPage lp1 = new LoginPage(driver);
            lp1.Login();
        }
    }
}
