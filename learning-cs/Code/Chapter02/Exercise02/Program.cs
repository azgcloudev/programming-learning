﻿using System;
using static System.Console;

namespace Exercise02
{
    class Program
    {
        static void Main(string[] args)
        {
            // outputs the number
            // of bytes in memory that each of the following number types use, and the minimum
            // and maximum values they can have: sbyte, byte, short, ushort, int, uint, long,
            // ulong, float, double, and decimal

            //table: Type   Bytes(s) of memory      Min     Max

            WriteLine("---------------------------------------------------------------------------------------------");
            WriteLine("{0, -10} {1, -20} {2, 30} {3, 30}", "Type", "Byte(s) of memory", "Min", "Max");
            WriteLine("---------------------------------------------------------------------------------------------");
            WriteLine("{0, -10} {1, -20} {2, 30} {3, 30}", "sbyte", sizeof(sbyte), sbyte.MinValue, sbyte.MaxValue);
            WriteLine("{0, -10} {1, -20} {2, 30} {3, 30}", "byte", sizeof(byte), byte.MinValue, byte.MaxValue);
            WriteLine("{0, -10} {1, -20} {2, 30} {3, 30}", "short", sizeof(short), short.MinValue, short.MaxValue);
            WriteLine("{0, -10} {1, -20} {2, 30} {3, 30}", "ushort", sizeof(ushort), ushort.MinValue, ushort.MaxValue);
            WriteLine("{0, -10} {1, -20} {2, 30} {3, 30}", "int", sizeof(int), int.MinValue, int.MaxValue);
            WriteLine("{0, -10} {1, -20} {2, 30} {3, 30}", "uint", sizeof(uint), uint.MinValue, uint.MaxValue);
            WriteLine("{0, -10} {1, -20} {2, 30} {3, 30}", "long", sizeof(long), long.MinValue, long.MaxValue);
            WriteLine("{0, -10} {1, -20} {2, 30} {3, 30}", "ulong", sizeof(ulong), ulong.MinValue, ulong.MaxValue);
            WriteLine("{0, -10} {1, -20} {2, 30} {3, 30}", "float", sizeof(float), float.MinValue, float.MaxValue);
            WriteLine("{0, -10} {1, -20} {2, 30} {3, 30}", "double", sizeof(double), double.MinValue, double.MaxValue);
            WriteLine("{0, -10} {1, -20} {2, 30} {3, 30}", "decimal", sizeof(decimal), decimal.MinValue, decimal.MaxValue);
            WriteLine("---------------------------------------------------------------------------------------------");

        }
    }
}
