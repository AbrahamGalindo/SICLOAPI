Feature: TutorialAdmin
		API endpoint  for tutorial admin

@APITutorial
Scenario Outline: 01_Post_tutorial
	Given Send the post request for tutorial <response>
	Then The response should match with the expected results <response>

	Examples: 
	| response |
	| 200      |
	| 400      |
	| 401      |
	| 404      |
