Feature: MyAccount


@SmokeTest
Scenario: TC02A. Check user can change Personal details
	Given I am on the home page
	When I click Account menu Login link
	And I enter my Login Name and Password
	And I click Login
	And I click Edit account details
	Then My Account Information page appears
	When I change my First Name, Last Name, and Telephone number
	And I click Continue to save Your Personal Details 
	Then "Success: Your account has been successfully updated." alert notification appears
	And Name beside My Account header updates with new name
	And Welcome back on Header updates with new name
	When I click Edit account details
	Then My Acount Information page appears with correct field values