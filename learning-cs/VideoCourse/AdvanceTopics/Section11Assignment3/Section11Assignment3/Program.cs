using System.Text.RegularExpressions;

//Read and store the whole text from the source file;
string[] lines = File.ReadAllLines(@"D:\Programming\Learning\programming-learning\learning-cs\VideoCourse\AdvanceTopics\Section11Assignment3\Section11Assignment3\input2.txt");
string text = string.Join(' ', lines);

//Using regular expressions find all sequences of numbers that has length 2 or 3;
string pattern = @"\d{2,3}";

Regex regex = new Regex(pattern);

MatchCollection matchCollection = regex.Matches(text);

foreach (Match m in matchCollection)
{
    // Pars every value into an integer;
    int i = int.Parse(m.Value);

    //Use casting to convert every integer into a char.
    Console.Write("{0}", (char)i);
}

Console.ReadLine();