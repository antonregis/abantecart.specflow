using TestSuite.Utilities;
using OpenQA.Selenium;
using static TestSuite.Utilities.WaitHelper;


namespace TestSuite.Pages
{
    public class SearchPage : Driver
    {

        #region  Initialize Web Elements

        private static IWebElement searchCriteriaBox => driver.FindElement(By.CssSelector("#keyword"));
        private static IWebElement searchBtn => driver.FindElement(By.CssSelector("#search_button"));
        private static IWebElement searchResultsFlag => driver.FindElement(By.XPath("//*[@id='maincontainer']/div/div/div/div/div[2]"));

        #endregion


        public void EnterSearchCriteriaBox(string keyword)
        {
            searchCriteriaBox.Clear();
            searchCriteriaBox.SendKeys(keyword);            
        }

        public void ClickSearchBtn() 
        {
            searchBtn.Click();
        }

        public string GetSearchResults()
        {
            return searchResultsFlag.Text;
        }
    }
}