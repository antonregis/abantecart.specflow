using NUnit.Framework;
using System;
using TechTalk.SpecFlow;
using TestSuite.Pages;

namespace TestSuite.StepDefinitions
{
    [Binding]
    public class HomePageStepDefinitions
    {
        HomePage homePage = new HomePage();


        [Then(@"headerstrip block element is displayed")]
        public void ThenHeaderstripBlockElementIsDisplayed()
        {
            Assert.IsTrue(homePage.IsHeaderstripBlockLoaded());
        }

        [Then(@"headerdetails block element is displayed")]
        public void ThenHeaderdetailsBlockElementIsDisplayed()
        {
            Assert.IsTrue(homePage.IsHeaderdetailBlockLoaded());
        }

        [Then(@"categorymenu block element is displayed")]
        public void ThenCategorymenuBlockElementIsDisplayed()
        {
            Assert.IsTrue(homePage.IsCategorymenuBlockLoaded());
        }

        [Then(@"slider block element is displayed")]
        public void ThenSliderBlockElementIsDisplayed()
        {
            Assert.IsTrue(homePage.IsSliderBlockLoaded());
        }

        [Then(@"promo_section block element is displayed")]
        public void ThenPromo_SectionBlockElementIsDisplayed()
        {
            Assert.IsTrue(homePage.IsPromo_sectionBlockLoaded());
        }

        [Then(@"featured block element is displayed")]
        public void ThenFeaturedBlockElementIsDisplayed()
        {
            Assert.IsTrue(homePage.IsFeaturedBlockLoaded());
        }

        [Then(@"latest block element is displayed")]
        public void ThenLatestBlockElementIsDisplayed()
        {
            Assert.IsTrue(homePage.IsLatestBlockLoaded());
        }

        [Then(@"bestseller block element is displayed")]
        public void ThenBestsellerBlockElementIsDisplayed()
        {
            Assert.IsTrue(homePage.IsBestsellerBlockLoaded());
        }

        [Then(@"special block element is displayed")]
        public void ThenSpecialBlockElementIsDisplayed()
        {
            Assert.IsTrue(homePage.IsSpecialBlockLoaded());
        }

        [Then(@"banner block element is displayed")]
        public void ThenBannerBlockElementIsDisplayed()
        {
            Assert.IsTrue(homePage.IsBannerBlockLoaded());
        }

        [Then(@"popularbrands block element is displayed")]
        public void ThenPopularbrandsBlockElementIsDisplayed()
        {
            Assert.IsTrue(homePage.IsPopularbrandsBlockLoaded());
        }

        [Then(@"footersocial block element is displayed")]
        public void ThenFootersocialBlockElementIsDisplayed()
        {
            Assert.IsTrue(homePage.IsFootersocialBlockLoaded());
        }

        [Then(@"footerlinks block element is displayed")]
        public void ThenFooterlinksBlockElementIsDisplayed()
        {
            Assert.IsTrue(homePage.IsFooterlinksBlockLoaded()); 
        }

        [Then(@"copyrightbottom block element is displayed")]
        public void ThenCopyrightbottomBlockElementIsDisplayed()
        {
            Assert.IsTrue(homePage.IsCopyrightbottomBlockLoaded());
        }


        // Check website logo is displayed correctly

        [Then(@"Logo element is displayed")]
        public void ThenLogoElementIsDisplayed()
        {
            Assert.IsTrue(homePage.IsLogoImageLoaded());
        }

        [Then(@"Logo image file exists in the specified Url")]
        public void ThenLogoImageFileExistsInTheSpecifiedUrl()
        {
            Assert.IsTrue(homePage.IsLogoImageSourceFileFound());
        }
    }
}
