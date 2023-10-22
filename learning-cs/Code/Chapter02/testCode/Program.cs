namespace testCode;
class Program
{
    static void Main(string[] args)
    {
        string[] names = { "Adam", "Bridgette", "Carla", "Daniel",
                         "Ebenezer", "Francine", "George" };
        decimal[] hours = { 40, 6.667m, 40.39m, 82, 40.333m, 80,
                                 16.75m };

        Console.WriteLine("{0,-20} {1,5}\n", "Name", "Hours");
        for (int ctr = 0; ctr < names.Length; ctr++)
            Console.WriteLine("{0,-20} {1,5:N1}", names[ctr], hours[ctr]);
    }
}
