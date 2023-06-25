using TestSuite.Utilities;
using OpenQA.Selenium;
using static TestSuite.Utilities.WaitHelper;


namespace TestSuite.Pages
{
    public class ContactUsPage : Driver
    {

        #region  Initialize Web Elements

        private static IWebElement firstNameField => driver.FindElement(By.CssSelector("#ContactUsFrm_first_name"));
        private static IWebElement emailField => driver.FindElement(By.CssSelector("#ContactUsFrm_email"));
        private static IWebElement eqnuiryTextarea => driver.FindElement(By.CssSelector("#ContactUsFrm_enquiry"));
        private static IWebElement firstNameErrorMsg => driver.FindElement(By.CssSelector("div[id='field_11'] div[class='element_error has-error']"));
        private static IWebElement emailErrorMsg => driver.FindElement(By.CssSelector("div[id='field_12'] div[class='element_error has-error']"));
        private static IWebElement eqnuiryErrorMsg => driver.FindElement(By.CssSelector("div[id='field_13'] div[class='element_error has-error']"));
        private static IWebElement successfullySentMsg => driver.FindElement(By.XPath("//*[@id='maincontainer']/div/div/div/div/section/p[2]"));        
        private static IWebElement submitBtn => driver.FindElement(By.CssSelector("button[title='Submit']"));

        #endregion


        public void ClickSubmitBtn()
        {
            submitBtn.Click();
        }

        public void EnterFirstNameField(string firstName) 
        { 
            firstNameField.SendKeys(firstName);        
        }

        public void EnterEmailField(string email) 
        { 
            emailField.SendKeys(email);
        }

        public void EnterEnquiryTextarea(string enquiry) 
        {
            eqnuiryTextarea.SendKeys(enquiry);
        }

        public string GetFirstNameErrorMsg()
        {
            return firstNameErrorMsg.Text;
        }

        public string GetEmailErrorMsg()
        {
            return emailErrorMsg.Text;
        }

        public string GetEqnuiryErrorMsg()
        {
            return eqnuiryErrorMsg.Text;
        }

        public string GetSuccessfullySentMsg()
        {
            return successfullySentMsg.Text;
        }
    }
}