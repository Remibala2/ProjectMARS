﻿using FluentAssertions.Formatting;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MARS_QA.Utilities
{
    public class CommonDriver
    {
        public static IWebDriver driver { get; set; }
        private static By SignInButtonLocator = By.XPath("//*[@id=\"home\"]/div/div/div[1]/div/a");
        private static By UserNameTextBoxLocator = By.XPath("//body/div[2]/div[1]/div[1]/div[1]/div[1]/div[1]/input[1]");
        private static By PasswordTextBoxLocator = By.XPath("//body/div[2]/div[1]/div[1]/div[1]/div[1]/div[2]/input[1]");
        private static By LoginButtonLocator = By.XPath("//button[contains(text(),'Login')]");
        private static By ProfileButtonLocator = By.XPath("//*[@id=\"account-profile-section\"]/div/section[1]/div/a[2]");
        private static By ProfileLanguageLocator = By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[1]/a[1]");
        private static By ProfileSkillsLocator = By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[1]/a[2]");
        public void Initialise()
        {
            driver = new ChromeDriver();
            TurnOnWait();
            driver.Manage().Window.Maximize();
        }

        public static void TurnOnWait()
        {
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(5);
        }

        public static void TurnOnWait(int s)
        {
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(s);
        }

        public static void NavigateUrl()
        {
            driver.Navigate().GoToUrl(ConstantHelper.BaseUrl);
        }

        public static void TakeScreenshot(IWebDriver driver, string saveLocation)
        {
            ITakesScreenshot ssdriver = driver as ITakesScreenshot;
            Screenshot screenshot = ssdriver.GetScreenshot();
            screenshot.SaveAsFile(saveLocation);
        }


        /*            public static string SaveScreenshot(IWebDriver driver, string ScreenShotFileName) // Definition
                    {
                        var folderLocation = (ConstantHelper.ScreenshotPath);

                        if (!System.IO.Directory.Exists(folderLocation))
                        {
                            System.IO.Directory.CreateDirectory(folderLocation);
                        }

                        var screenShot = ((ITakesScreenshot)driver).GetScreenshot();
                        var fileName = new StringBuilder(folderLocation);

                        fileName.Append(ScreenShotFileName);
                        fileName.Append(DateTime.Now.ToString("_dd-mm-yyyy_mss"));
                        //fileName.Append(DateTime.Now.ToString("dd-mm-yyyym_ss"));
                        fileName.Append(".jpeg");
                    screenShot.SaveAsFile(fileName.ToString());
                        //ScreenshotImageFormat.Jpeg);
                  //  screenShot.SaveAsFile(fileName.ToString(), Screenshot;
                    return fileName.ToString();
                    }
                */


        public static void login(IWebDriver driver, string username, string password)
        {
            IWebElement signInButton = driver.FindElement(SignInButtonLocator);
            signInButton.Click();
            IWebElement usernameTextbox = driver.FindElement(UserNameTextBoxLocator);
            usernameTextbox.SendKeys(username);
            IWebElement passwordTextbox = driver.FindElement(PasswordTextBoxLocator);
            passwordTextbox.SendKeys(password);
            IWebElement loginButton = driver.FindElement(LoginButtonLocator);
            loginButton.Click();
        }

        public static void login()
        {
           
            IWebElement signInButton = driver.FindElement(SignInButtonLocator);
            signInButton.Click();
            IWebElement usernameTextbox = driver.FindElement(UserNameTextBoxLocator);
            usernameTextbox.SendKeys(ConstantHelper.username);
            IWebElement passwordTextbox = driver.FindElement(PasswordTextBoxLocator);
            passwordTextbox.SendKeys(ConstantHelper.password);
            IWebElement loginButton = driver.FindElement(LoginButtonLocator);
            loginButton.Click();
        }

        public static void NavigateToProfile()
        {
            IWebElement ProfileTab = driver.FindElement(ProfileButtonLocator);
            ProfileTab.Click();
            TurnOnWait();
        }

        public static void NavigateToProfileLanguage()
        {
            IWebElement ProfileLanguageTab = driver.FindElement(ProfileLanguageLocator);
            ProfileLanguageTab.Click();
            TurnOnWait();
        }

        public static void NavigateToProfileSkills()
        {
            IWebElement ProfileSkillsTab = driver.FindElement(ProfileSkillsLocator);
            ProfileSkillsTab.Click();
            TurnOnWait();
        }
        public void Close()
        {
            driver.Quit();
        }
    }
}
