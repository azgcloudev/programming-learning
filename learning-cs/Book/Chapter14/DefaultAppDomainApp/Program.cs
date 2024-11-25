using System;
using System.ComponentModel.DataAnnotations;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Runtime.Loader;

namespace DefaultAppDomainApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("***** Fun with the default AppDomain *****\n");
            DisplayDADStats();

            ListAllAssembliesInAppDomain();
            ListAllAssembliesInAppDomain2();

            LoadAdditionalAssembliesDifferentContexts();

            Console.ReadLine();
        }

        private static void DisplayDADStats()
        {
            // get access to the AppDomain for the current thread
            AppDomain defaultAD = AppDomain.CurrentDomain;
            
            // print various stays of the AppDomain
            Console.WriteLine("Name of this domain: {0}", defaultAD.FriendlyName);
            Console.WriteLine("ID of domain in process: {0}", defaultAD.Id);
            Console.WriteLine("Is this the default domain?: {0}", defaultAD.IsDefaultAppDomain());
            Console.WriteLine("Base directory of this domain: {0}", defaultAD.BaseDirectory);
            Console.WriteLine("Setup information for this domain:");
            Console.WriteLine("\tApplication base: {0}", defaultAD.SetupInformation.ApplicationBase);
            Console.WriteLine("\tTarget framework: {0}", defaultAD.SetupInformation.TargetFrameworkName);
        }

        private static void ListAllAssembliesInAppDomain()
        {
            // get the current AppDomain thread
            AppDomain defaultAD = AppDomain.CurrentDomain;

            // get all the loaded assemblies in the AppDomain
            Assembly[] loadedAssemblies = defaultAD.GetAssemblies();

            Console.WriteLine("***** Here are the assemblies loaded in: {0}", defaultAD.FriendlyName);
            
            foreach (var a in loadedAssemblies)
            {
                Console.WriteLine($"-> Name, Version: {a.GetName().Name}:{a.GetName().Version}");
            }
        }

        private static void ListAllAssembliesInAppDomain2()
        {
            // get current AppDomain
            AppDomain defaultAD = AppDomain.CurrentDomain;

            // get loaded assemblies in the curren domain
            var loadedAssemblies = defaultAD.GetAssemblies().OrderBy(x => x.GetName().Name);

            Console.WriteLine("***** Here are the assemblies loaded in {0} *****\n", defaultAD.FriendlyName);
            foreach(var a in loadedAssemblies)
            {
                Console.WriteLine($"-> Name, Version: {a.GetName().Name}:{a.GetName().Version}");
            }
        }

        private static void LoadAdditionalAssembliesDifferentContexts()
        {
            String path = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "ClassLibrary1.dll");
            AssemblyLoadContext lc1 = new AssemblyLoadContext("NewContext1", false);
            var cl1 = lc1.LoadFromAssemblyPath(path);
            var c1 = cl1.CreateInstance("ClassLibrary1.Car");

            AssemblyLoadContext lc2 = new AssemblyLoadContext("NewContext", false);
            var cl2 = lc2.LoadFromAssemblyPath(path);
            var c2 = cl2.CreateInstance("ClassLibrary1.Car");
            Console.WriteLine("*** Loading additional assemblies in Different contexts ***");
            Console.WriteLine($"Assembly1 Equal(Assembly2) {cl1.Equals(cl2)}");
            Console.WriteLine($"Assembly1 == Assembly2 {cl1 == cl2}");
            Console.WriteLine($"Class1.Equals(Class2) {c1.Equals(c2)}");
            Console.WriteLine($"Class1 ==  Class2 {c1 == c2}");
        }
    }
}
