using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestingPractices
{
    public class Demo
    {
        public Demo Fun1()      //syntax  public ClassName MethodName() { //lines of code ; return this; }
        {
            Console.WriteLine("\nFun1 Called");
            return this;
        }
        public Demo Fun2()
        {
            Console.WriteLine("\nFun2 Called");
            return this;
        }
        public Demo Fun3()
        {
            Console.WriteLine("\nFun3 Called");
            return this;
        }
    }
}

/*In Object Oriented programming approach, generally we call functions using its object name, 
    for example there is an object named obj of class xyz and method name is myFun() 
then we can call it by using obj.myFun().
But, in C#.Net, we can call multiple functions in a single statement; it is called cascaded method calling in C#.*/