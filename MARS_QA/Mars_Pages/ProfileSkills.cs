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
        public static void AddNewSkill(string skillName, string skillLevel)
        {
            TurnOnWait();
            IWebElement skillAddNewButton = driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[3]/div/div[2]/div/table/thead/tr/th[3]/div"));
            skillAddNewButton.Click();
            TurnOnWait();
            IWebElement skillTextBox = driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[3]/div/div[2]/div/div/div[1]/input"));
            IWebElement skillLevelDropDown = driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[3]/div/div[2]/div/div/div[2]/select"));
            skillTextBox.Click();
            skillTextBox.SendKeys(skillName);
            skillLevelDropDown.Click();
            TurnOnWait();
            skillLevelDropDown.SendKeys(skillLevel);
            TurnOnWait();
        }

        public static string getAlertText()
        {
            Thread.Sleep(1000);
            var alertText = driver.FindElement(By.XPath("/html[1]/body[1]/div[1]/div[1]"));
            Thread.Sleep(1000);
            Console.WriteLine("Actual Alert Text"+alertText);
            return alertText.Text;
        }

        public static void SaveNewSkill()
        {

            IWebElement skillAddButton = driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[3]/div/div[2]/div/div/span/input[1]"));
            skillAddButton.Click();
        }

        public static void CancelNewSkill()
        {
            TurnOnWait();
            IWebElement skillCancelButton = driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[3]/div/div[2]/div/div/span/input[2]"));
            skillCancelButton.Click();
        }

        public static void DeleteSkill()
        {
            AddNewSkill("blah", "Basic");
            SaveNewSkill();
            Thread.Sleep(1000);
            IWebElement lastSkillDeleteButton = driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[3]/div/div[2]/div/table/tbody/tr/td[3]/span[2]/i"));
            lastSkillDeleteButton.Click();
        }

        public static void DeleteMyLastSkillEntry()
        {
            Thread.Sleep(5000);
            IWebElement lastSkillDeleteButton = driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[3]/div/div[2]/div/table/tbody[last()]/tr/td[3]/span[2]/i"));
            lastSkillDeleteButton.Click();
        }

        public static void DeleteAllSkillEntry()
        {
            Thread.Sleep(5000);
            int count = driver.FindElements(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[3]/div/div[2]/div/table/tbody")).Count;
            for (int i = 0; i < count; i++)
            {
                IWebElement lastSkillDeleteButton = driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[3]/div/div[2]/div/table/tbody[last()]/tr/td[3]/span[2]/i"));
                lastSkillDeleteButton.Click();
                Thread.Sleep(3000);
            }

        }

        //Edit Skill
        public static void ClickEditSkillButton(string oldSkill, string oldSkillLevel)
        {
            try
            {
                IWebElement skillEditButton = driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[3]/div/div[2]/div/table/tbody[last()]/tr/td[3]/span[1]/i"));
                skillEditButton.Click();

            }
            catch (Exception ex) { Console.WriteLine(ex.Message + Environment.NewLine); }

        }

        public static void EditSkill(string newSkillName, string newSkillLevel)
        {
            try
            {
                IWebElement lastSkillTextBox = driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[3]/div/div[2]/div/table/tbody[last()]/tr/td/div/div[1]/input"));
                IWebElement lastSkillLevelDropDown = driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[3]/div/div[2]/div/table/tbody[last()]/tr/td/div/div[2]/select"));

                lastSkillTextBox.Click();
                lastSkillTextBox.Clear();
                lastSkillTextBox.SendKeys(newSkillName);
                lastSkillLevelDropDown.Click();
                lastSkillLevelDropDown.SendKeys(newSkillLevel);
                TurnOnWait();

            }
            catch (Exception ex) { Console.WriteLine(ex.Message); }
        }

        public static void UpdateSkill()
        {
            try
            {
                Thread.Sleep(1000);
                IWebElement lastSkillUpdateButton = driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[3]/div/div[2]/div/table/tbody[last()]/tr/td/div/span/input[1]"));
                lastSkillUpdateButton.Click();
            }
            catch (Exception ex) { Console.WriteLine(ex.Message); }
        }

        public static void CancelUpdateSkill()
        {
            Thread.Sleep(1000);
            IWebElement lastSkillCancelButton = driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[3]/div/div[2]/div/table/tbody/tr/td/div/span/input[2]"));
            lastSkillCancelButton.Click();
        }
    }
}

