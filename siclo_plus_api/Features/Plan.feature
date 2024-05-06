Feature: Plan
	API endpoint  for plan

@APIPlan
Scenario Outline: 01_Get_plan
	Given Send the get request for plan <response>
	Then The response should match with the expected results <response>

Examples:
	| response |
	| 200      |
	| 400      |
	| 401      |
	| 404      |

@APIPlan
Scenario Outline: 02_Get_plan_id
	Given Send the get request for plan_id <response>
	Then The response should match with the expected results <response>

Examples:
	| response |
	| 200      |
	| 400      |
	| 401      |
	| 404      |


@APIPlan
Scenario Outline: 03_Get_plan_documentation
	Given Send the get request for plan_documentation <response>
	Then The response should match with the expected results <response>

Examples:
	| response |
	| 200      |
	| 404      |