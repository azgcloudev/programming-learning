import Cocoa

////// optional
var age: Int?
//print(age)

//age = 25

/*
////// optional binding
if let edad = age {
    print("La edad del usuario is: \(edad)")
} else {
    print("No se ha especificado la edad")
}
*/

////// guard expression
func edad(edad: Int?) {
    guard let age = edad else {
        print("Escriba la edad")
        return
    }
    print("La age es de \(age)")
}

edad(edad: age)
