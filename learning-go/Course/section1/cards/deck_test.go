package main

import (
	"os"
	"testing"
)

func TestNewDeck(t *testing.T) {
	d := newDeck()

	if len(d) != 16 {
		t.Errorf("Expected length of 16, but got %v", len(d))
	}

	// check the first card
	if d[0] != "Ace of Spades" {
		t.Errorf("Expected card is Ace of Spades, but got %v", d[0])
	}

	// check the last card
	if d[len(d)-1] != "Four of Clubs" {
		t.Errorf("Expected card is Ace of Spades, but got %v", d[len(d)-1])
	}
}

func TestSaveToDeckAndNewDeckFromFile(t *testing.T) {

	fn := "_decktesting.txt"

	// remove any testing file
	os.Remove(fn)

	// create a new deck
	deck := newDeck()

	// save the deck into a file
	deck.saveToFile(fn)

	loadedDeck := newDeckFromFile(fn)

	if len(loadedDeck) != 16 {
		t.Errorf("Expected 16 cards, but got %v", len(loadedDeck))
	}

	// remove any testing file
	os.Remove(fn)
}
