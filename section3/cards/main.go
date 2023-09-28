package main

func main() {
	cards := deck{"Ace of Diamonds", newCard()}

	// add new element
	cards = append(cards, "Six of Spades")

	// // loop/iterate over the slice
	// for i, card := range cards {
	// 	fmt.Println(i, card)
	// }
	cards.print()
}

func newCard() string {
	return "Five of Diamonds"
}
