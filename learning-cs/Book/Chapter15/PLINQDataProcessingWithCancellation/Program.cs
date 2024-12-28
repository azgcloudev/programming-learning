namespace PLINQDataProcessingWithCancellation_
{
    internal class Program
    {
        static CancellationTokenSource _cancelToken = new CancellationTokenSource();

        static void Main(string[] args)
        {
            do
            {
                Console.WriteLine("Press any key to start processing");
                Console.ReadKey();

                Console.WriteLine("Processing");
                Task.Factory.StartNew(ProcessIntData);
                Console.Write("Enter Q to exit: ");
                string answer = Console.ReadLine()!;

                if (answer.Equals("q", StringComparison.OrdinalIgnoreCase))
                {
                    _cancelToken.Cancel();
                    break;
                }
            } while (true);

            Console.ReadLine();
        }

        static void ProcessIntData()
        {
            // get a large array number
            int[] source = Enumerable.Range(1, 10_000_000).ToArray();

            int[] modThreeIsZero = null;

            try
            {
                Thread.Sleep(4000);
                modThreeIsZero = (
                    from n in source.AsParallel().
                        WithCancellation(_cancelToken.Token)// perform parallel task if possible
                    where n % 3 == 0
                    orderby n descending
                    select n).ToArray();
                Console.WriteLine($"Found {modThreeIsZero.Count()} numbers in the query");
            }
            catch (OperationCanceledException ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
