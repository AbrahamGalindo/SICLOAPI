Feature: User
API endpoint  for user

@APIUser
Scenario Outline: 01_Post_user
	Given Send the post request for user <response>
	Then The response should match with the expected results <response>

	Examples: 
	| response |
	| 200      |
	| 400      |
	| 401      |
	| 404      |

@APIUser
Scenario Outline: 02_Get_user
	Given Send the get request for user <response>
	Then The response should match with the expected results <response>

	Examples: 
	| response |
	| 200      |
	| 400      |
	| 401      |
	| 404      |

@APIUser
Scenario Outline: 03_Put_user
	Given Send the put request for user <response>
	Then The response should match with the expected results <response>

	Examples: 
	| response |
	| 200      |
	| 400      |
	| 401      |
	| 404      |

@APIUser
Scenario Outline: 04_Put_user_picture
	Given Send the put request for user_picture <response>
	Then The response should match with the expected results <response>

	Examples: 
	| response |
	| 200      |
	| 401      |
	| 404      |

@APIUser
Scenario Outline: 05_Get_user_subscription
	Given Send the get request for user_subscription <response>
	Then The response should match with the expected results <response>

	Examples: 
	| response |
	| 200      |
	| 400      |
	| 401      |
	| 404      |

@APIUser
Scenario Outline: 06_Post_user_subscription
Given Send the post request for user_subscription <response>
Then The response should match with the expected results <response>

	Examples: 
	| response |
	| 400      |
	| 401      |
	| 404      |