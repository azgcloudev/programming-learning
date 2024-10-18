using System;
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
            var defaultAD = AppDomain.CurrentDomain;

            // get all the loaded assemblies in the AppDomain
            var loadedAssemblies = defaultAD.GetAssemblies();

            Console.WriteLine("***** Here are the assemblies loaded in: {0}", defaultAD.FriendlyName);
            foreach (var a in loadedAssemblies)
            {
                Console.WriteLine($"-> Name, Version: {a.GetName().Name}:{a.GetName().Version}");
            }
        }
    }
}
