#include <iostream>
#include <math.h>

using std::cout;

// function declaration
double myPower(double, int);

void print_pow(double base, int exponent)
{
    double power = myPower(base, exponent);
    cout << base << " raised to the " << exponent << " power is " << power << ".\n";
}

int main()
{
    int base, exponent;
    cout << "What is base? ";
    std::cin >> base;
    cout << "What is the exponent? ";
    std::cin >> exponent;

    // power function
    double result = pow(base, exponent);
    double myResult = myPower(base, exponent);

    // vvoid function calling
    print_pow(base, exponent);

    cout << result << std::endl;
    cout << "My power: " << myResult << std::endl;

    return 0;
}

// function definition
double myPower(double base, int exponent)
{
    double result = 1;

    for (int i = 0; i < exponent; i++)
    {
        result = result * base;
    }

    return result;
}

// void functions
