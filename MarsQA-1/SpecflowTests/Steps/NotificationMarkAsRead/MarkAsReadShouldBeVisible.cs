using MarsQA_1.SpecflowPages.Pages;
using System;
using TechTalk.SpecFlow;

namespace MarsQA_1.SpecflowTests.Steps.NotificationDelete
{
    [Binding]
    public class MarkAsReadShouldBeVisible
    {
        [Then(@"mark as read should be visible")]
        public void ThenMarkAsReadShouldBeVisible()
        {
            Dashboard.MarkAsReadShouldBeVisible();
        }
    }
}
