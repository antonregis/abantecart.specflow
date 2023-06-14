using TestSuite.Utilities;
using OpenQA.Selenium;
using static TestSuite.Utilities.WaitHelper;


namespace TestSuite.Pages
{
    public class SideNavigationBlock : Driver
    {

        #region  Initialize Web Elements

        private static IWebElement accountDashboard => driver.FindElement(By.CssSelector(".selected"));
        private static IWebElement editAccountDetailsLink => driver.FindElement(By.XPath("//ul[@class='side_account_list']//li//a[@href='https://abantecart.codifyme.co.nz/index.php?rt=account/edit']"));

        #endregion


        public void ClickEditAccountDetailsLink()
        {
            editAccountDetailsLink.Click();
        }


        public string GetAccountDashboard()
        {
            return accountDashboard.Text.Trim();
        }
    }
}