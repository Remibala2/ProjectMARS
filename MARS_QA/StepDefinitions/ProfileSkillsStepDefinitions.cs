using MARS_QA.Mars_Pages;
using MARS_QA.Utilities;
using NUnit.Framework;
using System;
using TechTalk.SpecFlow;

namespace MARS_QA.StepDefinitions
{
    [Binding]
    public class ProfileSkillsStepDefinitions : CommonDriver
    {
        [Given(@"click on Add New in Skills in Skills Tab")]
        public void GivenClickOnAddNewInSkillsInSkillsTab()
        {
            login();
            NavigateToProfileSkills();
        }

        [When(@"User enter skill '([^']*)' and Level '([^']*)' and click Add")]
        public void WhenUserEnterSkillAndLevelAndClickAdd(string skillName, string skillLevel)
        {
            ProfileSkills.DeleteAllSkillEntry();
            ProfileSkills.AddNewSkill(skillName, skillLevel);
        }

        [Then(@"New Skill '([^']*)' and '([^']*)' are added to profile successfully")]
        public void ThenNewSkillAndAreAddedToProfileSuccessfully(string skillName, string skillLevel)
        {
            ProfileSkills.SaveNewSkill();
        }

        [Then(@"'([^']*)' ""([^""]*)"" message appears in Skills Page")]
        public void ThenMessageAppearsInSkillsPage(string skillName, string expectedMessage)
        {
            string alertText = ProfileSkills.getAlertText();
            expectedMessage = skillName + " " + expectedMessage;
            Assert.That(alertText, Is.EqualTo(expectedMessage));
            ProfileSkills.DeleteMyLastSkillEntry();
        }

        [Given(@"click on Add New in Skills Tab with existing '([^']*)' '([^']*)'")]
        public void GivenClickOnAddNewInSkillsTabWithExisting(string existingSkillName, string existingSkillLevel)
        {
            login();
            NavigateToProfileSkills();
            ProfileSkills.DeleteAllSkillEntry();
            ProfileSkills.AddNewSkill(existingSkillName, existingSkillLevel);
            ProfileSkills.SaveNewSkill();
        }

        [When(@"User enter existing skill '([^']*)' and Level '([^']*)' and click Add")]
        public void WhenUserEnterExistingSkillAndLevelAndClickAdd(string skillName, string skillLevel)
        {
            ProfileSkills.AddNewSkill(skillName, skillLevel);
            ProfileSkills.SaveNewSkill();
        }

        [Then(@"Skill and Level not added")]
        public void ThenSkillAndLevelNotAdded()
        {
        }

        [Then(@"""([^""]*)"" error message appears in Skills Page")]
        public void ThenErrorMessageAppearsInSkillsPage(string expectedMessage)
        {
            string alertText = ProfileSkills.getAlertText();
            Console.WriteLine(alertText);   
            Assert.That(alertText, Is.EqualTo(expectedMessage));
        }

        [When(@"User enter the existing Skill '([^']*)' and Level '([^']*)' and click Add")]
        public void WhenUserEnterTheExistingSkillAndLevelAndClickAdd(string skillName, string skillLevel)
        {
            ProfileSkills.AddNewSkill(skillName, skillLevel);
            ProfileSkills.SaveNewSkill();
        }

        [Given(@"click on Add New in Skills Tab")]
        public void GivenClickOnAddNewInSkillsTab()
        {
            login();
            NavigateToProfile();
            NavigateToProfileSkills();
        }

        [When(@"User enter Skill empty '([^']*)' and/or Level '([^']*)' and click Add")]
        public void WhenUserEnterSkillEmptyAndOrLevelAndClickAdd(string skillName, string skillLevel)
        {
            ProfileSkills.AddNewSkill(skillName, skillLevel);
            Console.WriteLine("input Skill Name" + skillName);
            Console.WriteLine("Input Skill level" + skillLevel);
            ProfileSkills.SaveNewSkill();
        }

        [When(@"User enter skill '([^']*)' and Level '([^']*)'")]
        public void WhenUserEnterSkillAndLevel(string skillName, string skillLevel)
        {
            ProfileSkills.AddNewSkill(skillName, skillLevel);
            ProfileSkills.SaveNewSkill();
        }

        [When(@"Click on Cancel at Skill Level")]
        public void WhenClickOnCancelAtSkillLevel()
        {
            ProfileSkills.CancelNewSkill();
        }

        [Then(@"New Skill not added to profile")]
        public void ThenNewSkillNotAddedToProfile()
        {
            NavigateToProfileSkills();
        }

        [Given(@"for a skill in Skills Tab '([^']*)'")]
        public void GivenForASkillInSkillsTab(string p0)
        {
            login();
            NavigateToProfileSkills();
        }

        [When(@"User click on X button for a skill '([^']*)'")]
        public void WhenUserClickOnXButtonForASkill(string p0)
        {
            ProfileSkills.DeleteSkill();
        }

        [Then(@"Skill deleted from profile successfully")]
        public void ThenSkillDeletedFromProfileSuccessfully()
        {
        }

        //Edit Skill
        [Given(@"User click on Pen button for a Skill '([^']*)' '([^']*)'")]
        public void GivenUserClickOnPenButtonForASkill(string oldSkillName, string oldSkillLevel)
        {
            login();
            NavigateToProfileSkills();
            ProfileSkills.AddNewSkill(oldSkillName, oldSkillLevel);
            ProfileSkills.SaveNewSkill();
            ProfileSkills.ClickEditSkillButton(oldSkillName, oldSkillLevel);
        }

        [When(@"User enter new Skills '([^']*)' , '([^']*)' and click Update button")]
        public void WhenUserEnterNewSkillsAndClickUpdateButton(string newSkillName, string newSkillLevel)
        {
            ProfileSkills.EditSkill(newSkillName, newSkillLevel);
        }

        [Then(@"Skill changes saved to profile successfully")]
        public void ThenSkillChangesSavedToProfileSuccessfully()
        {
            ProfileSkills.UpdateSkill();
        }

        [When(@"User enter new Skills '([^']*)' , '([^']*)'")]
        public void WhenUserEnterNewSkills(string skillName, string skillLevel)
        {
            ProfileSkills.EditSkill(skillName,skillLevel);
        }

        [When(@"Click on Cancel Button in Update Skill")]
        public void WhenClickOnCancelButtonInUpdateSkill()
        {
            ProfileSkills.CancelUpdateSkill();
        }

        [Then(@"Skill changes not saved to profile")]
        public void ThenSkillChangesNotSavedToProfile()
        {
        }
    }
}
