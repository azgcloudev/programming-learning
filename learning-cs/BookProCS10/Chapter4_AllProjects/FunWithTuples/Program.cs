namespace FunWithTuples
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // creating a tuple with var
            var values = ("a", 5, "b");

            // creating tuple defining the type
            (string, int, string) values2 = ("a", 5, "b");

            // access tuple by Item
            Console.WriteLine(values.Item1);
            Console.WriteLine(values2.Item2);


            // property names
            (string firstLetter, int number, string secondLetter) values3 = ("a", 5, "b");
            Console.WriteLine("firstLetter value is {0}", values3.firstLetter);

            // display tuple data type
            Console.WriteLine(values3.GetType().Name);


            // Inferred variable names
            var foo = new { Prop1 = "first", Prop2 = "second" };
            var boo = (foo.Prop1, foo.Prop2);
            Console.WriteLine("foo type is: {0}", foo.GetType().Name);
            Console.WriteLine("Tuple boo: ({0}, {1})", boo.Prop1, boo.Prop2);


            // equality/inequality comparison
            Console.WriteLine("\n\n=> Equality/inequality comparison:");
            var left = (5, 10);
            (int? a, int? b) nullableMembers = (5, 10);
            Console.WriteLine("left == nullablemembers: {0}", left == nullableMembers);

            // tuples as return values
            Console.WriteLine("\n\n== Tuples as return values ==");
            var samples = FillTheseValues();
            Console.WriteLine(samples.a);
            Console.WriteLine(samples.b);
            Console.WriteLine(samples.c);

            // discards
            var (first,_,last) = SplitNames("Aldair Antonio Zamora");
            Console.WriteLine($"{first}:{last}");
        }

        // static void FillTheseValues(out int a, out string b, out bool c)
        // {
        //     a = 9;
        //     b = "Enjoy your string.";
        //     c = true;
        // }
        static (int a, string b, bool c) FillTheseValues()
        {
            return (9, "Enjoy your string.", true);
        }

        static (string first, string middle, string last) SplitNames(string fullName)
        {
            string[] words = fullName.Split(' ');

            return (words[0], words[1], words[2]);
        }
    }
}