Feature: Login

@SmokeTest
Scenario: TC01A. Check if user can login and logout
	Given I am on the home page
	When I click Login or register
	Then Account Login page appears
	When I enter my Login Name and Password
	And I click Login
	Then My Account page appears with a Welcome back message
	When I click Logoff
	Then Account Logout page appears
