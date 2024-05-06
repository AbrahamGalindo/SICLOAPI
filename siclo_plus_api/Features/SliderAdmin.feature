Feature: SliderAdmin

API endpoint  for slider_admin


@slider
Scenario Outline: 01_Post_slider_admin
	Given Send the post request for slider_admin <response>
	Then The response should match with the expected results <response>

	Examples: 
	| response |
	| 201      |
	| 403      |
	| 404      |

@slider
Scenario Outline: 02_Put_slider_admin_id
	Given Send the put request for slider_admin_id <response>
	Then The response should match with the expected results <response>

	Examples: 
	| response |
	| 201      |
	| 403     |
	| 404      |
	
@slider
Scenario Outline: 03_Delete_slider_admin_id
	Given Send the delete request for slider_admin_id <response>
	Then The response should match with the expected results <response>

	Examples: 
	| response |
	| 403      |
	| 404      |