int x = 3;
int y = 2 + ++x;
Console.WriteLine($"y is {y}\n");

// 64 32 16 8 4 2 1
x = 3 << 2; //  0 0 1 1    1100 = 12
y = 10 >> 1; // 1 0 1 0    0101 = 5
Console.WriteLine($"3 << 2 = {x}");
Console.WriteLine($"10 >> 1 = {y}\n");

// bitwise operators
x = 10 & 8;
y = 10 | 7;
Console.WriteLine("10 & 8 = {0}", x); // if  bit is set to 1 on both numbers
Console.WriteLine("10 | 7 = {0}", y); // if at least bit is set to 1 in any number