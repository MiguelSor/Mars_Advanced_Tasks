using MarsQA_1.Helpers;
using MarsQA_1.SpecflowPages.Pages;
using OpenQA.Selenium;
using System;
using System.Threading;
using TechTalk.SpecFlow;

namespace MarsQA_1.SpecflowTests.Steps.SearchSkillsByFilter
{
    [Binding]
    public class ShouldBeResultsOnline
    {
        [When(@"I click on one of the results")]
        public void WhenIClickOnOneOfTheResults()
        {
            //Click on online button
            SearchSkillPage.ClickOnlineBtn();
            //wait for 1.5 seconds
            Thread.Sleep(1500);
            //Click the first result
            SearchSkillPage.ClickResultBtn();
        }
        
        [Then(@"the results should be online")]
        public void ThenTheResultsShouldBeOnline()
        {
            //Check if the location type in Online
            ServiceDetail.LocationOnline();
            //wait for screenshot for test reports
            Driver.TurnOnWait();
            
        }
    }
}
