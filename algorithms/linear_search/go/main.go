package main

import "fmt"

func main() {

	arr := []int{1, 2, 3, 4, 5, 6, 7, 8, 9, 10}
	guess := 4

	var result = search(arr, guess)

	if result == -1 {
		fmt.Println("Number not found")
	} else {
		fmt.Printf("Number %v is at index: %v\n", guess, result)
	}
}
