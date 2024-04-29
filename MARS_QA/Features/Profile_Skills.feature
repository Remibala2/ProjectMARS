Feature: Profile Skills
	TC1 - Add Skill 
	TC2 - Add Existing Skill 
	TC3 - Skill  Input empty
	TC4 - Level Input Empty
	TC5 - Cancel Add Skill 
	TC6 - Delete Skill 
	TC7 - Edit Skill 
	TC8 - Cancel Edit Skill 
	TC9 - Add New button disappear when 4 Skill added

Scenario Outline: Logged User Add New Skill
	Given click on Add New in Skills in Skills Tab
	When User enter skill <SkillName> and Level <SkillLevel> and click Add
	Then New Skill <SkillName> and <SkillLevel> are added to profile successfully
	And <SkillName> "has been added to your skills" message appears in Skills Page

Examples:
	| SkillName  | SkillLevel |
	| 'Selenium' | 'Beginner' |

Scenario Outline: Logged User Add an already existing Skill and Level
	Given click on Add New in Skills Tab with existing <existingSkillName> <existingSkillLevel>
	When User enter existing skill <SkillName> and Level <SkillLevel> and click Add
	Then Skill and Level not added
	And "This skill is already exist in your skill list." error message appears in Skills Page

Examples:
	| existingSkillName | existingSkillLevel | SkillName | SkillLevel |
	| 'C'               | 'Beginner'         | 'C'       | 'Beginner' |

Scenario Outline: Logged User Add an already existing Skill
	Given click on Add New in Skills Tab with existing <existingSkillName> <existingSkillLevel>
	When User enter the existing Skill <existingSkillName> and Level <SkillLevel> and click Add
	Then Skill and Level not added
	And "Duplicated data" error message appears in Skills Page

Examples:
	| existingSkillName | existingSkillLevel | SkillName | SkillLevel     |
	| 'C'               | 'Beginner'         | 'C'       | 'Intermediate' |

Scenario Outline: Logged User Add empty Skill or Level
	Given click on Add New in Skills Tab
	When User enter Skill empty <SkillName> and/or Level <SkillLevel> and click Add
	Then Skill and Level not added
	And "Please enter skill and experience level" error message appears in Skills Page

Examples:
	| SkillName | SkillLevel           |
	| ''        | 'Fluent'             |
	| ''        | 'Choose Skill Level' |
	| 'Spanish' | 'Choose Skill Level' |

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
	And "blah has been deleted" error message appears in Skills Page

Examples:
	| SkillName |
	| 'C#'      |

Scenario Outline: Logged User wants to Edit Skills
	Given User click on Pen button for a Skill <SkillName> <SkillLevel>
	When User enter new Skills <NewSkillName> , <NewSkillLevel> and click Update button
	Then Skill changes saved to profile successfully

Examples:
	| SkillName | SkillLevel | NewSkillName | NewSkillLevel  |
	| 'c#'      | 'Beginner' | 'J'          | 'Beginner'     |
	| 'c#'      | 'Beginner' | 'C#'         | 'Intermediate' |

Scenario Outline: Logged User clicks Cancel at Edit Skill
	Given User click on Pen button for a Skill <SkillName> <SkillLevel>
	When User enter new Skills <NewSkillName> , <NewSkillLevel>
	And Click on Cancel Button in Update Skill
	Then Skill changes not saved to profile

Examples:
	| SkillName | SkillLevel | NewSkillName | NewSkillLevel |
	| 'C#'      | 'Pro'      | 'j'          | 'Beginner'    |
