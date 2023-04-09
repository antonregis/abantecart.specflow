using TestSuite.Utilities;
using OpenQA.Selenium;
using static TestSuite.Utilities.WaitHelper;


namespace TestSuite.Pages
{
    public class PLP : Driver
    {

        public PLP() 
        {
            Sortby = new Sortby();
            GridWrapper = new GridWrapper();
        }

        public Sortby Sortby { get; internal set; }
        public GridWrapper GridWrapper { get; internal set; }


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