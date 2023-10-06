using static System.Convert;

// implicit casting (automatically)
int a = 10;
double b = a;
WriteLine($"int {a} assign to double b is {b}.");

// explicit casting (manually)
double c = 9.8;
// int d = c; // Program.cs(8,9,8,10): error CS0266: Cannot implicitly convert type 'double' to 'int'. An explicit conversion exists (are you missing a cast?)
//casting
int d = (int)c; // decimal points will be lost


long e = 10;
int f = (int)e;
WriteLine($"e is {e:N0} and f is {f:N0}");

e = 5_000_000_000;
f = (int)e;
WriteLine($"e is {e:N0} and f is {f:N0}");

// converting values
double g = 9.8;
int h = ToInt32(g);
WriteLine($"g is {g} and h is {h}.");