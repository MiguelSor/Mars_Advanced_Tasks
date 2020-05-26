using MarsQA_1.SpecflowPages.Pages;
using System;
using TechTalk.SpecFlow;

namespace MarsQA_1.SpecflowTests.Steps.NotificationsShowLess
{
    [Binding]
    public class LoadMoreShouldBeClickable
    {
        [Then(@"load more button should be clickable")]
        public void ThenLoadMoreButtonShouldBeClickable()
        {
            Dashboard.ClickLoadMore();
        }
    }
}
