Feature: AccountLogin

Account Login allows a user to register/login. 
A logged in user can do more functionalities compared to a guest user.

@tag1
Scenario: User can login
	Given I am in the home page
	When I click Login or Register link
	Then My Account page appears
	When I enter my user credentials
	Then My Account Dashboard appears with a welcome message
