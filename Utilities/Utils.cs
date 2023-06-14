using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;
using OpenQA.Selenium.Support.UI;
using SeleniumExtras.WaitHelpers;
using System.Text;



namespace TestSuite.Utilities
{
    public class Utils : Driver
    {
        public static void NavigateToBaseUrl()
        {
            driver.Navigate().GoToUrl(EnvironmentHelper.baseUrl);
        }

        public static void NavigateToUrl(string path)
        {
            driver.Navigate().GoToUrl(EnvironmentHelper.baseUrl + path);
        }


        public static void Placeholder()
        {
            // Do nothing at the moment
        }
    }
}