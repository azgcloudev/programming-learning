package main

import "fmt"

func main() {

	// declaring a map
	colors := map[string]string{
		"red":   "#ff0000",
		"green": "#4bf745",
	}

	// // declaring a map
	// var colors map[string]string

	// // declaring a map
	// colors := make(map[string]string)

	// add values to an existing map
	colors["white"] = "#ffffff"
	colors["black"] = "#000"

	// delete a keyvalue pair
	delete(colors, "black")

	fmt.Println(colors)

	printMapItems(colors)
}

// Iteration over a map
func printMapItems(m map[string]string) {
	for color, hex := range m {
		fmt.Printf("Hex color for %v is %v.\n", color, hex)
	}
}
