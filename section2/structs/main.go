package main

import "fmt"

// defining a struct
type person struct {
	firstName string
	lastName  string
}

func main() {
	// // declaring
	// alex := person{"Alex", "Anderson"}
	// alex := person{firstName: "Alex", lastName: "Anderson"}

	// zero value initialization
	var alex person

	fmt.Printf("%+v\n", alex)
	alex.firstName = "Alex"
	alex.lastName = "Anderson"
	fmt.Printf("%+v\n", alex)
}
