package main

func main() {

	s := square{
		sideLength: 10,
	}
	t := triangle{
		height: 10,
		base:   10,
	}

	printArea(s)
	printArea(t)
}
