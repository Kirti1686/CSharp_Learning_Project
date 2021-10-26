using OpenQA.Selenium;

namespace AutoTestFramework.Pages
{
    class LoginPage
    {
        public IWebDriver driver;

        public LoginPage(IWebDriver driver)
        {
           this.driver = driver;
        }
        public IWebElement UsernameTxt => driver.FindElement(By.Id("username"));
        public IWebElement PasswordTxt => driver.FindElement(By.Id("password"));
        public IWebElement LogInbtn => driver.FindElement(By.Id("btn-login"));
        private IWebElement DisplayNamelbl => driver.FindElement(By.XPath("//span[text()='Good Evening, Tyron!']"));

        public void Login()
        {
            UsernameTxt.SendKeys("HealthTrus_734578498-1");
            PasswordTxt.SendKeys("Password1");
            LogInbtn.Click();
        }
        public bool IsLoginSuccessful()
        {
            return DisplayNamelbl.Text.Equals("Good Evening, Tyron!");
        }
    }
}
