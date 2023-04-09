using TestSuite.Utilities;
using OpenQA.Selenium;
using static TestSuite.Utilities.WaitHelper;
using static TestSuite.Utilities.EnvironmentHelper;


namespace TestSuite.Pages
{
    public class AccountLogin : Driver
    {

        #region  Initialize Web Elements

        private static IWebElement LoginNameField => driver.FindElement(By.CssSelector("#loginFrm_loginname"));
        private static IWebElement PasswordField => driver.FindElement(By.CssSelector("#loginFrm_password"));
        private static IWebElement LoginButton => driver.FindElement(By.CssSelector("button[title='Login']"));
        private static IWebElement Placeholder => driver.FindElement(By.XPath(""));

        #endregion


        public void EnterUserCredentials()
        {
            LoginNameField.SendKeys(MemberUsername);
            PasswordField.SendKeys(MemberPassword);
            LoginButton.Click();
        }


        public string GetPlaceholder()
        {
            return Placeholder.Text;
        }
    }
}