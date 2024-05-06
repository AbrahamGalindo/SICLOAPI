Feature: Auth
	API endpoint  for authoritation

@auth
Scenario Outline: 01_Post_forgot_password 
	Given Send the post request for forgot password <Email> <response>
	Then The response should match with the expected results <response>

	Examples: 
	| Email                                        | response |
	| testautomation@automation.com                | 204      |
	| testautomationnoemaildatabase@automation.com | 400      |


@auth
Scenario Outline: 02_Post_login
	Given Send the post request for login <Email> <response> <password>
	Then The response should match with the expected results <response>

	Examples: 
	| Email                         | response | password      |
	| testautomation@automation.com | 200      | @Utomation123 |


@auth
Scenario Outline: 03_Get_documentation
	Given Send the get request for documentation <Email> <response> <password>
	Then The response should match with the expected results <response>

	Examples: 
	| Email                         | response | password      |
	| testautomation@automation.com | 405      | @Utomation123 |