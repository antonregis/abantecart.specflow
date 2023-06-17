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
        private static IWebElement headerdetails => driver.FindElement(By.CssSelector(".headerdetails"));
        private static IWebElement categorymenuBlock => driver.FindElement(By.CssSelector(".categorymenu"));
        private static IWebElement sliderBlock => driver.FindElement(By.CssSelector(".slider"));
        private static IWebElement promo_sectionBlock => driver.FindElement(By.CssSelector(".promo_section"));
        private static IWebElement featuredBlock => driver.FindElement(By.CssSelector("#featured"));
        private static IWebElement latestBlock => driver.FindElement(By.CssSelector("#latest"));
        private static IWebElement bestsellerBlock => driver.FindElement(By.CssSelector("#bestseller"));
        private static IWebElement specialBlock => driver.FindElement(By.CssSelector("#special"));
        private static IWebElement bannerBlock => driver.FindElement(By.CssSelector("#banner_banner_block_1773"));
        private static IWebElement popularbrandsBlock => driver.FindElement(By.CssSelector("#popularbrands"));
        private static IWebElement footersocialBlock => driver.FindElement(By.CssSelector(".footersocial"));
        private static IWebElement footerlinksBlock => driver.FindElement(By.CssSelector(".footerlinks"));
        private static IWebElement copyrightbottomBlock => driver.FindElement(By.CssSelector(".copyrightbottom"));

        #endregion


        public void PlaceHolderMethodName()
        {
            // Your code here
        }

        public bool IsHeaderstripBlockLoaded()
        {
            return headerstripBlock.Displayed;
        }

        public bool IsHeaderdetailBlockLoaded()
        {
            return headerdetails.Displayed;
        }

        public bool IsFeaturedBlockLoaded()
        {
            return featuredBlock.Displayed;
        }
        
        public bool IsCategorymenuBlockLoaded()
        {
            return categorymenuBlock.Displayed;
        }
        
        public bool IsSliderBlockLoaded()
        {
            return sliderBlock.Displayed;
        }
        
        public bool IsPromo_sectionBlockLoaded()
        {
            return promo_sectionBlock.Displayed;
        }
        
        public bool IsLatestBlockLoaded()
        {
            return latestBlock.Displayed;
        }
        
        public bool IsBestsellerBlockLoaded()
        {
            return bestsellerBlock.Displayed;
        }
        
        public bool IsSpecialBlockLoaded()
        {
            return specialBlock.Displayed;
        }
        
        public bool IsBannerBlockLoaded()
        {
            return bannerBlock.Displayed;
        }
        
        public bool IsPopularbrandsBlockLoaded()
        {
            return popularbrandsBlock.Displayed;
        }
        
        public bool IsFootersocialBlockLoaded()
        {
            return footersocialBlock.Displayed;
        }
        
        public bool IsFooterlinksBlockLoaded()
        {
            return footerlinksBlock.Displayed;
        }
        
        public bool IsCopyrightbottomBlockLoaded()
        {
            return copyrightbottomBlock.Displayed;
        }
    }
}