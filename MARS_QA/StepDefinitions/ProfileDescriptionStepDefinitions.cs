using MARS_QA.Mars_Pages;
using MARS_QA.Utilities;
using NUnit.Framework;


namespace MARS_QA.StepDefinitions
{
    [Binding]
    public class ProfileDescriptionStepDefinitions : CommonDriver
    {

        [Given(@"user click on Pen button for Description")]
        public void GivenUserClickOnPenButtonForDescription()
        {
            login();
        }

        [When(@"user enter Description and click Save Button '([^']*)'")]
        public void WhenUserEnterDescriptionAndClickSaveButton(string description)
        {
            ProfileDescription.AddProfileDescription(description);
        }

        [Then(@"Description is saved successfully")]
        public void ThenDescriptionIsSavedSuccessfully()
        {
        }

        [Then(@"""([^""]*)"" message appears")]
        public void ThenMessageAppears(string expectedMessage)
        {
            string alertText = ProfileLanguages.getAlertText();
            Assert.That(alertText, Is.EqualTo(expectedMessage));
        }

        [When(@"user enter nothing in Profile Description and click Save Button '([^']*)'")]
        public void WhenUserEnterNothingInProfileDescriptionAndClickSaveButton(string description)
        {
            ProfileDescription.AddProfileDescription(description);
        }

        [Then(@"Description not saved successfully")]
        public void ThenDescriptionNotSavedSuccessfully()
        {
        }

        [When(@"user enter Profile Description starting with special character and click Save Button '([^']*)'")]
        public void WhenUserEnterProfileDescriptionStartingWithSpecialCharacterAndClickSaveButton(string description)
        {
            ProfileDescription.AddProfileDescription(description);
        }

        [When(@"user enter Profile Description starting wwith more than (.*) characters and click Save Button '([^']*)'")]
        public void WhenUserEnterProfileDescriptionStartingWwithMoreThanCharactersAndClickSaveButton(int p0, string description)
        {
            ProfileDescription.AddProfileDescription(description);
        }

        [Then(@"only with count (.*) max")]
        public void ThenOnlyWithCountMax(int p0)
        {
        }
    }
}
