using Exercise_PrimeFactorsLib;

int number = 40;

var primeFactorsClass = new PrimeFactorsClass();
var result = primeFactorsClass.PrimeFactors(number);

Console.WriteLine($"Prime factor of {number} is: {result}");