import Foundation

// function not returning a value
func printMessage(name: String, age: Int, message: String) {
    print("Hello \(name) welcome to swift, I undertand you are \(age) years old, your applied message was \"\(message)\"")
}

func sumTwoNumbers(n1: Int, n2: Int) -> Int { //returns an Integer
        return n1 + n2
}

// use function label parameters
func numberToPower(number: Int, power p: Int) -> Double {
    if p == 0 {
        return 1
    } else if p == 1 {
        return Double(number)
    }
    
    var temp: Double = Double(number);
    
    for i in 1..<p {
        temp *= Double(number)
    }
    
    return temp
}


// avoid using the labels in the parameters
func multiplyTwoNumbers(_ n1: Int, _ n2: Int) -> Int {
    return n1 * n2
}

printMessage(name: "Aldair", age: 29, message: "Willing to learn new things")
sumTwoNumbers(n1: 10, n2: 21)
numberToPower(number: 2, power: 3)
multiplyTwoNumbers(3, 7)
