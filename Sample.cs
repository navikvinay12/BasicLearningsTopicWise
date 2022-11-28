using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestingPractices
{
    public class Sample
    {
        private int a;
        private int b;
        public Sample() 
        {
            a = 1;
            b = 2; 
        }
        public void SetValues(int a,int b)
        {
            Console.WriteLine("without using this keyword : "+a);   //scope is limited to local method
            Console.WriteLine("without using this keyword : " + b); //scope is limited to local method
            Console.WriteLine("using this keyword : " + this.a);    //using this keyword it is accessing current class instance variable
            Console.WriteLine("using this keyword : " + this.b);    //using this keyword it is accessing current class instance variable

        }
    }
}
