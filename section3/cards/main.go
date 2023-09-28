package main

func main() {
	cards := newDeck()

	hand, remaininDeck := deal(cards, 5)

	hand.print()
	remaininDeck.print()

	cards.saveToFile("my_cards")
}

func newCard() string {
	return "Five of Diamonds"
}
