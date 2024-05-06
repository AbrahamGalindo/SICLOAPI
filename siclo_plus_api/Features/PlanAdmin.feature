Feature: PlanAdmin
	API endpoint  for plan admin

@APIPlanAdmin
Scenario Outline: 01_Post_plan_admin
	Given Send the post request for plan admin <response>
	Then The response should match with the expected results <response>

	Examples: 
	| response |
	| 200      |
	| 400      |
	| 401      |
	| 404      |

@APIPlanAdmin
Scenario Outline: 02_Put_plan_admin
	Given Send the put request for plan admin <response>
	Then The response should match with the expected results <response>

	Examples: 
	| response |
	| 200      |
	| 400      |
	| 401      |
	| 404      |