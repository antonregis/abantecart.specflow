using TestSuite.Utilities;
using OpenQA.Selenium;
using static TestSuite.Utilities.WaitHelper;


namespace TestSuite.Pages
{
    public class MyAccountInfoBlock : Driver
    {
        public string savedFirstNameValue;
        public string savedLastNameValue;
        public string savedEmailValue;
        public string savedTelephoneValue;
        public string savedFaxValue;


        #region  Initialize Web Elements

        IWebElement firstNameField => driver.FindElement(By.CssSelector("#AccountFrm_firstname"));
        IWebElement lastNameField => driver.FindElement(By.CssSelector("#AccountFrm_lastname"));
        IWebElement emailField => driver.FindElement(By.CssSelector("#AccountFrm_email"));
        IWebElement telephoneField => driver.FindElement(By.CssSelector("#AccountFrm_telephone"));
        IWebElement faxField => driver.FindElement(By.CssSelector("#AccountFrm_fax"));
        IWebElement continueBtn => driver.FindElement(By.CssSelector("button[title='Continue']"));

        #endregion


        internal void ChangeYourPersonalDetails()
        {
            // Pickup Personal Details randomly from any of the exisiting 5 samples from the excel test data
            ExcelHelper.PopulateInCollection(EnvironmentHelper.excelTestData, "PersonalDetails"); // Select file and sheetname.
            Random random = new Random();
            int i;            
            string firstName = "";

            // This routine ensures the data pulled is not the same as the one presently in the Personal Details form
            do
            {                               
                i = random.Next(2, 7); // Generates a random number between 2 and 6 (for the excel rows)                                           
                firstName = ExcelHelper.ReadData(i, "firstName"); 

            } while (firstNameField.GetAttribute("value") == firstName);

            string lastName = ExcelHelper.ReadData(i, "lastName");
            string email = ExcelHelper.ReadData(i, "email");
            string telephoneNumber = ExcelHelper.ReadData(i, "telephoneNumber");
            string faxNumber = ExcelHelper.ReadData(i, "faxNumber");

            // Saving values for later assertions.
            savedFirstNameValue = firstName;
            savedLastNameValue = lastName;
            savedEmailValue = email;
            savedTelephoneValue = telephoneNumber;
            savedFaxValue = faxNumber;

            // Entering data to the fields
            firstNameField.Clear();
            firstNameField.SendKeys(firstName);
            lastNameField.Clear();
            lastNameField.SendKeys(lastName);
            emailField.Clear();
            emailField.SendKeys(email);
            telephoneField.Clear();
            telephoneField.SendKeys(telephoneNumber);
            faxField.Clear();
            faxField.SendKeys(faxNumber);
        }

        internal void ClickContinue() 
        { 
            continueBtn.Click();
        }

        internal string GetFirstNameField()
        {
            return firstNameField.GetAttribute("value");
        }

        internal string GetLastNameField()
        {
            return lastNameField.GetAttribute("value");
        }

        internal string GetEmailField()
        {
            return emailField.GetAttribute("value");
        }

        internal string GetTelephoneField()
        {
            return telephoneField.GetAttribute("value");
        }

        internal string GetFaxField()
        {
            return faxField.GetAttribute("value");
        }
    }
}