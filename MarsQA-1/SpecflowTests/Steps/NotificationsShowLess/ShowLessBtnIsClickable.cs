using MarsQA_1.SpecflowPages.Pages;
using System;
using TechTalk.SpecFlow;

namespace MarsQA_1.SpecflowTests.Steps.NotificationsShowLess
{
    [Binding]
    public class ShowLessBtnIsClickable
    {
        [Then(@"user should be able to click on show less button")]
        public void ThenUserShouldBeAbleToClickOnShowLessButton()
        {
            Dashboard.ShowLessIsClickable();
        }
    }
}
