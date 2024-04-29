using MARS_QA.Utilities;
using NUnit.Framework.Constraints;
using OpenQA.Selenium;

namespace MARS_QA.Mars_Pages
{
    public class ProfileLanguages : CommonDriver
    {
        public static void AddNewLanguage(string languageName, string languageLevel)
        {
            Thread.Sleep(1000);
            IWebElement languageAddNewButton = driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/table/thead/tr/th[3]/div"));
            languageAddNewButton.Click();
            TurnOnWait();
            IWebElement languageTextBox = driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/div/div[1]/input"));
            IWebElement languageLevelDropDown = driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/div/div[2]/select"));
            languageTextBox.Click();
            languageTextBox.SendKeys(languageName);
            languageLevelDropDown.Click();
            TurnOnWait();
            languageLevelDropDown.SendKeys(languageLevel);
            TurnOnWait();
        }

        public static string getAlertText()
        {
            Thread.Sleep(1000);
            var alertText = driver.FindElement(By.XPath("/html[1]/body[1]/div[1]/div[1]"));
            Thread.Sleep(1000);
            return alertText.Text;

        }

        public static void SaveNewLanguage()
        {

            IWebElement languageAddButton = driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/div/div[3]/input[1]"));
            languageAddButton.Click();
        }

        public static void CancelNewLanguage()
        {
            TurnOnWait();
            IWebElement languageCancelButton = driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/div/div[3]/input[2]"));
            languageCancelButton.Click();
        }
        public static void DeleteLanguage()
        {
            AddNewLanguage("blah", "Fluent");
            SaveNewLanguage();
            Thread.Sleep(1000);
            IWebElement lastLanguageDeleteButton = driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/table/tbody[last()]/tr/td[3]/span[2]/i"));
            lastLanguageDeleteButton.Click();
        }

        public static void DeleteMyLastLanguageEntry()
        {
            Thread.Sleep(5000);
            IWebElement lastLanguageDeleteButton = driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/table/tbody[last()]/tr/td[3]/span[2]/i"));
            lastLanguageDeleteButton.Click();
        }

        public static void DeleteAllLanguageEntry()
        {
            Thread.Sleep(5000);
            int count = driver.FindElements(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/table/tbody")).Count;
            for (int i = 0; i < count; i++)
            {
                IWebElement lastLanguageDeleteButton = driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/table/tbody[last()]/tr/td[3]/span[2]/i"));
                lastLanguageDeleteButton.Click();
                Thread.Sleep(3000);
            }

        }

        //Edit Language
        public static void ClickEditLanguageButton(string oldLanguage, string oldLangugaeLevel)
        {
            try
            {
                IWebElement languageEditButton = driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/table/tbody[last()]/tr/td[3]/span[1]/i"));
                languageEditButton.Click();

            }
            catch (Exception ex) { Console.WriteLine(ex.Message + Environment.NewLine); }

        }

        public static void EditLanguage(string newLanguageName, string newLanguageLevel)
        {
            try
            {
                IWebElement lastLanguageTextBox = driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/table/tbody[last()]/tr/td/div/div[1]/input"));
                IWebElement lastLanguageLevelDropDown = driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/table/tbody[last()]/tr/td/div/div[2]/select"));

                lastLanguageTextBox.Click();
                lastLanguageTextBox.Clear();
                lastLanguageTextBox.SendKeys(newLanguageName);
                lastLanguageLevelDropDown.Click();
                lastLanguageLevelDropDown.SendKeys(newLanguageLevel);
                TurnOnWait();


            }
            catch (Exception ex) { Console.WriteLine(ex.Message); }
        }

        public static void UpdateLanguage()
        {
            try
            {
                IWebElement lastLanguageUpdateButton = driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/table/tbody[last()]/tr/td/div/span/input[1]"));
                lastLanguageUpdateButton.Click();
            }
            catch (Exception ex) { Console.WriteLine(ex.Message); }
        }

        public static void CancelUpdateLanguage()
        {
            IWebElement lastLanguageCancelButton = driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/table/tbody[last()]/tr/td/div/span/input[2]"));
            lastLanguageCancelButton.Click();
        }

        public static bool verifyTextPresent(String value)
        {
            driver.PageSource.Contains(value);
            return true;
        }
    }
}