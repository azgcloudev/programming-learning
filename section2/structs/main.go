package main

import "fmt"

type contactInfo struct {
	email   string
	zipCode int
}

// defining a struct
type person struct {
	firstName string
	lastName  string
	// embedded struct
	contact contactInfo
}

func main() {
	// // declaring
	// alex := person{"Alex", "Anderson"}
	// alex := person{firstName: "Alex", lastName: "Anderson"}

	// // zero value initialization
	// var alex person

	// fmt.Printf("%+v\n", alex)
	// alex.firstName = "Alex"
	// alex.lastName = "Anderson"
	// fmt.Printf("%+v\n", alex)

	jim := person{
		firstName: "Jim",
		lastName:  "Party",
		contact: contactInfo{
			email:   "jim@gmail.com",
			zipCode: 94000,
		},
	}

	fmt.Printf("%v\n", jim.contact.email)
}
