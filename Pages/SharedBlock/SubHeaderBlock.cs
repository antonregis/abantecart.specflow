using TestSuite.Utilities;
using OpenQA.Selenium;
using static TestSuite.Utilities.WaitHelper;


namespace TestSuite.Pages
{
    public class SubHeaderBlock : Driver
    {

        #region  Initialize Web Elements

        private static IWebElement headerName => driver.FindElement(By.CssSelector(".maintext"));
        private static IWebElement subTextLabel => driver.FindElement(By.CssSelector(".subtext"));
        private static IWebElement alertNotificationBox => driver.FindElement(By.XPath("//*[@id='maincontainer']/div/div[1]/div/div[1]"));

        #endregion


        internal string GetHeaderName()
        {
            return headerName.Text.Trim();
        }

        internal string GetAlertNotificationBox()
        {
            return alertNotificationBox.Text.Replace("×\r\n", "");
        }

        internal string GetSubTextLabel()
        {
            return subTextLabel.Text.Trim();
        }
    }
}