Feature: NotificationMarkAsRead
	In order to check the website mark as read button for notifications
	As a test analyst
	I want to automate the testcases for the mark as read button

@mytag
Scenario: Mark as read should be visible to user
	Given I login to the website
	And I click on the dashboard
	When I click on the checkbox
	Then mark as read should be visible

Scenario: UI menu not visible when checkbox is unchecked
	Given I login to the website
	And I click on the dashboard
	When checkbox is unchecked
	Then UI menu is not visible
