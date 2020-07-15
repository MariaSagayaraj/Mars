using BoDi;
using OpenQA.Selenium;
using Project_MARS.Specflow.Helpers;
using Project_MARS.Specflow.Pages;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TechTalk.SpecFlow;

namespace Project_MARS.Hookup
{
    [Binding]
        public class SignInSteps : Drivers
        {
          
            [Given(@"I loginto the mars portal using the credentials (.*),(.*)")]
            public void GivenILogintoTheMarsPortalUsingTheCredentials(string username, string password)
            {
                Initialize();
                NavigateUrl();
                SignIn signin = new SignIn();
                signin.Login(username, password);
            }

            [Then(@"I validate that I logged into the portal successfully")]
            public void ThenIvalidateThatILoggedIntoThePortalSuccessfully()
            {
                SignIn.LoginPageValidation();
                driver.Quit();
            }

        }

    }

       