package main

// arrays and slices
// must be of the same data type

func syntax() {
	// declare a slice
	cards := []string{"card1", "card2"}

	// add items to the end
	cards = append(cards, "card3") // append returns a new slice and is assigned to cards
}
