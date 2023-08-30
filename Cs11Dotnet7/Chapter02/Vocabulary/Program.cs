using System.Reflection;
System.Data.DataSet ds;

Assembly? myApp = Assembly.GetEntryAssembly();

if (myApp == null) return; // quit he app

// loop through the assemblies my app references
foreach (AssemblyName name in myApp.GetReferencedAssemblies())
{
    // load the assembly so we can read its details
    Assembly a = Assembly.Load(name);

    // declare a variable to count the number of methods
    int methodCount = 0;

    // loop through all the types in the assembly
    foreach (TypeInfo t in a.DefinedTypes)
    {
        // add up the count of methods
        methodCount += t.GetMethods().Count();
    }

    // output the count of types and their methods
    Console.WriteLine(
        "{0:N0} types with {1:N0} methods in {2} assembly.",
        arg0: a.DefinedTypes.Count(),
        arg1: methodCount,
        arg2: name.Name
   );
}

// local variable naming
Console.WriteLine();
Console.WriteLine("--- Local Variable ---");
double heightInMeters = 1.88;
Console.WriteLine($"The variable {nameof(heightInMeters)} has the value {heightInMeters}");