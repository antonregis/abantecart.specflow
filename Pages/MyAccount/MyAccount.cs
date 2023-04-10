using TestSuite.Utilities;
using OpenQA.Selenium;
using static TestSuite.Utilities.WaitHelper;


namespace TestSuite.Pages
{
    public class MyAccount : Driver
    {
        
        public MyAccount() 
        { 
            EditAccountInfo = new EditAccountInfo();
            Header = new Header();
        }

        public EditAccountInfo EditAccountInfo { get; internal set; }
        public Header Header { get; internal set; }


        #region  Initialize Web Elements

        private static IWebElement AccountDashboard => driver.FindElement(By.CssSelector(".selected"));
        private static IWebElement EditAccountDetailsLink => driver.FindElement(By.XPath("//ul[@class='side_account_list']//li//a[@href='https://abantecart.codifyme.co.nz/index.php?rt=account/edit']"));

        #endregion


        public void ClickEditAccountDetailsLink()
        {
            EditAccountDetailsLink.Click();
        }


        public string GetAccountDashboard()
        {
            return AccountDashboard.Text.Trim();
        }
    }
}