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
        public void GivenClickOnXButtonForALanguageInLanguagesTab(string languageName)
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
        //Add Skills

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
            NavigateToProfileSkills();
        }

        [When(@"User enter skill '([^']*)' and Level '([^']*)'")]
        public void WhenUserEnterSkillAndLevel(string skillName, string skillLevel)
        {
            ProfileSkills.AddNewSkill(driver, skillName, skillLevel);
        }


        [When(@"Click on Cancel at Skill Level")]
        public void WhenClickOnCancelAtSkillLevel()
        {
            ProfileSkills.CancelNewSkill(driver);
        }

        [Then(@"New Skill not added to profile")]
        public void ThenNewSkillNotAddedToProfile()
        {
            NavigateToProfileSkills();
        }

        //Delete Skill
        [Given(@"for a skill in Skills Tab '([^']*)'")]
        public void GivenForASkillInSkillsTab(string skillName)
        {
            login();
            NavigateToProfile();
            NavigateToProfileSkills();
        }

        [When(@"User click on X button for a skill '([^']*)'")]
        public void WhenUserClickOnXButtonForASkill(string skillName)
        {
            ProfileSkills.DeleteSkill(driver, skillName);
        }

        [Then(@"Skill deleted from profile successfully")]
        public void ThenSkillDeletedFromProfileSuccessfully()
        {
            NavigateToProfile();
            NavigateToProfileSkills();
        }

        //Edit Skill

        [Given(@"User click on Pen button for a Skill '([^']*)' '([^']*)'")]
        public void GivenUserClickOnPenButtonForASkill(string oldSkillName, string oldSkillLevel)
        {
            login();
            NavigateToProfile();
            NavigateToProfileSkills();
            ProfileSkills.ClickEditSkillButton(driver, oldSkillName, oldSkillLevel);
        }

        [When(@"User enter new Skills '([^']*)' , '([^']*)' and click Update button")]
        public void WhenUserEnterNewSkillsAndClickUpdateButton(string newSkillName, string newSkillLevel)
        {
            ProfileSkills.EditSkill(driver, newSkillName, newSkillLevel);
        }

        [Then(@"Skill changes saved to profile successfully")]
        public void ThenSkillChangesSavedToProfileSuccessfully()
        {
            ProfileSkills.UpdateSkill(driver);
            NavigateToProfileSkills();
        }

        [When(@"User enter new Skills '([^']*)' , '([^']*)'")]
        public void WhenUserEnterNewSkills(string newSkillName, string newSkillLevel)
        {
            ProfileSkills.EditSkill(driver, newSkillName, newSkillLevel);
        }

        [When(@"Click on Cancel Button in Update Skill")]
        public void WhenClickOnCancelButtonInUpdateSkill()
        {
            ProfileSkills.CancelUpdateSkill(driver);
        }

        [Then(@"Skill changes not saved to profile")]
        public void ThenSkillChangesNotSavedToProfile()
        {
            NavigateToProfile();
            NavigateToProfileSkills();
        }

    }
}
