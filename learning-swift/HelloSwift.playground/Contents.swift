import Cocoa

var greeting = "Hello, playground"
print(greeting)

var name: String = "Aldair"

// optional
var nombre: String?
nombre = "Juan"
print(nombre)



// constants
let descuento = 0.13

var isOverAge = true


// STRINGS
let val1 = "hola"
let val2 = "como estas"

print(val1 + " " + val2)
print("\(val1), \(val2)?")

let emoji: Character = "😃"
var message = "Welcome to the course "
message.append(emoji)
print("message has \(message.count) characters, and the text is: \(message)")


// ------ optionals -------
var firstName: String? = "Aldair"

print(firstName!) // force unwrap

firstName = nil

// optional binding
if let checkedName = firstName {
    print("The name is \(checkedName)")
} else {
    print("Name has no value")
}

// implicit unwrapped optionals
// are use when the value will be assign and you know that always will hold a value
// shows runtime error if 'nil' is assigned
var lastName: String! = "Zamora"
var implicitLastName = lastName
print(implicitLastName!)

// can use optional binding also with implicit unwraped optionals
if let bindingLastName = lastName {
    print("The last name is \(bindingLastName)")
}


var title: String? = "Title"

var result = title ?? "The title"
print("result: \(result)")
title = nil
result = title ?? "The title"
print("result: \(result)")

// ranges
for i in 0..<10 {
    print(i)
}



/* ARRAYS */
var ages = [21,55,34,67,80,15]
var agesEmpty: [Int]

ages.count
ages.last
ages.append(99)
ages.insert(44, at: 0)

ages.sort()
ages.reverse()
ages.shuffle()


/* SET */
// unordered
// no duplicate values
var myAges = [21,52,63,62,22,56,32,21,52,22] // array
// empty set
var agesSet: Set<Int>
var agesSetFromArray = Set(myAges)
print(agesSetFromArray)
ages.contains(21)
agesSetFromArray.insert(200)
print(agesSetFromArray)



/* DICTIONARY */
// Key value pairs
let devices: [String : String] = [
    "phone": "iPhone X",
    "laptop": "2016 MacBook Pro",
    "table": "2018 iPad Pro",
    "desktop": "2017 iMac Pro"
]

devices["laptop"]
devices["phone"]
