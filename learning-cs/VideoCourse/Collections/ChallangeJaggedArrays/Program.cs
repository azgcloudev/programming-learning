namespace ChallangeJaggedArrays
{
    class Program
    {
        static void Main(string[] args)
        {
            string[][] friends = new string[3][];

            friends[0] = new string[] { "Ligia", "Andres" };
            friends[1] = new string[] { "Yari", "Jeffry" };
            friends[2] = new string[] { "Daniel", "Tony" };

            Console.WriteLine("Hello {0}, let me introduce {1} to you.", friends[0][0], friends[1][0]);
            Console.WriteLine("Hello {0}, let me introduce {1} to you.", friends[0][1], friends[1][1]);
            Console.WriteLine("Hello {0}, let me introduce {1} to you.", friends[1][0], friends[2][1]);
            Console.WriteLine("Hello {0}, let me introduce {1} to you.", friends[1][1], friends[2][0]);
            Console.WriteLine("Hello {0}, let me introduce {1} to you.", friends[2][0], friends[0][1]);
            Console.WriteLine("Hello {0}, let me introduce {1} to you.", friends[2][1], friends[0][0]);
        }
    }
}