using TestSuite.Utilities;
using OpenQA.Selenium;
using static TestSuite.Utilities.WaitHelper;


namespace TestSuite.Pages
{
    public class SideNavigationBlock : Driver
    {

        #region  Initialize Web Elements

        private static IWebElement logOffLink => driver.FindElement(By.LinkText("Logoff"));        
        private static IWebElement editAccountDetailsLink => driver.FindElement(By.XPath("//*[@id='maincontainer']/div/div[2]/div[1]/div/ul/li[3]/a"));

        #endregion

        internal void ClickLogoffLink() 
        { 
            logOffLink.Click();
        }

        internal void ClickEditAccountDetailsLink()
        {
            editAccountDetailsLink.Click();
        }
    }
}