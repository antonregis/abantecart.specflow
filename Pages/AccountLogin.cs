using TestSuite.Utilities;
using OpenQA.Selenium;
using static TestSuite.Utilities.WaitHelper;
using static TestSuite.Utilities.EnvironmentHelper;


namespace TestSuite.Pages
{
    public class AccountLogin : Driver
    {

        public AccountLogin()
        {
            Header = new Header();
        }

        public Header Header { get; internal set; }


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

        public void FullLoginProcess() 
        {
            NavigateToUrl("index.php?rt=account/login");
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
            return Placeholder.Text;
        }
    }
}