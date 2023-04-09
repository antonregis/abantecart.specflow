using TestSuite.Utilities;
using OpenQA.Selenium;
using static TestSuite.Utilities.WaitHelper;


namespace TestSuite.Pages
{
    public class MyAccount : Driver
    {
        
        #region  Initialize Web Elements
        
        private static IWebElement AccountDashboard => driver.FindElement(By.CssSelector(".selected"));
        private static IWebElement WelcomeBack => driver.FindElement(By.XPath("//div[@class='menu_text']"));

        #endregion


        public void PlaceHolderMethodName()
        {
            // Your code here
        }


        public string GetAccountDashboard()
        {
            return AccountDashboard.Text.Trim();
        }

        public string GetWelcomeBack()
        {
            return WelcomeBack.Text;
        }
    }
}