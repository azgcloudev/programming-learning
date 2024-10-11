package main

import "fmt"

// nums accept multiples values of type int
func sum(nums ...int) {
	fmt.Print(nums, " ")

	total := 0

	for _, num := range nums {
		total += num
	}
	fmt.Println(total)
}

func main() {
	sum(1, 2)
	sum(1, 2, 3)
	sum(1, 2, 3, 4)

	// a slice can be applied to a variadic function using <name...>
	numbers := []int{2, 4, 6, 8}
	sum(numbers...)
}
