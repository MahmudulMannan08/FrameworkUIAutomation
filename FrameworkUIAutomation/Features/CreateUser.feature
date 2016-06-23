Feature: UI User Creation Functionality
		Create new user
		Verify new user created
		delete new user

@Severity2
Scenario Outline: UC-02 Create new user
	Given I am on itmagnet framework landing page
	Then I provide my <username> and <password> and <remember> and press login button
	And Verify I am on framework homepage and <model> is visible when my logged in state <logged>
	Then I go to user list page
	And I go to create new page
	Then I create a new user
	And I logout
	Then I login with new user
	And Verify I am on framework homepage and <model> is visible when my logged in state <logged>
	And I logout
	Then I provide my <username> and <password> and <remember> and press login button
	And Verify I am on framework homepage and <model> is visible when my logged in state <logged>
	Then I go to user list page
	Then I go to audit page
	And I go to user authentication log page
	And I search new user
	And I delete user log
	Then I go to audit page
	Then I go to user session log page
	And I search new user
	And I delete user log
	Then I go to user list page
	And I search new user
	And I delete new user
	And I logout

Examples: 
	| username | password   | remember | model      | logged |
	| john     | itmagnet03 | false    | Prototypes | true   |