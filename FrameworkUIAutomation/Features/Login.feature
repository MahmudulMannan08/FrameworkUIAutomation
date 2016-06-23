Feature: UI LOGIN FUNCTIONALITY

@Severity1
Scenario Outline: UC-01 Login to It Magnet Framework
	Given I am on itmagnet framework landing page
	Then I provide my <username> and <password> and <remember> and press login button
	And Verify I am on framework homepage and <model> is visible when my logged in state <logged>
	And I logout

Examples: 
	| username | password   | remember | model      | logged |
	| john     | itmagnet03 | false    | Prototypes | true   |