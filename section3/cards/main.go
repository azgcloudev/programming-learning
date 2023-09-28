package main

func main() {
	cards := deck{"Ace of Diamonds", newCard()}

	// creates a new card deck
	cards = newDeck()

	// // loop/iterate over the slice
	// for i, card := range cards {
	// 	fmt.Println(i, card)
	// }
	cards.print()
}

func newCard() string {
	return "Five of Diamonds"
}
