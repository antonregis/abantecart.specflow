using TestSuite.Utilities;
using OpenQA.Selenium;
using static TestSuite.Utilities.WaitHelper;


namespace TestSuite.Pages
{
    public class Header : Driver
    {

        #region  Initialize Web Elements

        private static IWebElement LoginOrRegisterLink => driver.FindElement(By.XPath("//a[normalize-space()='Login or register']"));
        private static IWebElement Placeholder => driver.FindElement(By.XPath(""));

        #endregion


        internal void ClickLoginOrRegisterLink()
        {
            LoginOrRegisterLink.Click();
        }


        internal string GetPlaceholder()
        {
            return Placeholder.Text;
        }
    }
}