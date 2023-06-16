using TestSuite.Utilities;
using OpenQA.Selenium;
using static TestSuite.Utilities.WaitHelper;


namespace TestSuite.Pages
{
    public class HomePage : Driver
    {

        public HomePage() 
        {
            HeaderBlock = new HeaderBlock();
            SubHeaderBlock = new SubHeaderBlock();
            FooterBlock = new FooterBlock();
        }

        public HeaderBlock HeaderBlock { get; internal set; }
        public SubHeaderBlock SubHeaderBlock { get; internal set; }
        public FooterBlock FooterBlock { get; internal set; }


        #region  Initialize Web Elements

        private static IWebElement headerstripBlock => driver.FindElement(By.CssSelector(".headerstrip"));
        private static IWebElement featuredBlock => driver.FindElement(By.Id("featured"));        

        #endregion


        public void PlaceHolderMethodName()
        {
            // Your code here
        }

        public bool IsHeaderstripBlockLoaded()
        {
            return headerstripBlock.Displayed;
        }
        public bool IsFeaturedBlockLoaded()
        {
            return featuredBlock.Displayed;
        }
    }
}