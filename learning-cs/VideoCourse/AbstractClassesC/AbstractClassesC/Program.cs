namespace AbstractClassesC
{
    class Program
    {
        static void Main(string[] args)
        {
            Cube cube = new Cube(4);

            cube.GetInfo();
            cube.Volume();

            Sphere sphere = new Sphere(6);
            Console.WriteLine("Sphere volume is {0}", sphere.Volume());

            Console.ReadKey();
        }
    }
}
