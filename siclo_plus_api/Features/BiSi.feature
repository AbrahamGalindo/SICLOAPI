Feature: BiSi
	API endpoint  for biSi

@bisi
Scenario Outline: 01_Post_Bisi
	Given Send the post request for bisi <response>
	Then The response should match with the expected results <response>

Examples:
	| response |
	| 201      |
	| 400      |
	| 401      |
	| 404      |

@bisi
Scenario Outline: 02_Put_Bisi
	Given Send the put request for bisi <response>
	Then The response should match with the expected results <response>

Examples:
	| response |
	| 200      |
	| 400      |
	| 401      |
	| 404      |

@bisi
Scenario Outline: 03_Delete_bisi
	Given Send the delete request for bisi <response>
	Then The response should match with the expected results <response>

Examples:
	| response |
	| 200      |
	| 400      |
	| 401      |
	| 404      |