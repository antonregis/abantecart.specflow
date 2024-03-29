using NUnit.Framework;
using System;
using TechTalk.SpecFlow;
using TestSuite.Pages;

namespace TestSuite.StepDefinitions
{
    [Binding]
    public class SocialMediaStepDefinitions
    {
        HomePage homePage = new HomePage();

        
        [Then(@"Facebook header link is correct and working")]
        public void ThenFacebookHeaderLinkIsCorrectAndWorking()
        {
            Assert.That(homePage.HeaderBlock.GetfacebookBtnUrl(), Is.EqualTo("https://www.facebook.com/AbanteCart"));
            Assert.IsTrue(homePage.HeaderBlock.IsFacebookBtnWorking());
        }

        [Then(@"Twitter header link is correct and working")]
        public void ThenTwitterHeaderLinkIsCorrectAndWorking()
        {
            Assert.That(homePage.HeaderBlock.GetTwitterBtnUrl(), Is.EqualTo("https://twitter.com/abantecart"));
            Assert.IsTrue(homePage.HeaderBlock.IsTwitterBtnWorking());
        }

        [Then(@"Facebook footer link is correct and working")]
        public void ThenFacebookFooterLinkIsCorrectAndWorking()
        {
            Assert.That(homePage.FooterBlock.GetfacebookBtnUrl(), Is.EqualTo("https://www.facebook.com/AbanteCart"));
            Assert.IsTrue(homePage.FooterBlock.IsFacebookBtnWorking());
        }

        [Then(@"Twitter footer link is correct and working")]
        public void ThenTwitterFooterLinkIsCorrectAndWorking()
        {
            Assert.That(homePage.FooterBlock.GetTwitterBtnUrl(), Is.EqualTo("https://twitter.com/abantecart"));
            Assert.IsTrue(homePage.FooterBlock.IsTwitterBtnWorking());
        }
    }
}
