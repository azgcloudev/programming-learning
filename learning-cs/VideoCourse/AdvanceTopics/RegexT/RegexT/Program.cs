using System.Text.RegularExpressions;

// match german phone numbers
string phoneNumberRegexPattern = @"(\+49\d{3}|0049\d{3}|0\d{3})/\d{8}"; // ^(\+49\d{3}|0049\d{3}|0\d{3})/\d{8}

Regex regex = new Regex(phoneNumberRegexPattern);

string text = "Hello my number is 0049165/12312347";

// **** mr and ms match ****
// (mr|ms)\.?\s[A-Z]*

MatchCollection matches = regex.Matches(text);

Console.WriteLine(matches.Count);
Console.WriteLine($"Phone number: {matches.ElementAt(0).Value}");