using TestSuite.Utilities;
using OpenQA.Selenium;
using static TestSuite.Utilities.WaitHelper;
using System;


namespace TestSuite.Pages
{
    public class PDP : Driver
    {

        #region  Initialize Web Elements

        private static IWebElement Placeholder => driver.FindElement(By.XPath(""));

        #endregion


        public void PlaceHolderMethodName()
        {
            // Your code here
        }


        public string GetPlaceholder()
        {
            return Placeholder.Text;
        }
    }
}