#include <iostream>

// using directive
using namespace std;

// using declaarion
// short specific declaration and not the whole name space
using std::cout;

int main()
{
    std::cout << "Hello World\n";

    // avoid the name space thanks to using directive
    cout << "Using directive\n";

    return 0;
}