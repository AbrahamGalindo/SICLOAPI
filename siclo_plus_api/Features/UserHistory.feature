Feature: UserHistory
	API endpoint  for user history

@APIUser
Scenario Outline: 01_Get_user_history
	Given Send the get request for users_history <response>
	Then The response should match with the expected results <response>

	Examples: 
	| response |
	| 200      |
	| 401      |
	| 404      |

@APIUser
Scenario Outline: 02_Post_user_history
	Given Send the post request for users_history <response>
	Then The response should match with the expected results <response>

	Examples: 
	| response |
	| 200      |
	| 401      |
	| 404      |