#include <iostream>

using std::cout;

int main()
{
    // declaration
    int slices;

    // initialization
    slices = 21;

    cout << slices << std::endl;

    // variables with COUT
    cout << "Here are " << slices << " of pizza." << std::endl;

    // printf() is the C printing version
    printf("Here you have %i slices more of pizza.\n", slices);

    return 0;
}
