using MarsQA_1.Helpers;
using MarsQA_1.SpecflowPages.Pages;
using OpenQA.Selenium;
using System;
using TechTalk.SpecFlow;

namespace MarsQA_1.Feature
{
    [Binding]
    public class ClickOnlineFilter
    {
        [Then(@"I click on Online filter")]
        public void ThenIClickOnOnlineFilter()
        {
            //Clicks on the online filter button
            SearchSkillPage.ClickOnlineBtn();
            //waits for 3 seconds to get a screenshot
            Driver.TurnOnWait();
        }
    }
}
