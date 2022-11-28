using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestingPractices
{
    public class Demo
    {
        private int a, b, c;
        public void SetValue(int X, int Y = 10, int Z = 20)
        {
            a = X;
            b = Y;
            c = Z;
        }
        public void PrintValue()
        {
            Console.WriteLine($"Values are : {a},{b},{c}");
        }
    }
}
/*C#.Net has the concept of Default Arguments, which are also known as Optional Arguments in C#.

Understand the concept of Default Arguments by these points:

Every default argument contains a default value within the function definition.
If we do not pass any argument for default argument then, it uses default value.
Given default value for default argument must be a constant.
Default argument cannot be used for constructor and indexer etc.*/