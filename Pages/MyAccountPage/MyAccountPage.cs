using TestSuite.Utilities;
using OpenQA.Selenium;
using static TestSuite.Utilities.WaitHelper;


namespace TestSuite.Pages
{
    public class MyAccountPage : Driver
    {
        
        public MyAccountPage() 
        {
            HeaderBlock = new HeaderBlock();
            SubHeaderBlock = new SubHeaderBlock();
            SideNavigationBlock = new SideNavigationBlock();
            MyAccountInfoBlock = new MyAccountInfoBlock();
        }
                
        public HeaderBlock HeaderBlock { get; internal set; }
        public SubHeaderBlock SubHeaderBlock { get; internal set; }
        public SideNavigationBlock SideNavigationBlock { get; internal set; }
        public MyAccountInfoBlock MyAccountInfoBlock { get; internal set; }


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