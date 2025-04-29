import UIKit


let goodStart = """
one
two

"""

let end = """
three
"""

print(goodStart + end)

//# STRING INTERPOLATION
let multiplier = 7
let message = "\(multiplier) times 2.5 = \(Double(multiplier) * 2.5)"
print(message)

// ## string delimiters are use to ignore create strings with characters that are consider as
// string interpolation the backslash
print(#"Write an interpolated string using \(multiplier)."#)

