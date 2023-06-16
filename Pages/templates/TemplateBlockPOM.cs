using TestSuite.Utilities;
using OpenQA.Selenium;
using static TestSuite.Utilities.WaitHelper;


namespace TestSuite.Pages
{
    public class TemplateBlockPOM : Driver
    {
        
        #region  Initialize Web Elements
        
        IWebElement placeholder => driver.FindElement(By.XPath(""));

        #endregion


        internal void PlaceholderMethodName()
        {
            // Your code here
        }


        internal string GetPlaceholder()
        {
            return placeholder.Text;
        }
    }
}