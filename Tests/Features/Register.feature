Feature: Register
	Som Novanet
	ønsker jeg at en bruker skal registrere seg
	Slik at vi kan sende vedkommende spam

@mytag
Scenario: Registrere bruker med gyldig informasjon
	Given I navigate to the UserRegistration page
	And I register with the following information
	| Username | Password | Confirm password |
	| yngve    | test123  | test123          |
	Then I should be logged in as yngve
