using TestSuite.Utilities;
using OpenQA.Selenium;
using static TestSuite.Utilities.WaitHelper;


namespace TestSuite.Pages
{
    public class Sortby : Driver
    {

        #region  Initialize Web Elements

        private static IWebElement Placeholder => driver.FindElement(By.XPath(""));

        #endregion


        internal void PlaceHolderMethodName()
        {
            // Your code here
        }


        internal string GetPlaceholder()
        {
            return Placeholder.Text;
        }
    }
}