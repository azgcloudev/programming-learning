import Cocoa

//// variables
var name = "Aldair"
var quote = "He tapped s a sign saying \"Believe\" and walked away"
var age = 28
var multiLine = """
Line 1
Line 2
Line 3
"""

print(multiLine)
print(name.count)

print(quote.hasPrefix("He"))
print(quote.hasSuffix("sign"))

// constant
let pi = 3.1415


// numbers
let number = 30
print("Is multiple \(number.isMultiple(of: 3))")
Int.random(in: 0...100) // generate randon number
