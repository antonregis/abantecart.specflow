using TestSuite.Utilities;
using OpenQA.Selenium;
using static TestSuite.Utilities.WaitHelper;


namespace TestSuite.Pages
{
    public class Home : Driver
    {

        public Home() 
        {
            Header = new Header();
            Footer = new Footer();
        }

        public Header Header { get; internal set; }
        public Footer Footer { get; internal set; }


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