using OpenQA.Selenium;
using MARS_QA.Utilities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MARS_QA.Mars_Pages
{
    internal class ProfileDescription : CommonDriver
    {
        public static void AddProfileDescription(string description)
        {
            try
            {
                TurnOnWait(5);
                IWebElement DescPenButton = driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/div/div/div/h3/span/i"));
                DescPenButton.Click();
                TurnOnWait(3);
                IWebElement DescTextbox = driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/div/div/form/div/div/div[2]/div[1]/textarea"));

                DescTextbox.Click();
                DescTextbox.Clear();
                TurnOnWait(3);
                IWebElement DescSaveButton = driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/div/div/form/div/div/div[2]/button"));
                DescTextbox.Click();
                DescTextbox.SendKeys(description);
                DescSaveButton.Click();

                if (description.Length == 0)
                {
                    DescTextbox.Click();
                    DescTextbox.Clear();
                    DescTextbox.Click();
                    DescTextbox.SendKeys(string.Empty);
                    DescSaveButton.Click();
                }

            }
            catch (Exception ex) { }

        }
    }
}
