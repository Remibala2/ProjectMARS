Feature: Profile Language

	TC1 - Add Language 
	TC2 - Add Existing Language
	TC3 - Langugae Input empty
	TC4 - Level Input Empty
	TC5 - Cancel Add Language
	TC6 - Delete Language
	TC7 - Edit Langugage
	TC8 - Cancel Edit Language
	TC9 - Add New button disappear when 4 languages added

Scenario Outline: Logged User Add New Language
	Given click on Add New button in Languages Tab
	When User enter new language <LanguageName> and Level <LanguageLevel> and click Add
	Then New Language <LanguageName> and <LanguageLevel> are added to profile successfully
	And <LanguageName> "has been added to your languages" message appears

Examples:
	| LanguageName | LanguageLevel      |
	| 'English'    | 'Fluent'           |
	| 'Tamil'      | 'Native/Bilingual' |

Scenario Outline: Logged User Add an already existing Language and Level
	Given click on Add New in Languages Tab with existing <existingLanguageName> <existingLanguageLevel>
	When User enter the existing language <LanguageName> and Level <LanguageLevel> and click Add
	Then Langugae and Level not added
	And "This language is already exist in your language list." error message

Examples:
	| existingLanguageName | existingLanguageLevel | LanguageName | LanguageLevel |
	| 'English'            | 'Fluent'              | 'English'    | 'Fluent'      |

Scenario Outline: Logged User Add an already existing Language
	Given click on Add New in Languages Tab with existing <existingLanguageName> <existingLanguageLevel>
	When User enter the existing language <existingLanguageName> and Level <LanguageLevel> and click Add
	Then Langugae and Level not added
	And "Duplicated data" error message

Examples:
	| existingLanguageName | existingLanguageLevel | LanguageName | LanguageLevel      |
	| 'English'            | 'Fluent'              | 'English'    | 'Native/Bilingual' |


Scenario Outline: Logged User Add empty Language or Level
	Given click on Add empty langugae and/or Level in Languages Tab
	When User enter language empty <LanguageName> and/or Level <LanguageLevel> and click Add
	Then Langugae and Level not added
	And "Please enter language and level" error message

Examples:
	| LanguageName | LanguageLevel           |
	| ''           | 'Fluent'                |
	| ''           | 'Choose Language Level' |
	| 'Spanish'    | 'Choose Language Level' |



Scenario Outline: Logged User Click Cancel in Add Languages
	Given click on Add New button in Languages Tab
	When User enter new language <LanguageName> and Level <LanguageLevel>
	And Click on Cancel button
	Then New Language is not added to profile

Examples:
	| LanguageName | LanguageLevel |
	| 'English'    | 'Fluent'      |

Scenario Outline: Logged User wants to Delete an existing Languages
	Given for the last language in Languages Tab <LanguageName>
	When User click on X button
	Then Language deleted from the profile successfully
	And "blah has been deleted from your languages" error message

Examples:
	| LanguageName |
	| 'English'    |

Scenario Outline: Logged User wants to Edit Language
	Given User click Pen button for a language <LanguageName> <LanguageLevel>
	When User keyin new values <NewLanguageName> <NewLanguageLevel>
	Then Language changes is saved to profile successfully
	And language updated error message for <NewLanguageName>

Examples:
	| LanguageName | LanguageLevel | NewLanguageName | NewLanguageLevel   |
	| 'Spanish'    | 'Fluent'      | 'Spanish'       | 'Native/Bilingual' |
	| 'Spanish'    | 'Fluent'      | 'French'        | 'Native/Bilingual' |

Scenario Outline: Logged User clicks Cancel at Edit Languages flow
	Given User click Pen button for a language <LanguageName> <LanguageLevel>
	When User keyin new values <NewLanguageName> <NewLanguageLevel>
	And Click on Cancel Button in Edit flow
	Then Language changes not saved

Examples:
	| LanguageName | LanguageLevel | NewLanguageName | NewLanguageLevel   |
	| 'Spanish'    | 'Fluent'      | 'Spanish'       | 'Native/Bilingual' |

Scenario Outline: Logged User has 4 Languages added to profile
	Given User has four Languages added to profile <L1> <Lev1> <L2> <Lev2> <L3> <Lev3> <L4> <Lev4>
	Then Add New button is invisible

	Examples:
	| L1        | Lev1     | L2        | Lev2               | L3  | Lev3    | L4  | Lev4    |
	| 'Spanish' | 'Fluent' | 'English' | 'Native/Bilingual' | 'a' | 'Basic' | 'b' | 'Basic' |

