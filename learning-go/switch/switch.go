package main

import (
	"fmt"
	"time"
)

func main() {

	i := 2
	fmt.Println("Write", i, "as")
	switch i {
	case 1:
		fmt.Println("one")
	case 2:
		fmt.Println("two")
	case 3:
		fmt.Println("three")
	}

	// using commas to separate multiple expressions in the same
	// using the default keyword
	fmt.Println("\nMultiple expressions switch:")

	switch time.Now().Weekday() {
	case time.Saturday, time.Sunday:
		fmt.Println("It's the weekend.")
	default:
		fmt.Println("It's a weekday.")
	}

	// switch can be used like a regular if/else without an expression
	fmt.Println("\nSwitch without expression.")

	t := time.Now()
	switch {
	case t.Hour() < 12:
		fmt.Println("It's before noon.")
	default:
		fmt.Println("It's after noon.")
	}
	fmt.Println("Time is ", t.Hour())

	// type switch can be used to compare types and not values
	whatAmI := func(i interface{}) {
		switch t := i.(type) {
		case bool:
			fmt.Println("I am a bool.")
		case int:
			fmt.Println("I am an int.")
		default:
			fmt.Printf("Don't know the type %T\n", t)
		}
	}
	whatAmI(true)
	whatAmI(1)
	whatAmI("Heey")
}
