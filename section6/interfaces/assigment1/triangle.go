package main

type triangle struct {
	base   float64
	height float64
}

// Function that return the triangle area
// as float64
func (t triangle) getArea() float64 {
	return 0.5 * t.base * t.height
}
