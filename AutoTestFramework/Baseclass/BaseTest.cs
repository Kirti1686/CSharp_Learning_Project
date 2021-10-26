using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Text;

namespace AutoTestFramework.Baseclass
{
    public class BaseTest
    {
        public static IWebDriver driver;

        [SetUp]
        public void open()
        {
            driver = new ChromeDriver();
            driver.Manage().Window.Maximize();
            driver.Url = "https://login.onlifehealth.com/Home/Login/?ReturnUrl=%2F";
        }
        [TearDown]
        public void close()
        {
            driver.Quit();
        }
    }
}
