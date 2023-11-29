string[] test1 = ["hello", "world"];

ParamsMethod(test1);

// min number using params
int[] numbers = {2345,1236,5467,2135,657,123};
int minNumber = MinV2(numbers);
Console.WriteLine(minNumber);

Console.ReadKey();

// ========  METHODS ==========
static void ParamsMethod(params string[] words)
{
    for (int i = 0; i < words.Length; i++)
    {
        Console.Write("{0} ", words[i]);
    }
    Console.WriteLine();
}

static int MinV2(params int[] numbers)
{
    int min = int.MaxValue;

    foreach (int num in numbers)
    {
        if (num < min)
        {
            min = num;
        }
    }

    return min;
}