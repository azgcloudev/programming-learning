package main

import (
	"fmt"
	"math/rand"
	"os"
	"strings"
)

// create a new type of deck
// which is a slice of strings
type deck []string

// receiver method for type deck ---
// Shows all the cards in the deck.
func (d deck) print() { // the receiver is by convention with 1 or 2 letters related to the type
	for i, card := range d {
		fmt.Println(i, card)
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

func deal(d deck, handSize int) (deck, deck) {
	return d[:handSize], d[handSize:]
}

// Convert a deck into a string.
func (d deck) toString() string {

	str := strings.Join([]string(d), ",")

	return str
}

// Save the deck into a file locally.
func (d deck) saveToFile(filename string) error {

	return os.WriteFile(filename, []byte(d.toString()), 0666)
}

// Create a new deck, based on a local file
func newDeckFromFile(filename string) deck {
	bs, err := os.ReadFile(filename)

	// what to do in case if the read file fails, err != nil
	if err != nil {
		// will log the error and close the program
		fmt.Println("Error:", err)
		os.Exit(1)
	}

	//byte slice to string
	s := strings.Split(string(bs), ",")

	return deck(s)

}

// Shuffle the deck.
func (d deck) shuffle() {

	for i := range d {
		newPosition := rand.Intn(len(d) - 1) // generate a random number between 0 and the length of the slice

		// swap elements position in the slice
		d[i], d[newPosition] = d[newPosition], d[i]
	}
}
