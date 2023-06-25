using NUnit.Framework;
using System;
using TechTalk.SpecFlow;
using TestSuite.Pages;
using TestSuite.Utilities;


namespace TestSuite.StepDefinitions
{
    [Binding]
    public class ProductListPageStepDefinitions
    {
        ProductListPage productListPage = new ProductListPage();

        
        [When(@"I open a '([^']*)'")]
        public void WhenIOpenA(string p0)
        {
            Utils.NavigateToUrl(p0);
        }

        [Then(@"PLP header appears")]
        public void ThenPLPHeaderAppears()
        {
            Assert.IsTrue(productListPage.SubHeaderBlock.IsHeaderNameLoaded()); 
        }

        [Then(@"PLP top sorting well appears")]
        public void ThenPLPTopSortingWellAppears()
        {
            Assert.IsTrue(productListPage.IsTopSortingWellBlockLoaded());   
        }

        [Then(@"PLP product thumbnails appears")]
        public void ThenPLPProductThumbnailsAppears()
        {
            Assert.IsTrue(productListPage.IsProductThumbnailslockLoaded());
        }

        [Then(@"PLP bottom sorting well appears")]
        public void ThenPLPBottomSortingWellAppears()
        {
            Assert.IsTrue(productListPage.IsBottomSortingWellBlockLoaded());
        }
    }
}
