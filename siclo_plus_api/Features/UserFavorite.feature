Feature: UserFavorite
API endpoint  for user favorite

@APIUser
Scenario Outline: 01_Post_user_favorite
	Given Send the post request for user_favorite <response>
	Then The response should match with the expected results <response>

	Examples: 
	| response |
	| 200      |
	| 401      |
	| 404      |

@APIUser
Scenario Outline: 02_Get_user_favorite
	Given Send the get request for user_favorite <response>
	Then The response should match with the expected results <response>

	Examples: 
	| response |
	| 200      |
	| 401      |
	| 404      |

@APIUser
Scenario Outline: 09_Delete_user_favorite
	Given Send the delete request for user_favorite <response>
	Then The response should match with the expected results <response>

	Examples: 
	| response |
	| 200      |
	| 401      |
	| 404      |