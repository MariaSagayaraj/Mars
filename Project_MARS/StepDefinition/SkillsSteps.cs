﻿using NUnit.Framework;
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
    public class SkillsSteps : Drivers
    {
        [Given(@"I click on the skills tab")]
        public void GivenIClickOnTheSkillsTab()
        {
            TurnOnWait();
            Profile.SkillsTab.Click();
        }

        [Given(@"I click on Add New button of skills tab")]
        public void GivenIClickOnAddNewButtonofskillstab()
        {
            TurnOnWait();
            Profile.AddnewSkillButton.Click();
        }

        [Given(@"I enter the skill details (.*),(.*)")]
        public void GivenIEnterTheSkillDetails(string skill, string skilllevel)
        {
            TurnOnWait();
            Profile.AddSkillText.SendKeys(skill);
            SelectElement selectElement = new SelectElement(Profile.SelectSkillLevel);
            selectElement.SelectByText(skilllevel);
        }

        
        [Given(@"I edit the skill details (.*),(.*)")]
        public void GivenIEditTheSkillDetails(string skill, string editSkill)
        {
            TurnOnWait();
            Profile.SkillUpdate(skill, editSkill);
        }

        [Given(@"I click on Delete button of skills tab (.*)")]
        public void GivenIClickOnDeleteButtonofskillstab(string deleteskill)
        {
            TurnOnWait();
            Profile.SkillDelete(deleteskill);
        }

        [When(@"I click on Add button of skills tab")]
        public void ThenIClickOnAddButtonofskillstab()
        {
            TurnOnWait();
            Profile.AddSkillbutton.Click();
        }

        [Then(@"I validate that the new skill has been added successfully (.*)")]
        public void ThenIValidateThatTheNewSkillHasBeenAddedSuccessfully(string skill)
        {
            TurnOnWait();
            Profile.FlashMessage(skill);
        }

        [When(@"I click on the Update button of skills tab")]
        public void ThenIClickOnTheUpdateButtonofskillstab()
        {
            TurnOnWait();
            Profile.UpdateSkillButton.Click();
        }

        [Then(@"I validate that the skill has been edited successfully (.*)")]
        public void ThenIValidateThatTheSkillHasBeenEditedSuccessfully(string EditSkill)
        {
            TurnOnWait();
            Profile.FlashMessage(EditSkill);
        }

        [Then(@"I validate that the skill has been deleted successfully (.*)")]
        public void ThenIValidateThatTheSkillHasBeenDeletedSuccessfully(string deleteskill)
        {
            TurnOnWait();
            Profile.FlashMessage(deleteskill);
        }
    }
}

