using NUnit.Framework;
using System;
using TechTalk.SpecFlow;
using TestSuite.Pages;


namespace TestSuite.StepDefinitions
{
    [Binding]
    public class MyAccountStepDefinitions
    {
        MyAccountPage myAccountPage = new MyAccountPage();

        
        [When(@"I click Account menu Login link")]
        public void WhenIClickAccountMenuLoginLink()
        {
            myAccountPage.HeaderBlock.ClickAccountMenuLoginLink();
        }

        [When(@"I click Edit account details")]
        public void WhenIClickEditAccountDetails()
        {
            myAccountPage.SideNavigationBlock.ClickEditAccountDetailsLink();
        }

        [Then(@"My Account Information page appears")]
        public void ThenMyAccountInformationPageAppears()
        {
            Assert.That(myAccountPage.SubHeaderBlock.GetHeaderName(), Is.EqualTo("MY ACCOUNT INFORMATION"));
        }

        [When(@"I change my First Name, Last Name, and Telephone number")]
        public void WhenIChangeMyFirstNameLastNameAndTelephoneNumber()
        {
            myAccountPage.MyAccountInfoBlock.ChangeYourPersonalDetails();
        }

        [When(@"I click Continue to save Your Personal Details")]
        public void WhenIClickContinueToSaveYourPersonalDetails()
        {
            myAccountPage.MyAccountInfoBlock.ClickContinue();            
        }

        [Then(@"""([^""]*)"" alert notification appears")]
        public void ThenAlertNotificationAppears(string p0)
        {            
            Assert.That(myAccountPage.SubHeaderBlock.GetAlertNotificationBox(), Is.EqualTo(p0));
        }

        [Then(@"Name beside My Account header updates with new name")]
        public void ThenNameBesideMyAccountHeaderUpdatesWithNewName()
        {
            Assert.That(myAccountPage.SubHeaderBlock.GetSubTextLabel(), Is.EqualTo(myAccountPage.MyAccountInfoBlock.savedFirstNameValue));
        }

        [Then(@"Welcome back on Header updates with new name")]
        public void ThenWelcomeBackOnHeaderUpdatesWithNewName()
        {
            Assert.That(myAccountPage.HeaderBlock.GetTopCustomerMenu().Contains(myAccountPage.MyAccountInfoBlock.savedFirstNameValue));
        }

        [Then(@"My Acount Information page appears with correct field values")]
        public void ThenMyAcountInformationPageAppearsWithCorrectFieldValues()
        {
            Assert.That(myAccountPage.MyAccountInfoBlock.GetFirstNameField(), Is.EqualTo(myAccountPage.MyAccountInfoBlock.savedFirstNameValue));
            Assert.That(myAccountPage.MyAccountInfoBlock.GetLastNameField(), Is.EqualTo(myAccountPage.MyAccountInfoBlock.savedLastNameValue));
            Assert.That(myAccountPage.MyAccountInfoBlock.GetEmailField(), Is.EqualTo(myAccountPage.MyAccountInfoBlock.savedEmailValue));
            Assert.That(myAccountPage.MyAccountInfoBlock.GetTelephoneField(), Is.EqualTo(myAccountPage.MyAccountInfoBlock.savedTelephoneValue));
            Assert.That(myAccountPage.MyAccountInfoBlock.GetFaxField(), Is.EqualTo(myAccountPage.MyAccountInfoBlock.savedFaxValue));
        }
    }
}
