using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;
using OpenQA.Selenium.Support.UI;
using SeleniumExtras.WaitHelpers;
using System.Text;


namespace TestSuite.Utilities
{
    public class WaitHelper : Driver
    {

        public static IWebElement WaitForElementToBeClickable(IWebElement element, int timeOutinSeconds = 10)
        {
            WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(timeOutinSeconds));
            return wait.Until(ExpectedConditions.ElementToBeClickable(element));
        }

        public static IWebElement WaitForElement(By by, int timeOutinSeconds = 10)
        {
            WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(timeOutinSeconds));
            return (wait.Until(ExpectedConditions.ElementIsVisible(by)));
        }

        public static void WaitForElementByXpath(string xpath, int timeOutinSeconds = 10)
        {
            WaitForElement(By.XPath(xpath), timeOutinSeconds);
        }


        // All other methods below this comment are experimental and are saved just in case needed

        public static void PauseInSeconds(int seconds)
        {
            Thread.Sleep(seconds * 1000);
        }

    }
}