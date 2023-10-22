using static System.Console;

// four columns
// Type | Byte(s) of memory | Min | Max 

string rowSeparator = new string('-', count: 74);

// header
Console.WriteLine(rowSeparator);
Console.WriteLine("{0,-10} {1,-18} {2,30} {3,40}", "Type", "Byte(s) of memory", "Min", "Max");
Console.WriteLine(rowSeparator);
Console.WriteLine("{0,-10} {1,-18} {2,30} {3,40}", "sbyte", sizeof(sbyte), sbyte.MinValue, sbyte.MaxValue);
Console.WriteLine("{0,-10} {1,-18} {2,30} {3,40}", "sbyte", sizeof(byte), byte.MinValue, byte.MaxValue);
Console.WriteLine("{0,-10} {1,-18} {2,30} {3,40}", "sbyte", sizeof(ushort), ushort.MinValue, ushort.MaxValue);
Console.WriteLine("{0,-10} {1,-18} {2,30} {3,40}", "sbyte", sizeof(int), int.MinValue, int.MaxValue);
Console.WriteLine("{0,-10} {1,-18} {2,30} {3,40}", "sbyte", sizeof(uint), uint.MinValue, uint.MaxValue);
Console.WriteLine("{0,-10} {1,-18} {2,30} {3,40}", "sbyte", sizeof(long), long.MinValue, long.MaxValue);
Console.WriteLine("{0,-10} {1,-18} {2,30} {3,40}", "sbyte", sizeof(ulong), ulong.MinValue, ulong.MaxValue);
Console.WriteLine("{0,-10} {1,-18} {2,30} {3,40}", "sbyte", sizeof(float), float.MinValue, float.MaxValue);
Console.WriteLine("{0,-10} {1,-18} {2,30} {3,40}", "sbyte", sizeof(double), double.MinValue, double.MaxValue);
Console.WriteLine("{0,-10} {1,-18} {2,30} {3,40}", "decimal", sizeof(decimal), decimal.MinValue, decimal.MaxValue);


// solution
WriteLine(rowSeparator);
WriteLine("Type    Byte(s) of memory               Min                            Max");
WriteLine(rowSeparator);
WriteLine($"sbyte   {sizeof(sbyte),-4} {sbyte.MinValue,30} {sbyte.MaxValue,30}");
WriteLine($"byte    {sizeof(byte),-4} {byte.MinValue,30} {byte.MaxValue,30}");
WriteLine($"short   {sizeof(short),-4} {short.MinValue,30} {short.MaxValue,30}");
WriteLine($"ushort  {sizeof(ushort),-4} {ushort.MinValue,30} {ushort.MaxValue,30}");
WriteLine($"int     {sizeof(int),-4} {int.MinValue,30} {int.MaxValue,30}");
WriteLine($"uint    {sizeof(uint),-4} {uint.MinValue,30} {uint.MaxValue,30}");
WriteLine($"long    {sizeof(long),-4} {long.MinValue,30} {long.MaxValue,30}");
WriteLine($"ulong   {sizeof(ulong),-4} {ulong.MinValue,30} {ulong.MaxValue,30}");
WriteLine($"float   {sizeof(float),-4} {float.MinValue,30} {float.MaxValue,30}");
WriteLine($"double  {sizeof(double),-4} {double.MinValue,30} {double.MaxValue,30}");
WriteLine($"decimal {sizeof(decimal),-4} {decimal.MinValue,30} {decimal.MaxValue,30}");

// end
Console.ReadKey();