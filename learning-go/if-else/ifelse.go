package main

import "fmt"

func main() {

	// can declare a variable before a condition and is used only inside the scope
	if num := -1; num < 0 {
		fmt.Println(num, "is a negative number")
	} else if num < 10 {
		fmt.Println(num, "has only 1 digit.")
	} else {
		fmt.Println(num, "has multiple digits.")
	}
}
