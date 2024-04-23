Feature: Profile Description
1. Description
	TC1 - Add Description
	TC2 - Description mandatory error

Scenario Outline: Logged User Add Description
	Given user click on Pen button for Description
	When user enter Description and click Save Button <Description>
	Then Description is saved successfully
	And "Description has been saved successfully" message appears

Examples:
	| Username              | Password             | Description |
	| 'remibala2@gmail.com' | 'Jesus#1AnswerSheet' | 'jshadfga'  |

Scenario Outline: Logged User Add Empty Description
	Given user click on Pen button for Description
	When user enter nothing in Profile Description and click Save Button <Description>
	Then Description not saved successfully
	And "Please, a description is required" error message

Examples:
	| Username              | Password             | Description |
	| 'remibala2@gmail.com' | 'Jesus#1AnswerSheet' | ''  |


Scenario Outline: Logged User Add Description starting with special character
	Given user click on Pen button for Description
	When user enter Profile Description starting with special character and click Save Button <Description>
	Then Description not saved successfully
	And "First character can only be digit or letters" error message

Examples:
	| Username              | Password             | Description |
	| 'remibala2@gmail.com' | 'Jesus#1AnswerSheet' | '!lelfsd'   |

	
Scenario Outline: Logged User Add Description more than 600 characters
	Given user click on Pen button for Description
	When user enter Profile Description starting wwith more than 600 characters and click Save Button <Description>
	Then Description is saved successfully
	And only with count 600 max

Examples:
	| Username              | Password             | Description                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                      |
	| 'remibala2@gmail.com' | 'Jesus#1AnswerSheet' | 'jshadfgajshadfgajshadfgajshadfgajshadfgajshadfgajdfkggggggggggggggggggggggggggggggggggggggggggggggggggggggggggggggggggggggggggggggggggggggggggggggggggggggggggggggggggggggggggggggggggggggggggggggggggggggggggggggggggggggggggggggggggggggggggggggggggggggggggggggggggggggggggggggggggggggggggggggggggggggggggggggggggggggggggggggggggggggggggggggggggggggggggggggggggggggggggggggggggggggggggggggggggggggggggggggggggggggggggggggggggggggggggggggggggggggggggggggggggggggggggggggggggggggggggggggggggggggggggggggggggggggggggggggggggggggggggggggggggggggggggggggggggggggggggggggggggggggggggggggggggggggggggggggggggggpooiosdjkadjfbdjhbjhdbjhvjhsdvjhsdjfbj' |

