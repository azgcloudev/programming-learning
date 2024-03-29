namespace MainArgsDemo;

class Program
{
    static void Main(string[] args)
    {
        if (args.Length == 0)
        {
            Console.WriteLine("Invalid arguments. Pass 'help' to get more instructions");

            Console.ReadKey();
            return;
        }

        // check if Help is pass
        if (args[0] == "help")
        {
            // display menu
            Console.WriteLine("**********************Instructions:");
            Console.WriteLine("Use one of the following commands followed by two numbers");
            Console.WriteLine("'add' : to add 2 numbers");
            Console.WriteLine("'sub' : to substract 2 numbers");
            Console.WriteLine("**********************");

            Console.ReadKey();
            return;
        }

        // check if the args are 3 length
        if (args.Length != 3)
        {
            Console.WriteLine("Invalid arguments. Pass 'help' to get more instructions");
            Console.ReadKey();
            return;
        }

        // parse the 2 numbers
        bool num1Parsed = float.TryParse(args[1], out float num1);
        bool num2Parsed = float.TryParse(args[2], out float num2);

        // check if both parse are true
        if (!num1Parsed || !num2Parsed)
        {
            Console.WriteLine("Invalid arguments. Pass 'help' to get more instructions");
            Console.ReadKey();
            return;
        }

        // switch to work with add and substract
        switch (args[0])
        {
            case "add":
                Console.WriteLine($"{num1} + {num2} sum result is: {num1 + num2}");
                break;
            case "sub":
                Console.WriteLine($"{num1} - {num2} sum result is: {num1 - num2}");
                break;
            default:
                Console.WriteLine("Invalid arguments. Pass 'help' to get more instructions");
                break;
        }
        Console.ReadKey();
    }
}
