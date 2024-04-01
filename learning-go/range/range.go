package main

import "fmt"

func main() {

	// sum numbers in a slice
	nums := []int{1, 2, 3, 4, 5}
	sum := 0
	for _, num := range nums {
		sum += num
	}
	fmt.Println("sum:", sum)

	// using range with slices and arrays also returns the index number
	fmt.Println("\nRange with index:")
	for i, num := range nums {
		fmt.Println("index:", i, "num:", num)
	}

	// using range to iterate over key/value pairs like maps
	fmt.Println("\nRange with key-value pairs:")
	kvs := map[string]string{"a": "apple", "b": "banana"}
	for k, v := range kvs {
		fmt.Printf("%s -> %s\n", k, v)
	}

	// iterate only over the keys of the map
	fmt.Println("\nRange with only keys on maps")
	for k := range kvs {
		fmt.Println("key:", k)
	}

	// range with strings, the first value is the byte index of the rune
	// the second the rune itself
	fmt.Println("\nRange with rune:")
	for i, c := range "My name is azgcloudev." {
		fmt.Println(i, c)
	}
}
