using AutoTestFramework.Baseclass;
using AutoTestFramework.Pages;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Text;


namespace AutoTestFramework.Test
{
    class Login_Test : BaseTest
    {

        LoginPage lp = new LoginPage(driver);
        lp.Login();

    }
}
