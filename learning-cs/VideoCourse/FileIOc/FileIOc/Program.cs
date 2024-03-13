namespace FileIOc
{
    class Program
    {
        static void Main(string[] args)
        {
            string path = "D:\\Documents\\Programming\\Learning\\programming-learning\\learning-cs\\VideoCourse\\FileIOc\\FileIOc\\";

            // all text
            string allText = System.IO.File.ReadAllText(@"D:\Documents\Programming\Learning\programming-learning\learning-cs\VideoCourse\FileIOc\FileIOc\textFile.txt");

            Console.WriteLine("The file contains the following text:\n{0}", allText);

            // getting lines
            Console.WriteLine();
            string[] lines = System.IO.File.ReadAllLines(@"D:\Documents\Programming\Learning\programming-learning\learning-cs\VideoCourse\FileIOc\FileIOc\textFile.txt");

            Console.WriteLine("Single lines:");
            foreach (string line in lines)
            {
                Console.WriteLine("\t{0}", line);
            }

            // Write in a file
            string[] linesToWrite = { "first line", "second line", "third line." };
            File.WriteAllLines(@"D:\Documents\Programming\Learning\programming-learning\learning-cs\VideoCourse\FileIOc\FileIOc\textFile2.txt", linesToWrite);

            // practice
            int high_score = int.MinValue;

            int[] scores = { 123, 432, 63 };

            foreach (int score in scores)
            {
                if (score > high_score)
                {
                    high_score = score;
                }
            }

            // write the score in the file
            File.WriteAllText(@"D:\Documents\Programming\Learning\programming-learning\learning-cs\VideoCourse\FileIOc\FileIOc\highScore.txt", high_score.ToString());


            string[] lines3 = { "First 250", "Second 100", "Third 240", "Second 367" };
            // wirte using streamwriter
            using (StreamWriter file = new StreamWriter(@"D:\Documents\Programming\Learning\programming-learning\learning-cs\VideoCourse\FileIOc\FileIOc\myText2.txt"))
            {
                foreach (string line in lines3)
                {
                    if (line.Contains("Second"))
                    {
                        file.WriteLine(line);
                    }
                }
            }
            Console.ReadKey();
        }
    }
}
