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

// structs and receivers
func (p person) print() {
	fmt.Printf("%+v", p)
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
	// // jimPointer := &jim
	// jimPointer.updateName("Jimmy")

	// if receiver is type pointer, Go can use the value variable and convert it in reference
	// hence create a variable with the reference value is not needed and can do the following:
	jim.updateName("Todd")
	jim.print()
}

func (p *person) updateName(name string) {
	(*p).firstName = name
}
