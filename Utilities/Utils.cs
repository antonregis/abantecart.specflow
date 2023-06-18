using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;
using OpenQA.Selenium.Support.UI;
using SeleniumExtras.WaitHelpers;
using System.Net;
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

        public static bool IsUrlWorking(IWebElement element, string attribute)
        {
            bool status;
            HttpClient httpClient = new HttpClient();

            string url = element.GetAttribute(attribute);

            if (url == null)
            {
                throw new ArgumentNullException(attribute + " attribute is not found in the element.");
            }

            HttpResponseMessage response = httpClient.GetAsync(url).Result;
            HttpStatusCode statusCode = response.StatusCode;

            if (statusCode == HttpStatusCode.OK)
            {
                status = true;
            }
            else
            {
                status = false;
            }

            Console.WriteLine(statusCode + " - " + attribute + ": " + url); // Show in logs/output for any debug purposes

            return status;
        }

        public static bool AreAllLinksWorking(IWebElement element, int linkCount)
        {
            HttpClient httpClient = new HttpClient();
            string result = "";
            bool status;

            // Locate all the <a> elements within the parent element
            IList<IWebElement> linkElements = element.FindElements(By.XPath(".//a"));

            if (linkElements.Count == 0)
            {
                // No <a> tags found
                throw new NoSuchElementException("No <a> tags found using XPath: .//a");
            }
            else if (linkElements.Count != linkCount) 
            {
                throw new NoSuchElementException("Expected number of links is " + linkCount + ", but actual is " + linkElements.Count +".");
            }

            // Iterate through each <a> element and gather each result
            foreach (IWebElement linkElement in linkElements)
            {
                string hrefValue = linkElement.GetAttribute("href");
                HttpResponseMessage response = httpClient.GetAsync(hrefValue).Result;
                HttpStatusCode statusCode = response.StatusCode;
                Console.WriteLine(statusCode + " - " + hrefValue); // Show in logs/output for any debug purposes
                result = result + statusCode + " ";
            }

            Console.WriteLine("Links found: " + linkElements.Count);

            // statusCode is either OK / NotFound.
            // If result "does not" contains NotFound, this means all results are OK.
            if (!result.Contains("NotFound"))
            {
                status = true;
            }
            else
            {
                status = false;
            }

            return status;
        }
    }
}