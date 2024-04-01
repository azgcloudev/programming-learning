package main

import "fmt"

// function that return 2 integers
func plus(a int, b int) int { // the type after the parameters is the return type
	return a + b
}

// when the parameters are of the same type, it can be omitted until the last parameter
func plusplus(a, b, c int) int {
	return a + b + c
}

func main() {
	// calling the function
	res := plus(1, 2)
	fmt.Println("1+2:", res)

	res = plusplus(1, 2, 3)
	fmt.Println("1+2+3:", res)
}
