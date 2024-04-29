using MARS_QA.Mars_Pages;
using MARS_QA.Utilities;
using NUnit.Framework;
using OpenQA.Selenium;

namespace MARS_QA.StepDefinitions
{
    [Binding]

    public class ProfileLanguageStepDefinitions : CommonDriver
    {
        //Add New Language
        [Given(@"click on Add New button in Languages Tab")]
        public void GivenClickOnAddNewButtonInLanguagesTab()
        {
            login();
        }

        [When(@"User enter new language '([^']*)' and Level '([^']*)' and click Add")]
        public void WhenUserEnterNewLanguageAndLevelAndClickAdd(string languageName, string languageLevel)
        {
            ProfileLanguages.DeleteAllLanguageEntry();
            ProfileLanguages.AddNewLanguage(languageName, languageLevel);
        }

        [Then(@"New Language '([^']*)' and '([^']*)' are added to profile successfully")]
        public void ThenNewLanguageAndAreAddedToProfileSuccessfully(string languageName, string languageLevel)
        {
            ProfileLanguages.SaveNewLanguage();
        }

        [Then(@"'([^']*)' ""([^""]*)"" message appears")]
        public void ThenMessageAppears(string languageName, string expectedMessage)
        {
            string alertText = ProfileLanguages.getAlertText();
            expectedMessage = languageName + " " + expectedMessage;
            Assert.That(alertText, Is.EqualTo(expectedMessage));
            ProfileLanguages.DeleteMyLastLanguageEntry();
        }

        //Add Existing Language
        [Given(@"click on Add New in Languages Tab with existing '([^']*)' '([^']*)'")]
        public void GivenClickOnAddNewInLanguagesTabWithExisting(string existingLanguageName, string existingLanguageLevel)
        {
            login();
            ProfileLanguages.DeleteAllLanguageEntry();
            ProfileLanguages.AddNewLanguage(existingLanguageName, existingLanguageLevel);
            ProfileLanguages.SaveNewLanguage();
        }

        [When(@"User enter the existing language '([^']*)' and Level '([^']*)' and click Add")]
        public void WhenUserEnterTheExistingLanguageAndLevelAndClickAdd(string languageName, string languageLevel)
        {

            ProfileLanguages.AddNewLanguage(languageName, languageLevel);
            ProfileLanguages.SaveNewLanguage();
        }

        [Then(@"Langugae and Level not added")]
        public void ThenLangugaeAndLevelNotAdded()
        {

        }

        [Then(@"""([^""]*)"" error message")]
        public void ThenErrorMessage(string expectedMessage)
        {
            string alertText = ProfileLanguages.getAlertText();
            Assert.That(alertText, Is.EqualTo(expectedMessage));
        }



        [Given(@"click on Add empty langugae and/or Level in Languages Tab")]
        public void GivenClickOnAddEmptyLangugaeAndOrLevelInLanguagesTab()
        {
            login();
            NavigateToProfile();
            NavigateToProfileLanguage();
        }

        [When(@"User enter language empty '([^']*)' and/or Level '([^']*)' and click Add")]
        public void WhenUserEnterLanguageEmptyAndOrLevelAndClickAdd(string languageName, string languageLevel)
        {
            ProfileLanguages.AddNewLanguage(languageName, languageLevel);
            ProfileLanguages.SaveNewLanguage();
        }

        [When(@"User enter new language '([^']*)' and Level '([^']*)'")]
        public void WhenUserEnterNewLanguageAndLevel(string languageName, string languageLevel)
        {
            ProfileLanguages.AddNewLanguage(languageName, languageLevel);
        }

        [When(@"Click on Cancel button")]
        public void WhenClickOnCancelButton()
        {
            ProfileLanguages.CancelNewLanguage();
        }

        [Then(@"New Language is not added to profile")]
        public void ThenNewLanguageIsNotAddedToProfile()
        {
            NavigateToProfile();
        }

        [Given(@"for the last language in Languages Tab '([^']*)'")]
        public void GivenForTheLastLanguageInLanguagesTab(string english)
        {
            login();
        }

        [When(@"User click on X button")]
        public void WhenUserClickOnXButton()
        {
            ProfileLanguages.DeleteLanguage();
        }

        [Then(@"Language deleted from the profile successfully")]
        public void ThenLanguageDeletedFromTheProfileSuccessfully()
        {

        }

        //Edit Language
        [Given(@"User click Pen button for a language '([^']*)' '([^']*)'")]
        public void GivenUserClickPenButtonForALanguage(string oldLanguageName, string oldLanguageLevel)
        {
            login();
            ProfileLanguages.AddNewLanguage(oldLanguageName, oldLanguageLevel);
            ProfileLanguages.SaveNewLanguage();
            ProfileLanguages.ClickEditLanguageButton(oldLanguageName, oldLanguageLevel);

        }

        [When(@"User keyin new values '([^']*)' '([^']*)'")]
        public void WhenUserKeyinNewValues(string newLanguageName, string newLanguageLevel)
        {
            ProfileLanguages.EditLanguage(newLanguageName, newLanguageLevel);
        }

        [Then(@"Language changes is saved to profile successfully")]
        public void ThenLanguageChangesIsSavedToProfileSuccessfully()
        {
            ProfileLanguages.UpdateLanguage();
        }

        [Then(@"language updated error message for '([^']*)'")]
        public void ThenLanguageUpdatedErrorMessageFor(string newLanguageName)
        {
            string alertText = ProfileLanguages.getAlertText();
            string expectedMessage = newLanguageName + " has been updated to your languages";
            Console.WriteLine(expectedMessage);
            Assert.That(alertText, Is.EqualTo(expectedMessage));
            ProfileLanguages.DeleteMyLastLanguageEntry();
        }

        [When(@"Click on Cancel Button in Edit flow")]
        public void WhenClickOnCancelButtonInEditFlow()
        {
            ProfileLanguages.CancelUpdateLanguage();
        }


        [Then(@"Language changes not saved")]
        public void ThenLanguageChangesNotSaved()
        {
        }


        [Given(@"User has four Languages added to profile '([^']*)' '([^']*)' '([^']*)' '([^']*)' '([^']*)' '([^']*)' '([^']*)' '([^']*)'")]
        public void GivenUserHasFourLanguagesAddedToProfile(string l1, string lev1, string l2, string lev2, string l3, string lev3, string l4, string lev4)
        {
            login();
            ProfileLanguages.DeleteAllLanguageEntry();
            ProfileLanguages.AddNewLanguage(l1, lev1);
            ProfileLanguages.SaveNewLanguage();
            ProfileLanguages.AddNewLanguage(l2, lev2);
            ProfileLanguages.SaveNewLanguage();
            ProfileLanguages.AddNewLanguage(l3, lev3);
            ProfileLanguages.SaveNewLanguage();
            ProfileLanguages.AddNewLanguage(l4, lev4);
            ProfileLanguages.SaveNewLanguage();
        }

        [Then(@"Add New button is invisible")]
        public void ThenAddNewButtonIsInvisible()
        {
            bool buttonStatus = ProfileLanguages.verifyTextPresent("Add New");
          Assert.That(buttonStatus, Is.True,"Add New button Invisible");
            ProfileLanguages.DeleteAllLanguageEntry();
        }

    }
}
