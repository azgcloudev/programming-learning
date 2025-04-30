import UIKit

// creating arrays
var levelDifficulty: [String] = ["Easy", "Moderate", "Veteran", "Nightmare"]
var extraSyntax1: Array<String> = Array<String>()

// count
levelDifficulty.count
levelDifficulty.isEmpty

// accessing array values
var mostDiffficult = levelDifficulty[3]
levelDifficulty[3] = "Utter Ridiculousness"
//levelDifficulty[100] // error not in range


// changing and appending items
var characterClasses = ["Ranger", "Paladin", "Druid"]
characterClasses.append("Glunslinger")
characterClasses += ["Healer","Berserker"]

// inserting and removing items
characterClasses.insert("Beast Master", at: 2)
characterClasses.remove(at: 1)


