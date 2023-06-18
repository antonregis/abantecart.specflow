using NUnit.Framework;
using System;
using TechTalk.SpecFlow;
using TestSuite.Pages;

namespace TestSuite.StepDefinitions
{
    [Binding]
    public class MainNavigationMenuStepDefinitions
    {
        HomePage homePage = new HomePage();        
  

        [Then(@"HOME Menu link is working")]
        public void ThenHOMEMenuLinkIsWorking()
        {
            Assert.IsTrue(homePage.HeaderBlock.IsHomeMenuBtnLinkWorking());
        }

        [When(@"I mouseover HOME Menu button")]
        public void WhenIMouseoverHOMEMenuButton()
        {
            homePage.HeaderBlock.MouseoverHomeMenuBtn();
        }

        [Then(@"All links in the HOME Menu dropdown are working")]
        public void ThenAllLinksInTheHOMEMenuDropdownAreWorking()
        {
            Assert.IsTrue(homePage.HeaderBlock.AreHomeMenuDropdownLinksWorking());
        }
    }
}
