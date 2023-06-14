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

        HomePage homePage = new HomePage();
        AccountLoginPage accountLoginPage = new AccountLoginPage(); 
        AccountLogoutPage accountLogoutPage = new AccountLogoutPage();
        MyAccountPage myAccountPage = new MyAccountPage();

        
        [Given(@"I am in the home page")]
        public void GivenIAmInTheHomePage()
        {
            Utils.NavigateToBaseUrl();
        }

        [When(@"I click Login")]
        public void WhenIClickLogin()
        {
            homePage.HeaderBlock.ClickLoginOrRegisterLink();
        }

        [Then(@"Account login page appears")]
        public void ThenAccountLoginPageAppears()
        {
            Assert.That(driver.Title, Is.EqualTo("Account Login"));
        }

        [When(@"I enter my user credentials anc click Login")]
        public void WhenIEnterMyUserCredentialsAncClickLogin()
        {
            accountLoginPage.EnterUserCredentials();
        }

        [Then(@"My Account Dashboard appears with a welcome message")]
        public void ThenMyAccountDashboardAppearsWithAWelcomeMessage()
        {
            Assert.That(myAccountPage.SideNavigationBlock.GetAccountDashboard(), Is.EqualTo("Account Dashboard"));
            Assert.That(myAccountPage.HeaderBlock.GetTopCustomerMenu().Contains("Welcome back"));
        }

        [When(@"I click Logoff")]
        public void WhenIClickLogoff()
        {
            myAccountPage.HeaderBlock.ClickLogoff();
        }

        [Then(@"Account logout message appears")]
        public void ThenAccountLogoutMessageAppears()
        {
            Assert.That(accountLogoutPage.GetAccountLogoutHeader(), Is.EqualTo("ACCOUNT LOGOUT"));
            Assert.That(accountLogoutPage.GetAccountLogoutMessage().Contains("You have been logged off your account. It is now safe to leave the computer."));
            Assert.That(accountLogoutPage.GetAccountLogoutMessage().Contains("Your shopping cart has been saved, the items inside it will be restored whenever you log back into your account."));
        }

    }
}
