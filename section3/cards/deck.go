package main

import "fmt"

// create a new type of deck
// which is a slice of strings
type deck []string

// receiver
// method for type deck
func (d deck) print() { // the receiver is by convention with 1 or 2 letters related to the type
	for i, card := range d {
		fmt.Println(i, card)
	}
}
