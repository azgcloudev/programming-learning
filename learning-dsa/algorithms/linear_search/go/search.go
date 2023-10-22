package main

func search(arr []int, x int) int {

	for index := range arr {
		if arr[index] == x {
			return index
		}
	}
	return -1
}
