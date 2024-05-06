Feature: ReviewAdmin
API endpoint  for review admin

@APIReviewAdmin
Scenario Outline: 01_Get_review
	Given Send the get request for review <response>
	Then The response should match with the expected results <response>

	Examples: 
	| response |
	| 400      |
	| 401      |

	@APIReviewAdmin
Scenario Outline: 02_Get_review_id
	Given Send the get request for review_id <response>
	Then The response should match with the expected results <response>

	Examples: 
	| response |
	| 400      |
	| 401      |
	| 404      |

	@APIReviewAdmin
Scenario Outline: 03_Put_review_id
	Given Send the put request for review_id <response>
	Then The response should match with the expected results <response>

	Examples: 
	| response |
	| 200      |
	| 400      |
	| 401      |
	| 404      |