using MarsQA_1.SpecflowPages.Pages;
using System;
using TechTalk.SpecFlow;

namespace MarsQA_1.SpecflowTests.Steps.NotificationsShowLess
{
    [Binding]
    public class LoadMoreShouldBeVisible
    {
        [Then(@"load more button should be visible")]
        public void ThenLoadMoreButtonShouldBeVisible()
        {
            //Navigates to User Dashboard to verify if Load More Button is visible
            Dashboard.LoadMoreisVisible();
        }
    }
}
