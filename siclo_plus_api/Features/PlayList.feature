Feature: PlayList
		API endpoint  for playlist

@APIPlaylist
Scenario Outline: 01_Get_playlist
	Given Send the get request for play list <response>
	Then The response should match with the expected results <response>

	Examples: 
	| response |
	| 200      |
	| 401      |
	| 404      |

	@APIPlaylist
Scenario Outline: 02_Get_playlist_id
	Given Send the get request for play list_id <response>
	Then The response should match with the expected results <response>

	Examples: 
	| response |
	| 200      |
	| 401      |
	| 404      |