package main

func main() {

	// simple declaration
	var x int = 10

	// if type is obvious can omit the type
	var y = 20

	// declare a variable with the default type
	var v int

	// multiple variables of the same type
	var a, b int = 1, 2

	// different types with known types
	var c, d = 1, "hello"

	// multiple values of different types
	var (
		e        = 10
		f    int = 30
		g, h     = 10, "string"
		k, l string
	)
}
