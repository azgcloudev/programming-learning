#include <iostream>

int main() {
    int x; // declaration
    x = 5;
    int y = 5; // declaration and assignment
    std::cout << x << "\n";
    
    // double (decimal numbers)
    double price = 3.99;
    double gpa = 2.5;
    double temp = 25.1;
    std::cout << price << "\n";
    
    // single character CHAR
    char grade  = 'A';  // use single quotes
    char initial = 'b';
    std::cout << initial << "\n";
    
    // booleans
    bool isOverAge = true;
    std::cout << "Is he over age: " << isOverAge << "\n";
    
    // strings
    std::string name = "Aldair";
    std::string day = "Friday";
    std::string food = "Pizza";
    
    std::cout << name << "\n";
    
    
    //    CONSTANTS
    // consts cannot be change thru out the code
    const double PI = 3.14159;
    double radius = 10;
    double circumference = 2 * PI * radius;
    std::cout << "Circumference is " << circumference << "cm.\n" ;
    
    return 0;
}

