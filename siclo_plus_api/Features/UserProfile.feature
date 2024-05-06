Feature: UserProfile
	API endpoint  for user profile

@APIUser
Scenario Outline: 01_Get_user_profile
	Given Send the get request for users_profile <response>
	Then The response should match with the expected results <response>

	Examples: 
	| response |
	| 200      |
	| 401      |
	| 404      |

	@APIUser
Scenario Outline: 02_Post_user_profile
	Given Send the post request for users_profile <response>
	Then The response should match with the expected results <response>

	Examples: 
	| response |
	| 400      |
	| 401      |
	| 404      |

	@APIUser
Scenario Outline: 03_Get_user_profile_id
	Given Send the get request for users_profile_id <response>
	Then The response should match with the expected results <response>

	Examples: 
	| response |
	| 200      |
	| 401      |
	| 404      |

	@APIUser
Scenario Outline: 04_Delete_user_profile_id
	Given Send the delete request for users_profile_id <response>
	Then The response should match with the expected results <response>

	Examples: 
	| response |
	| 400      |
	| 401      |
	| 404      |