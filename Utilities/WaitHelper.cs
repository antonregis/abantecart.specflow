using OpenQA.Selenium;
using OpenQA.Selenium.DevTools.V108.Debugger;
using OpenQA.Selenium.Interactions;
using OpenQA.Selenium.Support.UI;
using SeleniumExtras.WaitHelpers;
using System.Text;


namespace TestSuite.Utilities
{
    public class WaitHelper : Driver
    {

        public static IWebElement WaitForElementToBeClickable(IWebElement element, int timeOutinSeconds = 20)
        {
            WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(timeOutinSeconds));
            return wait.Until(ExpectedConditions.ElementToBeClickable(element));
        }

        public static IWebElement WaitForElement(By by, int timeOutinSeconds = 20)
        {
            WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(timeOutinSeconds));
            return (wait.Until(ExpectedConditions.ElementIsVisible(by)));
        }

        public static void WaitForElementByXpath(string xpath, int timeOutinSeconds = 20)
        {
            WaitForElement(By.XPath(xpath), timeOutinSeconds);
        }


        // All other methods below this comment are experimental and are saved just in case needed

        public static void PauseInSeconds(int seconds)
        {
            Thread.Sleep(seconds * 1000);
        }

        public static void WaitForPageToLoad()
        {
            String title = driver.Title;

            if (title == "My Account")
            {
                WaitForElementByXpath("//body/div[1]/div[2]/div[1]/div[1]/div[1]/div[1]/div[4]");
            }
            else if (title == "Placeholder") 
            {
                WaitForElementByXpath("//*[@name='title']");                
            }
            else
            {
                // do nothing
            }

            // Adding time for unexpected time delay
            Thread.Sleep(1000);
        }
    }
}