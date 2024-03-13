string[] lines = File.ReadAllLines(@"D:\Programming\Learning\programming-learning\learning-cs\VideoCourse\Section10Assigment2\input.txt");
List<string> splittedLines = new List<string> { };
List<string> splittedText = new List<string> { };

foreach (string line in lines)
{
    if (line.Contains("split"))
    {
        splittedLines.Add(line);
    }
}

foreach(string text in splittedLines)
{
    Console.WriteLine(text);
}