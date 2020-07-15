using MongoDB.Driver.Core.Authentication;
using Project_MARS.Specflow.Helpers;
using System;
using System.Collections.Generic;
using System.Text;
using TechTalk.SpecFlow;

namespace Project_MARS.Specflow.Pages
{
    [Binding]
    class Start : Drivers
    {
        [BeforeScenario]
        public void Setup()
        {
            //launch the browser
            Initialize();
            NavigateUrl();
            //call the login class
            SignIn signin = new SignIn();
            signin.Login("maria.saronia@gmail.com","123456");
        }

        [AfterScenario]
        public void TearDown()
        {
            driver.Quit();
        }
    }
}
