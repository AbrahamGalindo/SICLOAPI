Feature: Brightcove
	API endpoint  for brightcove

@APICategory
Scenario Outline: 01_Post_brightcove_videos
	Given Send the post request for brightcove videos <response>
	Then The response should match with the expected results <response>

	Examples: 
	| response |
	| 200      |
	| 400      |
	| 401      |
	| 404      |