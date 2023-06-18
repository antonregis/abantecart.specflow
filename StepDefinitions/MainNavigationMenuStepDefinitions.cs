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
  

        // HOME Menu

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

        [Then(@"HOME dropdown appears and All links are working")]
        public void ThenHOMEDropdownAppearsAndAllLinksAreWorking()
        {
            Assert.IsTrue(homePage.HeaderBlock.AreHomeMenuDropdownLinksWorking());
        }


        // APPAREL & ACCESSORIES Menu

        [Then(@"APPAREL & ACCESSORIES Menu link is working")]
        public void ThenAPPARELACCESSORIESMenuLinkIsWorking()
        {
            Assert.IsTrue(homePage.HeaderBlock.IsApparelAccessoriesMenuBtnLinkWorking());
        }

        [When(@"I mouseover APPAREL & ACCESSORIES Menu button")]
        public void WhenIMouseoverAPPARELACCESSORIESMenuButton()
        {
            homePage.HeaderBlock.MouseoverApparelAccessoriesMenuBtn();
        }

        [Then(@"APPAREL & ACCESSORIES dropdown appears and All links are working")]
        public void ThenAPPARELACCESSORIESDropdownAppearsAndAllLinksAreWorking()
        {
            Assert.IsTrue(homePage.HeaderBlock.AreApparelAccessoriesMenuDropdownLinksWorking());
        }


        // MAKEUP Menu

        [Then(@"MAKEUP Menu link is working")]
        public void ThenMAKEUPMenuLinkIsWorking()
        {
            Assert.IsTrue(homePage.HeaderBlock.IsMakeupMenuBtnLinkWorking());
        }

        [When(@"I mouseover MAKEUP Menu button")]
        public void WhenIMouseoverMAKEUPMenuButton()
        {
            homePage.HeaderBlock.MouseoverMakeupMenuBtn();
        }

        [Then(@"MAKEUP dropdown appears and All links are working")]
        public void ThenMAKEUPDropdownAppearsAndAllLinksAreWorking()
        {
            Assert.IsTrue(homePage.HeaderBlock.AreMakeupMenuDropdownLinksWorking());
        }


        // SKINCARE Menu

        [Then(@"SKINCARE Menu link is working")]
        public void ThenSKINCAREMenuLinkIsWorking()
        {
            Assert.IsTrue(homePage.HeaderBlock.IsSkinCareMenuBtnLinkWorking());
        }

        [When(@"I mouseover SKINCARE Menu button")]
        public void WhenIMouseoverSKINCAREMenuButton()
        {
            homePage.HeaderBlock.MouseoverSkincareMenuBtn();
        }

        [Then(@"SKINCARE dropdown appears and All links are working")]
        public void ThenSKINCAREDropdownAppearsAndAllLinksAreWorking()
        {
            Assert.IsTrue(homePage.HeaderBlock.AreSkincareMenuDropdownLinksWorking());
        }
    }
}
