Feature: InstructorAdmin
API endpoint  for instructor admin

@APIInstructorAdmin
Scenario Outline: 01_Post_instructor
	Given Send the post request for instructor <response>
	Then The response should match with the expected results <response>

Examples:
	| response |
	| 200      |
	| 400      |
	| 401      |
	| 404      |


@APIInstructorAdmin
Scenario Outline: 02_Put_instructor_id
	Given Send the put request for instructor_id <response>
	Then The response should match with the expected results <response>

Examples:
	| response |
	| 200      |
	| 400      |
	| 401      |
	| 404      |

@APIInstructorAdmin
Scenario Outline: 03_Put_instructor_id_picture
	Given Send the put request for instructor id picture <response>
	Then The response should match with the expected results <response>

Examples:
	| response |
	| 200      |
	| 401      |
	| 404      |


@APIInstructorAdmin
Scenario Outline: 05_Delete_instructor_id
	Given Send the delete request for instructor id <response>
	Then The response should match with the expected results <response>

Examples:
	| response |
	| 204      |
	| 400      |
	| 401      |
	| 404      |