package main

import "fmt"

func main() {

	// create a new variable
	var a = "Hello World"
	fmt.Println(a)

	// declare and initializee multiple variables in the same declaration
	var b, c int = 1, 3
	fmt.Println(b + c)

	// shorthand assigment and declaration
	name := "Aldair"
	fmt.Println(a + " " + name)
}
