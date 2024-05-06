Feature: BiSiAdmin
	API endpoint  for biSi admin

@bisiAdmin
Scenario Outline: 01_Get_bisi_admin
	Given Send the get request for bisi_admin <Email> <response>
	Then The response should match with the expected results <response>

Examples:
	| Email                         | response |
	| yael@siclo.com             | 200      |
	| testautomation@automation.com | 400      |
	| testautomation@automation.com | 401      |
	| testautomation@automation.com | 404      |
	

@bisiAdmin
Scenario Outline: 02_Post_bisi_admin
	Given Send the post request for bisi_admin <Email> <response>
	Then The response should match with the expected results <response>

Examples:
	| Email                         | response |
	| testautomation@automation.com | 200      |
	| testautomation@automation.com | 400      |
	| testautomation@automation.com | 401      |
	| testautomation@automation.com | 404      |


@bisiAdmin
Scenario Outline: 03_Put_bisi_admin
	Given Send the put request for bisi_admin <Email> <response>
	Then The response should match with the expected results <response>

Examples:
	| Email                         | response |
	| testautomation@automation.com | 200      |
	| testautomation@automation.com | 400      |

@bisiAdmin
Scenario Outline: 04_Delete_bisi_admin
	Given Send the delete request for bisi_admin <response>
	Then The response should match with the expected results <response>

Examples:
	| response |
	| 200      |
	| 400      |
