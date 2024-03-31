package main

import "fmt"

func main() {

	// most basic for
	fmt.Println("Basic for:")
	i := 0
	for i < 3 {
		fmt.Println(i)
		i = i + 1
	}

	// clasical for with initial/condition/after
	fmt.Println("\nClassic for:")
	for j := 0; j < 4; j++ {
		fmt.Println(j)
	}

	// for using a fixed range
	fmt.Println("\nFor with range:")
	for j := range 4 {
		fmt.Println(j)
	}

	// infinite loop until break or return
	for {
		fmt.Println("\nEternal loop")
		break
	}

	// continue keyword to continue to the next iteration
	fmt.Println("\ncontinue keyword:")
	for z := range 7 {
		if z%2 == 0 {
			continue
		}
		fmt.Println("Odd number", z)
	}
}
