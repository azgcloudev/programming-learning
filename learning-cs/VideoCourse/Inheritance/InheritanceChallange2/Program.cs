namespace InheritanceChallange2
{
    class Program
    {
        static void Main(string[] args)
        {
            Boss boss1 = new Boss("Aldair Zamora", "aldair", 100000, true);
            Trainee trainee1 = new Trainee(32, 13);
            trainee1.Salary = 12;

            trainee1.Work();
            boss1.Lead();
            boss1.Pause();
            trainee1.Pause();
        }
    }
}
