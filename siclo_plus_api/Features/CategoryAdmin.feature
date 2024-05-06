Feature: CategoryAdmin
API endpoint  for category

@APICategoryAdmin
Scenario Outline: 01_Post_category_admin
	Given Send the post request for category admin <response>
	Then The response should match with the expected results <response>

Examples:
	| response |
	| 200      |
	| 400      |
	| 401      |
	| 404      |

@APICategoryAdmin
Scenario Outline: 02_Put_category_admin
	Given Send the put request for category admin <response> <name> <description>
	Then The response should match with the expected results <response>

Examples:
	| name                | description            | response |
	| Nameforcategorytest | Thisbrandisjustfortest | 200      |
	| Nameforcategorytest | Thisbrandisjustfortest | 400      |
	| Nameforcategorytest | Thisbrandisjustfortest | 401      |
	| Nameforcategorytest | Thisbrandisjustfortest | 404      |

@APICategoryAdmin
Scenario Outline: 03_Delete_category_admin_id
	Given Send the delete request for category admin id <response>
	Then The response should match with the expected results <response>

Examples:
	| response |
	| 204      |
	| 400      |
	| 401      |
	| 404      |

@APICategoryAdmin
Scenario Outline: 04_Put_category_admin_picture
	Given Send the put request for category admin_picture <response>
	Then The response should match with the expected results <response>

Examples:
	| response |
	| 200      |
	| 401      |
	| 404      |

@APICategoryAdmin
Scenario Outline: 05_Delete_category_admin_picture
	Given Send the delete request for category admin_picture <response>
	Then The response should match with the expected results <response>

Examples:
	| response |
	| 204      |
	| 400      |
	| 401      |
	| 404      |