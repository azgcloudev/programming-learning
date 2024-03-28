package main

import "fmt"

func main() {
	// In go arrays are of fixed size

	// declaration, without initialization, will get the default value of the type
	var a [5]int // int array of size 5
	fmt.Println("emp:", a)

	// assign a value at an specific index
	a[4] = 100

	// len function to get the size of an array
	fmt.Println("Array length is", len(a))

	// declara and initialize an array in a single line
	b := [6]int{1, 2, 3, 4, 5, 6}
	fmt.Println(b)

	// type for multi dimension array
	var twoD [2][3]int
	for i := 0; i < 2; i++ {
		for j := 0; j < 3; j++ {
			twoD[i][j] = i + j
		}
	}
	fmt.Println("2d:", twoD)

	threeD := [3][3]int{{1, 2, 3}, {4, 5, 6}, {7, 8, 9}}
	fmt.Println(threeD)
}
