using TestSuite.Utilities;
using OpenQA.Selenium;
using static TestSuite.Utilities.WaitHelper;
using TestSuite.TestData;

namespace TestSuite.Pages
{
    public class AccountLoginPage : Driver
    {

        public AccountLoginPage()
        {
            HeaderBlock = new HeaderBlock();
            SubHeaderBlock = new SubHeaderBlock();
        }

        public HeaderBlock HeaderBlock { get; internal set; }
        public SubHeaderBlock SubHeaderBlock { get; internal set; }


        #region  Initialize Web Elements

        private static IWebElement loginNameField => driver.FindElement(By.CssSelector("#loginFrm_loginname"));
        private static IWebElement passwordField => driver.FindElement(By.CssSelector("#loginFrm_password"));
        private static IWebElement loginButton => driver.FindElement(By.CssSelector("button[title='Login']"));

        #endregion


        public void EnterUserCredentials()
        {
            loginNameField.SendKeys(UserTestData.memberUsername);            
            passwordField.SendKeys(UserTestData.memberPassword);         
        }

        public void ClickLogin()
        {
            loginButton.Click();
        }
    }
}