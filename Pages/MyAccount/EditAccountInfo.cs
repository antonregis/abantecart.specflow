using TestSuite.Utilities;
using OpenQA.Selenium;
using static TestSuite.Utilities.WaitHelper;


namespace TestSuite.Pages
{
    public class EditAccountInfo : Driver
    {
        
        #region  Initialize Web Elements
        
        private static IWebElement Heading => driver.FindElement(By.CssSelector(".maintext"));

        #endregion


        internal void PlaceHolderMethodName()
        {
            // Your code here
        }


        internal string GetHeading()
        {
            return Heading.Text.Trim();
        }
    }
}