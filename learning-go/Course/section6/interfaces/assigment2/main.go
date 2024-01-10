package main

import (
	"fmt"
	"log"
	"os"
)

func main() {

	var fileName string

	// check if args is empty
	if len(os.Args) > 1 {
		// save file name in variable
		fileName = os.Args[1]
	} else {
		fmt.Println("File name not added in arguments.")
		os.Exit(1)
	}

	data, err := os.ReadFile(fileName)
	if err != nil {
		log.Fatalln("Error:", err)
		os.Exit(-1)
	}

	// convert data to string
	fmt.Println(string(data))
}
