using MARS_QA.Utilities;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MARS_QA.Mars_Pages
{
    public class ProfileSkills:CommonDriver
    {

        private static By SkillAddNewButtonLocator = By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[3]/div/div[2]/div/table/thead/tr/th[3]/div");
        private static By SkillTextBoxLocator = By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[3]/div/div[2]/div/div/div[1]/input");
        private static By SkillLevelLocator = By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[3]/div/div[2]/div/div/div[2]/select");
        private static By SkillAddButtonLocator = By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[3]/div/div[2]/div/div/span/input[1]");
        private static By SkillCancelButtonLocator = By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[3]/div/div[2]/div/div/span/input[2]");
        private static By LastSkillNameLocator = By.XPath("");
        private static By LastSkillLevelTextLocator = By.XPath("");
        private static By LastSkillDeleteButtonLocator = By.XPath("");
        private static By LastSkillEditButtonLocator = By.XPath("");
        private static By LastSkillTextBoxLocator = By.XPath("");
        private static By LastSkillLevelLocator = By.XPath("");
        private static By LastSkillUpdateButtonLocator = By.XPath("");
        private static By LastSkillCancelEditButtonLocator = By.XPath("");


     

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

    }
}
