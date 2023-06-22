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


        [When(@"I enter ""([^""]*)"" keyword on the header search box")]
        public void WhenIEnterKeywordOnTheHeaderSearchBox(string p0)
        {
            homePage.HeaderBlock.EnterSearchBox(p0);
        }
                
        [When(@"I click the magnifying lens button")]
        public void WhenIClickTheMagnifyingLensButton()
        {
            homePage.HeaderBlock.ClickMagnifyingLensBtn();
        }

        [When(@"I enter ""([^""]*)"" keyword on the search criteria box")]
        public void WhenIEnterKeywordOnTheSearchCriteriaBox(string p0)
        {
            searchPage.EnterSearchCriteriaBox(p0);
        }

        [When(@"I click Search button")]
        public void WhenIClickSearchButton()
        {
            searchPage.ClickSearchBtn();
        }

        [When(@"I enter an invalid '([^']*)' on the header search box")]
        public void WhenIEnterAnInvalidOnTheHeaderSearchBox(string p0)
        {
            homePage.HeaderBlock.EnterSearchBox(p0);
        }

        [When(@"I enter an invalid '([^']*)' on the search criteria box")]
        public void WhenIEnterAnInvalidOnTheSearchCriteriaBox(string p0)
        {
            searchPage.EnterSearchCriteriaBox(p0);
        }

        [Then(@"I see search results")]
        public void ThenISeeSearchResults()
        {            
            Assert.That(searchPage.GetSearchResults(), Does.Not.Contain("There is no product that matches the search criteria."));
        }

        [Then(@"I see search results returns with no matches message")]
        public void ThenISeeSearchResultsReturnsWithNoMatchesMessage()
        {
           Console.WriteLine("Captured text: " + searchPage.GetSearchResults());
            Assert.That(searchPage.GetSearchResults().Contains("There is no product that matches the search criteria."));
        }
    }
}
