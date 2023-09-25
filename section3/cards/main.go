package main

import "fmt"

func main() {
	card := newCard()

	fmt.Println(card)

	fmt.Println(printState())
}

func newCard() string {
	return "Five of Diamonds"
}
