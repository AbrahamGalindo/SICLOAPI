Feature: Brand
		API endpoint  for brand

@bisiBrand
Scenario Outline: 01_Get_brand
	Given Send the get request for brand <response>
	Then The response should match with the expected results <response>

	Examples: 
	| response |
	| 200      |
	| 400      |
	| 401      |
	| 404      |

@bisiBrand
Scenario Outline: 06_Get_brand_id
	Given Send the get request for brand_id <id> <response>
	Then The response should match with the expected results <response>

	Examples: 
	| id                                   | response |
	| ee30cf30-a4b3-4858-8d7f-4af246295519 | 200      |
	| ee30cf30-a4b3-4858-8d7f-4af24629551  | 400      |
	| ee30cf30-a4b3-4858-8d7f-4af246295519 | 401      |
	| ee30cf30-a4b3-4858-8d7f-4af246295519 | 404      |