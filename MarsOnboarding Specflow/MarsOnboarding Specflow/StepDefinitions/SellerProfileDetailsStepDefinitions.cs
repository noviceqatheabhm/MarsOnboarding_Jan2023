using MarsOnboarding_Specflow.Utilities;
using OpenQA.Selenium;
using NUnit.Framework;
using OpenQA.Selenium.Chrome;
using System;
using System.Reflection.Emit;
using TechTalk.SpecFlow;

namespace MarsOnboarding_Specflow.Pages
{
    [Binding]
    public class SellerProfileDetailsStepDefinitions : CommonDriver
    {
        LoginPage loginPageObj;

        UserLanguage LanguagePageObj = new UserLanguage();
        UserSkills skillsPageObj = new UserSkills();
        UserCertification certificationObj = new UserCertification();

        //Constructor
        public SellerProfileDetailsStepDefinitions()
        {
            loginPageObj= new LoginPage(); 
        }


        [Given(@"User logs in to the website")]
        public void GivenUserLogsInToTheWebsite()
        {
           loginPageObj.LoginActions();
        }

        [When(@"User adds a '([^']*)' and '([^']*)'")]
        public void WhenUserAddsAAnd(string language, string languageLevel)
        {
            LanguagePageObj.CreateLanguages(language, languageLevel);
        }

        [Then(@"the '([^']*)' and '([^']*)' is added successfully on the profile")]
        public void ThenTheAndIsAddedSuccessfullyOnTheProfilee(string language, string languageLevel)
        {
            LanguagePageObj.CheckLangugaeAdded(language, languageLevel);
        }

        [When(@"User updates a '([^']*)' and '([^']*)'")]
        public void WhenUserUpdatesAAnd(string german, string basic)
        {
            throw new PendingStepException();
        }

        [Then(@"The '([^']*)' and '([^']*)' is updated successfully on the profile")]
        public void ThenTheAndIsUpdatedSuccessfullyOnTheProfile(string german, string basic)
        {
            throw new PendingStepException();
        }

        [When(@"User deletes a language")]
        public void WhenUserDeletesALanguage()
        {
            throw new PendingStepException();
        }

        [Then(@"The language is deleted successfully from the user profile")]
        public void ThenTheLanguageIsDeletedSuccessfullyFromTheUserProfile()
        {
            throw new PendingStepException();
        }

        [When(@"Language Field is left blank")]
        public void WhenLanguageFieldIsLeftBlank()
        {
            throw new PendingStepException();
        }

        [Then(@"Error message should be displayed")]
        public void ThenErrorMessageShouldBeDisplayed()
        {
            throw new PendingStepException();
        }

        [When(@"User adds a Description")]
        public void WhenUserAddsADescription()
        {
            throw new PendingStepException();
        }

        [Then(@"the description is added successfully")]
        public void ThenTheDescriptionIsAddedSuccessfully()
        {
            throw new PendingStepException();
        }

        [When(@"User updates new description")]
        public void WhenUserUpdatesNewDescription()
        {
            throw new PendingStepException();
        }

        [Then(@"the description is updated successfully")]
        public void ThenTheDescriptionIsUpdatedSuccessfully()
        {
            throw new PendingStepException();
        }

        [When(@"User leaves a blank description")]
        public void WhenUserLeavesABlankDescription()
        {
            throw new PendingStepException();
        }

        [Then(@"Description is deleted successfully")]
        public void ThenDescriptionIsDeletedSuccessfully()
        {
            throw new PendingStepException();
        }

        [When(@"Description Field is left blank")]
        public void WhenDescriptionFieldIsLeftBlank()
        {
            throw new PendingStepException();
        }

        [When(@"User adds a '([^']*)' and '([^']*)'")]
        public void WhenUserAddsAAnnd(string skill, string Level)
        {
            //
            skillsPageObj.CreateSkills(skill, Level);
        }

        [Then(@"the '([^']*)' and '([^']*)' is added successfully on the profile")]
        public void ThenTheAndIsAddedSuccessfullyOnTheProfile(string skill, string Level)
        {
            //
            skillsPageObj.CheckSkillAdded(skill, Level);
        }

        [When(@"User updates a skill")]
        public void WhenUserUpdatesASkill()
        {
            throw new PendingStepException();
        }

        [Then(@"Skill is updated successfully")]
        public void ThenSkillIsUpdatedSuccessfully()
        {
            throw new PendingStepException();
        }

        [When(@"User deletes a skill")]
        public void WhenUserDeletesASkill()
        {
            throw new PendingStepException();
        }

        [Then(@"Skill is deleted successfully")]
        public void ThenSkillIsDeletedSuccessfully()
        {
            throw new PendingStepException();
        }

        [When(@"Skill Field is left blank")]
        public void WhenSkillFieldIsLeftBlank()
        {
            throw new PendingStepException();
        }

        [When(@"User adds a Education")]
        public void WhenUserAddsAEducation()
        {
            throw new PendingStepException();
        }

        [Then(@"Education is added successfully")]
        public void ThenEducationIsAddedSuccessfully()
        {
            throw new PendingStepException();
        }

        [When(@"User updates the Education")]
        public void WhenUserUpdatesTheEducation()
        {
            throw new PendingStepException();
        }

        [Then(@"Education is updated successfully")]
        public void ThenEducationIsUpdatedSuccessfully()
        {
            throw new PendingStepException();
        }

        [When(@"User deletes Education")]
        public void WhenUserDeletesEducation()
        {
            throw new PendingStepException();
        }

        [Then(@"Education is deleted successfully")]
        public void ThenEducationIsDeletedSuccessfully()
        {
            throw new PendingStepException();
        }

        
        [When(@"User adds a '([^']*)' and '([^']*)' and '([^']*)'")]
        public void WhenUserAddsAAndAnd(string Certificate, string From, string Year)
        {
            //
            certificationObj.CreateCertifications(Certificate, From, Year);
        }

        [Then(@"the '([^']*)' and '([^']*)' and '([^']*)' is added successfully on the profile")]
        public void ThenTheAndAndIsAddedSuccessfullyOnTheProfile(string Certificate, string From, string Year)
        {
            certificationObj.CheckCertificationAdded(Certificate, From, Year);
        }

        [When(@"User updates a new certification")]
        public void WhenUserUpdatesANewCertification()
        {
            throw new PendingStepException();
        }

        [Then(@"the certification is updated successfully")]
        public void ThenTheCertificationIsUpdatedSuccessfully()
        {
            throw new PendingStepException();
        }

        [When(@"User deletes a new certification")]
        public void WhenUserDeletesANewCertification()
        {
            throw new PendingStepException();
        }

        [Then(@"the certification is deleted successfully")]
        public void ThenTheCertificationIsDeletedSuccessfully()
        {
            throw new PendingStepException();
        }

        [When(@"User edits to change the availability")]
        public void WhenUserEditsToChangeTheAvailability()
        {
            throw new PendingStepException();
        }

        [Then(@"the user availability is updated successfully on the user profile")]
        public void ThenTheUserAvailabilityIsUpdatedSuccessfullyOnTheUserProfile()
        {
            throw new PendingStepException();
        }

        [When(@"User edits to change the availability and then cancels")]
        public void WhenUserEditsToChangeTheAvailabilityAndThenCancels()
        {
            throw new PendingStepException();
        }

        [When(@"User changes the Hours")]
        public void WhenUserChangesTheHours()
        {
            throw new PendingStepException();
        }

        [Then(@"the user hours is updated successfully on the user profile")]
        public void ThenTheUserHoursIsUpdatedSuccessfullyOnTheUserProfile()
        {
            throw new PendingStepException();
        }

        [When(@"User changes the earn target")]
        public void WhenUserChangesTheEarnTarget()
        {
            throw new PendingStepException();
        }
    }
}