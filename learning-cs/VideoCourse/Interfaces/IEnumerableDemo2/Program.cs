
// array
int[] numbers = new int[] {2,56,87};
Console.Write("'numbers' sum total is: ");
Console.WriteLine(CollectionSum(numbers));


static int CollectionSum(IEnumerable<int> data)
{
    int sum = 0;

    foreach(int n in data)
    {
        sum += n;
    }

    return sum;
}
