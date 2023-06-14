using TestSuite.Utilities;
using OpenQA.Selenium;
using static TestSuite.Utilities.WaitHelper;


namespace TestSuite.Pages
{
    public class AccountLogoutPage : Driver
    {
        
        #region  Initialize Web Elements
        
        private static IWebElement accountLogoutHeader => driver.FindElement(By.XPath("//span[@class='maintext']"));
        private static IWebElement accountLogoutMessage => driver.FindElement(By.CssSelector(".mb40"));

        #endregion


        public void PlaceHolderMethodName()
        {
            // Your code here
        }

        public string GetAccountLogoutHeader()
        {
            return accountLogoutHeader.Text;
        }

        public string GetAccountLogoutMessage()
        {
            return accountLogoutMessage.Text;
        }
    }
}