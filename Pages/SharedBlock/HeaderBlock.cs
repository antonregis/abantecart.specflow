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
        private static IWebElement accountMenu => driver.FindElement(By.XPath("//*[@id='main_menu_top']/li[2]/a/span"));        
        private static IWebElement accountMenuLoginLink => driver.FindElement(By.CssSelector("li[class='dropdown open'] a[class='sub menu_login']"));
        private static IWebElement checkYourOrderLink => driver.FindElement(By.CssSelector("li[class='dropdown'] span[class='menu_text']"));

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

        internal void ClickAccountMenuLoginLink()
        {           
            WebElementHelper.MouseOverHelper(accountMenu);
            WaitForElementToBeClickable(accountMenuLoginLink);
            accountMenuLoginLink.Click();
        }

        internal string GetTopCustomerMenu() 
        {
            return topCustomerMenu.Text;
        }
    }
}