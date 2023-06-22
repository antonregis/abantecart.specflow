using NUnit.Framework;
using System;
using TechTalk.SpecFlow;
using TestSuite.Pages;

namespace TestSuite.StepDefinitions
{
    [Binding]
    public class SearchStepDefinitions
    {
        HomePage homePage = new HomePage();
        SearchPage searchPage = new SearchPage();


        [When(@"I enter ""([^""]*)"" keyword on header search box")]
        public void WhenIEnterKeywordOnHeaderSearchBox(string p0)
        {
            homePage.HeaderBlock.EnterSearchBox(p0);
        }

        [When(@"I click the magnifying lens button")]
        public void WhenIClickTheMagnifyingLensButton()
        {
            homePage.HeaderBlock.ClickMagnifyingLensBtn();
        }

        [When(@"Enter ""([^""]*)"" keyword on the search criteria box")]
        public void WhenEnterKeywordOnTheSearchCriteriaBox(string p0)
        {
            searchPage.EnterSearchCriteriaBox(p0);
        }

        [When(@"I click Search button")]
        public void WhenIClickSearchButton()
        {
            searchPage.ClickSearchBtn();
        }

        [Then(@"I see search results")]
        public void ThenISeeSearchResults()
        {            
            Assert.That(searchPage.GetSearchResults(), Does.Not.Contain("There is no product that matches the search criteria."));
        }
    }
}
