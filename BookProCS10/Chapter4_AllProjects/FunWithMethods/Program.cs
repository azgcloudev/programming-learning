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
            SwapStrings( str1, str2);
            Console.WriteLine("After: {0}, {1}", str1, str2);

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
        public static void SwapStrings(string s1, string s2)
        {
            string tempStr = s1;
            s1 = s2;
            s2 = tempStr;
        }
    }
}