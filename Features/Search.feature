Feature: Search


@SmokeTest
Scenario: TC05A. Check user can search a keyword that matches search criteria
	Given I am on the home page
	When I enter "shirt" keyword on the header search box
	And I click the magnifying lens button
	Then I see search results
	When I enter "perfume" keyword on the search criteria box
	And I click Search button
	Then I see search results


@SmokeTest
Scenario Outline: TC05B. Check user cannot search a keyword that does not match search criteria
	Given I am on the home page
	When I enter an invalid '<keyword1>' on the header search box
	And I click the magnifying lens button
	Then I see search results returns with no matches message
	When I enter an invalid '<keyword2>' on the search criteria box
	And I click Search button
	Then I see search results returns with no matches message

	Examples: 
	| keyword1                                                           | keyword 2 |
	| <script>alert("YOU GOT HACKED by Javascript injection!");</script> | *         |
	| chat.openai.com                                                    |           |