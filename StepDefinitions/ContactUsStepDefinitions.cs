using NUnit.Framework;
using System;
using TechTalk.SpecFlow;
using TestSuite.Pages;

namespace TestSuite.StepDefinitions
{
    [Binding]
    public class ContactUsStepDefinitions
    {
        HomePage homePage = new HomePage();
        ContactUsPage contactUsPage = new ContactUsPage();

        
        [When(@"I click Contact Us on the footer block")]
        public void WhenIClickContactUsOnTheFooterBlock()
        {
            homePage.FooterBlock.ClickContactUsLink();
        }

        [When(@"I enter '([^']*)' in the First name field")]
        public void WhenIEnterInTheFirstNameField(string p0)
        {
            contactUsPage.EnterFirstNameField(p0);
        }

        [When(@"I enter '([^']*)' in the Email field")]
        public void WhenIEnterInTheEmailField(string p0)
        {
            contactUsPage.EnterEmailField(p0);
        }

        [When(@"I enter '([^']*)' in the Enquiry Text area")]
        public void WhenIEnterInTheEnquiryTextArea(string p0)
        {
            contactUsPage.EnterEnquiryTextarea(p0);
        }

        [When(@"I Click Submit")]
        public void WhenIClickSubmit()
        {
            contactUsPage.ClickSubmitBtn();
        }

        [Then(@"I get a success message ""([^""]*)""")]
        public void ThenIGetASuccessMessage(string p0)
        {
            Assert.That(contactUsPage.GetSuccessfullySentMsg(), Is.EqualTo(p0));  
        }


        [When(@"Leave all Contact Us feilds blank")]
        public void WhenLeaveAllContactUsFeildsBlank()
        {
            contactUsPage.EnterFirstNameField("");
            contactUsPage.EnterEmailField("");
            contactUsPage.EnterEnquiryTextarea("");
        }

        [Then(@"First name field returns with error message ""([^""]*)""")]
        public void ThenFirstNameFieldReturnsWithErrorMessage(string p0)
        {
            Assert.That(contactUsPage.GetFirstNameErrorMsg(), Is.EqualTo(p0));
        }

        [Then(@"Email field returns with error message ""([^""]*)""")]
        public void ThenEmailFieldReturnsWithErrorMessage(string p0)
        {
            Assert.That(contactUsPage.GetEmailErrorMsg(), Is.EqualTo(p0));
        }

        [Then(@"Enquiry text area returns with error message ""([^""]*)""")]
        public void ThenEnquiryTextAreaReturnsWithErrorMessage(string p0)
        {
            Assert.That(contactUsPage.GetEqnuiryErrorMsg(), Is.EqualTo(p0));  
        }
    }
}
