Feature: UserExternalServices
	API endpoint  for user external services

@APIUser
Scenario Outline: 01_Get_user_services
	Given Send the get request for users_services <response>
	Then The response should match with the expected results <response>

	Examples: 
	| response |
	| 200      |
	| 401      |
	| 404      |

@APIUser
Scenario: 02_Post_user_services
	Given Send the post request for users_services <response>
	Then The response should match with the expected results <response>

	Examples: 
	| response |
	| 200      |
	| 401      |
	| 404      |