import UIKit

var helloWorld: String = "Hello World"


// ***** printing constantans and variables *****
print(helloWorld)

// print without line break at the end
print(helloWorld, terminator: "")
print("Dummy line")

// string interpolation
print("The value of helloWorld is '\(helloWorld)'")


// integers
let unsignedMaxInt: UInt = UInt.max
let signedMaxInt: Int = Int.max


// **** numerical literals ****
// all represents the number 7
let decimalInteger = 17
let binaryInteger = 0b10001
let octaclInteger = 0o21
let hexadecimalInteger = 0x11

// floating points
let decimalDouble = 12.1875
let exponentDouble = 1.21875e1  // 1.2187 x 10^1
let hexadecimalDouble = 0xC.3p0 // 12.3 x 10^0

