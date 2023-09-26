package main

import "fmt"

func main() {
	cards := []string{"Ace of Diamonds", newCard()}

	// add new element
	cards = append(cards, "Six of Spades")

	// loop/iterate over the slice
	for i, card := range cards {
		fmt.Println(i, card)
	}
}

func newCard() string {
	return "Five of Diamonds"
}
