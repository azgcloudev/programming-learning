// provide an array of numbers
int[] arr = new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
int arrLength = arr.Length;
int numberToSearch = 8;

int indexPosition = Search(arr, arrLength, numberToSearch);

if (indexPosition == -1)
{
    Console.WriteLine("Number is not in the array.");
}
else
{
    Console.WriteLine($"Number {numberToSearch} is at index {indexPosition}.");
}


// linear seach function
static int Search(int[] arr, int N, int x)
{
    for (int i = 0; i < N; i++)
    {
        if (arr[i] == x)
        {
            return i;
        }
    }

    return -1;
}