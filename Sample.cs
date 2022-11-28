using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestingPractices
{
    public class Sample
    {
        private int X;
        private int Y;
        public Sample()
        {
            X = 5;
            Y = 10;
        }
        public void read()
        {
            Console.WriteLine("Enter value of X: ");
            X = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter value of Y: ");
            Y= Convert.ToInt32(Console.ReadLine());
        }
        public void Print()
        {
            Console.WriteLine("Value of X : " + X);
            Console.WriteLine("Value of Y : " + Y);
        }
    }
}
