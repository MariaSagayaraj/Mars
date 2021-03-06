﻿using NUnit.Framework;
using OpenQA.Selenium;
using Project_MARS.Specflow.Helpers;
using Project_MARS.Specflow.Pages;
using System;
using System.Threading;
using TechTalk.SpecFlow;

namespace Project_MARS.Hookup
{
    [Binding]
    public class DescriptionSteps : Drivers
    {
        [Given(@"I click on the edit button of Description")]
        public void GivenIClickOnTheEditButtonOfDescription()
        {
            TurnOnWait();
            Profile.DescriptionIcon.Click();
        }

        [Given(@"I enter the description (.*)")]
        public void GivenIEnterTheDescription(string description)
        {
            Profile.DescriptionText.Click();
            Profile.DescriptionText.Clear();
            Profile.DescriptionText.SendKeys(description);
        }

        [When(@"I click on Save button")]
        public void GivenIClickOnSaveButton()
        {
            Profile.SaveDescriptionButton.Click();
        }

        [Then(@"I validate that the description has been added successfully")]
        public void ThenIValidateThatTheDescriptionHasBeenAddedSuccessfully()
        {
            Profile.FlashMessageDescription();
        }

    }
}
