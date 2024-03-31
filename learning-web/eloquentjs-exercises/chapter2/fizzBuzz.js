// print numbers from 1 to 100
// if the number is divisible by 3, print Fizz
// if the number is divisible by 5, print Buzz
// if the number is divisible by 3 and 5, print FizzBuzz

const fizzBuzz = () => {
	for (let i = 1; i <= 100; i++) {
		// if divisible by 3 and 5 = FizzBuzz
		if (i % 5 === 0 && i % 3 === 0)
			console.log("FizzBuzz ")
		else if (i % 5 === 0)
			console.log("Buzz")
		else if (i % 3 === 0)
			console.log("Fizz")
		else
			console.log(`${i} `)
	}
}

fizzBuzz();