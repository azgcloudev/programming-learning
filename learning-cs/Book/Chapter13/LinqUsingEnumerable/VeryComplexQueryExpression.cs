using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinqUsingEnumerable
{
    internal class VeryComplexQueryExpression
    {
        public static void QueryStringsWithRawDelegates()
        {
            Console.WriteLine(">>>>> Using Raw Delegates <<<<<");
            string[] currentVideoGames = { "Morrowind", "Uncharted 2", "Fallout 3", "Daxter", "SystemShock 2" };

            // build the func<> delegates
            Func<string, bool> searchFilter = new Func<string, bool>(Filter);
            Func<string, string> itemToProcess = new Func<string, string>(ProcessItem);

            var result = currentVideoGames.Where(searchFilter)
                .OrderBy(itemToProcess)
                .Select(itemToProcess);

            foreach (var item in result)
            {
                Console.WriteLine(item);
            }
        }

        // delegate targets
        public static bool Filter(string s)
        {
            return s.Contains(" ");
        }

        public static string ProcessItem(string s)
        {
            return s;
        }
    }
}