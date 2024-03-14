string[] lines = File.ReadAllLines(@"D:\Programming\Learning\programming-learning\learning-cs\VideoCourse\Section10Assigment2\input.txt");

foreach (string line in lines)
{
    if (line.Contains("split"))
    {
        string[] arrText = line.Split();

        using (StreamWriter sw = new StreamWriter(@"D:\Programming\Learning\programming-learning\learning-cs\VideoCourse\Section10Assigment2\output.txt", true))
        {
            sw.Write($"{arrText[4]} ");
        }
    }
}