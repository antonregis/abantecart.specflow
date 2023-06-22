Feature: Search


@SmokeTest
Scenario: TC05A. Check user can search a keyword that matches search criteria
	Given I am on the home page
	When I enter "shirt" keyword on header search box
	And I click the magnifying lens button
	Then I see search results
	When Enter "perfume" keyword on the search criteria box
	And I click Search button
	Then I see search results