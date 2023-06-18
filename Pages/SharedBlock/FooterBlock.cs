using TestSuite.Utilities;
using OpenQA.Selenium;
using static TestSuite.Utilities.WaitHelper;


namespace TestSuite.Pages
{
    public class FooterBlock : Driver
    {
        
        #region  Initialize Web Elements
        
        private static IWebElement footerLinks => driver.FindElement(By.XPath("//div[@class='pull-left']"));

        #endregion


        internal void PlaceHolderMethodName()
        {
            // Your code here
        }


        internal bool AreAllFooterLinksWorking()
        {
            return Utils.AreAllLinksWorking(footerLinks, 6);
        }
    }
}