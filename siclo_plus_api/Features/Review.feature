Feature: Review
API endpoint  for review

@APIReview
Scenario Outline: 01_Post_review
	Given Send the post request for review <response>
	Then The response should match with the expected results <response>

	Examples: 
	| response |
	| 200      |
	| 400      |
	| 401      |
	| 404      |