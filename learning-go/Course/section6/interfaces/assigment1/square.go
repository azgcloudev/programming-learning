package main

type square struct {
	sideLength float64
}

// Function to get the quare area
// returns a float64
func (s square) getArea() float64 {
	return s.sideLength * s.sideLength
}
