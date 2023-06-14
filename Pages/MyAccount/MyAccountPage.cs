using TestSuite.Utilities;
using OpenQA.Selenium;
using static TestSuite.Utilities.WaitHelper;


namespace TestSuite.Pages
{
    public class MyAccountPage : Driver
    {
        
        public MyAccountPage() 
        {
            SideNavigationBlock = new SideNavigationBlock();
            HeaderBlock = new HeaderBlock();
        }

        public SideNavigationBlock SideNavigationBlock { get; internal set; }
        public HeaderBlock HeaderBlock { get; internal set; }


        #region  Initialize Web Elements

        private static IWebElement placeholder => driver.FindElement(By.XPath(""));

        #endregion


        public void PlaceHolderMethodName()
        {
            // Your code here
        }


        public string GetPlaceholder()
        {
            return placeholder.Text;
        }
    }
}