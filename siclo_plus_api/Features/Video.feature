Feature: Video
	API endpoint  for video

@APIVideo
Scenario Outline: 01_Get_video
	Given Send the get request for video <response>
	Then The response should match with the expected results <response>

	Examples: 
	| response |
	| 200      |
	| 400      |
	| 401      |
	| 404      |