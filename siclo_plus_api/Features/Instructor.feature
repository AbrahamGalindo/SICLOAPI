Feature: Instructor
API endpoint  for instructor

@APIInstructor
Scenario Outline: 01_Get_instructor
	Given Send the get request for instructor <response>
	Then The response should match with the expected results <response>

	Examples: 
	| response |
	| 200      |
	| 400      |
	| 401      |
	| 404      |

@APIInstructor
Scenario Outline: 05_Get_instructor_id
	Given Send the get request for instructor_id <response>
	Then The response should match with the expected results <response>

	Examples: 
	| response |
	| 200      |
	| 401      |
	| 404      |