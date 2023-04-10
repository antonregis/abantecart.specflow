using TestSuite.Utilities;
using OpenQA.Selenium;
using static TestSuite.Utilities.WaitHelper;


namespace TestSuite.Pages
{
    public class Header : Driver
    {

        #region  Initialize Web Elements

        private static IWebElement TopCustomerMenu => driver.FindElement(By.CssSelector("ul[id='customer_menu_top'] li a"));
        private static IWebElement Placeholder => driver.FindElement(By.XPath(""));

        #endregion


        internal void ClickLoginOrRegisterLink()
        {
            TopCustomerMenu.Click();
        }


        internal string GetPlaceholder()
        {
            return Placeholder.Text;
        }

        public string GetTopCustomerMenu()
        {
            return TopCustomerMenu.Text;
        }
    }
}