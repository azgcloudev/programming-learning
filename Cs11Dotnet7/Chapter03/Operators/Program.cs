// postfix operator
WriteLine("--- postfix operator ---");
int a = 3;
int b = a++;
WriteLine($"a is {a}, b is {b}");

WriteLine();

// prefix operator
WriteLine("--- prefix operator ---");
int c = 3;
int d = ++c;
WriteLine($"c is {c}, d is {d}");

WriteLine();

// arithmetic operators
WriteLine("--- Arithmetic operators ---");
int e = 11;
int f = 3;
WriteLine($"e is {e}, f is {f}");
WriteLine($"e + f = {e + f}");
WriteLine($"e - f = {e - f}");
WriteLine($"e * f = {e * f}");
WriteLine($"e / f = {e / f}");
WriteLine($"e % f = {e % f}");
double g = 11.0;
WriteLine($"g is {g:N1}, f is {f}");
WriteLine($"g / f = {g / f}");

WriteLine();

// assigment operator with arithmetic operator
WriteLine("--- assigment operator ---");
int p = 6;
p += 3; // equivalent to p = p + 3
p -= 3;
p *= 3;
p /= 3;
WriteLine(p);