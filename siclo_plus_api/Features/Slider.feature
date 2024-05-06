Feature: Slider
	API endpoint  for slider 

@slider
Scenario Outline: 01_Get_slider
	Given Send the get request for slider <response>
	Then The response should match with the expected results <response>

	Examples: 
	| response |
	| 200      |
	| 403     |
	| 404      |

@slider
Scenario Outline: 02_Get_slider_id
	Given Send the get request for slider_id <response>
	Then The response should match with the expected results <response>

	Examples: 
	| response |
	| 200      |
	| 403      |
	| 404      |

@slider
Scenario Outline: 03_Get_slider_documentation
	Given Send the get request for slider_documentation <response>
	Then The response should match with the expected results <response>

	Examples: 
	| response |
	| 200      |
	| 404      |