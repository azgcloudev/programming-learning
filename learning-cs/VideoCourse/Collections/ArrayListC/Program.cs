using System.Collections;

// Array list can hold multiple item types

// declaring an arraylist
ArrayList newArrayList = new ArrayList();

newArrayList.Add("Hello World");
newArrayList.Add(25);
newArrayList.Add(101);
newArrayList.Add("string");
newArrayList.Add(3.1415);

// ArrayList length
int lengthArr = newArrayList.Count;

// loop logic using object
double sum = 0;
foreach (object obj in newArrayList)
{
    // sum numbers and console the strins
    if (obj is int)
    {
        // convert obj to double
        sum += Convert.ToDouble(obj);
    }
    else if (obj is double)
    {
        // cast obj
        sum += (double)obj;
    }
    else if (obj is string)
    {
        Console.WriteLine(obj);
    }
}
Console.WriteLine("Sum is {0}", sum);


// remove an element
newArrayList.Remove(101);

// remove by index
newArrayList.RemoveAt(2);