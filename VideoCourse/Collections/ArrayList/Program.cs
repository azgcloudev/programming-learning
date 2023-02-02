using System;
using System.Collections;

namespace ArrayListC
{
    class Program
    {
        static void Main(string[] args)
        {
            // defene an undefine count of objects
            ArrayList myArrayList = new ArrayList();

            // define an arraylist with a defined count og objects
            ArrayList myArrayList2 = new ArrayList(100);

            myArrayList.Add(25);
            myArrayList.Add("Hello");
            myArrayList.Add(100);
            myArrayList.Add(25.5);
            myArrayList.Add(21);
            myArrayList.Add(321.2);
            myArrayList.Add('@');
            myArrayList.Add(21);

            // delete an specific value (only the first one if there are multiple equal objects)
            myArrayList.Remove(21);

            // delete the object in an specific index
            myArrayList.RemoveAt(2);

            // get the length (count) of an array
            int size = myArrayList.Count;

            Console.WriteLine("The array list contains:");
            Console.Write("[ ");
            foreach (object obj in myArrayList)
            {
                Console.Write("{0} ", obj);
            }
            Console.Write("]\n");

            double sum = 0;
            foreach (object obj in myArrayList)
            {
                if (obj is int)
                {
                    // convert the obj to double to be able to add it to 'sum'
                    sum += Convert.ToDouble(obj);
                }
                else if (obj is double)
                {
                    sum += (double)obj; // casting
                }
                else if (obj is char)
                {
                    Console.WriteLine("Char: {0}", obj);
                }
            }

            Console.WriteLine("The total sum is: {0}", sum);
        }
    }
}