using TestSuite.Utilities;
using OpenQA.Selenium;
using static TestSuite.Utilities.WaitHelper;


namespace TestSuite.Pages
{
    public class HeaderBlock : Driver
    {

        #region  Initialize Web Elements

        private static IWebElement topCustomerMenu => driver.FindElement(By.XPath("//ul[@id='customer_menu_top']//li//a"));
        private static IWebElement logoffLink => driver.FindElement(By.XPath("//div[@id='customernav']//li[10]//a[1]"));
        private static IWebElement accountMenuDropdown => driver.FindElement(By.CssSelector("li[class='dropdown'] a[class='top menu_account'] span[class='menu_text']"));
        private static IWebElement loginLink => driver.FindElement(By.CssSelector("li[class='dropdown open'] a[class='sub menu_login']"));
        private static IWebElement checkYourOrderLink => driver.FindElement(By.CssSelector("li[class='dropdown'] span[class='menu_text']"));
        private static IWebElement headerName => driver.FindElement(By.CssSelector(".maintext"));
        #endregion


        internal void ClickLoginOrRegisterLink()
        {
            topCustomerMenu.Click();
        }

        internal void ClickLogoff()
        {
            WebElementHelper.MouseOverHelper(topCustomerMenu);
            WaitForElementToBeClickable(logoffLink);
            logoffLink.Click();
        }

        internal string GetTopCustomerMenu() 
        {
            return topCustomerMenu.Text;
        }

        internal string GetHeaderName()
        {
            return headerName.Text.Trim();
        }
    }
}