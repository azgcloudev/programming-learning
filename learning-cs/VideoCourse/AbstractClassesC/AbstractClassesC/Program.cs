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
            sphere.GetInfo();
            //Console.WriteLine("Sphere volume is {0}", sphere.Volume());

            Shape[] shapes = { new Sphere(3), new Cube(6) };
            foreach(Shape shape in shapes)
            {
                shape.GetInfo();
                Console.WriteLine($"{shape.Name} has a volume of {shape.Volume()}");
                Console.WriteLine();
            }

            Console.ReadKey();
        }
    }
}
