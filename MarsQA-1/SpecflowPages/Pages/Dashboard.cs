using MarsQA_1.Helpers;
using NUnit.Framework;
using NUnit.Framework.Constraints;
using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;
using OpenQA.Selenium.Support.Events;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace MarsQA_1.SpecflowPages.Pages
{
    class Dashboard
    {
        private static IWebElement DashboardBtn => Driver.driver.FindElement(By.XPath("//a[@class='item'][contains(.,'Dashboard')]"));

        private static IWebElement LoadMoreBtn => Driver.driver.FindElement(By.XPath("//a[@class='ui button'][contains(.,'Load More...')]"));

        private static IWebElement ShowLessBtn => Driver.driver.FindElement(By.XPath("//a[@class='ui button'][contains(.,'...Show Less')]"));

        private static IWebElement CheckBox => Driver.driver.FindElement(By.XPath("//input[@value='0']"));

        private static IWebElement UiMenu => Driver.driver.FindElement(By.XPath("//div[@class='ui menu']"));

        private static IWebElement DeleteBtn => Driver.driver.FindElement(By.XPath("//i[contains(@class,'trash icon')]"));

        private static IWebElement SelectAllBtn => Driver.driver.FindElement(By.XPath("//i[contains(@class,'mouse pointer icon')]"));

        private static IWebElement UnSelectAllBtn => Driver.driver.FindElement(By.XPath("//div[contains(@data-tooltip,'Unselect all')]"));

        private static IWebElement MarkSelectionAsReadBtn => Driver.driver.FindElement(By.XPath("//div[contains(@data-tooltip,'Mark selection as read')]"));
        public static void ClickOnDashboard()
        {
            //waits for the dashboard button to be available
            WebDriverWait wait = new WebDriverWait(Driver.driver, TimeSpan.FromSeconds(10));
            wait.Until(ExpectedConditions.ElementIsVisible(By.XPath("//a[@class='item'][contains(.,'Dashboard')]")));
           
            //clicks on the dashboard button
            DashboardBtn.Click();

        }

        public static void ClickLoadMore()
        {
            //can also be used for testcase_19_04
            //waits for the web element to load
            WebDriverWait wait = new WebDriverWait(Driver.driver, TimeSpan.FromSeconds(10));
            wait.Until(ExpectedConditions.ElementIsVisible(By.XPath("//a[@class='ui button'][contains(.,'Load More...')]")));

            String ExpectedResult = LoadMoreBtn.Text;
            String ActualResult = "Load More...";
            Assert.That(ExpectedResult, Is.EqualTo(ActualResult));
            //clicks the load more button
            LoadMoreBtn.Click();
            //scrolls to load more button and highlights the button
            Actions action = new Actions(Driver.driver);
            action.MoveToElement(LoadMoreBtn);
            action.Perform();
            Driver.TurnOnWait();
            //waits for 1.5 seconds
            Driver.TurnOnWait();
        }

        public static void ShowLessIsVisible()
        {
            //Also is used for testcase_18_03 hover effect on show less

            //clicks on load more button
            ClickLoadMore();

            //waits for the web element to load
            WebDriverWait wait = new WebDriverWait(Driver.driver, TimeSpan.FromSeconds(10));
            wait.Until(ExpectedConditions.ElementIsVisible(By.XPath("//a[@class='ui button'][contains(.,'...Show Less')]")));


            //Checks if show less button is displayed
            if (ShowLessBtn.Displayed)
            {
                //scrolls the page to show less button
                Actions action = new Actions(Driver.driver);
                action.MoveToElement(ShowLessBtn);
                action.Perform();
                //waits for 1.5 sec
                Driver.TurnOnWait();
            }
        }

        public static void ShowLessIsClickable()
        {
            //clicks on load more button
            ClickLoadMore();

            //waits for the web element to load
            WebDriverWait wait = new WebDriverWait(Driver.driver, TimeSpan.FromSeconds(10));
            wait.Until(ExpectedConditions.ElementIsVisible(By.XPath("//a[@class='ui button'][contains(.,'...Show Less')]")));

            //clicks on show less button
            ShowLessBtn.Click();

            //waits for 1.5 sec
            Driver.TurnOnWait();
        }

        public static void ShowLessResults()
        { 
            WebDriverWait wait = new WebDriverWait(Driver.driver, TimeSpan.FromSeconds(10));
            wait.Until(ExpectedConditions.ElementIsVisible(By.XPath("//a[@class='ui button'][contains(.,'...Show Less')]")));
            
            if(ShowLessBtn.Displayed)
            {
                ShowLessIsClickable();
            }
            else
            {
                Actions action = new Actions(Driver.driver);
                action.MoveToElement(LoadMoreBtn);
                action.Perform();
                Driver.TurnOnWait();
            }
        }

        public static void LoadMoreisVisible()
        {
            //waits for the element to load
            WebDriverWait wait = new WebDriverWait(Driver.driver,TimeSpan.FromSeconds(10));
            //waits until element is visible
            wait.Until(ExpectedConditions.ElementIsVisible(By.XPath("//a[@class='ui button'][contains(.,'Load More...')]")));

            //Verifies if the button visible
            String expectedResult = LoadMoreBtn.Text;
            String actualResult = "Load More";
            if (expectedResult == actualResult)
            {
                //scroll the webpage to locate load more button
                Actions action = new Actions(Driver.driver);
                action.MoveToElement(LoadMoreBtn);
                action.Perform();
                Driver.TurnOnWait();
            }
        }

        public static void LoadMoreResults()
        { 
            //wait for element to be visible on the page
            WebDriverWait wait = new WebDriverWait(Driver.driver,TimeSpan.FromSeconds(10));
            wait.Until(ExpectedConditions.ElementIsVisible(By.XPath("//a[@class='ui button'][contains(.,'Load More...')]")));

            //if both elements are present then there are more than 4 results on notifications
            if(LoadMoreBtn.Displayed && ShowLessBtn.Displayed )
            {
                //scroll the webpage to the web element for the screenshot
                Actions action = new Actions(Driver.driver);
                action.MoveToElement(LoadMoreBtn);
                action.Perform();
                Driver.TurnOnWait();
            }
        }

        public static void CheckboxShouldBeVisible()
        {
            //wait for the element to load
            WebDriverWait wait = new WebDriverWait(Driver.driver,TimeSpan.FromSeconds(10));
            //wait until the checkbox is visible in the webpage
            wait.Until(ExpectedConditions.ElementIsVisible(By.XPath("//input[@value='0']")));
            //wait for 1.5 seconds for screenshot
            Driver.TurnOnWait();
        }

        public static void CheckboxShouldBeClickable()
        {
            //wait for the element to load
            WebDriverWait wait = new WebDriverWait(Driver.driver, TimeSpan.FromSeconds(10));
            //wait until the checkbox is visible in the webpage
            wait.Until(ExpectedConditions.ElementIsVisible(By.XPath("//input[@value='0']")));
            //clicks on the checkbox
            CheckBox.Click();
            
        }

        public static void UIMenuShouldBeVisible()
        {
            //wait for the element to load
            WebDriverWait wait = new WebDriverWait(Driver.driver, TimeSpan.FromSeconds(10));
            //wait until UI menu is visibles
            wait.Until(ExpectedConditions.ElementIsVisible(By.XPath("//div[@class='ui menu']")));
            //waits for 1.5 seconds for screenshot
            Driver.TurnOnWait();

        }

        public static void DeleteButtonShouldBeVisible()
        {
            //wait for the element to load
            WebDriverWait wait = new WebDriverWait(Driver.driver, TimeSpan.FromSeconds(10));
            //wait until delete button is visible
            wait.Until(ExpectedConditions.ElementIsVisible(By.XPath("//i[contains(@class,'trash icon')]")));
            //waits for 1.5 seconds for screenshot
            Driver.TurnOnWait();
        }

        public static void DeleteButtonShouldBeClickable()
        {
            //wait for the element to load
            WebDriverWait wait = new WebDriverWait(Driver.driver, TimeSpan.FromSeconds(10));
            //wait until delete button is visible
            wait.Until(ExpectedConditions.ElementIsVisible(By.XPath("//i[contains(@class,'trash icon')]")));
            //click on the delete button
            DeleteBtn.Click();
        }

        public static void MarkAsReadShouldBeVisible()
        {
            //wait for the element to load
            WebDriverWait wait = new WebDriverWait(Driver.driver, TimeSpan.FromSeconds(10));
            //wait until mark selection as read is visible
            wait.Until(ExpectedConditions.ElementIsVisible(By.XPath("//div[contains(@data-tooltip,'Mark selection as read')]")));
            //wait for 1.5 seconds for screenshot
            Driver.TurnOnWait();
        }

        public static void CheckboxIsUnchecked()
        {
            //wait for the element to load
            WebDriverWait wait = new WebDriverWait(Driver.driver, TimeSpan.FromSeconds(10));
            //wait until mark selection as read is visible
            wait.Until(ExpectedConditions.ElementIsVisible(By.XPath("//input[@value='0']")));

            if(!CheckBox.Selected)
            {
                Console.WriteLine("Checkbox is unchecked");
                Driver.TurnOnWait();
            }

        }

        public static void UiMenuIsNotVisible()
        {
            //wait for the element to load
            WebDriverWait wait = new WebDriverWait(Driver.driver, TimeSpan.FromSeconds(10));
            //wait until mark selection as read is visible
            wait.Until(ExpectedConditions.ElementIsVisible(By.XPath("//input[@value='0']")));

            if(!UiMenu.Displayed)
            {
                Console.WriteLine("UI menu is not visible");
                Driver.TurnOnWait();
            }
        }
    }
}
