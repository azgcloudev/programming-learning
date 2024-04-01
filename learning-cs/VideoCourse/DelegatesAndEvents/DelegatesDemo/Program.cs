List<string> names = new List<string>() { "Aiden", "Sif", "Walter", "Anatoli" };

// print names before removing them all
foreach(string name in names)
{
    Console.WriteLine(name);
}

// calling RemoveAll and passing a method filter we created
names.RemoveAll(Filter);

// print names after the RemoveAll
Console.WriteLine("\nAfter RemoveAll");
foreach (string name in names)
{
    Console.WriteLine(name);
}

static bool Filter(string s)
{
    // return whether the stringgb s scontains the letter 'i'
    // the Contains method will retuirn a bool which we will return as well
    return s.Contains("i");
}