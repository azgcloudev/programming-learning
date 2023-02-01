namespace ArrayAsParameter
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] studentsGrades = new int[] { 15, 13, 8, 12, 6, 16 };
            double averageResult = GetAverage(studentsGrades);

            foreach (int grade in studentsGrades)
            {
                Console.WriteLine(grade);
            }

            Console.WriteLine("The average is: {0}", averageResult);

            // CHALLANGE
            // create an array of happiness in the main method and assign 5 values to it
            // create a method which has an array of type int as its parameter
            // this method should increase the argument given by 2, for each entry
            // Call this method in the main method and use "hapiness" as the argument
            // Create a foreach loop in the main method to write all values onto the console
            Console.WriteLine("\n--> Challange <--");
            int[] hapiness = new int[] { 1, 4, 7, 2, 8 };
            Increase(hapiness);

            foreach (int value in hapiness)
            {
                Console.WriteLine(value);
            }

        }

        // Increase adds 1 to each value in the array
        static void Increase(int[] array)
        {
            for (int i = 0; i < array.Length; i++)
            {
                array[i] += 1;
            }
        }


        static double GetAverage(int[] gradesArray)
        {
            int size = gradesArray.Length;
            double average;
            int sum = 0;

            for (int i = 0; i < size; i++)
            {
                sum += gradesArray[i];
            }

            average = (double)sum / size;

            return average;
        }
    }
}