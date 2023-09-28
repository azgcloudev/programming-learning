package main

import "fmt"

// create a new type of deck
// which is a slice of strings
type deck []string

// receiver method for type deck ---
// Shows all the cards in the deck.
func (d deck) print() { // the receiver is by convention with 1 or 2 letters related to the type
	for _, card := range d {
		fmt.Println(card)
	}
}

func newDeck() deck {
	cards := deck{}
	cardValues := []string{"Ace", "Two", "Three", "Four"}
	cardSuits := []string{"Spades", "Diamonds", "Hearts", "Clubs"}

	// form a card value with concatenation
	for _, value := range cardValues {
		for _, suit := range cardSuits {
			cards = append(cards, value+" of "+suit)
		}
	}

	return cards
}

func hand() deck {

}
