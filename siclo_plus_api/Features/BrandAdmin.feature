Feature: BrandAdmin
	API endpoint  for brand admin

@bisiBrandAdmin
Scenario Outline: 01_Post_brand_admin
	Given Send the post request for brand admin <name> <description> <color> <response>
	Then The response should match with the expected results <response>

Examples:
	| name                | description                 | color          | response |
	| Name for brand test | This brand is just for test | #d62e2e        | 200      |
	| Name for brand test | This brand is just for test | Color for test | 400      |
	| Name for brand test | This brand is just for test | #d62e2e        | 401      |
	| Name for brand test | This brand is just for test | #d62e2e        | 404      |

@bisiBrandAdmin
Scenario Outline: 02_Put_brand_admin_id
	Given Send the put request for brand admin_id <name> <description> <color> <response>
	Then The response should match with the expected results <response>
	And Delete this brand

Examples:
	| name                | description                 | color   | response |
	| Name for brand test | This brand is just for test | #d62e2e | 204      |
	| Name for brand test | This brand is just for test | #d62e2e | 400      |
	| Name for brand test | This brand is just for test | #d62e2e | 401      |
	| Name for brand test | This brand is just for test | #d62e2e | 404      |

@bisiBrandAdmin
Scenario Outline: 03_Delete_brand_admin_id
	Given Send the delete request for brand admin_id <name> <description> <color> <response>
	Then The response should match with the expected results <response>
	And Delete this brand

Examples:
	| name                | description                 | color   | response |
	| Name for brand test | This brand is just for test | #d62e2e | 400      |
	| Name for brand test | This brand is just for test | #d62e2e | 401      |
	| Name for brand test | ThIS brand is just for test | #d62e2e | 404      |
	| Name for brand test | This brand is just for test | #d62e2e | 204      |

@bisiBrandAdmin
Scenario Outline: 04_Put_brand_admin_cover
	Given Send the put request for brand admin cover <name> <description> <color> <response>
	Then The response should match with the expected results <response>
	And Delete this brand

Examples:
	| name                | description                 | color   | response |
	| Name for brand test | This brand is just for test | #d62e2e | 200      |
	| Name for brand test | This brand is just for test | #d62e2e | 401      |
	| Name for brand test | This brand is just for test | #d62e2e | 404      |
	
@bisiBrandAdmin
Scenario Outline: 05_Delete_brand_admin_cover
	Given Send the delete request for brand admin cover <name> <description> <color> <response>
	Then The response should match with the expected results <response>
	And Delete this brand

Examples:
	| name                | description                 | color   | response |
	| Name for brand test | This brand is just for test | #d62e2e | 400      |
	| Name for brand test | This brand is just for test | #d62e2e | 401      |
	| Name for brand test | This brand is just for test | #d62e2e | 404      |
	| Name for brand test | This brand is just for test | #d62e2e | 204      |

@bisiBrandAdmin
Scenario Outline: 06_Put_brand_admin_picture
	Given Send the put request for brand admin picture <name> <description> <color> <response>
	Then The response should match with the expected results <response>
	And Delete this brand

Examples:
	| name                | description                 | color   | response |
	| Name for brand test | This brand is just for test | #d62e2e | 200      |
	| Name for brand test | This brand is just for test | #d62e2e | 401      |
	| Name for brand test | This brand is just for test | #d62e2e | 404      |

@bisiBrandAdmin
Scenario Outline: 07_Delete_brand_admin_picture
	Given Send the delete request for brand admin picture <name> <description> <color> <response>
	Then The response should match with the expected results <response>
	And Delete this brand

Examples:
	| name                | description                 | color   | response |
	| Name for brand test | This brand is just for test | #d62e2e | 204      |
	| Name for brand test | This brand is just for test | #d62e2e | 400      |
	| Name for brand test | This brand is just for test | #d62e2e | 401      |
	| Name for brand test | This brand is just for test | #d62e2e | 404      |