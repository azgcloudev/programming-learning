import UIKit

// type inference
var currentHealth = 90

// type annotation
var characterName: String
characterName = "King Krull"


// type annotation + inference
var maxHealth: Int = 90


// multiple variables with type annotation
var n1,n2,n3: Int

// types
var number: Int
var decimals: Double
var floatingNumbers: Float
var yesOrNo: Bool
var text: String
var char: Character


//// OPERATORS


// arithmetic
var usingMathIRL = 5 + 4 - 3 / 2 * 1

// compound assigment *=  /=  +=  -=
currentHealth *= 5
print(currentHealth)

// modulo
var modulo = 90 % 5
print(modulo)



//// STRINGS

// declaring string
var activeQuest: String = "Retrieving the Cart!"
print(activeQuest)

// concatenation
var questDifficulty = "Nightmare"
var questInfo = activeQuest + " -> " + questDifficulty
print(questInfo)

// string interpolation
let questInfo_Interpolated = "I'am not sure you're ready for \(activeQuest) yet, it's \(questDifficulty) level."
print(questInfo_Interpolated)


var dialogue = "the Innkeeper's Haven"
dialogue.count
dialogue.isEmpty
dialogue.contains("S")

// append and insert
dialogue.append(contentsOf: ", weary travelers!")

dialogue.removeLast()
dialogue.removeFirst()
//dialogue.removeAll()
dialogue.split(separator: ",")


//// TYPE CONVERSION
var currentGold_Double = 5.832

// explicit conversion
var currentGold_Integer: Int = Int(currentGold_Double)
var currentGold_String = String(currentGold_Double)

// inferred conversion with operators
var bankDeposit = 37 + 5.892 // double var
var bankDeposit_Explicit = currentGold_Double + Double(currentGold_Integer)




//// BOOLEAND AND LOGICAL OPERATORS
var isActive: Bool = true
var canMove = false

// logical operators
!isActive

var playerControl = canMove && isActive
playerControl = canMove || isActive



//// OPTIONAL
var itemGathered: String? = "Pickaxe"
var isExachangable: Bool?

// force unwrapping
print(itemGathered!) // unwrapp without nil checking
//print(isExachangable!) // error

if isExachangable != nil {
    print(isExachangable)
}

// optional binding
if let temporary = isExachangable {
    print(isExachangable)
} else {
    print("isExchange is null")
}

