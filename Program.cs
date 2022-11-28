using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestingPractices
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            Demo D = new Demo();

            D.SetValue(5);
            D.PrintValue();

            D.SetValue(5, 8);
            D.PrintValue();

            D.SetValue(5, 8, 13);
            D.PrintValue();
        }
    }
}