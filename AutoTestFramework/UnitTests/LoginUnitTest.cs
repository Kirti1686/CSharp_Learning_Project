using AutoTestFramework.Baseclass;
using AutoTestFramework.Test;
using NUnit.Framework;
using System.Collections.Generic;
using System.Text;

namespace AutoTestFramework.UnitTests
{
    class LoginUnitTest : BaseTest
    {
        [Test]
        public void loginTest()
        {
            var testcase = new Login_Test(driver);
            testcase.Login();
        }
    }
}
