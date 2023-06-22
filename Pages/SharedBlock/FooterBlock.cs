using TestSuite.Utilities;
using OpenQA.Selenium;
using static TestSuite.Utilities.WaitHelper;


namespace TestSuite.Pages
{
    public class FooterBlock : Driver
    {

        #region  Initialize Web Elements

        private static IWebElement facebookBtn => driver.FindElement(By.XPath("//div[@class='footer_block']//a[@title='Facebook']"));
        private static IWebElement twitterBtn => driver.FindElement(By.XPath("//div[@class='footer_block']//a[@title='Twitter']"));

        #endregion


        internal void PlaceHolderMethodName()
        {
            // Your code here
        }

        internal bool IsFacebookBtnWorking()
        {
            return Utils.IsUrlWorking(facebookBtn, "href");
        }

        internal string GetfacebookBtnUrl()
        {
            return facebookBtn.GetAttribute("href");
        }

        internal bool IsTwitterBtnWorking()
        {
            return Utils.IsUrlWorking(twitterBtn, "href");
        }

        internal string GetTwitterBtnUrl()
        {
            return twitterBtn.GetAttribute("href");
        }
    }
}