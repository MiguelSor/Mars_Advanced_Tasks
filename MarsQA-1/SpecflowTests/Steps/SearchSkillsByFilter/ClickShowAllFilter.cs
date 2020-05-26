using MarsQA_1.Helpers;
using MarsQA_1.SpecflowPages.Pages;
using System;
using System.Threading;
using TechTalk.SpecFlow;

namespace MarsQA_1.SpecflowTests.Steps.SearchSkillsByFilter
{
    [Binding]
    public class ClickShowAllFilter
    {
        [Then(@"I click on Show All Filter")]
        public void ThenIClickOnShowAllFilter()
        {
            //wait for elements to load
            Driver.TurnOnWait();
            //click on show all filter
            SearchSkillPage.ClickShowAllBtn();
            //wait for screenshot
            Thread.Sleep(1500);
        }
    }
}
