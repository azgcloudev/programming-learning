using System.Runtime.CompilerServices;
using System.Text;

BasicStringFunctionality();

StringConcatenation();

EscapeChars();

StringInterpolation();

VerbatimStrings();

StringEquality();

Console.ReadKey();


// functions
static void BasicStringFunctionality()
{
    Console.WriteLine("=> Basic String functionality:");
    string firstName = "Freddy";
    Console.WriteLine("Value of firstName: {0}", firstName);
    Console.WriteLine("firstName has {0} characters", firstName.Length);
    Console.WriteLine("firstName in uppercase: {0}", firstName.ToUpper());
    Console.WriteLine("firstName in lowercase: {0}", firstName.ToLower());
    Console.WriteLine("firstName contains y?: {0}", firstName.Contains('y'));
    Console.WriteLine("New firstnName: {0}", firstName.Replace("dy", ""));
    Console.WriteLine();
}


// STRING CONCATENATION
static void StringConcatenation()
{
    Console.WriteLine("=> String concatenation:");
    string s1 = "Programming the ";
    string s2 = "PsychoDrill (PTP)";
    string s3 = s1 + s2;
    Console.WriteLine(s3);
    // using +, the compiler uses String.concat()
    string s4 = String.Concat(s1, s2);
    Console.WriteLine(s4);

    Console.WriteLine();
}



// ESPACE CHARACTERS
static void EscapeChars()
{
    Console.WriteLine("=> Escape characters:");
    string strWithTabs = "Model\tColor\tSpeed\tPet Name";
    Console.WriteLine(strWithTabs);

    Console.WriteLine("Everyone loves \"Hello World\" ");
    Console.WriteLine("C:\\\\MyApp\\bin\\Debug ");

    // Add a total of 4 blank lines (3 escaped, 1  from writeline)
    Console.WriteLine("All finished.\n\n\n");
    // add the new lines based on the OS (Unix based or non Unix)
    Console.WriteLine("All finished for real.{0}{0}{0}", Environment.NewLine);
    Console.WriteLine();
}


// STRING INTERPOLATION
static void StringInterpolation()
{
    Console.WriteLine("=> String Interpolation:");

    // Some variables that will be plug into our larger string
    int age = 4;
    string name = "sorem";

    // using curly bracket syntax
    string greeting = String.Format("Hello {0} you are {1} years old.", name, age);
    Console.WriteLine(greeting);

    // using string interpolation
    string greeting2 = $"Hello {name.ToUpper()} you are {age} years old.";
    Console.WriteLine(greeting2);
    Console.WriteLine();
}

// VERBATIM STRINGS
static void VerbatimStrings()
{
    // escape sequence are omitted
    Console.WriteLine(@"C:\MyApp\bin\Debug");

    // whitespace is preserved
    string myLongString = @"This is a very
        very
            very
                long string";
    Console.WriteLine(myLongString);

    // can insert double quotes
    Console.WriteLine(@"Cerebus said ""Darrrr! Pret-ty sun-sets""");

    // use interpolation with verbatim
    string interp = "interpolation";
    string myLongString2 = $@"This is a very
            very
                long string with {interp}";
    Console.WriteLine(myLongString2);

    Console.WriteLine();
}


// STRING EQUALITY
static void StringEquality()
{
    Console.WriteLine("=> String equality:");
    string s1 = "Hello!";
    string s2 = "Yo!";
    Console.WriteLine("s1 = {0}", s1);
    Console.WriteLine("s2 = {0}", s2);
    Console.WriteLine();

    // test these strings for equality
    Console.WriteLine("s1 == s2: {0}", s1 == s2);
    Console.WriteLine("s1 == Hello!: {0}", s1 == "Hello!");
    Console.WriteLine("s1 == HELLO!: {0}", s1 == "HELLO!");
    Console.WriteLine("s1 == hello!: {0}", s1 == "hello!");
    Console.WriteLine("s1.Equals(s2): {0}", s1.Equals(s2));
    Console.WriteLine("Yo!.Equals(s2): {0}", "Yo!".Equals(s2));

    Console.WriteLine();
}