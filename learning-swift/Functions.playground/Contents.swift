import UIKit

func printInstructorName(name: String) {
    print(name)
}

printInstructorName(name: "Sean Allen")

func add(sum left: Int, plus right: Int) -> Int {
    // 'to' is the argument label
    // 'right' is the parameter variable
    return left + right
}

print(add(sum: 21, plus: 4))

// omit argument labels names in fucntion calls
func divideTwoNumbers(_ n1: Double, _ n2: Double) -> Double {
    if n2 > n1 {
        return -1
    }
    
    return n1 / n2
}

divideTwoNumbers(21, 4)
