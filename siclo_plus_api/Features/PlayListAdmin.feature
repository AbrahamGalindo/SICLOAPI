Feature: PlayListAdmin
	API endpoint  for playlist admin

@APIPlaylistAdmin
Scenario Outline: 01_Post_playlist
	Given Send the post request for play list admin <response>
	Then The response should match with the expected results <response>

	Examples: 
	| response |
	| 200      |
	| 400      |
	| 401      |
	| 404      |

@APIPlaylistAdmin
Scenario Outline: 02_Put_playlist_id
	Given Send the put request for play list admin <response>
	Then The response should match with the expected results <response>

	Examples: 
	| response |
	| 200      |
	| 400      |
	| 401      |
	| 404      |

@APIPlaylistAdmin
Scenario Outline: 03_Put_playlist_id_items
	Given Send the put request for play list items admin <response>
	Then The response should match with the expected results <response>

	Examples: 
	| response |
	| 200      |
	| 400      |
	| 401      |
	| 404      |


@APIPlaylistAdmin
Scenario Outline: 04_Put_playlist_id_pictures
	Given Send the put request for play list pictures admin <response>
	Then The response should match with the expected results <response>

	Examples: 
	| response |
	| 200      |
	| 401      |
	| 404      |

@APIPlaylistAdmin
Scenario Outline: 05_Delete_playlist_id
	Given Send the delete request for play list admin <response>
	Then The response should match with the expected results <response>

	Examples: 
	| response |
	| 204      |
	| 401      |
	| 404      |