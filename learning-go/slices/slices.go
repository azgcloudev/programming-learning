package main

import (
	"fmt"
	"slices"
)

func main() {
	// slices are typed only and an uninitialized slice has type nil and len 0
	var s []string
	fmt.Println("uninit", s, s == nil, len(s) == 0)

	// create an empty slice with a type and a size using the make keyword
	st := make([]string, 3)
	fmt.Println("emp:", st, st == nil, len(st))

	// set and get the same way as arrays using index number
	st[0] = "a"
	st[1] = "b"
	st[2] = "c"
	fmt.Println("Getting st[2] =", st[2])

	// append return a new slice with the values of an existing one
	st = append(st, "d")
	st = append(st, "e", "f")
	fmt.Println(st)

	// copy a slice
	c := make([]string, len(st))
	copy(c, st)
	fmt.Println(c)

	// slice operator to create slices from another slice and its ranges
	l := st[2:5] // from index 2 to index 4
	fmt.Println(l)

	l = st[:6] // from the start until index 5
	fmt.Println(l)

	// from the start index until the last element
	l = st[3:]
	fmt.Println(l)

	// declara and initialize a slice in a single statement
	fullName := []string{"Aldair", "Zamora", "Gomez"}
	fmt.Println("decled:", fullName)

	// methods from slices package
	fmt.Println(slices.Equal(l, st))

	// two dimensional slices
	twoD := make([][]int, 3)
	for i := 0; i < 3; i++ {
		innerLen := i + 1
		twoD[i] = make([]int, innerLen)
		for j := 0; j < innerLen; j++ {
			twoD[i][j] = i + j
		}
	}
	fmt.Println("2d", twoD)

	// tic tac toe slices
	tic := make([][]string, 3)
	for i := 0; i < 3; i++ {
		tic[i] = make([]string, 3)
	}
	fmt.Println(tic)
	tic[0][1] = "x"
	tic[1][1] = "x"
	tic[2][1] = "x"
	tic[1][0] = "o"
	fmt.Println(tic, len(tic), len(tic[0][1]))
}
