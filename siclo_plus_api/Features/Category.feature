Feature: Category
API endpoint  for category

@APICategory
Scenario Outline: 01_Get_category
	Given Send the get request for category <response>
	Then The response should match with the expected results <response>

	Examples: 
	| response |
	| 200      |
	| 401      |
	| 404      |

@APICategory
Scenario Outline: 02_Get_category_id
	Given Send the get request for category_id <response>
	Then The response should match with the expected results <response>

	Examples: 
	| response |
	| 200      |
	| 401      |
	| 404      |

@APICategory
Scenario Outline: 03_Get_category_id_product
	Given Send the get request for category_id_product <response>
	Then The response should match with the expected results <response>

	Examples: 
	| response |
	| 200      |
	| 401      |
	| 404      |