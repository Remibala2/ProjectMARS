using MARS_QA.Utilities;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MARS_QA.Mars_Pages
{
    public class ProfileSkills : CommonDriver
    {

        private static By SkillAddNewButtonLocator = By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[3]/div/div[2]/div/table/thead/tr/th[3]/div");
        private static By SkillTextBoxLocator = By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[3]/div/div[2]/div/div/div[1]/input");
        private static By SkillLevelLocator = By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[3]/div/div[2]/div/div/div[2]/select");
        private static By SkillAddButtonLocator = By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[3]/div/div[2]/div/div/span/input[1]");
        private static By SkillCancelButtonLocator = By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[3]/div/div[2]/div/div/span/input[2]");
        private static By LastSkillNameLocator = By.XPath("");
        private static By LastSkillLevelTextLocator = By.XPath("");
        private static By LastSkillDeleteButtonLocator = By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[3]/div/div[2]/div/table/tbody/tr/td[3]/span[2]/i");
        private static By LastSkillEditButtonLocator = By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[3]/div/div[2]/div/table/tbody[last()]/tr/td[3]/span[1]/i");
        private static By LastSkillTextBoxLocator = By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[3]/div/div[2]/div/table/tbody[last()]/tr/td/div/div[1]/input");
        private static By LastSkillLevelLocator = By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[3]/div/div[2]/div/table/tbody[last()]/tr/td/div/div[2]/select");
        private static By LastSkillUpdateButtonLocator = By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[3]/div/div[2]/div/table/tbody[last()]/tr/td/div/span/input[1]");
        private static By LastSkillCancelEditButtonLocator = By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[3]/div/div[2]/div/table/tbody[last()]/tr/td/div/span/input[2]");




        public static void AddNewSkill(IWebDriver driver, string skillName, string skillLevel)
        {
            TurnOnWait();
            IWebElement skillAddNewButton = driver.FindElement(SkillAddNewButtonLocator);
            skillAddNewButton.Click();
            TurnOnWait();
            IWebElement skillTextBox = driver.FindElement(SkillTextBoxLocator);
            IWebElement skillLevelDropDown = driver.FindElement(SkillLevelLocator);

            skillTextBox.Click();
            skillTextBox.SendKeys(skillName);
            skillLevelDropDown.Click();
            TurnOnWait();

            skillLevelDropDown.SendKeys(skillLevel);
            TurnOnWait();
        }

        public static void SaveNewSkill(IWebDriver driver)
        {

            IWebElement skillAddButton = driver.FindElement(SkillAddButtonLocator);
            skillAddButton.Click();
        }

        public static void CancelNewSkill(IWebDriver driver)
        {
            TurnOnWait();
            IWebElement skillCancelButton = driver.FindElement(SkillCancelButtonLocator);
            skillCancelButton.Click();
        }

        public static void DeleteSkill(IWebDriver driver, string skillName)
        {
            try
            {
                IWebElement lastSkillDeleteButton = driver.FindElement(LastSkillDeleteButtonLocator);
                lastSkillDeleteButton.Click();
            }

            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

        }

        //Edit Skill
        public static void ClickEditSkillButton(IWebDriver driver, string oldSkill, string oldSkillLevel)
        {
            try
            {
                IWebElement skillEditButton = driver.FindElement(LastSkillEditButtonLocator);
                skillEditButton.Click();

            }
            catch (Exception ex) { Console.WriteLine(ex.Message + Environment.NewLine); }

        }

        public static void EditSkill(IWebDriver driver, string newSkillName, string newSkillLevel)
        {
            try
            {
                IWebElement lastSkillTextBox = driver.FindElement(LastSkillTextBoxLocator);
                IWebElement lastSkillLevelDropDown = driver.FindElement(LastSkillLevelLocator);

                lastSkillTextBox.Click();
                lastSkillTextBox.Clear();
                lastSkillTextBox.SendKeys(newSkillName);
                Console.WriteLine(newSkillName);
                lastSkillLevelDropDown.Click();
                TurnOnWait();
                lastSkillLevelDropDown.SendKeys(newSkillLevel);
                Console.WriteLine(newSkillLevel);
                TurnOnWait();

            }
            catch (Exception ex) { Console.WriteLine(ex.Message); }
        }

        public static void UpdateSkill(IWebDriver driver)
        {
            try
            {
                IWebElement lastSkillUpdateButton = driver.FindElement(LastSkillUpdateButtonLocator);
                lastSkillUpdateButton.Click();
            }
            catch (Exception ex) { Console.WriteLine(ex.Message); }
        }

        public static void CancelUpdateSkill(IWebDriver driver)
        {
            IWebElement lastSkillCancelButton = driver.FindElement(LastSkillCancelEditButtonLocator);
            lastSkillCancelButton.Click();
        }
    }
}

