using System;
using System.Collections;
using System.Diagnostics.Metrics;
using System.Reflection.Metadata;
using System.Text.RegularExpressions;
using System.Xml.Linq;
using static System.Reflection.Metadata.BlobBuilder;

namespace Testing
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //The following may throw an exception if you enter a non-numeric character.
            //Hence kept inside a try block .
            //Ideally, a catch block should include a parameter of a built-in or custom exception class
            //to get an error detail.
            try
            {
                Console.WriteLine("Enter a number : ");
                var num=int.Parse(Console.ReadLine());
                Console.WriteLine($"Square of {num} is {num*num}");
            }
            catch(Exception ex)
            {
                Console.Write("Error Occurred." + ex.Message);
            }
            finally
            {
                Console.Write("Re-try with a different number.");
            }
            //You can use multiple catch blocks with the different exception type parameters.
        }
    }
}
/*
The finally block is an optional block and should come after a try or catch block.
The finally block will always be executed whether or not an exception occurred.
The finally block generally used for cleaning - up code e.g., disposing of unmanaged objects.

Note:
Multiple finally blocks are not allowed. 
Also, the finally block cannot have the return, continue, or break keywords.
It doesn't let control to leave the finally block.
*/
