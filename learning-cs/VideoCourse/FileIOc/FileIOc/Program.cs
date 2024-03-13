namespace FileIOc
{
    class Program
    {
        static void Main(string[] args)
        {
            // all text
            string allText = System.IO.File.ReadAllText(@"D:\Documents\Programming\Learning\programming-learning\learning-cs\VideoCourse\FileIOc\FileIOc\textFile.txt");

            Console.WriteLine("The file contains the following text:\n{0}", allText);

            // getting lines
            Console.WriteLine();
            string[] lines = System.IO.File.ReadAllLines(@"D:\Documents\Programming\Learning\programming-learning\learning-cs\VideoCourse\FileIOc\FileIOc\textFile.txt");

            Console.WriteLine("Single lines:");
            foreach(string line in lines)
            {
                Console.WriteLine("\t{0}", line);
            }

            Console.ReadKey();
        }
    }
}
