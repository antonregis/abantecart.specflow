using TestSuite.Utilities;
using OpenQA.Selenium;
using static TestSuite.Utilities.WaitHelper;


namespace TestSuite.Pages
{
    public class TemplatePagePOM : Driver
    {

        public TemplatePagePOM()
        {
            HeaderBlock = new HeaderBlock();
            SubHeaderBlock = new SubHeaderBlock();
            FooterBlock = new FooterBlock();
        }

        public HeaderBlock HeaderBlock { get; internal set; }
        public SubHeaderBlock SubHeaderBlock { get; internal set; }
        public FooterBlock FooterBlock { get; internal set; }


        #region  Initialize Web Elements

        IWebElement placeholder => driver.FindElement(By.XPath(""));

        #endregion


        public void PlaceholderMethodName()
        {
            // Your code here
        }


        public string GetPlaceholder()
        {
            return placeholder.Text;
        }
    }
}