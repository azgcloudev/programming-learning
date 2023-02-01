namespace ParamsKeyword
{
    class Program
    {
        static void Main(string[] args)
        {
            ParamsMethod("Hello", "String", "Aldair", "Keywords");

            int number = 1;
            char symbol = '$';
            string name = "Aldair";
            float pi = 3.1415F;

            ParamsMethod2(number, symbol, name, pi);
        }

        // params allows to enter multiple values

        static void ParamsMethod(params string[] words)
        {
            //print each string in the parameters
            for (int i = 0; i < words.Length; i++)
            {
                Console.WriteLine(words[i]);
            }
        }

        static void ParamsMethod2(params object[] obj)
        {
            foreach (object str in obj)
            {
                // objects has a string method
                Console.WriteLine(str);
            }
        }
    }
}