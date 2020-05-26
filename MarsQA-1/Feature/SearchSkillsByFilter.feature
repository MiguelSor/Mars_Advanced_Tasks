Feature: SearchSkillsByFilter
	In order to test the filters on search skill page	
	As a test analyst	
	I want to automate user interactions with the filters

@mytag
Scenario: Navigate to Search Skills Page
	Given I login to the website
	When I click on programming and tech
	Then I am directed to search skills page

Scenario: Check if filters is visible to the user
	Given I login to the website
	And I clicked on programming and tech
	When scroll down to the filters
	Then filters should be visible to the user

Scenario: Check if user is able to click on Online Filter
	Given I login to the website
	And I clicked on programming and tech
	When scroll down to the filters
	Then I click on Online filter

Scenario: Check if result has location as Online
	Given I login to the website
	And I clicked on programming and tech
	When I click on one of the results
	Then the results should be online

Scenario: Check if user is able to click Onsite Filter
	Given I login to the website
	And I clicked on programming and tech
	When I scroll down to filters
	Then I click on Onsite filter

Scenario: Check if result has location as onsite
	Given I login to the website
	And I clicked on programming and tech
	When I click on onsite filter and onsite result
	Then the location type of result should be onsite

Scenario: Check if user is able to click on Show All Filter
	Given I login to the website
	And I clicked on programming and tech
	When I scroll down to filters
	Then I click on Show All Filter

Scenario: Check if result has location as either onsite or online
	Given I login to the website
	And I clicked on programming and tech
	When I click on show all filter and the first result
	Then the location type should be either onsite or online
