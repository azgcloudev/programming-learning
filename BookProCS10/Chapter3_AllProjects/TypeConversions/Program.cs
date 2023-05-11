Console.WriteLine("***** Fun with Conversions *****");

// add two shorts and print the result
short numb1 = 9, numb2 = 10;
// since short is shorter than Int, hence compiler winding automatilly short into
// int , because there won't be data loss
Console.WriteLine("{0} + {1}: {2}", numb1, numb2, Add(numb1, numb2));
Console.ReadLine();


// narrowing is the oposite of widening
// convert from bigger to smaller type

// compile error
numb1 = 30000;
numb2 = 30000;
short answer = Add(numb1, numb2);
Console.WriteLine(answer);

static int Add(int x, int y)
{
    return x + y;
}