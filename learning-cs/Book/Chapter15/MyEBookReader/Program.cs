using System.Net;
using System.Text;

string theBook = await GetBookAsync();

Console.WriteLine();
GetStats(theBook);
Console.ReadLine();

/*
void GetBook()
{
    using WebClient wc = new WebClient();

    wc.DownloadStringCompleted += (s, eArgs) =>
    {
        _theEbook = eArgs.Result;
        Console.WriteLine("Download completed");
        GetStats();
    };

    wc.DownloadStringAsync(new Uri("http://www.gutenberg.org/files/98/98-0.txt"));
}
*/

static async Task<string> GetBookAsync()
{
    Console.WriteLine("Downloading book...");

    string s = "";

    HttpClient hp = new HttpClient();
    s = await hp.GetStringAsync("http://www.gutenberg.org/files/98/98-0.txt");
    
    Console.WriteLine("Download completed");
    return s;
}

void GetStats(string text)
{
    // get the words from the books
    string[] words = text.Split(new char[]
    { ' ', '\u000A', ',', '.', ';', ':', '-', '?', '/' },
    StringSplitOptions.RemoveEmptyEntries);

    string[] tenMostCommonWords = null;
    string longestWord = String.Empty;

    Parallel.Invoke(
        () =>
        {
            // find the ten most common words
            tenMostCommonWords = FindTenMostCommonWords(words);
        },
        () =>
        {
            // Get the longest word
            longestWord = FindTheLongestWord(words);
        });

    StringBuilder bookStats = new StringBuilder("Ten most common words are:\n");
    foreach (string s in tenMostCommonWords)
    {
        bookStats.AppendLine(s);
    }

    bookStats.AppendFormat("Longest word is: {0}", longestWord);
    bookStats.AppendLine();
    Console.WriteLine(bookStats.ToString(), "Book info");
}

string? FindTheLongestWord(string[] words)
{
    return (from w in words orderby w.Length descending select w).FirstOrDefault();
}

string[] FindTenMostCommonWords(string[] words)
{
    var frequencyOrder = from word in words
                         where word.Length > 6
                         group word by word into g
                         orderby g.Count() descending
                         select g.Key;
    string[] commonWords = (frequencyOrder.Take(10).ToArray());
    return commonWords;
}