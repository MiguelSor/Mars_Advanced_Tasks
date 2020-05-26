using MarsQA_1.SpecflowPages.Pages;
using System;
using TechTalk.SpecFlow;

namespace MarsQA_1.SpecflowTests.Steps.NotificationLoadMore
{
    [Binding]
    public class LoadMoreResults
    {
        [When(@"I click on load more button")]
        public void WhenIClickOnLoadMoreButton()
        {
            Dashboard.ClickLoadMore();
        }
        
        [Then(@"there should be more results")]
        public void ThenThereShouldBeMoreResults()
        {
            Dashboard.LoadMoreResults();
        }
    }
}
