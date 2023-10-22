namespace FunWithMethods
{
    class Program
    {
        static void Main(string[] args)
        {

            // DEFAULT BEHAVIOR FOR VALUE TYPES
            // numbers are VALUE TYPES

            Console.WriteLine("***** Fun with Methods *****\n");

            int x = 9, y = 10;
            Console.WriteLine("Before call: X: {0}, Y: {1}", x, y);
            Console.WriteLine("Answer is: X: {0}", Add(x, y));
            Console.WriteLine("After call: X: {0}, Y: {1}\n", x, y);

            // DEFAULT BEHAVIOR FOR REFERENCE TYPES
            // output modifier
            Console.WriteLine("-> Output parameters:");
            // no need to assign initial value to local variables
            // used as output parameters, provided the first time
            // you use them is as output arguments.
            // C# 7 allows for out parameters to be declared in the method call
            int ans1;
            AddOut(y, x, out ans1);
            AddOut(90, 90, out int ans);
            Console.WriteLine("90 + 90 = {0}\n", ans);


            // ref modifier
            Console.WriteLine("\n-> ref modifier:");
            string str1 = "flip";
            string str2 = "flop";
            Console.WriteLine("Before: {0}, {1}", str1, str2);
            SwapStrings( ref str1, ref str2);
            Console.WriteLine("After: {0}, {1}", str1, str2);


            // in modifier
            Console.WriteLine("\n-> in modifier:");
            Console.WriteLine(AddReadOnly(10, 40));


            // paramm modifier
            Console.WriteLine("\n-> params modifier:");
            Console.WriteLine(CalculateAverage(21,54,657,34.2)); // using comma delimited values
            double[] myNumbers = { 324, 1234, 423, 54322, 124 };
            Console.WriteLine(CalculateAverage(myNumbers)); // passing array values


            // optional parameters
            Console.WriteLine("-> Optional parameters:");
            EnterLogData("Oh no! Grid can't find data");    // not using the optional 'owner'
            EnterLogData("Oh no! I can't find the payroll data", "CFO");

            // named arguments
            Console.WriteLine("-> Named arguments:");
            DisplayFancyMessage(message: "Wow! Very fancy", textColor: ConsoleColor.DarkRed, backgroundColor: ConsoleColor.White);

        }

        // value type arguments are passed by value by default
        static int Add(int x, int y)
        {
            int ans = x + y;
            // caller will not see these changes
            // as you are modifying a copy of
            // the original data
            x = 10000;
            x = 88888;
            return ans;
        }


        // ouput parameters
        static void AddOut(int x, int y, out int ans)
        {
            ans = x + y;
        }

        //static void AddOutCompilerError(int x, int y, out int res)
        //{
        //    result = x + y;
        //    Console.WriteLine("error CS0177: The out parameter 'res' must be assigned to before control leaves the current method");
        //}



        // ref modifier
        public static void SwapStrings(ref string s1, ref string s2)
        {
            string tempStr = s1;
            s1 = s2;
            s2 = tempStr;
        }


        // --- in modifier ---
        // The in keyword causes arguments to be passed by reference but ensures the argument is not modified.
        public static int AddReadOnly(in int x, in int y)
        {
            // error CS8331: Cannot assign to variable 'x' or use it as the right hand side of a ref assignment because it is a readonly variable
            // x = 10000;
            // y = 88888;
            int ans = x + y;
            return ans;
        }



        // ---- PARAMS MODIFIER ----
        static double CalculateAverage(params double[] values)
        {
            double sum = 0;

            if (values.Length == 0)
            {
                return sum;
            }
           
            for (int i = 0; i < values.Length; i++)
            {
                sum += values[i];
            }

            return (sum / values.Length);
        }


        // ---- OPTIONAL PARAMETERS ----
        static void EnterLogData(string message, string owner = "Programmer")
        {
            Console.WriteLine("Error: {0}", message);
            Console.WriteLine("Owner of error: {0}", owner);
        } 


        // ---- NAMED ARGUMENTS ----
        static void DisplayFancyMessage(ConsoleColor textColor, ConsoleColor backgroundColor, string message)
        {
            // store old colors to restore after message is printed
            ConsoleColor oldTextColor = Console.ForegroundColor;
            ConsoleColor oldBackgroundColor = Console.BackgroundColor;

            // set new colors and print message
            Console.ForegroundColor = textColor;
            Console.BackgroundColor = backgroundColor;
            Console.WriteLine(message);

            // restore colors
            Console.ForegroundColor = oldTextColor;
            Console.BackgroundColor = oldBackgroundColor;
         }
    }
}