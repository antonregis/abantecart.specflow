using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;
using OpenQA.Selenium.Support.UI;
using SeleniumExtras.WaitHelpers;
using System.Net;
using System.Text;
using TestSuite.Utilities;

namespace TestSuite.Utilities
{
    public static class WebElementHelper
    {
        public static void ScrollIntoView(this IWebElement element)
        {
            // This is used for elements that are beneath the somehow focused floating 
            // navigation bar/panel at the bottom of the page.
            // Scroll into view the desired element, and it shall be seen by Selenium.
            ((IJavaScriptExecutor)Driver.driver).ExecuteScript("arguments[0].scrollIntoView(true);", element);
        }

        public static void MouseOverHelper(this IWebElement element)
        {
            // This is used to mouseover a MegaMenu
            Actions a = new Actions(Driver.driver);
            a.MoveToElement(element).Perform();
            Thread.Sleep(1000);
        }

        public static void MouseOverHelperByXPath(string xpath)
        {
            // This is used to mouseover a MegaMenu
            Actions a = new Actions(Driver.driver);
            a.MoveToElement(Driver.driver.FindElement(By.XPath(xpath))).Perform();
            Thread.Sleep(1000);
        }
    }
}