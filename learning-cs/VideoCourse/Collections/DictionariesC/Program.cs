

/*
 * Dictionaries are Generic collections and are also Key Value pairs
 * Key values need to have a type
 */

// DECLARATION
Dictionary<int, string> myDict = new Dictionary<int, string>
{
    {1, "one" },
    {2, "two" },
    {3, "three" }
};

// access an element
Console.WriteLine(myDict[1]); // access by the key
Console.WriteLine(myDict.ElementAt(2).Value); // access by index position

// loop thru all elements
foreach (KeyValuePair<int, string> item in myDict)
{
    Console.WriteLine($"Key: {item.Key} Value: {item.Value}");
}

// UPDATE A DICTIONARY
Console.WriteLine("\n\n--- Update dict ---");
string one = "uno";
if (myDict.ContainsKey(1))
{
    myDict[1] = one;
}
foreach (KeyValuePair<int, string> item in myDict)
{
    Console.WriteLine($"Key: {item.Key} Value: {item.Value}");
}

// remove element from dictionary
Console.WriteLine("\n\n--- Remove dict element ---");
myDict.Remove(1);
Console.WriteLine(myDict.ContainsKey(1));