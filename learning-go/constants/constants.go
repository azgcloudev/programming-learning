package main

import "fmt"

func main() {

	// constant
	const name string = "Aldair Zamora"

	// constant is given a type until a given value is provided in numeric values
	const s = 3e20 / 5000000
	fmt.Println(s)
	fmt.Println(int64(s))
}
