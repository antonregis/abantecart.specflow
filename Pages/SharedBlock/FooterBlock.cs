using TestSuite.Utilities;
using OpenQA.Selenium;
using static TestSuite.Utilities.WaitHelper;


namespace TestSuite.Pages
{
    public class FooterBlock : Driver
    {
        
        #region  Initialize Web Elements
        
        private static IWebElement placeholder => driver.FindElement(By.XPath(""));

        #endregion


        internal void PlaceHolderMethodName()
        {
            // Your code here
        }


        internal string GetPlaceholdert()
        {
            return placeholder.Text;
        }
    }
}