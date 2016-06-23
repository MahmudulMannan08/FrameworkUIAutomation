Feature: UI Employee Creation Functionality

@mytag
Scenario Outline: UC-03 Create new employee with information and documents
	Given I am on itmagnet framework landing page
	Then I provide my <username> and <password> and <remember> and press login button
	And Verify I am on framework homepage and <model> is visible when my logged in state <logged>
	Then I go to employee list page
	And I go to create new page
	Then I create a new employee
	And I add employee address
	And I add employee note
	And I add employee document
	And I add employee license
	And I add employee communication
	Then I go to employee list page
	And I search new employee
	And I delete new employee
	And I logout

Examples: 
	| username | password   | remember | model      | logged |
	| john     | itmagnet03 | false    | Prototypes | true   |