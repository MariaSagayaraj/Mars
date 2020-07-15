Feature:SignIn
	As a user, I should be Signed In successfully

@automation
Scenario: Signin feature
	Given I loginto the mars portal using the credentials <username>,<password>
	Then I validate that I logged into the portal successfully

	Examples:
		| username                | password |
		| maria.saronia@gmail.com | 123456   |


