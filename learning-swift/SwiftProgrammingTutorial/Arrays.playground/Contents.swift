import UIKit

// arrays must be of the same type
var ages = [21, 7, 6, 25]

// empty array declaration
var ages2: [Int] = []

// get the number of items in the array
ages.count

ages.first
ages.last
ages[3]

// add element
ages.append(99)
print(ages)

// add element to specific index
ages.insert(45, at: 2)
print(ages)

ages.sort()
ages.shuffle()
ages.reverse()
