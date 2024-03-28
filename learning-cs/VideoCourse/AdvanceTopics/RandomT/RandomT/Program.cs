
Random dice = new Random();

int n;

for (int i = 0; i < 10; i++)
{
    n = dice.Next(1, 7);
    Console.WriteLine(n);
}

// random challange
/*
 * 1 = yes
 * 2 = maybe
 * 3 = no
 */

Random yeOrNo = new Random();
do
{
    n = yeOrNo.Next(1, 4);

    if (1 == n)
    {
        Console.WriteLine("Yes");
    }
    else if (2 == n)
    {
        Console.WriteLine("Maybe");
    }
    else if (3 == n)
    {
        Console.WriteLine("No");
    }
} while (false);