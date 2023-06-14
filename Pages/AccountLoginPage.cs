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
            Header = new HeaderBlock();
        }

        public HeaderBlock Header { get; internal set; }


        #region  Initialize Web Elements

        private static IWebElement loginNameField => driver.FindElement(By.CssSelector("#loginFrm_loginname"));
        private static IWebElement passwordField => driver.FindElement(By.CssSelector("#loginFrm_password"));
        private static IWebElement loginButton => driver.FindElement(By.CssSelector("button[title='Login']"));
        private static IWebElement placeholder => driver.FindElement(By.XPath(""));

        #endregion


        public void EnterUserCredentials()
        {
            loginNameField.SendKeys(UserTestData.memberUsername);            
            passwordField.SendKeys(UserTestData.memberPassword);
            loginButton.Click();
        }

        public void FullLoginProcess() 
        {
            Utils.NavigateToUrl("index.php?rt=account/login");
            EnterUserCredentials();        
        }

        public void IsUserLoggedIn() 
        {
            Console.WriteLine(Header.GetTopCustomerMenu());
            string topCustomerMenuContent = Header.GetTopCustomerMenu();

            if (!topCustomerMenuContent.Contains("Welcome")) 
            {
                Console.WriteLine("Is not logged in");
                //FullLoginProcess();
            }
        
        }

        public string GetPlaceholder()
        {
            return placeholder.Text;
        }
    }
}