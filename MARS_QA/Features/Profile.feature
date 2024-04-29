Feature: Profile 
1. Description
	TC1 - Add Description
	TC2 - Description mandatory error
2.Language 
	TC2 - Add Language 
	TC3 - Cancel Add Language
	TC4 - Delete Language
	TC5 - Edit Langugage
	TC6 - Cancel Edit Language
3.Skills 
	TC7 - Add Skill
	TC8 - Cancel Skill
	TC9 - Delete Skill

	Scenario Outline: Logged User Add Description
	Given user enter valid <Username> <Password>
	When user enter Profile Description and click Save Button <Description>
	Then Description saved successfully

	Examples: 
	| Username              | Password             | Description                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                      |
	| 'remibala2@gmail.com' | 'Jesus#1AnswerSheet' | 'jshadfga'                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                       |
	| 'remibala2@gmail.com' | 'Jesus#1AnswerSheet' | ''                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                            |
	| 'remibala2@gmail.com' | 'Jesus#1AnswerSheet' | 'jshadfgajshadfgajshadfgajshadfgajshadfgajshadfgajdfkggggggggggggggggggggggggggggggggggggggggggggggggggggggggggggggggggggggggggggggggggggggggggggggggggggggggggggggggggggggggggggggggggggggggggggggggggggggggggggggggggggggggggggggggggggggggggggggggggggggggggggggggggggggggggggggggggggggggggggggggggggggggggggggggggggggggggggggggggggggggggggggggggggggggggggggggggggggggggggggggggggggggggggggggggggggggggggggggggggggggggggggggggggggggggggggggggggggggggggggggggggggggggggggggggggggggggggggggggggggggggggggggggggggggggggggggggggggggggggggggggggggggggggggggggggggggggggggggggggggggggggggggggggggggggggggggggggpooiosdjkadjfbdjhbjhdbjhvjhsdvjhsdjfbj' |
	| 'remibala2@gmail.com' | 'Jesus#1AnswerSheet' | '!lelfsd'                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                        |

	Scenario Outline: Logged User Add Languages
	Given click on Add New in Languages Tab
	When User enter language <LanguageName> and Level <LanguageLevel> and Add
	Then New Language added to profile successfully

	Examples: 
	| LanguageName | LanguageLevel           |
	| 'English'    | 'Fluent'                |
	| 'Tamil'      | 'Native/Bilingual'      |
	| ''           | 'Fluent'                |
	| ''           | 'Choose Language Level' |
	| 'English'    | 'Fluent'                |
	| 'Spanish'    | 'Choose Language Level' |

	Scenario Outline: Logged User Click Cancel in Add Languages
	Given click on Add New in Languages Tab
	When User enter language <LanguageName> and Level <LanguageLevel> 
	And Click on Cancel
	Then New Language not added to profile

	Examples: 
	| LanguageName | LanguageLevel      |
	| 'English'    | 'Fluent'           |

	Scenario Outline: Logged User wants to Delete Languages
	Given for a language in Languages Tab <LanguageName>
	When User click on X button for a language <LanguageName>
	Then Language deleted from profile successfully

	Examples: 
	| LanguageName |
	| 'English'    |

	Scenario Outline: Logged User wants to Edit Languages
	Given User click on Pen button for a language <LanguageName> <LanguageLevel>
	When User enter new values <NewLanguageName> <NewLanguageLevel>
	Then Language changes saved to profile successfully

	Examples: 
	| LanguageName | LanguageLevel    | NewLanguageName | NewLanguageLevel   |
	| 'Spanish'    | 'Fluent'         | 'Spanish'       | 'Native/Bilingual' |

	Scenario Outline: Logged User clicks Cancel at Edit Languages
	Given User click on Pen button for a language <LanguageName> <LanguageLevel>
	When User enter new values <NewLanguageName> <NewLanguageLevel>
	And Click on Cancel Button in Update Language
	Then Language changes not saved to profile

	Examples: 
	| LanguageName | LanguageLevel    | NewLanguageName | NewLanguageLevel   |
	| 'Spanish'    | 'Fluent'         | 'Spanish'       | 'Native/Bilingual' |

	Scenario Outline: Logged User Add New Skill
	Given click on Add New in Skills Tab
	When User enter skill <SkillName> and Level <SkillLevel> and Add
	Then New Skill added to profile successfully

	Examples: 
	| SkillName  | SkillLevel |
	| 'Selenium' | 'Beginner' |

	Scenario Outline: Logged User Click Cancel in Add Skills
	Given click on Add New in Skills Tab
	When User enter skill <SkillName> and Level <SkillLevel> 
	And Click on Cancel at Skill Level
	Then New Skill not added to profile

	Examples: 
	| SkillName  | SkillLevel |
	| 'Selenium' | 'Beginner' |

	Scenario Outline: Logged User wants to Delete Skills
	Given for a skill in Skills Tab <SkillName>
	When User click on X button for a skill <SkillName>
	Then Skill deleted from profile successfully

	Examples: 
	| SkillName |
	| 'C#' |

	Scenario Outline: Logged User wants to Edit Skills
	Given User click on Pen button for a Skill <SkillName> <SkillLevel>
	When User enter new Skills <NewSkillName> , <NewSkillLevel> and click Update button
	Then Skill changes saved to profile successfully

	Examples: 
	| SkillName | SkillLevel | NewSkillName | NewSkillLevel  |
	| 'c#'      | 'Pro'      | 'J'          | 'Beginner'     |
	| 'c#'      | 'Pro'      | 'Python'     | 'Intermediate' |

	Scenario Outline: Logged User clicks Cancel at Edit Skill
	Given User click on Pen button for a Skill <SkillName> <SkillLevel>
	When User enter new Skills <NewSkillName> , <NewSkillLevel>
	And Click on Cancel Button in Update Skill
	Then Skill changes not saved to profile

	Examples: 
	| SkillName | SkillLevel | NewSkillName | NewSkillLevel |
	| 'C#'      | 'Pro'      | 'j'          | 'Beginner'    |
