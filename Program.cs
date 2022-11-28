using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Testing
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            //Object Creation
            Sample S1=new Sample();
            Sample S2=new Sample();
            Sample S3= new Sample();
            //passing integers
            S1.SetValue(10);
            S2.SetValue(20);
            //passing objects
            S3.AddObj(S1, S2);
            //printing the Objects
            S1.PrintValue();
            S2.PrintValue();
            S3.PrintValue();
        }
    }
}
