int[] arr = new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

int x = 42;
int result = BinarySearch(arr, x);

if (result == -1)
{
    Console.WriteLine("Number {0} not found.", x);
}
else
{
    Console.WriteLine("Number {0} is at index {1}.", x, result);
}

static int BinarySearch(int[] arr, int x)
{
    // x will be the number to search
    int left = 0;
    int right = arr.Length - 1;

    while (left <= right)
    {
        // get the middle item
        int middle = (left + right) / 2;

        // check if middle matches to number
        if (arr[middle] == x)
        {
            return middle;
        }

        // check if number is greater than guess (remove left block)
        if (x > arr[middle])
        {
            left = middle + 1;
        }
        // check if number is less than guess (remove right block)
        else
        {
            right = middle - 1;
        }
    }

    // if number is not found
    return -1;
}