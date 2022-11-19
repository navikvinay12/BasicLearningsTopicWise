using System;
using System.Collections.Specialized;
class ArrayDemo
{
    public static void Main(string[] args)
    {
        string[] cars;      //declaration --> Array of string , variable name - cars 
        string[] carCollection = { "Volvo", "BMW", "Ford", "Mazda" };   //declaration/initialization of carCollection
        int[] myNum = { 1, 2, 3, 4, 5, 6, 7 };
        Console.WriteLine(myNum[6]);
        //carCollection[1];       //we cannot write like this ...
        Console.WriteLine(carCollection[1]); //we can write like this 
        carCollection[3] = "Replacing Mazda";
        Console.WriteLine(carCollection[3]);
        Console.WriteLine(carCollection.Length);

        //4 ways of creating arrays:-
        string[] brands = new string[4];
        string[] brandCollection = new string[4] { "sonata", "dhara", "OnePlus", "LG" };
        string[] Demos = new string[] { "one", "two", "three", "four" };
        string[] simpleDirect = { "Honey", "Tree" };

        //However, you should note that if you declare an array and initialize it later,
        //you have to use the new keyword:
        string[] onlyJustDeclaring;// Declare an array
        onlyJustDeclaring = new string[] { "Customised1", "custom2", "custom3" };// Add values, using new
                                                                                 //cars ={ "Customised1", "custom2", "custom3" }; // Add values without using new (this will cause an error)

        //Loop Through an Array
        //for loop
        string[] shapes = { "circle", "triangle", "square", "rectangle" };
        for (int i = 0; i < shapes.Length; i++) { Console.WriteLine(shapes[i]); }
        //foreach Loop
        foreach (string temp in shapes)
        {
            Console.WriteLine("Each alone elements - match "+temp);
        }
        //Sort Arrays
        string[] poles = { "east", "west", "south", "north" };
        Array.Sort(poles);
        foreach(string i in poles)
        {
            Console.WriteLine(i);
        }
        int[] myNumbers = { 5, 1, 8, 9 };
        Console.WriteLine(myNumbers.Max());// returns the largest value
        Console.WriteLine(myNumbers.Min());// returns the smallest value
        Console.WriteLine(myNumbers.Sum());// returns the sum of elements

        //Two-Dimensional Arrays
        int[,] numbers = { { 1, 4, 2 }, { 3, 6, 8 } };
        Console.WriteLine(numbers[1,2]);//8
        //change elements of 2D array
        numbers[1, 2] = 5;
        Console.WriteLine(numbers[1,2]);//5
        //Loop through a 2D
        foreach(int i in numbers)
        {
            Console.WriteLine(i);
        }
/*      You can also use a for loop.For multidimensional arrays, 
        you need one loop for each of the array's dimensions.
        Also note that we have to use GetLength() instead of Length to specify 
        how many times the loop should run:*/
        for(int i=0; i<numbers.GetLength(0);i++)
        {
            for(int j=0;j<numbers.GetLength(1);j++)
            {
                Console.WriteLine(numbers[i,j]);
            }
        }
    }
}