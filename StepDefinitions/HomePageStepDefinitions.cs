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
    }
}
