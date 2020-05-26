using MarsQA_1.SpecflowPages.Pages;
using System;
using TechTalk.SpecFlow;

namespace MarsQA_1.SpecflowTests.Steps.NotificationsShowLess
{
    [Binding]
    public class ShowLessResults
    {
        [Then(@"show less button should not ne visible")]
        public void ThenShowLessButtonShouldNotNeVisible()
        {
            Dashboard.ShowLessResults();
        }
    }
}
