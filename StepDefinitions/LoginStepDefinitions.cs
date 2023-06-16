using System;
using TechTalk.SpecFlow;
using TestSuite.Utilities;
using TestSuite.Pages;
using NUnit.Framework;
using static TestSuite.Utilities.WaitHelper;


namespace TestSuite.StepDefinitions
{
    [Binding]
    public class LoginStepDefinitions
    {
        HomePage homePage = new HomePage();
        AccountLoginPage accountLoginPage = new AccountLoginPage();
        AccountLogoutPage accountLogoutPage = new AccountLogoutPage();
        MyAccountPage myAccountPage = new MyAccountPage();

        
        [Given(@"I am on the home page")]
        public void GivenIAmOnTheHomePage()
        {
            Utils.NavigateToBaseUrl();            
        }

        [When(@"I click Login or register")]
        public void WhenIClickLoginOrRegister()
        {
            homePage.HeaderBlock.ClickLoginOrRegisterLink();
        }

        [Then(@"Account Login page appears")]
        public void ThenAccountLoginPageAppears()
        {
            Assert.That(accountLoginPage.SubHeaderBlock.GetHeaderName(), Is.EqualTo("ACCOUNT LOGIN"));
        }

        [When(@"I enter my Login Name and Password")]
        public void WhenIEnterMyLoginNameAndPassword()
        {
            accountLoginPage.EnterUserCredentials();
        }

        [When(@"I click Login")]
        public void WhenIClickLogin()
        {
            accountLoginPage.ClickLogin();
        }

        [Then(@"My Account page appears with a Welcome back message")]
        public void ThenMyAccountPageAppearsWithAWelcomeBackMessage()
        {
            Assert.That(myAccountPage.SubHeaderBlock.GetHeaderName(), Is.EqualTo("MY ACCOUNT"));
            Assert.That(myAccountPage.HeaderBlock.GetTopCustomerMenu().Contains("Welcome back"));
        }

        [When(@"I click Logoff")]
        public void WhenIClickLogoff()
        {
            myAccountPage.SideNavigationBlock.ClickLogoffLink();
        }

        [Then(@"Account Logout page appears")]
        public void ThenAccountLogoutPageAppears()
        {
            Assert.That(accountLogoutPage.SubHeaderBlock.GetHeaderName(), Is.EqualTo("ACCOUNT LOGOUT"));
        }
    }
}
