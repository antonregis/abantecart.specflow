using NUnit.Framework;
using System;
using TechTalk.SpecFlow;
using TestSuite.Pages;
using TestSuite.Utilities;

namespace TestSuite.StepDefinitions
{
    [Binding]
    public class AccountLoginStepDefinitions : Driver
    {

        Home HomePage = new Home();
        AccountLogin AccountLoginPage = new AccountLogin(); 
        MyAccount MyAccountPage = new MyAccount();

        
        [Given(@"I am in the home page")]
        public void GivenIAmInTheHomePage()
        {
            NavigateToBaseUrl();
        }

        [When(@"I click Login or Register link")]
        public void WhenIClickLoginOrRegisterLink()
        {
            HomePage.Header.ClickLoginOrRegisterLink();
        }

        [Then(@"My Account page appears")]
        public void ThenMyAccountPageAppears()
        {
            Assert.That(driver.Title, Is.EqualTo("Account Login"));
        }

        [When(@"I enter my user credentials")]
        public void WhenIEnterMyUserCredentials()
        {
            AccountLoginPage.EnterUserCredentials();
        }

        [Then(@"My Account Dashboard appears with a welcome message")]
        public void ThenMyAccountDashboardAppearsWithAWelcomeMessage()
        {
            Assert.That(driver.Title, Is.EqualTo("My Account"));
            Assert.That(MyAccountPage.GetAccountDashboard(), Is.EqualTo("Account Dashboard"));
            Assert.That(MyAccountPage.Header.GetTopCustomerMenu(), Is.EqualTo("Welcome back Johnn"));
        }
    }
}
