using Microsoft.VisualStudio.TestPlatform.CommunicationUtilities;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using Project_MARS.Specflow.Helpers;
using Project_MARS.Specflow.Pages;
using System;
using System.Threading;
using TechTalk.SpecFlow;

namespace Project_MARS.Hookup
{
    [Binding]
    public class LanguageSteps : Drivers
    {
        [Given(@"I click on the Language tab")]
        public void GivenIClickOnTheLanguageTab()
        {
            TurnOnWait();
            Profile.LanguagesTab.Click();
        }

        [Given(@"I click on Add New button of Language tab")]
        public void GivenIClickOnAddNewButtonOfLanguageTab()
        {
            TurnOnWait();
            Profile.AddnewLanguageButton.Click();
        }

        [Given(@"I enter the language details (.*),(.*)")]
        public void GivenIEnterTheLanguageDetails(string language, string languagelevel)
        {
            TurnOnWait();
            Profile.AddLanguageText.SendKeys(language);
            SelectElement selectElement = new SelectElement(Profile.SelectLanguageLevel);
            selectElement.SelectByText(languagelevel);
        }


        [Given(@"I edit the language details (.*),(.*)")]
        public void GivenIEditTheLanguageDetails(string language, string editLanguage)
        {
            TurnOnWait();
            Profile.LanguageUpdate(language, editLanguage);

        }

        [When(@"I click on Delete button of Language tab (.*)")]
        public void GivenIClickOnDeleteButtonOfLanguageTab(string deletelanguage)
        {
            TurnOnWait();
            Profile.LanguageDelete(deletelanguage);
        }

        [When(@"I click on Add button of Language tab")]
        public void ThenIClickOnAddButtonOfLanguageTab()
        {
            TurnOnWait();
            Profile.AddLanguagebutton.Click();
        }

        [Then(@"I validate that the new language has been added successfully (.*)")]
        public void ThenIValidateThatTheNewLanguageHasBeenAddedSuccessfully(string language)
        {
            TurnOnWait();
            Profile.FlashMessage(language);
        }

        [When(@"I click on the Update button of Language tab")]
        public void ThenIClickOnTheUpdateButtonOfLanguageTab()
        {
            TurnOnWait();
            Profile.UpdateLanguageButton.Click();
        }

        [Then(@"I validate that the language has been edited successfully (.*)")]
        public void ThenIValidateThatTheLanguageHasBeenEditedSuccessfully(string Editlanguage)
        {
            TurnOnWait();
            Profile.FlashMessage(Editlanguage);
        }

        [Then(@"I validate that the language has been deleted successfully (.*)")]
        public void ThenIValidateThatTheLanguageHasBeenDeletedSuccessfully(string deletelanguage)
        {
            TurnOnWait();
            Profile.FlashMessage(deletelanguage);
        }

    }
}

