using TestSuite.Utilities;
using OpenQA.Selenium;
using static TestSuite.Utilities.WaitHelper;


namespace TestSuite.Pages
{
    public class ProductListPage : Driver
    {

        public ProductListPage()
        {
            HeaderBlock = new HeaderBlock();
            SubHeaderBlock = new SubHeaderBlock();
            FooterBlock = new FooterBlock();
        }

        public HeaderBlock HeaderBlock { get; internal set; }
        public SubHeaderBlock SubHeaderBlock { get; internal set; }
        public FooterBlock FooterBlock { get; internal set; }


        #region  Initialize Web Elements

        IWebElement topSortingWellBlock => driver.FindElement(By.XPath("//body/div/div[@id='maincontainer']/div/div/div/div/div[1]"));
        IWebElement productThumbnailsBlock => driver.FindElement(By.XPath("//body/div/div[@id='maincontainer']/div/div/div/div/div[2]"));
        IWebElement bottomSortingWellBlock => driver.FindElement(By.XPath("//body/div/div[@id='maincontainer']/div/div/div/div/div[4]"));

        #endregion


        public void PlaceholderMethodName()
        {
            // Your code here
        }


        public bool IsTopSortingWellBlockLoaded()
        {
            return topSortingWellBlock.Displayed;
        }

        public bool IsProductThumbnailslockLoaded()
        {
            return productThumbnailsBlock.Displayed;
        }

        public bool IsBottomSortingWellBlockLoaded()
        {
            return bottomSortingWellBlock.Displayed;
        }
    }
}