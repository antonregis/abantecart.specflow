using TestSuite.Utilities;
using OpenQA.Selenium;
using static TestSuite.Utilities.WaitHelper;
using Microsoft.VisualStudio.TestPlatform.Utilities;
using System.Net;
using AngleSharp.Dom;
using MongoDB.Bson.IO;

namespace TestSuite.Pages
{
    public class HeaderBlock : Driver
    {

        #region  Initialize Web Elements

        private static IWebElement topCustomerMenu => driver.FindElement(By.XPath("//ul[@id='customer_menu_top']//li//a"));
        private static IWebElement logoffLink => driver.FindElement(By.XPath("//div[@id='customernav']//li[10]//a[1]"));
        private static IWebElement accountMenu => driver.FindElement(By.XPath("//*[@id='main_menu_top']/li[2]/a/span"));        
        private static IWebElement accountMenuLoginLink => driver.FindElement(By.CssSelector("li[class='dropdown open'] a[class='sub menu_login']"));
        private static IWebElement checkYourOrderLink => driver.FindElement(By.CssSelector("li[class='dropdown'] span[class='menu_text']"));        
        
        private static IWebElement homeMenuBtn => driver.FindElement(By.XPath("//*[@id='categorymenu']/nav/ul/li[1]/a"));
        private static IWebElement apparelAccessoriesMenuBtn => driver.FindElement(By.XPath("//*[@id='categorymenu']/nav/ul/li[2]/a"));
        private static IWebElement makeupMenuBtn => driver.FindElement(By.XPath("//*[@id='categorymenu']/nav/ul/li[3]/a"));
        private static IWebElement skincareMenuBtn => driver.FindElement(By.XPath("//*[@id='categorymenu']/nav/ul/li[4]/a"));
        private static IWebElement fragranceMenuBtn => driver.FindElement(By.XPath("//*[@id='categorymenu']/nav/ul/li[5]/a"));
        private static IWebElement menMenuBtn => driver.FindElement(By.XPath("//*[@id='categorymenu']/nav/ul/li[6]/a"));
        private static IWebElement hairCareMenuBtn => driver.FindElement(By.XPath("//*[@id='categorymenu']/nav/ul/li[7]/a"));
        private static IWebElement booksMenuBtn => driver.FindElement(By.XPath("//*[@id='categorymenu']/nav/ul/li[8]/a"));
        
        private static IWebElement homeMenuDropdown => driver.FindElement(By.XPath("//*[@id='categorymenu']/nav/ul/li[1]/div"));
        private static IWebElement apparelAccessoriesMenuDropdown => driver.FindElement(By.XPath("//*[@id='categorymenu']/nav/ul/li[2]/div"));
        private static IWebElement makeupMenuDropdown => driver.FindElement(By.XPath("//*[@id='categorymenu']/nav/ul/li[3]/div"));
        private static IWebElement skincareMenuDropdown => driver.FindElement(By.XPath("//*[@id='categorymenu']/nav/ul/li[4]/div"));
        private static IWebElement fragranceMenuDropdown => driver.FindElement(By.XPath("//*[@id='categorymenu']/nav/ul/li[5]/div"));
        private static IWebElement menMenuDropdown => driver.FindElement(By.XPath("//*[@id='categorymenu']/nav/ul/li[6]/div"));
        private static IWebElement hairCareMenuDropdown => driver.FindElement(By.XPath("//*[@id='categorymenu']/nav/ul/li[7]/div"));
        private static IWebElement booksMenuDropdown => driver.FindElement(By.XPath("//*[@id='categorymenu']/nav/ul/li[8]/div"));

        #endregion

        #region Hide this region temporarily

        internal void ClickLoginOrRegisterLink()
        {
            topCustomerMenu.Click();
        }

        internal void ClickLogoff()
        {
            WebElementHelper.MouseOverHelper(topCustomerMenu);
            WaitForElementToBeClickable(logoffLink);
            logoffLink.Click();
        }

        internal void ClickAccountMenuLoginLink()
        {           
            WebElementHelper.MouseOverHelper(accountMenu);
            WaitForElementToBeClickable(accountMenuLoginLink);
            accountMenuLoginLink.Click();
        }

        internal void ClickMenCategory() 
        {
            WebElementHelper.MouseOverHelper(menMenuBtn);            
        }        

        internal string GetTopCustomerMenu() 
        {
            return topCustomerMenu.Text;
        }

        internal void MouseoverHomeMenuBtn()
        {
            WebElementHelper.MouseOverHelper(homeMenuBtn);
        }

        internal bool IsHomeMenuBtnLinkWorking() 
        {
            return Utils.IsUrlWorking(homeMenuBtn, "href");
        }

        internal bool AreHomeMenuDropdownLinksWorking() 
        {
            return Utils.AreAllLinksWorking(homeMenuDropdown, 6);
        }
       
        internal void MouseoverApparelAccessoriesMenuBtn()
        {
            WebElementHelper.MouseOverHelper(apparelAccessoriesMenuBtn);
        }

        internal bool IsApparelAccessoriesMenuBtnLinkWorking()
        {
            return Utils.IsUrlWorking(apparelAccessoriesMenuBtn, "href");
        }

        internal bool AreApparelAccessoriesMenuDropdownLinksWorking()
        {
            return Utils.AreAllLinksWorking(apparelAccessoriesMenuDropdown, 2);
        }
        
        internal void MouseoverMakeupMenuBtn()
        {
            WebElementHelper.MouseOverHelper(makeupMenuBtn);
        }

        internal bool IsMakeupMenuBtnLinkWorking()
        {
            return Utils.IsUrlWorking(makeupMenuBtn, "href");
        }

        internal bool AreMakeupMenuDropdownLinksWorking()
        {
            return Utils.AreAllLinksWorking(makeupMenuDropdown, 6);
        }

        internal void MouseoverSkincareMenuBtn()
        {
            WebElementHelper.MouseOverHelper(skincareMenuBtn);
        }

        internal bool IsSkinCareMenuBtnLinkWorking()
        {
            return Utils.IsUrlWorking(skincareMenuBtn, "href");
        }

        internal bool AreSkincareMenuDropdownLinksWorking()
        {
            return Utils.AreAllLinksWorking(skincareMenuDropdown, 5);
        }

        #endregion
    }
}