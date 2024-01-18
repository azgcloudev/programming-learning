int[] happiness = { 5, 7, 3, 76, 3 };

UpdateArray(happiness);

// print array
for (int i = 0; i < happiness.Length; i++)
{
    Console.Write("{0} ", happiness[i]);
}


static void UpdateArray(int[] arr)
{
    int size = arr.Length;

    for (int i = 0; i < size; i++)
    {
        arr[i] = arr[i] + 2;
    }
}