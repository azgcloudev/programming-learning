#include <iostream>

using std::cin;
using std::cout;

int main()
{
    int slices;
    cout << "How manay slices you want to eat? ";
    // cin >>
    cin >> slices; // assign the input to the variable
    cout << "Here you have " << slices << " slices of pizza." << std::endl;

    return 0;
}