// while statements
using System.Collections;

WriteLine("--- While loop ---");
int x = 0;

while (x <10)
{
    WriteLine(x);
    x++;
}

WriteLine();

// do while
WriteLine("--- Do while loop ---");
string password;

int attempts = 0;
bool isCorrect = true;

do
{
    Write("Enter you password:");
    password = ReadLine();
    attempts++;
    if (attempts >= 10)
    {
        isCorrect = false;
        break;
    }
}
while (password != "Password");

if (isCorrect)
{
WriteLine("Password is correct.");
}
else
{
    WriteLine("Password is incorrect. Account blocked.");
}

Console.WriteLine();

// for loop statement
WriteLine("--- For loop statement ---");
for (int y = 1; y <= 10; y++)
{
    WriteLine(y);
}

Console.WriteLine();

// foreach statement
WriteLine("--- Foreach loop ---");
string[] names = { "Adam", "Barry", "Charlie" };

foreach (string name in names)
{
    WriteLine($"{name} has {name.Length} characters.");
}

// behind the IEnumerable that is used to run a foreach
IEnumerator e = names.GetEnumerator();

// if movenext is true, means there is another item next
while (e.MoveNext())
{
    string name = (string)e.Current; // current shows the current item
    WriteLine($"{name} has {name.Length} characters long.");
}