Feature: Tutorial
		API endpoint  for tutorial

@APITutorial
Scenario Outline: 01_Get_tutorial
	Given Send the get request for tutorial <response>
	Then The response should match with the expected results <response>

	Examples: 
	| response |
	| 200      |
	| 404      |

	@APITutorial
Scenario Outline: 02_Get_tutorial_id
	Given Send the get request for tutorial_id <response>
	Then The response should match with the expected results <response>

	Examples: 
	| response |
	| 200      |
	| 404      |