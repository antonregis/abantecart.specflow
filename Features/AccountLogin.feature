Feature: AccountLogin


Scenario: User can login and logout
	Given I am in the home page
	When I click Login
	Then Account login page appears
	When I enter my user credentials anc click Login
	Then My Account Dashboard appears with a welcome message
	When I click Logoff
	Then Account logout message appears
