Feature: UserAdmin
API endpoint  for user admin

@APIUser
Scenario Outline: 01_Get_user
	Given Send the get request for users <response>
	Then The response should match with the expected results <response>

	Examples: 
	| response |
	| 200      |
	| 401      |
	| 404      |

@APIUser
Scenario Outline: 02_Get_user_id
	Given Send the get request for users_id <response>
	Then The response should match with the expected results <response>

	Examples: 
	| response |
	| 200      |
	| 401      |
	| 404      |

@APIUser
Scenario Outline: 09_Delete_user_id
	Given Send the delete request for users_id <response>
	Then The response should match with the expected results <response>

	Examples: 
	| response |
	| 400      |
	| 401      |
	| 404      |