package main

import (
	"fmt"
	"maps"
)

func main() {

	// maps are like dictionaries in c#
	// are key value pairs

	// create a map using make(map[key-type]value-type)
	m := make(map[string]int)

	// set values using the brackets like slices
	m["k1"] = 7
	m["k2"] = 21

	fmt.Println("map", m)

	// get a value from an specific key
	v1 := m["k1"]
	fmt.Println("v1 is", v1)

	// if the key doesn't exists it returns the zero value of the type
	fmt.Println("zero value:", m["k3"])

	// number of key-value pairs using the len
	fmt.Println(len(m))

	// delete remove key-values from the map
	delete(m, "k1")

	// the clear() method removes everything in the map
	clear(m)

	m["k1"] = 2
	m["k2"] = 34
	m["k4"] = 67

	// the second return value indicates if the key is present in the map
	// _ just ignored the value returned
	_, prs := m["k2"]
	fmt.Println("prs:", prs)

	map2 := make(map[string]int)
	maps.Copy(map2, m)
	fmt.Println("Are map2 and m equal?", maps.Equal(m, map2))
}
