using MARS_QA.Mars_Pages;
using MARS_QA.Utilities;
using System;
using TechTalk.SpecFlow;

namespace MARS_QA.StepDefinitions
{
    [Binding]
    public class ProfileStepDefinitions:CommonDriver
    {
        [Given(@"user enter valid '([^']*)' '([^']*)'")]
        public void GivenUserEnterValid(string username, string password)
        {
            login(driver, username, password);
        }

        [When(@"user enter Profile Description and click Save Button '([^']*)'")]
        public void WhenUserEnterProfileDescriptionAndClickSaveButton(string description)
        {
            ProfileLanguages.AddProfileDescription(driver, description);
        }


        [Then(@"Description saved successfully")]
        public void ThenDescriptionSavedSuccessfully()
        {
            TurnOnWait();
        }

        //Languages
        //Add New Language

        [Given(@"click on Add New in Languages Tab")]
        public void GivenClickOnAddNewInLanguagesTab()
        {
            login();
            NavigateToProfile();
            NavigateToProfileLanguage();
        }

        [When(@"User enter language '([^']*)' and Level '([^']*)' and Add")]
        public void WhenUserEnterLanguageAndLevelAndAdd(string languageName, string languageLevel)
        {
            ProfileLanguages.AddNewLanguage(driver, languageName,languageLevel);
        }

        [Then(@"New Language added to profile successfully")]
        public void ThenNewLanguageAddedToProfileSuccessfully()
        {
            ProfileLanguages.SaveNewLanguage(driver);
            NavigateToProfileLanguage();
        }

        //Cancel in Add New Language

        [When(@"User enter language '([^']*)' and Level '([^']*)'")]
        public void WhenUserEnterLanguageAndLevel(string languageName, string languageLevel)
        {

            ProfileLanguages.AddNewLanguage(driver, languageName, languageLevel);
        }

        [When(@"Click on Cancel")]
        public void WhenClickOnCancel()
        {
            ProfileLanguages.CancelNewLanguage(driver);
        }

        [Then(@"New Language not added to profile")]
        public void ThenNewLanguageNotAddedToProfile()
        {
            NavigateToProfile();
        }

        //Delete Language

        [Given(@"for a language in Languages Tab '([^']*)'")]
        public void GivenClickOnXButtonForALanguageInLanguagesTab(string english)
        {
            login();
            NavigateToProfile();
            NavigateToProfileLanguage();
        }

        [When(@"User click on X button for a language '([^']*)'")]
        public void WhenUserClickOnXButtonForALanguage(string languageName)
        {
            ProfileLanguages.DeleteLanguage(driver, languageName);
        }

        [Then(@"Language deleted from profile successfully")]
        public void ThenLanguageDeletedFromProfileSuccessfully()
        {
            NavigateToProfile();
            NavigateToProfileLanguage();
        }

        //Edit Langugae

        [Given(@"User click on Pen button for a language '([^']*)' '([^']*)'")]
        public void GivenUserClickOnPenButtonForALanguage(string oldLanguageName, string oldLanguageLevel)
        {
            login();
            NavigateToProfile();
            NavigateToProfileLanguage();
            ProfileLanguages.ClickEditLanguageButton(driver, oldLanguageName, oldLanguageLevel);
        }

        [When(@"User enter new values '([^']*)' '([^']*)'")]
        public void WhenUserEnterNewValues(string newLanguageName, string newLanguageLevel)
        {
            ProfileLanguages.EditLanguage(driver, newLanguageName, newLanguageLevel);
        }

        [Then(@"Language changes saved to profile successfully")]
        public void ThenLanguageChangesSavedToProfileSuccessfully()
        {
           ProfileLanguages.UpdateLanguage(driver);
            NavigateToProfileLanguage();
        }

        //Cancel at Update Language
        [When(@"Click on Cancel Button in Update Language")]
        public void WhenClickOnCancelButtonInUpdateLanguage()
        {
            ProfileLanguages.CancelUpdateLanguage(driver);
        }

        [Then(@"Language changes not saved to profile")]
        public void ThenLanguageChangesNotSavedToProfile()
        {
            NavigateToProfile();
            NavigateToProfileLanguage();
        }

        //Skills

        [Given(@"click on Add New in Skills Tab")]
        public void GivenClickOnAddNewInSkillsTab()
        {
            login();
            NavigateToProfile();
            NavigateToProfileSkills();
        }

        [When(@"User enter skill '([^']*)' and Level '([^']*)' and Add")]
        public void WhenUserEnterSkillAndLevelAndAdd(string skillName, string skillLevel)
        {
            ProfileSkills.AddNewSkill(driver, skillName, skillLevel);
        }

        [Then(@"New Skill added to profile successfully")]
        public void ThenNewSkillAddedToProfileSuccessfully()
        {
            ProfileSkills.SaveNewSkill(driver);
            NavigateToProfileLanguage();
        }



    }
}
