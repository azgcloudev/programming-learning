package main

import "fmt"

func valvs() (int, int) {
	return 3, 7
}

func main() {

	// using the two returned values from the function
	a, b := valvs()
	fmt.Println(a)
	fmt.Println(b)

	// omitting a value with the blank identifier
	_, c := valvs()
	fmt.Println(c)
}
