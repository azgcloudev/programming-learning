// main is the executable path for the go programs
// all go programs must include a main package
package main

// declared packages that will be use
import "fmt"

// package scoped variables
const secondsInHours = 3600

// function declaration
// main is the entry executable function
func main() {
	// local scoped variables
	// won't work outside the main scope
	distance := 60.8

	fmt.Println("Hello Go world!")
	result := distance * 0.621
	fmt.Printf("The distance in miles is %f \n", result)
}
