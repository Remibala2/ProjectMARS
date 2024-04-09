using MARS_QA.Utilities;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MARS_QA.Mars_Pages
{
    public class ProfileLanguages:CommonDriver
    {
        private static By DescPenButtonLocator = By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/div/div/div/h3/span/i");
        private static By DescTextBoxLocator = By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/div/div/form/div/div/div[2]/div[1]/textarea");
        private static By DescSaveButtonLocator = By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/div/div/form/div/div/div[2]/button");
        private static By LanguageAddNewButtonLocator = By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/table/thead/tr/th[3]/div");
        private static By LanguageTextBoxLocator = By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/div/div[1]/input");
        private static By LanguageLevelLocator = By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/div/div[2]/select");
        private static By LanguageAddButtonLocator = By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/div/div[3]/input[1]");
        private static By LanguageCancelButtonLocator = By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/div/div[3]/input[2]");
        private static By LastLanguageNameLocator = By.XPath("");
        private static By LastLanguageLevelTextLocator = By.XPath("");
        private static By LastLanguageDeleteButtonLocator = By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/table/tbody[last()]/tr/td[3]/span[2]/i");
        private static By LastLanguageEditButtonLocator = By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/table/tbody[last()]/tr/td[3]/span[1]/i");
        private static By LastLanguageTextBoxLocator = By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/table/tbody[last()]/tr/td/div/div[1]/input");
        private static By LastLanguageLevelLocator = By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/table/tbody[last()]/tr/td/div/div[2]/select");
        private static By LastLanguageUpdateButtonLocator = By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/table/tbody[last()]/tr/td/div/span/input[1]");
        private static By LastLanguageCancelEditButtonLocator = By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/table/tbody[last()]/tr/td/div/span/input[2]");
   

        //*[@id="account-profile-section"]/div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/div/div[1]/input


        public static void AddProfileDescription(IWebDriver driver, string description)
        {           
            TurnOnWait();
            TurnOnWait();
            IWebElement DescPenButton = driver.FindElement(DescPenButtonLocator);
            DescPenButton.Click();
            TurnOnWait();
            IWebElement DescTextbox = driver.FindElement(DescTextBoxLocator);
            DescTextbox.Click();
            DescTextbox.SendKeys(description);

            TurnOnWait();
            if(description != null)
            {
                IWebElement DescSaveButton = driver.FindElement(DescSaveButtonLocator);
                DescSaveButton.Click();
            }
            
        }

        public static void AddNewLanguage(IWebDriver driver, string languageName, string languageLevel)
        {
            TurnOnWait();
            IWebElement languageAddNewButton = driver.FindElement(LanguageAddNewButtonLocator);
            languageAddNewButton.Click();
            TurnOnWait();
            IWebElement languageTextBox = driver.FindElement(LanguageTextBoxLocator);
            IWebElement languageLevelDropDown = driver.FindElement(LanguageLevelLocator);
/*          IWebElement languageAddButton = driver.FindElement(LanguageAddButtonLocator);
            IWebElement languageCancelButton = driver.FindElement(LanguageCancelButtonLocator);

        
            TurnOnWait();*/
            languageTextBox.Click();
            languageTextBox.SendKeys(languageName);
            languageLevelDropDown.Click();
            TurnOnWait();

            languageLevelDropDown.SendKeys(languageLevel);
            TurnOnWait();
        }

        public static void SaveNewLanguage(IWebDriver driver)
        {
           
            IWebElement languageAddButton = driver.FindElement(LanguageAddButtonLocator);
            languageAddButton.Click();           
        }

        public static void CancelNewLanguage(IWebDriver driver)
        {
            TurnOnWait();
            IWebElement languageCancelButton = driver.FindElement(LanguageCancelButtonLocator);
            languageCancelButton.Click();
        }

        public static void DeleteLanguage(IWebDriver driver, string languageName)
        {
            try
            {
                IWebElement lastLanguageDeleteButton = driver.FindElement(LastLanguageDeleteButtonLocator);
                lastLanguageDeleteButton.Click();
            }

            catch(Exception ex) {
                Console.WriteLine(ex.Message);              
            }
            
        }
        //Edit Language
        public static void ClickEditLanguageButton(IWebDriver driver, string oldLanguage, string oldLangugaeLevel)
        {
            try
            {
                IWebElement languageEditButton = driver.FindElement(LastLanguageEditButtonLocator);
                languageEditButton.Click();

            }
            catch(Exception ex) { Console.WriteLine(ex.Message + Environment.NewLine); }
                     
        }

        public static void EditLanguage(IWebDriver driver, string newLanguageName, string newLanguageLevel)
        {
            try { 
            IWebElement lastLanguageTextBox = driver.FindElement(LastLanguageTextBoxLocator);
            IWebElement lastLanguageLevelDropDown = driver.FindElement(LastLanguageLevelLocator);

            lastLanguageTextBox.Click();
            lastLanguageTextBox.Clear();
            lastLanguageTextBox.SendKeys(newLanguageName);
            lastLanguageLevelDropDown.Click();
            lastLanguageLevelDropDown.SendKeys(newLanguageLevel);
            TurnOnWait();

        }
            catch(Exception ex) { Console.WriteLine(ex.Message); }
}

        public static void UpdateLanguage(IWebDriver driver)
        {
            try { 
            IWebElement lastLanguageUpdateButton = driver.FindElement(LastLanguageUpdateButtonLocator);
            lastLanguageUpdateButton.Click();
        }
            catch(Exception ex) { Console.WriteLine(ex.Message); }
}

        public static void CancelUpdateLanguage(IWebDriver driver)
        {
            IWebElement lastLanguageCancelButton = driver.FindElement(LastLanguageCancelEditButtonLocator);
            lastLanguageCancelButton.Click();
        }
    }
}
