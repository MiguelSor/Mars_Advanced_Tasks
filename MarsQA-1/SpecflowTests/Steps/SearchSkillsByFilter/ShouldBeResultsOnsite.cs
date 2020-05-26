using MarsQA_1.Helpers;
using MarsQA_1.SpecflowPages.Pages;
using System;
using System.Threading;
using TechTalk.SpecFlow;

namespace MarsQA_1.SpecflowTests.Steps.SearchSkillsByFilter
{
    [Binding]
    public class ShouldBeResultsOnsite
    {
        [When(@"I click on onsite filter and onsite result")]
        public void WhenIClickOnOnsiteFilterAndOnsiteResult()
        {
            //Click on onsite filter
            SearchSkillPage.ClickOnSiteBtn();
            //wait for elements to load
            Driver.TurnOnWait();
            //click on the first result
            SearchSkillPage.ClickResultBtn();
        }
        
        [Then(@"the location type of result should be onsite")]
        public void ThenTheLocationTypeOfResultShouldBeOnsite()
        {
            //wait for elements to load
            Driver.TurnOnWait();
            //Check if location type is onsite
            ServiceDetail.LocationOnsite();
            //wait for the screenshot
            Thread.Sleep(1500);
        }
    }
}
