using MarsQA_1.SpecflowPages.Pages;
using System;
using TechTalk.SpecFlow;

namespace MarsQA_1.SpecflowTests.Steps.SearchSkillsByFilter
{
    [Binding]
    public class NotificationsShowIsVisible
    {
        [Given(@"I click on the dashboard")]
        public void GivenIClickOnTheDashboard()
        {
            //waits for the dashboad button to be visible and clicks on the dashboard button
            Dashboard.ClickOnDashboard();
        }
        
        [When(@"I click on load more button on notifications")]
        public void WhenIClickOnLoadMoreButtonOnNotifications()
        {
            //waits and then clicks on the load more button
            Dashboard.ClickLoadMore();
        }
        
        [Then(@"show less should be visible")]
        public void ThenShowLessShouldBeVisible()
        {
            //waits and verifies if the show less button is visible
            Dashboard.ShowLessIsVisible();
        }
    }
}
